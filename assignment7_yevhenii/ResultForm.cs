using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment7_yevhenii
{
    public partial class ResultForm : Form
    {
        public ResultForm(double result)
        {
            InitializeComponent();
            this.progress_result.Value = (int) result;
            this.label_result.Text = result.ToString() + " %";
        }
    }
}
