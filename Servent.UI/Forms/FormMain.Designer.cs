namespace Servent.UI.Forms
{
    partial class FormAdministration
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("TbStock", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn1 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cID");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn2 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cName");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn3 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cQuantity");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn4 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cUnityType");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn5 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cUnityPrice");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn6 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cLastMov");
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn7 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cTotalBalance", -1, null, 0, Infragistics.Win.UltraWinGrid.SortIndicator.Descending, false);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn8 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("cDescription");
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn1 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cID");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn2 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cName");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn3 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cQuantity");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn4 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cUnityType");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn5 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cUnityPrice");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn6 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cLastMov");
            Infragistics.Win.UltraWinDataSource.UltraDataColumn ultraDataColumn7 = new Infragistics.Win.UltraWinDataSource.UltraDataColumn("cTotalBalance");
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool13 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnExit");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool25 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnServer");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab1 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon1");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup1 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool1 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddMaterials");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool3 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnUpdateMaterial");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool5 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnDelete");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup2 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup2");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool14 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnMananger");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup3 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup3");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool18 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnLow");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab2 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon2");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup4 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup1");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool2 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddConstruction");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool4 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnUpdateConstruction");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool6 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnDeleteConstruction");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup5 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup2");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool23 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnHistoric");
            Infragistics.Win.UltraWinToolbars.RibbonGroup ribbonGroup6 = new Infragistics.Win.UltraWinToolbars.RibbonGroup("ribbonGroup3");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool20 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddMaterialFromStore");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool7 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddMaterials");
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool8 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnUpdateMaterial");
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool9 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnDelete");
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool10 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddConstruction");
            Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool11 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnUpdateConstruction");
            Infragistics.Win.Appearance appearance19 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool12 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnDeleteConstruction");
            Infragistics.Win.Appearance appearance20 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool15 = new Infragistics.Win.UltraWinToolbars.ButtonTool("Adicionar");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool16 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnMananger");
            Infragistics.Win.Appearance appearance21 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool17 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnExit");
            Infragistics.Win.Appearance appearance22 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool19 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnLow");
            Infragistics.Win.Appearance appearance23 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool21 = new Infragistics.Win.UltraWinToolbars.ButtonTool("BtnAddMaterial");
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool22 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnAddMaterialFromStore");
            Infragistics.Win.Appearance appearance31 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool24 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnHistoric");
            Infragistics.Win.Appearance appearance32 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinToolbars.ButtonTool buttonTool26 = new Infragistics.Win.UltraWinToolbars.ButtonTool("btnServer");
            Infragistics.Win.Appearance appearance33 = new Infragistics.Win.Appearance();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministration));
            this.Form1_Fill_Panel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.ultraGrid = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.tbServent = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.cID = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.ultraDataSource3 = new Infragistics.Win.UltraWinDataSource.UltraDataSource(this.components);
            this._FormAdministration_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.toolbarsManager = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._FormAdministration_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._FormAdministration_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._FormAdministration_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.Form1_Fill_Panel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1_Fill_Panel
            // 
            this.Form1_Fill_Panel.Controls.Add(this.statusStrip1);
            this.Form1_Fill_Panel.Controls.Add(this.ultraGrid);
            this.Form1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Form1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1_Fill_Panel.Location = new System.Drawing.Point(4, 145);
            this.Form1_Fill_Panel.Name = "Form1_Fill_Panel";
            this.Form1_Fill_Panel.Size = new System.Drawing.Size(1186, 556);
            this.Form1_Fill_Panel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 534);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel1.Text = "Valor total de estoque:";
            // 
            // lblValue
            // 
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(23, 17);
            this.lblValue.Text = "R$ ";
            // 
            // ultraGrid
            // 
            this.ultraGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ultraGrid.DataSource = this.tbServent;
            appearance1.BackColor = System.Drawing.SystemColors.ControlLight;
            appearance1.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance1.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            this.ultraGrid.DisplayLayout.Appearance = appearance1;
            ultraGridColumn1.Header.VisiblePosition = 0;
            ultraGridColumn2.Header.VisiblePosition = 1;
            ultraGridColumn3.Header.VisiblePosition = 2;
            ultraGridColumn4.Header.Caption = "Tipo de Unidade";
            ultraGridColumn4.Header.VisiblePosition = 3;
            ultraGridColumn5.Header.Caption = "Valor por Unidade";
            ultraGridColumn5.Header.VisiblePosition = 4;
            ultraGridColumn6.Header.VisiblePosition = 5;
            ultraGridColumn7.Header.Caption = "Valor Total";
            ultraGridColumn7.Header.VisiblePosition = 6;
            ultraGridColumn8.Header.VisiblePosition = 7;
            ultraGridColumn8.MinLength = 200;
            ultraGridColumn8.ProportionalResize = true;
            ultraGridColumn8.Width = 250;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn1,
            ultraGridColumn2,
            ultraGridColumn3,
            ultraGridColumn4,
            ultraGridColumn5,
            ultraGridColumn6,
            ultraGridColumn7,
            ultraGridColumn8});
            ultraGridBand1.RowLayoutStyle = Infragistics.Win.UltraWinGrid.RowLayoutStyle.ColumnLayout;
            this.ultraGrid.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.ultraGrid.DisplayLayout.InterBandSpacing = 10;
            this.ultraGrid.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.ultraGrid.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.AllowGroupBy = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
            this.ultraGrid.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.False;
            this.ultraGrid.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.None;
            appearance2.BackColor = System.Drawing.Color.Transparent;
            this.ultraGrid.DisplayLayout.Override.CardAreaAppearance = appearance2;
            appearance3.BackColor = System.Drawing.SystemColors.Control;
            appearance3.BackColor2 = System.Drawing.SystemColors.ControlLightLight;
            appearance3.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.CellAppearance = appearance3;
            this.ultraGrid.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.ultraGrid.DisplayLayout.Override.CellPadding = 2;
            this.ultraGrid.DisplayLayout.Override.CellSpacing = 2;
            appearance4.BackColor = System.Drawing.SystemColors.Control;
            appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            appearance4.ThemedElementAlpha = Infragistics.Win.Alpha.Transparent;
            this.ultraGrid.DisplayLayout.Override.HeaderAppearance = appearance4;
            this.ultraGrid.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            appearance5.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.ultraGrid.DisplayLayout.Override.RowAppearance = appearance5;
            appearance6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ultraGrid.DisplayLayout.Override.RowSelectorAppearance = appearance6;
            this.ultraGrid.DisplayLayout.Override.RowSpacingAfter = 1;
            this.ultraGrid.DisplayLayout.Override.RowSpacingBefore = 2;
            appearance7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            appearance7.BackColor2 = System.Drawing.SystemColors.ActiveCaption;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.VerticalBump;
            this.ultraGrid.DisplayLayout.Override.SelectedRowAppearance = appearance7;
            this.ultraGrid.DisplayLayout.Override.SelectTypeCell = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid.DisplayLayout.Override.SelectTypeCol = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid.DisplayLayout.Override.SelectTypeGroupByRow = Infragistics.Win.UltraWinGrid.SelectType.None;
            this.ultraGrid.DisplayLayout.Override.SelectTypeRow = Infragistics.Win.UltraWinGrid.SelectType.Extended;
            this.ultraGrid.DisplayLayout.RowConnectorColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ultraGrid.DisplayLayout.RowConnectorStyle = Infragistics.Win.UltraWinGrid.RowConnectorStyle.Dashed;
            this.ultraGrid.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.ultraGrid.DisplayLayout.TabNavigation = Infragistics.Win.UltraWinGrid.TabNavigation.NextControlOnLastCell;
            this.ultraGrid.DisplayLayout.ViewStyleBand = Infragistics.Win.UltraWinGrid.ViewStyleBand.OutlookGroupBy;
            this.ultraGrid.Location = new System.Drawing.Point(0, 0);
            this.ultraGrid.Name = "ultraGrid";
            this.ultraGrid.Size = new System.Drawing.Size(1186, 557);
            this.ultraGrid.TabIndex = 0;
            this.ultraGrid.DoubleClickRow += new Infragistics.Win.UltraWinGrid.DoubleClickRowEventHandler(this.ultraGrid_DoubleClickRow);
            // 
            // tbServent
            // 
            this.tbServent.DataSetName = "NewDataSet";
            this.tbServent.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.cID,
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7});
            this.dataTable1.TableName = "TbStock";
            // 
            // cID
            // 
            this.cID.Caption = "Código";
            this.cID.ColumnName = "cID";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "Material";
            this.dataColumn1.ColumnName = "cName";
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "Quantidade";
            this.dataColumn2.ColumnName = "cQuantity";
            this.dataColumn2.DataType = typeof(int);
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "Unidade";
            this.dataColumn3.ColumnName = "cUnityType";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "Preço";
            this.dataColumn4.ColumnName = "cUnityPrice";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "Última Movimentação";
            this.dataColumn5.ColumnName = "cLastMov";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "Balanço Total";
            this.dataColumn6.ColumnName = "cTotalBalance";
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "Descrição";
            this.dataColumn7.ColumnName = "cDescription";
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn14,
            this.dataColumn12,
            this.dataColumn13});
            this.dataTable2.TableName = "TbConstructions";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "Código";
            this.dataColumn8.ColumnName = "cID";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "Construção";
            this.dataColumn9.ColumnName = "cConstructionName";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "Endereço";
            this.dataColumn10.ColumnName = "cAddress";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "Responsável";
            this.dataColumn11.ColumnName = "cResponsible";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "Telefone do Responsavél";
            this.dataColumn14.ColumnName = "cResponsiblePhone";
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "Ativa";
            this.dataColumn12.ColumnName = "cIsAlive";
            this.dataColumn12.DataType = typeof(bool);
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "Descrição";
            this.dataColumn13.ColumnName = "cDescriptionConstruction";
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn17,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20,
            this.dataColumn21});
            this.dataTable3.TableName = "TbHistoric";
            // 
            // dataColumn17
            // 
            this.dataColumn17.Caption = "ID";
            this.dataColumn17.ColumnName = "cProviderID";
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "Fornecedor";
            this.dataColumn15.ColumnName = "cProviderName";
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "Telefone";
            this.dataColumn16.ColumnName = "cProviderPhone";
            // 
            // dataColumn18
            // 
            this.dataColumn18.Caption = "Material";
            this.dataColumn18.ColumnName = "cMatName";
            // 
            // dataColumn19
            // 
            this.dataColumn19.Caption = "Data";
            this.dataColumn19.ColumnName = "cDate";
            // 
            // dataColumn20
            // 
            this.dataColumn20.Caption = "Quantidade";
            this.dataColumn20.ColumnName = "cQtd";
            // 
            // dataColumn21
            // 
            this.dataColumn21.Caption = "Valor";
            this.dataColumn21.ColumnName = "cTotalBalance";
            // 
            // ultraDataSource3
            // 
            ultraDataColumn1.DataType = typeof(decimal);
            this.ultraDataSource3.Band.Columns.AddRange(new object[] {
            ultraDataColumn1,
            ultraDataColumn2,
            ultraDataColumn3,
            ultraDataColumn4,
            ultraDataColumn5,
            ultraDataColumn6,
            ultraDataColumn7});
            // 
            // _FormAdministration_Toolbars_Dock_Area_Left
            // 
            this._FormAdministration_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FormAdministration_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this._FormAdministration_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._FormAdministration_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FormAdministration_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4;
            this._FormAdministration_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 145);
            this._FormAdministration_Toolbars_Dock_Area_Left.Name = "_FormAdministration_Toolbars_Dock_Area_Left";
            this._FormAdministration_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(4, 556);
            this._FormAdministration_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbarsManager;
            // 
            // toolbarsManager
            // 
            this.toolbarsManager.AlwaysShowMenusExpanded = Infragistics.Win.DefaultableBoolean.True;
            this.toolbarsManager.DesignerFlags = 1;
            this.toolbarsManager.DockWithinContainer = this;
            this.toolbarsManager.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.toolbarsManager.Office2007UICompatibility = false;
            appearance8.ThemedElementAlpha = Infragistics.Win.Alpha.UseAlphaLevel;
            this.toolbarsManager.Ribbon.ApplicationMenu.FooterToolbar.Settings.Appearance = appearance8;
            this.toolbarsManager.Ribbon.ApplicationMenu.ToolAreaLeft.NonInheritedTools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool13,
            buttonTool25});
            ribbonTab1.Caption = "Estoque";
            ribbonGroup1.Caption = "Materiais";
            buttonTool1.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            buttonTool3.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            buttonTool5.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup1.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool1,
            buttonTool3,
            buttonTool5});
            ribbonGroup2.Caption = "Unidades de Medida";
            buttonTool14.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup2.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool14});
            ribbonGroup3.Caption = "Baixas";
            buttonTool18.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup3.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool18});
            ribbonTab1.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup1,
            ribbonGroup2,
            ribbonGroup3});
            ribbonTab2.Caption = "Obras";
            ribbonGroup4.Caption = "Gerenciar";
            buttonTool2.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            buttonTool4.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            buttonTool6.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup4.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool2,
            buttonTool4,
            buttonTool6});
            ribbonGroup5.Caption = "Histórico";
            buttonTool23.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup5.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool23});
            ribbonGroup6.Caption = "";
            buttonTool20.InstanceProps.PreferredSizeOnRibbon = Infragistics.Win.UltraWinToolbars.RibbonToolSize.Large;
            ribbonGroup6.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool20});
            ribbonTab2.Groups.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonGroup[] {
            ribbonGroup4,
            ribbonGroup5,
            ribbonGroup6});
            this.toolbarsManager.Ribbon.NonInheritedRibbonTabs.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonTab[] {
            ribbonTab1,
            ribbonTab2});
            this.toolbarsManager.Ribbon.QuickAccessToolbar.Visible = false;
            this.toolbarsManager.Ribbon.Visible = true;
            this.toolbarsManager.ShowFullMenusDelay = 250;
            this.toolbarsManager.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.ScenicRibbon;
            appearance9.Image = global::Servent.UI.Properties.Resources._01b;
            buttonTool7.SharedPropsInternal.AppearancesLarge.Appearance = appearance9;
            buttonTool7.SharedPropsInternal.Caption = "Adicionar";
            appearance10.Image = global::Servent.UI.Properties.Resources._02b;
            buttonTool8.SharedPropsInternal.AppearancesLarge.Appearance = appearance10;
            buttonTool8.SharedPropsInternal.Caption = "Editar";
            appearance17.Image = global::Servent.UI.Properties.Resources._03b;
            buttonTool9.SharedPropsInternal.AppearancesLarge.Appearance = appearance17;
            buttonTool9.SharedPropsInternal.Caption = "Excluir";
            appearance18.Image = global::Servent.UI.Properties.Resources.adicionar;
            buttonTool10.SharedPropsInternal.AppearancesLarge.Appearance = appearance18;
            buttonTool10.SharedPropsInternal.Caption = "Adicionar";
            appearance19.Image = global::Servent.UI.Properties.Resources.editar;
            buttonTool11.SharedPropsInternal.AppearancesLarge.Appearance = appearance19;
            buttonTool11.SharedPropsInternal.Caption = "Editar";
            appearance20.Image = global::Servent.UI.Properties.Resources.excluir;
            buttonTool12.SharedPropsInternal.AppearancesLarge.Appearance = appearance20;
            buttonTool12.SharedPropsInternal.Caption = "Excluir";
            buttonTool15.SharedPropsInternal.Caption = "Adicionar";
            appearance21.Image = global::Servent.UI.Properties.Resources.unidades_de_medida;
            buttonTool16.SharedPropsInternal.AppearancesLarge.Appearance = appearance21;
            buttonTool16.SharedPropsInternal.Caption = "Gerenciar";
            appearance22.Image = global::Servent.UI.Properties.Resources.exit;
            buttonTool17.SharedPropsInternal.AppearancesLarge.Appearance = appearance22;
            buttonTool17.SharedPropsInternal.Caption = "Sair";
            appearance23.Image = global::Servent.UI.Properties.Resources.residential_construction_256;
            buttonTool19.SharedPropsInternal.AppearancesLarge.Appearance = appearance23;
            buttonTool19.SharedPropsInternal.Caption = "Obras";
            buttonTool21.SharedPropsInternal.Caption = "Adicionar ";
            appearance31.Image = global::Servent.UI.Properties.Resources.addMat;
            buttonTool22.SharedPropsInternal.AppearancesLarge.Appearance = appearance31;
            buttonTool22.SharedPropsInternal.Caption = "Adicionar Material";
            appearance32.Image = global::Servent.UI.Properties.Resources._1383971288_old_edit_find;
            buttonTool24.SharedPropsInternal.AppearancesLarge.Appearance = appearance32;
            buttonTool24.SharedPropsInternal.Caption = "Histórico de Movimentações";
            appearance33.Image = global::Servent.UI.Properties.Resources.server1;
            buttonTool26.SharedPropsInternal.AppearancesLarge.Appearance = appearance33;
            buttonTool26.SharedPropsInternal.Caption = "Servidor";
            this.toolbarsManager.Tools.AddRange(new Infragistics.Win.UltraWinToolbars.ToolBase[] {
            buttonTool7,
            buttonTool8,
            buttonTool9,
            buttonTool10,
            buttonTool11,
            buttonTool12,
            buttonTool15,
            buttonTool16,
            buttonTool17,
            buttonTool19,
            buttonTool21,
            buttonTool22,
            buttonTool24,
            buttonTool26});
            this.toolbarsManager.AfterRibbonTabSelected += new Infragistics.Win.UltraWinToolbars.RibbonTabEventHandler(this.toolbarsManager_AfterRibbonTabSelected);
            this.toolbarsManager.ToolClick += new Infragistics.Win.UltraWinToolbars.ToolClickEventHandler(this.toolbarsManager_ToolClick);
            // 
            // _FormAdministration_Toolbars_Dock_Area_Right
            // 
            this._FormAdministration_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FormAdministration_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this._FormAdministration_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._FormAdministration_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FormAdministration_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4;
            this._FormAdministration_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1190, 145);
            this._FormAdministration_Toolbars_Dock_Area_Right.Name = "_FormAdministration_Toolbars_Dock_Area_Right";
            this._FormAdministration_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(4, 556);
            this._FormAdministration_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbarsManager;
            // 
            // _FormAdministration_Toolbars_Dock_Area_Top
            // 
            this._FormAdministration_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FormAdministration_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this._FormAdministration_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._FormAdministration_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FormAdministration_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._FormAdministration_Toolbars_Dock_Area_Top.Name = "_FormAdministration_Toolbars_Dock_Area_Top";
            this._FormAdministration_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1194, 145);
            this._FormAdministration_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbarsManager;
            // 
            // _FormAdministration_Toolbars_Dock_Area_Bottom
            // 
            this._FormAdministration_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._FormAdministration_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(233)))), ((int)(((byte)(245)))));
            this._FormAdministration_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._FormAdministration_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._FormAdministration_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 4;
            this._FormAdministration_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 701);
            this._FormAdministration_Toolbars_Dock_Area_Bottom.Name = "_FormAdministration_Toolbars_Dock_Area_Bottom";
            this._FormAdministration_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1194, 4);
            this._FormAdministration_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolbarsManager;
            // 
            // FormAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 705);
            this.Controls.Add(this.Form1_Fill_Panel);
            this.Controls.Add(this._FormAdministration_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._FormAdministration_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._FormAdministration_Toolbars_Dock_Area_Top);
            this.Controls.Add(this._FormAdministration_Toolbars_Dock_Area_Bottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "FormAdministration";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servent ";
            this.Load += new System.EventHandler(this.FormAdministration_Load);
            this.Form1_Fill_Panel.ResumeLayout(false);
            this.Form1_Fill_Panel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbServent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraDataSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarsManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager toolbarsManager;
        private System.Windows.Forms.Panel Form1_Fill_Panel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FormAdministration_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FormAdministration_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FormAdministration_Toolbars_Dock_Area_Top;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _FormAdministration_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinGrid.UltraGrid ultraGrid;
        private Infragistics.Win.UltraWinDataSource.UltraDataSource ultraDataSource3;
        private System.Data.DataSet tbServent;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn cID;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private System.Data.DataColumn dataColumn21;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblValue;
    }
}

