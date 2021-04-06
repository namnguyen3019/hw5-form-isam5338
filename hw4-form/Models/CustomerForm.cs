using System;
namespace hw4_form.Models
{
    public class CustomerForm
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string StreetAddress { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public Boolean FreeSample { get; set; }
       
    }
}
