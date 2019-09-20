using System;
using Project2.Models;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form2 : System.Windows.Forms.Form
        
    {
        public Student Student { get; set; }
        public Form2()
        {
            InitializeComponent();
    }

    private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string matricNo = txtMatricNo.Text;

            this.Student = new Student();
            Student.Name = name;
            Student.matricNo = matricNo;
            this.Close();
        }
    }
}
