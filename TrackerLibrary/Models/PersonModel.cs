using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellPhoneNo { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string FirstName, string LastName, string EmailAddress, string CellPhoneNo)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.EmailAddress = EmailAddress;
            this.CellPhoneNo = CellPhoneNo;

        }

        public string FullName 
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
