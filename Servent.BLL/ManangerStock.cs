using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Servent.DAL;
using Servent.Domain;

namespace Servent.BLL
{
    public class ManangerStock
    {
        #region Fields

        private readonly ServentContext _serventContext;

        #endregion

        #region Ctrs

        public ManangerStock()
        {
            _serventContext = ServentContextFactory.GetContextInstance();
            _serventContext.Configuration.LazyLoadingEnabled = true;
            _serventContext.Configuration.ProxyCreationEnabled = false;

        }

        #endregion

        #region Properties
        #endregion

        #region Methods

        public void AddMaterialToStock(MaterialsMovement materials)
        {
            if (materials != null)
            {
                if (_serventContext.Stocks.Any(x => x.Material.Name.ToLower() == materials.Material.Name))
                    UpdateMaterial(materials);
                else
                {
                    materials.TotalBalance = ComputeTotalBalance(materials);
                    if (materials.Material.TypeOfUnit.ID != 0)
                        materials.Material.TypeOfUnit =_serventContext.UnitTypes.First(x => x.ID == materials.Material.TypeOfUnit.ID);
                    _serventContext.Stocks.Add(materials);
                    _serventContext.SaveChanges();

                }
            }

        }

        private static double ComputeTotalBalance(MaterialsMovement materials)
        {
            double total = materials.Quantity * materials.Material.Price;
            return total;
        }

        public List<Material> GetAllMaterials()
        {
            var ret = (from mov in _serventContext.Stocks
                       join mat in _serventContext.Materials on mov.ID equals mat.ID
                       select mat).ToList();
            return ret;
        }

        public IEnumerable<MaterialsMovement> GetAllMaterialsMov()
        {
            return _serventContext.Stocks.ToList();
        }

        public MaterialsMovement GetmaterialByID(int id)
        {
            MaterialsMovement mat = (from movement in _serventContext.Stocks
                                     where movement.ID == id
                                     select movement).First();
            return mat;
        }

        public bool UpdateMaterial(MaterialsMovement movement)
        {
            MaterialsMovement first;
            //Update por ID
            if (movement.ID != 0)
                first = _serventContext.Stocks.First(m => m.ID == movement.ID);
            else //Update por Nome
                first = _serventContext.Stocks.First(m => m.Material.Name == movement.Material.Name);
            if (first != null)
            {
                first.Material.Name = movement.Material.Name;
                if (Math.Abs(movement.Material.Price - first.Material.Price) > 0)
                {
                    first.Material.Price = movement.Material.Price;
                    first.TotalBalance = UpdateTotalBalance(movement.Quantity, first.Quantity, movement.Material.Price, first.TotalBalance);
                }
                else
                {
                    first.TotalBalance = ComputeTotalBalance(movement);
                }

                first.Material.Description = movement.Material.Description;
                first.Material.TypeOfUnit = movement.Material.TypeOfUnit;
                first.Quantity = movement.Quantity;
                first.DateOfMovement = movement.DateOfMovement;
                _serventContext.SaveChanges();
            }
            return true;
        }

        private double UpdateTotalBalance(int qtdNova, int qtdAntiga, double priceNew, double totalBalanceOld)
        {
            double newBalance = totalBalanceOld + ((qtdNova - qtdAntiga) * priceNew);
            return newBalance;
        }

        public List<UnitType> GetAllUnitTypes()
        {
            return _serventContext.UnitTypes.ToList();
        }

        public MaterialsMovement GetMaterialMovByID(int id)
        {
            return _serventContext.Stocks.First(x => x.ID == id);
        }

        public void DeleteMaterialMov(MaterialsMovement movement)
        {
            /*Primeiro remove o Material se ele não tiver sendo usado por nenhum outro objeto.*/
            var list = _serventContext.ConstructionHistories.Select(x => x.MaterialsMovements.Material.ID).ToList();

            if (!list.Contains(movement.Material.ID))//se o material estiver sendo usado em uma movimentação não pode ser excluido 
                _serventContext.Materials.Remove(_serventContext.Materials.First(x => x.ID == movement.Material.ID));

            /*Depois excluo a Movimentação de Materiais do estoque.*/
            _serventContext.Stocks.Remove(_serventContext.Stocks.First(x => x.ID == movement.ID));
            _serventContext.SaveChanges();
        }

        public void AddUnitType(UnitType unit)
        {
            _serventContext.UnitTypes.Add(unit);
            _serventContext.SaveChanges();
        }

        public UnitType GetUnitTypeById(int id)
        {
            return _serventContext.UnitTypes.First(x => x.ID == id);
        }

        public void DeleteUnitType(UnitType unitType)
        {
            _serventContext.UnitTypes.Remove(unitType);
            _serventContext.SaveChanges();
        }

        public void UpdateUnit(UnitType unitType)
        {
            UnitType first = _serventContext.UnitTypes.First(u => u.ID == unitType.ID);
            first.Name = unitType.Name;
            first.Description = unitType.Description;
            _serventContext.SaveChanges();
        }

        public bool IsUsedUnit(int id)
        {
            var queryable = _serventContext.Materials.Select(x => x.TypeOfUnit.ID).ToList();
            Util.TraceHelper.WriteInEventVwr(queryable.Count.ToString(CultureInfo.InvariantCulture), System.Diagnostics.EventLogEntryType.Information);
            return queryable.Contains(id);
        }

        public bool LowStock(MaterialsMovement mm, int id)
        {
            var materialsMovement = _serventContext.Stocks.First(x => x.ID == id);
            materialsMovement.Quantity -= mm.Quantity;
            materialsMovement.TotalBalance = ComputeTotalBalance(materialsMovement);
            _serventContext.SaveChanges();
            return true;
        }

        public void LowMaterialFromStock(MaterialsMovement movement, int qtd)
        {
            MaterialsMovement material = _serventContext.Stocks.First(x => x.ID == movement.ID);
            material.Quantity -= qtd;
            material.TotalBalance = ComputeTotalBalance(material);
            _serventContext.SaveChanges();
        }

        public double GetTotalValueInStock()
        {
            double value = Enumerable.Sum(_serventContext.Stocks, material => material.Quantity*material.Material.Price);
            return value;
        }
        #endregion

    }
}
