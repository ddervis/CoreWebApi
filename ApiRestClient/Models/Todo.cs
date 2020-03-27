using System;
using System.Collections.Generic;
using System.Text;

namespace ApiRestClient.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsComplete { get; set; }
    }
}
