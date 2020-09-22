using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   
            int i = 0;
            string[] texto = richTextBox1.Text.Split(' ','\n');
            Dictionary<string, int> palabrasDictionary = new Dictionary<string, int>();
            foreach(string palabra in texto)
            {
                if(palabrasDictionary.ContainsKey(palabra))
                {
                    palabrasDictionary[palabra] += 1; 
                }
                else
                {
                    palabrasDictionary.Add(palabra, 1);
                }
            }

            palabrasDictionary.OrderByDescending(d => d.Value);

            if(palabrasDictionary.Count > 2)
            {
                StringBuilder sb = new StringBuilder();
                foreach(var dicc in palabrasDictionary)
                {       
                    sb.AppendLine($"{dicc.Key} : {dicc.Value}");
                    i++;
                    if(i==3)
                    {
                        break;
                    }
                }
                
                MessageBox.Show(sb.ToString());
            }
            
            
            

            
        }
    }
}
