using System;
using System.Windows.Forms;

namespace Servent.UI.Forms
{
    public partial class FormServerConfi : Form
    {
        private string _serverAddress;
        private bool _isLocalServer;
        public FormServerConfi()
        {
            InitializeComponent();
        }

        public FormServerConfi(string address, bool isLocalSever)
        {
            InitializeComponent();
            if (address == string.Empty) return;
            this._serverAddress = address;
            txbAddress.Text = _serverAddress;
            rbAnotherMachine.Checked = isLocalSever;
        }

        public String ServerAddress
        {
            get
            {
                return _serverAddress;
            }
        }

        private void rbAnotherMachine_CheckedChanged(object sender, EventArgs e)
        {
            label1.Enabled = txbAddress.Enabled = rbAnotherMachine.Checked;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbAnotherMachine.Checked && txbAddress.Text != string.Empty)
                this.DialogResult = DialogResult.OK;
            else if (rbLocalServer.Checked)
            {
                _serverAddress = "./sql";
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Por favor, informe o endereço do servidor corretamente.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Retry;
            }
        }

        public bool IsLocalServer
        {
            get { return _isLocalServer; }
            set { _isLocalServer = value; }
        }
    }
}
