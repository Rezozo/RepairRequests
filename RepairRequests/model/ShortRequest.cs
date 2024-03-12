using System;

namespace RepairRequests.model
{
    public class ShortRequest
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; } 
        public string Equipment { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public int SenderId { get; set; }

        public ShortRequest() { }
    }
}
