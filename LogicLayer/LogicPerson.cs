using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPerson
    {
        public static List<EntityPersonel> LLPersobList()
        {
            return DALPerson.PersonList();

        }
        public static int LLAddPerson(EntityPersonel p)
        {
            if (p.Name!="" && p.Surname!=""&& p.Salary>=3500 && p.Name.Length>=3)
            {
                return DALPerson.AddPerson(p);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLRemovePerson(int per)
        {
            if (per>=1)
            {
                return DALPerson.DeletePerson(per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonUpdate(EntityPersonel p)
        {
            if (p.Name.Length>=3 && p.Name!="" && p.Salary>=4500)
            {
                return DALPerson.UpdatePerson(p);
            }
            else
            {
                return false;
            }
        }
    }
}
