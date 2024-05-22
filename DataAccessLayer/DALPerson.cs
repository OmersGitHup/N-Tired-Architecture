using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace DataAccessLayer
{
    public class DALPerson
    {
        public static List<EntityPersonel> PersonList()
        {
            List<EntityPersonel> degerler=new List<EntityPersonel>();
            SqlCommand command1 = new SqlCommand("Select * from Tbl_PersonInfo",Connectionit.conn);
            if (command1.Connection.State!=ConnectionState.Open)
            {
                command1.Connection.Open();
            }
            SqlDataReader dr= command1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent= new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Name = dr["Name"].ToString();
                ent.Surname = dr["Surname"].ToString();
                ent.City = dr["City"].ToString() ;
                ent.Job = dr["Job"].ToString();
                ent.Salary = short.Parse(dr["Salary"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }

        public static int AddPerson(EntityPersonel p)
        {
            SqlCommand command2 = new SqlCommand("Insert into Tbl_PersonInfo (Name,Surname,Job,City,Salary) Values (@p1,@p2,@p3,@p4,@p5)", Connectionit.conn);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }
            command2.Parameters.AddWithValue("@p1", p.Name);
            command2.Parameters.AddWithValue("@p2", p.Surname);
            command2.Parameters.AddWithValue("@p3", p.Job);
            command2.Parameters.AddWithValue("@p4", p.City);
            command2.Parameters.AddWithValue("@p5", p.Salary);
            return command2.ExecuteNonQuery();
        }

        public static bool DeletePerson(int p)
        {
            SqlCommand command3 = new SqlCommand("Delete from Tbl_PersonInfo WHERE ID=@P1", Connectionit.conn);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1", p);
            return command3.ExecuteNonQuery()>0;
        }

        public static bool UpdatePerson(EntityPersonel ent)
        {
            SqlCommand command4 = new SqlCommand("Update Tbl_PersonInfo Set Name=@p1,Surname=@p2,Job=@p3,City=@p4,Salary=@p5 where ID=@p6", Connectionit.conn);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("@p1", ent.Name);
            command4.Parameters.AddWithValue("@p2", ent.Surname);
            command4.Parameters.AddWithValue("@p3", ent.Job);
            command4.Parameters.AddWithValue("@p4", ent.City);
            command4.Parameters.AddWithValue("@p5", ent.Salary);
            command4.Parameters.AddWithValue("@p6", ent.Id);
            return command4.ExecuteNonQuery() > 0;
        }

    }
}
