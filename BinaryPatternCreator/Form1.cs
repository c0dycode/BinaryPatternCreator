using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryPatternCreator
{
    public partial class Form1 : Form
    {
        public string[] pattern1 { get; set; }
        public string[] pattern2 { get; set; }
        public string[] finalpattern { get; set; }

        public Form1()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxInput1.Text.Length >= 2 && textBoxInput2.Text.Length >= 2)
                {
                    string _stringpattern1 = textBoxInput1.Text;
                    string[] _pattern1 = _stringpattern1.Split(null);

                    string _stringpattern2 = textBoxInput2.Text;
                    string[] _pattern2 = _stringpattern2.Split(null);

                    List<string> _finalpattern = new List<string>();

                    for (int i = 0; i < _pattern1.Length; i++)
                    {
                        if (_pattern1[i] == _pattern2[i])
                        {

                            _finalpattern.Add(_pattern1[i]);
                        }
                        else
                            _finalpattern.Add("??");
                    }

                    string[] resulttext = _finalpattern.ToArray();
                    textBoxResult.Text = string.Join(" ", resulttext);
                }
            }

            catch (Exception excep)
            {
                MessageBox.Show("Looks like the input was not correct. Check it again:\n{0}", excep.Message);
            }
        }
    }
}
