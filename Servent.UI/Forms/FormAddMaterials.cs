using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormAddMaterials : Form
    {
        private MaterialsMovement _materialsMovement;
        private readonly List<UnitType> _unitTypes;
        public FormAddMaterials(List<UnitType> unitTypes)
        {
            _unitTypes = unitTypes;
            InitializeComponent();
            _materialsMovement = new MaterialsMovement();
            LoadCombo();
        }

        public FormAddMaterials(MaterialsMovement movement, List<UnitType> unitTypes)
        {
            InitializeComponent();
            _materialsMovement = movement;
            _unitTypes = unitTypes;
            LoadCombo();
            btnOk.Text = "Salvar";
            txbName.Text = movement.Material.Name;
            txbID.Text = movement.ID.ToString(CultureInfo.InvariantCulture);
            txbPrice.Value = (decimal)movement.Material.Price;
            txbQuantity.Text = movement.Quantity.ToString(CultureInfo.InvariantCulture);
            txbDescription.Text = movement.Material.Description;
            cbxUnit.SelectedItem = movement.Material.TypeOfUnit;
            lblCode.Visible = txbID.Visible = true;
            txbID.ReadOnly = true;
            //Configuração da interface....
            //Permitir somente visualização do id do material

        }
        public MaterialsMovement MaterialsMovement
        {
            get { return _materialsMovement; }
            set { _materialsMovement = value; }
        }

        private void LoadCombo()
        {
            cbxUnit.Items.Clear();
            _unitTypes.Where(x => x != null).ToList().ForEach(x => cbxUnit.Items.Add(x));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string validate = ValidateForm();
            if (validate != String.Empty)
                MessageBox.Show("Campos inválidos! " + validate, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    _materialsMovement.Quantity = int.Parse(txbQuantity.Text);
                    _materialsMovement.IsFromStock = false;
                    _materialsMovement.DateOfMovement = Convert.ToDateTime(cboDateMov.Text);
                    _materialsMovement.Material = new Material
                                                   {
                                                       Name = txbName.Text,
                                                       Price = double.Parse(txbPrice.Value.ToString()),
                                                       TypeOfUnit = (UnitType)cbxUnit.SelectedItem,
                                                       Description = txbDescription.Text
                                                   };
                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Descrição do erro: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ValidateForm()
        {
            if (new List<TextBox>() { txbDescription, txbName, txbQuantity }.Any(x => x.Text == string.Empty))
                return "Nome/Quantidade/Descrição não podem ser vazios.";
            if ((cbxUnit.SelectedIndex < 0))
                return "Selecione o tipo de unidade.";
            if (Convert.ToDateTime(cboDateMov.Text).CompareTo(DateTime.Now) > 0)
                return "Não é possível adicionar uma data futura.";
            return string.Empty;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddUnitType frUnits = new FormAddUnitType();
            var dialog = frUnits.ShowDialog();
            if (dialog != DialogResult.OK) return;
            _unitTypes.Add(frUnits.UnitType);
            LoadCombo();
            cbxUnit.SelectedItem = frUnits.UnitType;
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
