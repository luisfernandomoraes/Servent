using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servent.Domain
{
    public  class Construction
    {
        #region Fields

        private int _id;
        private string _responsible;
        private string _responsiblePhone;
        private List<ConstructionHistory> _constructionHistory;
        private string _name;
        private string _description;
        private bool _isAlive;
        private DateTime _constructionDate;

        public virtual Address Address { get; set; }
        #endregion

        #region Ctrs

        public Construction(string responsible, int id, string name, string description, List<ConstructionHistory> constructionHistory, bool isAlive, Address address, string responsiblePhone)
        {
            Responsible = responsible;
            ID = id;
            Name = name;
            Description = description;
            ConstructionHistory = constructionHistory;
            IsAlive = isAlive;
            Address = address;
            ResponsiblePhone = responsiblePhone;
        }

        public Construction()
        {
            ResponsiblePhone = string.Empty;
            Address = new Address();
            Responsible = string.Empty;
            ID = 0;
            Name = string.Empty;
            Description = string.Empty;
            ConstructionHistory = new List<ConstructionHistory>();
            IsAlive = true;

        }

        #endregion

        #region Properties
        [MaxLength(150)]
        public string Responsible
        {
            get { return _responsible; }
            set { _responsible = value; }
        }
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [MaxLength(250)]
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public List<ConstructionHistory> ConstructionHistory
        {
            get { return _constructionHistory; }
            set { _constructionHistory = value; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }   
        }
      /*  public  Address Addresse
        {
            get { return _address; }
            set { _address = value; }
        }*/
        [MaxLength(250)]
        public string ResponsiblePhone
        {
            get { return _responsiblePhone; }
            set { _responsiblePhone = value; }
        }

        public DateTime ConstructionDate
        {
            get { return _constructionDate; }
            set { _constructionDate = value; }
        }


        
        #endregion
        
        #region Methods

        public double GetTotalBalance()
        {
            double totalBalance = 0;
            foreach (var history in ConstructionHistory)
            {
                totalBalance += history.MaterialsMovements.TotalBalance;
            }
            
            return totalBalance;
        }

        #endregion
      
    }
}
