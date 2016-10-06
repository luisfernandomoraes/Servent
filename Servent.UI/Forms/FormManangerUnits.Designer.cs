namespace Servent.UI.Forms
{
    partial class FormManangerUnits
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
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cName", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDescription");
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cID");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cName");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cDescription");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManangerUnits));
            this.ultraGridUnitsType = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.ultraDataSource1 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this.tbUnit = new System.Data.DataSet();
            this.tbUnits = new System.Data.DataTable();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridUnitsType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnits)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraGridUnitsType
            // 
            this.ultraGridUnitsType.CausesValidation = false;
            this.ultraGridUnitsType.DataSource = this.ultraDataSource1;
            appearance13.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance13.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance13.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGridUnitsType.DisplayLayout.Appearance = appearance13;
            ultraGridColumn1.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn1.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Equals;
            ultraGridColumn1.Header.Caption = "Código";
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn1.Hidden = true;
            ultraGridColumn1.Width = 200;
            ultraGridColumn2.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn2.Header.Caption = "Tipo de Unidade";
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn2.Width = 200;
            ultraGridColumn3.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            ultraGridColumn3.Header.Caption = "Descrição";
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn3.Width = 222;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3});
            this.ultraGridUnitsType.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGridUnitsType.DisplayLayout.GroupByBox.Prompt = "Arraste uma coluna aqui para agrupar.";
            this.ultraGridUnitsType.DisplayLayout.InterBandSpacing = 10;
            this.ultraGridUnitsType.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGridUnitsType.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridUnitsType.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGridUnitsType.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridUnitsType.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            appearance14.BackColor = System.Drawing.Color.Transparent;
            this.ultraGridUnitsType.DisplayLayout.Override.CardAreaAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.Control;
            appearance15.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance15.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridUnitsType.DisplayLayout.Override.CellAppearance = appearance15;
            this.ultraGridUnitsType.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGridUnitsType.DisplayLayout.Override.CellPadding = 2;
            this.ultraGridUnitsType.DisplayLayout.Override.CellSpacing = 2;
            appearance16.BackColor = System.Drawing.SystemColors.Control;
            appearance16.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance16.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance16.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGridUnitsType.DisplayLayout.Override.HeaderAppearance = appearance16;
            this.ultraGridUnitsType.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance17.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ultraGridUnitsType.DisplayLayout.Override.RowAppearance = appearance17;
            appearance18.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraGridUnitsType.DisplayLayout.Override.RowSelectorAppearance = appearance18;
            this.ultraGridUnitsType.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGridUnitsType.DisplayLayout.Override.RowSpacingAfter = 1;
            this.ultraGridUnitsType.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance19.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance19.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance19.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGridUnitsType.DisplayLayout.Override.SelectedRowAppearance = appearance19;
            this.ultraGridUnitsType.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGridUnitsType.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGridUnitsType.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGridUnitsType.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended;
            this.ultraGridUnitsType.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGridUnitsType.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            this.ultraGridUnitsType.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGridUnitsType.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell;
            this.ultraGridUnitsType.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGridUnitsType.Location = new System.Drawing.Point(-1, 81);
            this.ultraGridUnitsType.Name = "ultraGridUnitsType";
            this.ultraGridUnitsType.Size = new System.Drawing.Size(425, 384);
            this.ultraGridUnitsType.TabIndex = 22;
            // 
            // ultraDataSource1
            // 
            this.ultraDataSource1.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3});
            // 
            // tbUnit
            // 
            this.tbUnit.DataSetName = "NewDataSet";
            this.tbUnit.Tables.AddRange(new System.Data.DataTable[] {
            this.tbUnits});
            // 
            // tbUnits
            // 
            this.tbUnits.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn3,
            this.dataColumn1,
            this.dataColumn2});
            this.tbUnits.TableName = "Table1";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "cId";
            this.dataColumn3.DataType = typeof(int);
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Tipo de Unidade";
            this.dataColumn1.ColumnName = "cUnitType";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Descrição";
            this.dataColumn2.ColumnName = "cDescription";
            // 
            // btnDel
            // 
            this.btnDel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDel.FlatAppearance.BorderSize = 5;
            this.btnDel.Image = global::Servent.UI.Properties.Resources._1382751000_90;
            this.btnDel.Location = new System.Drawing.Point(175, 12);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 51);
            this.btnDel.TabIndex = 21;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.FlatAppearance.BorderSize = 5;
            this.btnUpdate.Image = global::Servent.UI.Properties.Resources._1382750732_519584_081_Pen;
            this.btnUpdate.Location = new System.Drawing.Point(94, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 51);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "\r\n";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatAppearance.BorderSize = 5;
            this.btnAdd.Image = global::Servent.UI.Properties.Resources._1382750997_519691_199_CircledPlus;
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 51);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox2.Location = new System.Drawing.Point(-1, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 10);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // FormManangerUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(422, 466);
            this.Controls.Add(this.ultraGridUnitsType);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormManangerUnits";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gerenciador de Tipos de Unidades";
            ((System.ComponentModel.ISupportInitialize)(this.ultraGridUnitsType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUnits)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDel;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGridUnitsType;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource1;
        private System.Data.DataSet tbUnit;
        private System.Data.DataTable tbUnits;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}