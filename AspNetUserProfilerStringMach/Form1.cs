using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspNetUserProfilerStringMach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            string[] names = txtPropertyNames.Text.Split(':');
            int len = names.Length;
            string propertyValues = txtPropertyValuesString.Text;
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < len; i+=4)
            {
                if (i + 4 < len)
                {
                    build.Append(Environment.NewLine);
                    build.Append(names[i]);
                    build.Append(" = ");
                    build.Append(propertyValues.Substring(int.Parse(names[i + 2]), int.Parse(names[i + 3])));
                }

            }
            txtResult.Text = build.ToString();
        }
    }
}
