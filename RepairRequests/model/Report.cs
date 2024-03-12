using System;

namespace RepairRequests.model
{
    public class Report
    {
        public int Id { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public string Description { get; set; }
        public Request request { get; set; }
        public Report() { }
    }
}
