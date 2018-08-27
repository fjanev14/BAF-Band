using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BafBand.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Cardnumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Place { get; set; }
        public string Rating { get; set; }
        public string Date { get; set; }
    }
}