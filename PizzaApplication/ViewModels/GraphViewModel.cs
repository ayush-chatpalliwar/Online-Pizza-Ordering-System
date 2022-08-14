using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace PizzaApplication.ViewModels
{
    [DataContract]
    public class GraphViewModel
    {
        public GraphViewModel(string y, int total)
        {

            this.Date = y;
            this.Total = total;

        }

        [DataMember(Name = "label")]
        public string Date { get; set; }
        [DataMember(Name = "y")]
        public int Total { get; set; }
    }
}
