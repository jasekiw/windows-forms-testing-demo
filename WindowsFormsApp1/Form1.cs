using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private IDataService _dataService;
        public SomeData _loadedData;
        public Form1(IDataService dataService)
        {
            _dataService = dataService;
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void LoadData()
        {
            _loadedData = _dataService.GetSomeData().Result;
        }
    }
}
