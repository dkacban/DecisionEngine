using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string EmailAdress { get; set; }
        public Gender Sex { get; set; }
        public double Height { get; set; }
        public double Leglenght { get; set; }
    }
    
    public enum Gender
    {
        Male,
        Female
    }
}
