using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servent.Domain
{
    public class Address
    {
        #region Fields

        private int _id;
        private string _street;
        private string _neighborhood;
        private int _number;
        private string _details;

        #endregion

        #region Ctrs

        public Address(string street, string neighborhood, int number, string details)
        {
            
            Street = street;
            Neighborhood = neighborhood;
            Number = number;
            Details = details;
        }

        public Address()
        {
            Street = string.Empty;
            Neighborhood = string.Empty;
            Number = 0;
            Details = string.Empty;
        }

        #endregion

        #region Properties
        [Key]
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        [MaxLength(150)]
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        [MaxLength(50)]
        public string Neighborhood
        {
            get { return _neighborhood; }
            set { _neighborhood = value; }
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }
        [MaxLength(250)]
        public string Details
        {
            get { return _details; }
            set { _details = value; }
        }

        #endregion

        public override string ToString()
        {
            return string.Format("Rua: {0} Bairro: {1}", _street, _neighborhood);
        }
    }
}
