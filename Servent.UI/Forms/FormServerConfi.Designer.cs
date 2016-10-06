namespace Servent.UI.Forms
{
    partial class FormServerConfi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormServerConfi));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.rbLocalServer = new System.Windows.Forms.RadioButton();
            this.rbAnotherMachine = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbAddress);
            this.groupBox1.Controls.Add(this.rbLocalServer);
            this.groupBox1.Controls.Add(this.rbAnotherMachine);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuração";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereço:";
            // 
            // txbAddress
            // 
            this.txbAddress.Enabled = false;
            this.txbAddress.Location = new System.Drawing.Point(88, 66);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(127, 20);
            this.txbAddress.TabIndex = 3;
            // 
            // rbLocalServer
            // 
            this.rbLocalServer.AutoSize = true;
            this.rbLocalServer.Checked = true;
            this.rbLocalServer.Location = new System.Drawing.Point(16, 124);
            this.rbLocalServer.Name = "rbLocalServer";
            this.rbLocalServer.Size = new System.Drawing.Size(199, 17);
            this.rbLocalServer.TabIndex = 2;
            this.rbLocalServer.TabStop = true;
            this.rbLocalServer.Text = "Usar a minha máquina como servidor";
            this.rbLocalServer.UseVisualStyleBackColor = true;
            // 
            // rbAnotherMachine
            // 
            this.rbAnotherMachine.AutoSize = true;
            this.rbAnotherMachine.Location = new System.Drawing.Point(16, 40);
            this.rbAnotherMachine.Name = "rbAnotherMachine";
            this.rbAnotherMachine.Size = new System.Drawing.Size(126, 17);
            this.rbAnotherMachine.TabIndex = 1;
            this.rbAnotherMachine.Text = "Utilizar outra máquina";
            this.rbAnotherMachine.UseVisualStyleBackColor = true;
            this.rbAnotherMachine.CheckedChanged += new System.EventHandler(this.rbAnotherMachine_CheckedChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(190, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(271, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormServerConfi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormServerConfi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Servidor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.RadioButton rbLocalServer;
        private System.Windows.Forms.RadioButton rbAnotherMachine;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}