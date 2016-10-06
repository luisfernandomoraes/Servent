namespace Servent.UI.Forms
{
    partial class FormAddConstruction
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
            Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton dateButton1 = new Infragistics.Win.UltraWinSchedule.CalendarCombo.DateButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddConstruction));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbRespNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbAddressDetails = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbAddressStreet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAddressNeighboard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddressNumber = new System.Windows.Forms.TextBox();
            this.rbAlive = new System.Windows.Forms.RadioButton();
            this.rbFinalized = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txbResponsible = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.cboDateAddConstruction = new Infragistics.Win.UltraWinSchedule.UltraCalendarCombo();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNameConstruction = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateAddConstruction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(591, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(510, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(-7, 442);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 10);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbRespNumber);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.rbAlive);
            this.groupBox2.Controls.Add(this.rbFinalized);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txbResponsible);
            this.groupBox2.Controls.Add(this.txbDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCode);
            this.groupBox2.Controls.Add(this.txbID);
            this.groupBox2.Controls.Add(this.cboDateAddConstruction);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txbNameConstruction);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 391);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Construção:";
            // 
            // txbRespNumber
            // 
            this.txbRespNumber.Location = new System.Drawing.Point(97, 145);
            this.txbRespNumber.Mask = "(99) 0000-0000";
            this.txbRespNumber.Name = "txbRespNumber";
            this.txbRespNumber.Size = new System.Drawing.Size(230, 20);
            this.txbRespNumber.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Nº Responsável:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbAddressDetails);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txbAddressStreet);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txbAddressNeighboard);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtAddressNumber);
            this.groupBox3.Location = new System.Drawing.Point(333, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 300);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Endereço";
            // 
            // txbAddressDetails
            // 
            this.txbAddressDetails.Location = new System.Drawing.Point(85, 152);
            this.txbAddressDetails.Multiline = true;
            this.txbAddressDetails.Name = "txbAddressDetails";
            this.txbAddressDetails.Size = new System.Drawing.Size(192, 104);
            this.txbAddressDetails.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Complemento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Rua:";
            // 
            // txbAddressStreet
            // 
            this.txbAddressStreet.Location = new System.Drawing.Point(85, 112);
            this.txbAddressStreet.Name = "txbAddressStreet";
            this.txbAddressStreet.Size = new System.Drawing.Size(192, 20);
            this.txbAddressStreet.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Bairro:";
            // 
            // txbAddressNeighboard
            // 
            this.txbAddressNeighboard.Location = new System.Drawing.Point(85, 74);
            this.txbAddressNeighboard.Name = "txbAddressNeighboard";
            this.txbAddressNeighboard.Size = new System.Drawing.Size(192, 20);
            this.txbAddressNeighboard.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Número:";
            // 
            // txtAddressNumber
            // 
            this.txtAddressNumber.Location = new System.Drawing.Point(85, 37);
            this.txtAddressNumber.Name = "txtAddressNumber";
            this.txtAddressNumber.Size = new System.Drawing.Size(192, 20);
            this.txtAddressNumber.TabIndex = 0;
            this.txtAddressNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddressNumber_KeyPress);
            // 
            // rbAlive
            // 
            this.rbAlive.AutoSize = true;
            this.rbAlive.Checked = true;
            this.rbAlive.Location = new System.Drawing.Point(97, 337);
            this.rbAlive.Name = "rbAlive";
            this.rbAlive.Size = new System.Drawing.Size(49, 17);
            this.rbAlive.TabIndex = 5;
            this.rbAlive.TabStop = true;
            this.rbAlive.Text = "Ativa";
            this.rbAlive.UseVisualStyleBackColor = true;
            // 
            // rbFinalized
            // 
            this.rbFinalized.AutoSize = true;
            this.rbFinalized.Location = new System.Drawing.Point(152, 337);
            this.rbFinalized.Name = "rbFinalized";
            this.rbFinalized.Size = new System.Drawing.Size(72, 17);
            this.rbFinalized.TabIndex = 6;
            this.rbFinalized.Text = "Finalizada";
            this.rbFinalized.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Status:";
            // 
            // txbResponsible
            // 
            this.txbResponsible.Location = new System.Drawing.Point(96, 104);
            this.txbResponsible.Name = "txbResponsible";
            this.txbResponsible.Size = new System.Drawing.Size(231, 20);
            this.txbResponsible.TabIndex = 1;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(96, 226);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(231, 101);
            this.txbDescription.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descrição:";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(8, 30);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(43, 13);
            this.lblCode.TabIndex = 28;
            this.lblCode.Text = "Código:";
            this.lblCode.Visible = false;
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(96, 27);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(141, 20);
            this.txbID.TabIndex = 27;
            this.txbID.Visible = false;
            // 
            // cboDateAddConstruction
            // 
            this.cboDateAddConstruction.DateButtons.Add(dateButton1);
            this.cboDateAddConstruction.Location = new System.Drawing.Point(97, 186);
            this.cboDateAddConstruction.Name = "cboDateAddConstruction";
            this.cboDateAddConstruction.NonAutoSizeHeight = 21;
            this.cboDateAddConstruction.Size = new System.Drawing.Size(230, 21);
            this.cboDateAddConstruction.SpinButtonsVisible = true;
            this.cboDateAddConstruction.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Responsável:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nome:";
            // 
            // txbNameConstruction
            // 
            this.txbNameConstruction.Location = new System.Drawing.Point(96, 66);
            this.txbNameConstruction.Name = "txbNameConstruction";
            this.txbNameConstruction.Size = new System.Drawing.Size(231, 20);
            this.txbNameConstruction.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Data de adição:";
            // 
            // FormAddConstruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 509);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddConstruction";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adição de Construções";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboDateAddConstruction)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbID;
        private Infragistics.Win.UltraWinSchedule.UltraCalendarCombo cboDateAddConstruction;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNameConstruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbResponsible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFinalized;
        private System.Windows.Forms.RadioButton rbAlive;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddressNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbAddressStreet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAddressNeighboard;
        private System.Windows.Forms.TextBox txbAddressDetails;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txbRespNumber;
        private System.Windows.Forms.Label label10;
    }
}