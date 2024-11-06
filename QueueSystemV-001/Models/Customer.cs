using QueueSystemV_001.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueSystemV_001.Models
{
    public class Customer
    {
        public int ID { get; private set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public Series series { get; set; }
        public string Number { get; set; }
        public string FIN { get; set; }
        public OperationType operationType { get; set; }
        public Customer()
        {
            this.ID = Halper.get_id();
        }
        public Customer(string name,string surname,string patronymic,Series series,string number,string fin,OperationType operationType)
        {
            this.ID = Halper.get_id();
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.series = series;
            this.Number = number;
            this.FIN = fin;
            this.operationType = operationType;

        }

    }
}
