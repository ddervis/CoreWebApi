using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApi.Models.Entity
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IsComplete { get; set; }
    }
}
