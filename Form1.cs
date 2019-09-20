using Project2.Models;
using System;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
            Student student = form2.Student;
            if (student != null)
            {
                dataGridView.Rows.Add(student.matricNo, student.Name);
            }
        }
    }
}
