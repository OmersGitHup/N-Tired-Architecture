using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    internal class EntityDepartment
    {
        private int id;
        private string name;
        private string statement;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Statement { get => statement; set => statement = value; }
    }
}
