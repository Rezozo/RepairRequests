using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairRequests.model
{
    public class Statistic
    {
        public string Title { get; set; }
        public long Count { get; set; }
        public Statistic() { }
        public Statistic(string title, long count)
        {
            Title = title;
            Count = count;
        }
    }
}
