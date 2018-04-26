using System;
using System.Windows.Forms;

namespace WinDot
{
    public partial class _MainForm : Form
    {
        public _MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = System.IO.File.ReadAllText("Network.gv");
            GraphResult g = GraphProvider.Generate(txt,"dot","jpg");
            
            if (g != null)
            {
                g.Dispose();
            }

        }
    }
}
