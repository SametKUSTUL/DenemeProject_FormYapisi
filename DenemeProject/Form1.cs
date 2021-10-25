
using DataAccess;
using Form_DataStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenemeProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void ShowForm1Data()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Comport_Presenter.getInstance();
            this.tbx_Date.Text = DataModel.getInstance().Date;
            this.tbx_Time.Text = DataModel.getInstance().Time;
            this.tbx_SerialNumber.Text = DataModel.getInstance().SerialNumber;
        }
    }
}
