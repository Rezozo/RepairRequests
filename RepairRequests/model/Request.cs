using System;
using System.Collections.Generic;

namespace RepairRequests.model
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Equipment { get; set; }
        public string TypeOfRepair { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Priority { get; set; }
        public User Sender { get; set; }
        public User Executor { get; set; }
        public List<User> Helper { get; set; }
        public List<Details> Details { get; set; }
        public List<Comment> Comments { get; set; }

        public Request() { }
    }
}
