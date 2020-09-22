using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssessment1
{
    public partial class MainForm : Form
    {
        LogicClass Logic = new LogicClass();

        public MainForm()
        {
            InitializeComponent();
        }

        private void ShootHeadButton_Click(object sender, EventArgs e)
        {
            Logic.ShootAtHead();
        }

        private void ShootAwayButton_Click(object sender, EventArgs e)
        {
            Logic.ShootAway();
        }
    }
}
