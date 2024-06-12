using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Name = textBox1.Text;
            string Class = textBox2.Text;
            int RNumber = Convert.ToInt32(textBox3.Text);
            int Marks = Convert.ToInt32(textBox4.Text);

            dataGridView1.Rows.Add(Name, Class, RNumber, Marks  );

            //TODO: Get all Inputs from User and put it in StudentClass
            //TODO: Use StudentClass to popoulate dataGridView
            //Example: dataGridView1.Rows.Add(StudentClass Instance)
            //TODO: Remove, Update Student
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();  
            textBox4.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("Column1", "Name");
            dataGridView1.Columns.Add("Column2", "Class");
            dataGridView1.Columns.Add("Column3", "Roll Number");
            dataGridView1.Columns.Add("Column4", "Marks");

            // Add rows with sample data
            dataGridView1.Rows.Add("Name", "Class", "Roll Number", "Marks");
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RemoveStudent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateStudent();
        }
    }
}/
