using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionEngine.Domain
{
    public class BikeDecision
    {
        public DateTime CreatedDate { get; set; }
        public Customer Customer { get; set; }

        public Decision Decision { get; set; }

        public BikeDecision(Customer customer)
        {
            Customer = customer;
        }

        public Decision GetDecision()
        {
            return Decision;                                                                               
        }
    }
}
