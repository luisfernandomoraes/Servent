using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormAddMaterialFromStore : Form
    {
        private MaterialsMovement _materialsMovement;
        private readonly List<UnitType> _unitTypes;
        private Provider _provider;
        private ConstructionHistory c;

        public ConstructionHistory ConstructionHistory
        {
            get { return c; }
            set { c = value; }
        }
        public FormAddMaterialFromStore(string nome,List<UnitType> unitTypes)
        {
            _unitTypes = unitTypes;
            InitializeComponent();
            _materialsMovement = new MaterialsMovement();
            _provider = new Provider();
            c = new ConstructionHistory();
            LoadCombo();
            txbConstructionName.Text = nome;
        }

        public MaterialsMovement MaterialsMovement
        {
            get { return _materialsMovement; }
            set { _materialsMovement = value; }
        }

        private void LoadCombo()
        {
            cbxUnit.Items.Clear();
            foreach (var unitType in _unitTypes)
            {
                if (unitType != null)
                    cbxUnit.Items.Add(unitType);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                MessageBox.Show("Campos inválidos!" + (cbxUnit.SelectedIndex < 0 ? "" : " Por favor, selecione o tipo de unidade."), Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    _materialsMovement.Quantity = int.Parse(txbQuantity.Text);
                    _materialsMovement.DateOfMovement = Convert.ToDateTime(cboDateMov.Text);
                    _materialsMovement.Material = new Material
                    {
                        Name = txbName.Text,
                        Price = double.Parse(txbPrice.Value.ToString()),
                        TypeOfUnit = (UnitType)cbxUnit.SelectedItem ?? new UnitType() { Name = cbxUnit.Text },
                        Description = txbDescription.Text
                     };
                    _provider.Name = txbPoviderName.Text;
                    _provider.PhoneNumber = txbProviderPhone.Text;
                    c.MaterialsMovements = _materialsMovement;
                    c.MaterialsMovements.IsFromStock = true;
                    c.MaterialsMovements.TotalBalance = c.MaterialsMovements.Material.Price*c.MaterialsMovements.Quantity;
                    c.Provider = _provider;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Descrição do erro: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidateForm()
        {
            if (new List<TextBox>() { txbDescription, txbName, txbQuantity, txbPoviderName, }.Any(x => x.Text == string.Empty) || txbProviderPhone.Text == string.Empty ||(cbxUnit.SelectedIndex < 0))
                return false;
            return true;
        }

        private void txbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormAddUnitType frUnits = new FormAddUnitType();
            frUnits.ShowDialog();
            _unitTypes.Add(frUnits.UnitType);
            LoadCombo();
            cbxUnit.SelectedItem = frUnits.UnitType;
        }

       
    }
}
