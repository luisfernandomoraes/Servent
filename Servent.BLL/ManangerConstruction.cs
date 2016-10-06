using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Servent.DAL;
using Servent.Domain;
using Servent.Util.Properties;


namespace Servent.BLL
{
    public class ManangerConstruction
    {
        #region Fields

        private ServentContext _serventContext;

        #endregion

        #region Ctrs

        public ManangerConstruction()
        {
            _serventContext = ServentContextFactory.GetContextInstance();
        }

        #endregion

        #region Properties
        #endregion

        public void AddConstructions(Construction construction)
        {
            //validações ....
            _serventContext.Construction.Add(construction);
            _serventContext.SaveChanges();
        }


        [NotNull]
        public IEnumerable<Construction> GetAllConstructions()
        {
            _serventContext.Construction.Include(x => x.Address);
            return _serventContext.Construction.ToList();
        }

        public bool AddNewHistoricalMovement(ConstructionHistory constructionHistory, int idConstr)
        {
            if (constructionHistory.Provider != null)
            {
                
                var construction = _serventContext.Construction.First(x => x.ID == idConstr);
                 construction.ConstructionHistory.Add(constructionHistory);
                _serventContext.SaveChanges();    
            }
            else
            {
                var construction = _serventContext.Construction.First(x => x.ID == idConstr);
                construction.ConstructionHistory.Add(constructionHistory);
                _serventContext.SaveChanges();
            }
            return true;
        }

       // ReSharper disable once UnusedMember.Local
        private UnitType GetUnityByID(int id)
        {
            return  _serventContext.UnitTypes.First(u => u.ID == id);
        }

        public void UpdateConstruction(Construction construction)
        {
            Construction ct = _serventContext.Construction.First(c => c.ID == construction.ID);
            ct.Address = construction.Address;
            ct.ConstructionDate = construction.ConstructionDate;
            ct.Description = construction.Description;
            ct.IsAlive = construction.IsAlive;
            ct.Name = construction.Name;
            ct.Responsible = construction.Responsible;
            ct.ResponsiblePhone = construction.ResponsiblePhone;
            _serventContext.SaveChanges();
        }
        public Construction GetConstructionByID(int id)
        {
            return _serventContext.Construction.First(x => x.ID == id);
        }


        public void Delete(Construction construction)
        {
            _serventContext.Construction.Remove(construction);
            _serventContext.SaveChanges();
        }

        public string GetConstructionById(int id)
        {
            var c = _serventContext.Construction.First(x => x.ID == id);
                return c.Name;
        }
    }
}
