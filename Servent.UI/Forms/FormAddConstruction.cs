using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormAddConstruction : Form
    {
        private Construction _construction;

        public FormAddConstruction()
        {
            InitializeComponent();
            _construction = new Construction();

        }

        public FormAddConstruction(Domain.Construction construction)
        {
            InitializeComponent();
            this.Construction = construction;
            lblCode.Visible = txbID.Visible = true;

            txbID.Text = construction.ID.ToString();
            txbNameConstruction.Text = construction.Name;
            txbResponsible.Text = construction.Responsible;
            txbRespNumber.Text = construction.ResponsiblePhone;
            cboDateAddConstruction.Text = construction.ConstructionDate.ToShortDateString();
            txbDescription.Text = construction.Description;
            rbFinalized.Checked = !(rbAlive.Checked = construction.IsAlive);
            txtAddressNumber.Text = construction.Address.Number.ToString();
            txbAddressNeighboard.Text = construction.Address.Neighborhood;
            txbAddressStreet.Text = construction.Address.Street;
            txbAddressDetails.Text = construction.Address.Details;
            btnAdd.Text = "Salvar";
        }

        public Construction Construction
        {
            get { return _construction; }
            set { _construction = value; }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string validate = Validate();
            if (validate != string.Empty)
                MessageBox.Show("Campos inválidos! "+ validate, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //Construção do objeto.
               _construction.Address = new Address()
                                       {
                                           Details = txbAddressDetails.Text,
                                           Neighborhood = txbAddressNeighboard.Text,
                                           Number = Convert.ToInt32(txtAddressNumber.Text),
                                           Street = txbAddressStreet.Text
                                       };

                _construction.Description = txbDescription.Text;
                _construction.Name = txbNameConstruction.Text;
                _construction.Responsible = txbResponsible.Text;
                _construction.ResponsiblePhone =  txbRespNumber.Text;
                _construction.IsAlive = rbAlive.Checked;
                _construction.ConstructionDate = DateTime.Parse(cboDateAddConstruction.Text);
                //Setando o resultado do dialogo.
                this.DialogResult = DialogResult.OK;
            }
        }

        public string Validate()
        {
            if (new List<TextBox>()
                {
                    txbAddressNeighboard,
                    txbAddressStreet,
                    txbNameConstruction,
                    txbResponsible,
                    txtAddressNumber
                }.Any(x => x.Text == string.Empty))
                return "Os campos de identificação da obra e do responsável não podem ser vazios.";
            if (Convert.ToDateTime(cboDateAddConstruction.Text).CompareTo(DateTime.Today) > 0)
            {
                return "Não pode ser adicionada uma data futura.";
            }
            return string.Empty;
        }

        private void txtAddressNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        
    }
}
