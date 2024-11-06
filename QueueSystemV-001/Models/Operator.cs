using QueueSystemV_001.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystemV_001.Models
{
    public class Operator
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public OperationType operationType { get; set; }
        public Operator()
        {
            this.ID = Halper.get_id();
        }
        public Operator(string name, string surname, OperationType operationType)
        {
           this.ID = Halper.get_id();
            this.Name = name;
            this.Surname = surname;
            this.operationType = operationType;
        }
    }
}
