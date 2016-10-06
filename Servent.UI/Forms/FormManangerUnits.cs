using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win;
using Servent.BLL;
using Servent.Domain;

namespace Servent.UI.Forms
{
    public partial class FormManangerUnits : Form
    {
        private readonly ManangerStock _manangerStock = new ManangerStock();
        
        public FormManangerUnits()
        {
            InitializeComponent();
            LoadDataGridUnits();

        }

        private void LoadDataGridUnits()
        {
            tbUnit.Tables[0].Clear();
            //Aqui eu pego todas os tipos de unidade de todas as movimentações de materials, que estão em estoque. Unidades que estão presentes em movimentações de obras, 
            //não seram apresentados aqui.
            //List<UnitType> allUnitTypes = _manangerStock.GetAllMaterialsMov().Where(material => !material.IsFromStock).Select(material => material.Material.TypeOfUnit).Distinct().ToList();
            List<UnitType> allUnitTypes = _manangerStock.GetAllUnitTypes();
            foreach (var allUnitType in allUnitTypes)
            {
                tbUnit.Tables[0].Rows.Add(allUnitType.ID, allUnitType.Name, (allUnitType.Description != string.Empty ? allUnitType.Description : "                              -  "));
            }
            ultraGridUnitsType.DataSource = tbUnit.Tables[0];
            ultraGridUnitsType.DisplayLayout.Bands[0].Columns[1].Width = 200;
            ultraGridUnitsType.DisplayLayout.Bands[0].Columns[2].Width = 222;
            ultraGridUnitsType.DisplayLayout.Override.AllowUpdate = DefaultableBoolean.False;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormAddUnitType f = new FormAddUnitType();
            var dialog = f.ShowDialog();

            if (dialog != DialogResult.OK) return;

            var unit = f.UnitType;
            _manangerStock.AddUnitType(unit);
            LoadDataGridUnits();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ultraGridUnitsType.Selected.Rows.Count == 0 || ultraGridUnitsType.Selected.Rows[0].IsGroupByRow)
                return;

            int id = 0;
            try
            {
                string s = (((DataRowView)ultraGridUnitsType.ActiveRow.ListObject).Row.ItemArray[0]).ToString();
                id = int.Parse(s);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            UnitType unitType = _manangerStock.GetUnitTypeById(id);
            FormAddUnitType form = new FormAddUnitType(unitType);
            switch (form.ShowDialog())
            {
                case DialogResult.OK:
                    try
                    {
                        _manangerStock.UpdateUnit(form.UnitType);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao atualizar o tipo de unidade " + unitType.Name + ". Descrição do erro: " + ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    LoadDataGridUnits();
                    break;
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (ultraGridUnitsType.Selected.Rows.Count == 0 || ultraGridUnitsType.Selected.Rows[0].IsGroupByRow)
                return;
            int id = 0;
                    
            try
            {
                id = int.Parse((((DataRowView)ultraGridUnitsType.ActiveRow.ListObject).Row.ItemArray[0]).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, Text, MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (_manangerStock.IsUsedUnit(id))
            {
                MessageBox.Show("O tipo de unidade está em uso. Impossível excluí-lo no momento.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            UnitType unitType = _manangerStock.GetUnitTypeById(id);
            var dialog = MessageBox.Show("Deseja realmente deletar a unidade de medida: " + unitType.Name + " ?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog != DialogResult.Yes) return;
            _manangerStock.DeleteUnitType(unitType);
            LoadDataGridUnits();
            
            
        }
    }
}
