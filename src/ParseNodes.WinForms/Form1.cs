using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ParseNodes.WinForms
{
    public partial class Form1 : Form
    {
        private List<ExitNode> _data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            _data = new Serialiser().SerialiseExitNodes(new Parser().GetExitNodes());
            dataGridView1.DataSource = _data;
            
        }

        private void btnJSON_Click(object sender, EventArgs e)
        {
            string serializeObject = Newtonsoft.Json.JsonConvert.SerializeObject(_data);
            try
            {
                File.WriteAllText("ParseNodes.json", serializeObject);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
