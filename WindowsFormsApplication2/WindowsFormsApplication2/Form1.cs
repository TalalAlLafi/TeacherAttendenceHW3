using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void attendaseBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.attendaseBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dataSet1.teacher);
            // TODO: This line of code loads data into the 'dataSet1.room' table. You can move, or remove it, as needed.
            this.roomTableAdapter.Fill(this.dataSet1.room);
            // TODO: This line of code loads data into the 'dataSet1.course' table. You can move, or remove it, as needed.
            this.courseTableAdapter.Fill(this.dataSet1.course);
            // TODO: This line of code loads data into the 'dataSet1.attendase' table. You can move, or remove it, as needed.
            this.attendaseTableAdapter.Fill(this.dataSet1.attendase);

        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
