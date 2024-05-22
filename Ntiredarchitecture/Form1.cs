using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace Ntiredarchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPerson.LLPersobList();
            dataGridView1.DataSource = PerList; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent=new EntityPersonel();
            ent.Name=txtName.Text;
            ent.Surname=txtSurname.Text;
            ent.Salary=short.Parse(txtSalary.Text);
            ent.Job=txtJob.Text;
            ent.City=txtCity.Text;
            LogicPerson.LLAddPerson(ent);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EntityPersonel ent=new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicPerson.LLRemovePerson(ent.Id);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Name=txtName.Text;
            ent.Surname= txtSurname.Text;
            ent.City = txtCity.Text;
            ent.Job = txtJob.Text;
            ent.Salary=short.Parse(txtSalary.Text);
            LogicPerson.LLPersonUpdate(ent);
        }
    }
}
