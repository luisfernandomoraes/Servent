using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Servent.Domain
{
    public class Provider
    {
        private int _id;
        private string _name;
        private string _phoneNumber;

        public Provider(int id, string name,string cnpj, string phoneNumber)
        {
            ID = id;
            Name = name;
           PhoneNumber = phoneNumber;
        }

        public Provider()
        {
            ID = 0;
            Name = string.Empty;
            PhoneNumber = string.Empty;            
        }
        
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        [Column(TypeName = "varchar")]
        [MaxLength(35)]
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public override string ToString()
        {
            return Name + " " + PhoneNumber;
        }
    }
}
