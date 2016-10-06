namespace Servent.UI.Forms
{
    partial class FormAddUnitType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUnitType));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbUnitID = new System.Windows.Forms.TextBox();
            this.lblUnitID = new System.Windows.Forms.Label();
            this.txbDescriptionUnit = new System.Windows.Forms.TextBox();
            this.txbNameUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbFinalized = new System.Windows.Forms.CheckBox();
            this.ckbAlive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Location = new System.Drawing.Point(1, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 10);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txbUnitID);
            this.groupBox2.Controls.Add(this.lblUnitID);
            this.groupBox2.Controls.Add(this.txbDescriptionUnit);
            this.groupBox2.Controls.Add(this.txbNameUnit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ckbFinalized);
            this.groupBox2.Controls.Add(this.ckbAlive);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 184);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Unidade:";
            // 
            // txbUnitID
            // 
            this.txbUnitID.Location = new System.Drawing.Point(105, 18);
            this.txbUnitID.Name = "txbUnitID";
            this.txbUnitID.ReadOnly = true;
            this.txbUnitID.Size = new System.Drawing.Size(100, 20);
            this.txbUnitID.TabIndex = 43;
            // 
            // lblUnitID
            // 
            this.lblUnitID.AutoSize = true;
            this.lblUnitID.Location = new System.Drawing.Point(31, 25);
            this.lblUnitID.Name = "lblUnitID";
            this.lblUnitID.Size = new System.Drawing.Size(43, 13);
            this.lblUnitID.TabIndex = 42;
            this.lblUnitID.Text = "Código:";
            this.lblUnitID.Visible = false;
            // 
            // txbDescriptionUnit
            // 
            this.txbDescriptionUnit.Location = new System.Drawing.Point(105, 81);
            this.txbDescriptionUnit.Multiline = true;
            this.txbDescriptionUnit.Name = "txbDescriptionUnit";
            this.txbDescriptionUnit.Size = new System.Drawing.Size(100, 65);
            this.txbDescriptionUnit.TabIndex = 41;
            // 
            // txbNameUnit
            // 
            this.txbNameUnit.Location = new System.Drawing.Point(105, 45);
            this.txbNameUnit.Name = "txbNameUnit";
            this.txbNameUnit.Size = new System.Drawing.Size(100, 20);
            this.txbNameUnit.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome:";
            // 
            // ckbFinalized
            // 
            this.ckbFinalized.AutoSize = true;
            this.ckbFinalized.Location = new System.Drawing.Point(165, 334);
            this.ckbFinalized.Name = "ckbFinalized";
            this.ckbFinalized.Size = new System.Drawing.Size(73, 17);
            this.ckbFinalized.TabIndex = 37;
            this.ckbFinalized.Text = "Finalizada";
            this.ckbFinalized.UseVisualStyleBackColor = true;
            // 
            // ckbAlive
            // 
            this.ckbAlive.AutoSize = true;
            this.ckbAlive.Location = new System.Drawing.Point(105, 334);
            this.ckbAlive.Name = "ckbAlive";
            this.ckbAlive.Size = new System.Drawing.Size(50, 17);
            this.ckbAlive.TabIndex = 36;
            this.ckbAlive.Text = "Ativa";
            this.ckbAlive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Status:";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Location = new System.Drawing.Point(139, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Location = new System.Drawing.Point(220, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormAddUnitType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 300);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddUnitType";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adição de Tipo de Unidade";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbDescriptionUnit;
        private System.Windows.Forms.TextBox txbNameUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbFinalized;
        private System.Windows.Forms.CheckBox ckbAlive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txbUnitID;
        private System.Windows.Forms.Label lblUnitID;
    }
}