using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormAddUnitType : Form
    {
        private UnitType _unitType;
        public FormAddUnitType()
        {
            InitializeComponent();
            UnitType = new UnitType();
            txbUnitID.Visible = false;

        }

        public FormAddUnitType(UnitType unitType)
        {
            InitializeComponent();
            UnitType = unitType;
            this.Text = "Edição de Unidades";
            txbNameUnit.Text = unitType.Name;
            lblUnitID.Visible = true;
            txbUnitID.Text = unitType.ID.ToString();
            txbUnitID.ReadOnly = true;
            txbDescriptionUnit.Text = unitType.Description;
            btnAdd.Text = "Salvar";
        }

        public UnitType UnitType
        {
            get { return _unitType; }
            set { _unitType = value; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                MessageBox.Show("Campos inválidos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    UnitType.Name = txbNameUnit.Text;
                    UnitType.Description = txbDescriptionUnit.Text;
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Descrição do erro: "+ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

              
            }
        }

        private bool ValidateForm()
        {
            if (new List<TextBox>() {txbNameUnit}.Any(x => x.Text == string.Empty))
                return false;
            return true;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
             MessageBox.Show("Campos inválidos!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    UnitType.Name = txbNameUnit.Text;
                    UnitType.Description = txbDescriptionUnit.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Descrição do erro: "+ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.DialogResult = DialogResult.OK;
                InitializeComponent();
                //qual é o dialogresult para não fechar a tela?
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

       
    }
}
