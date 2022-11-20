using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArashZomorrodi_01._08._29
{
    public partial class Home : Form
    {
        static int number;
        public Home()
        {
            InitializeComponent();
        }
         void RefMet(int var)
        {
            number = Convert.ToInt32(RefTxt2nd.Text);
            var += number; 
            
        }

        void Met(ref int var)
        {
            number = Convert.ToInt32(RefTxt2nd.Text);
            var += number;

        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (InputTxt.Text!="")
            {
                string Result = InputTxt.Text.Replace(" ", "");
                if (Result!=InputTxt.Text)
                {
                    DialogResult res = new DialogResult();
                    res = MessageBox.Show("\"" + Result + "\" :شکل نهایی رشته\n آیا می‌خواهید که متن نهایی روی متن وارد شده اعمال شود؟", "شکل نهاییِ رشته", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (res)
                    {
                        case DialogResult.Yes:
                            {
                                InputTxt.Text = Result;
                                MessageBox.Show("تغییرات اعمال شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        case DialogResult.No:
                            {
                                InputTxt.Focus();
                            }
                            break;
                        default:
                            break;
                    }
                }
                else if (Result==InputTxt.Text)
                {

                    MessageBox.Show("!مقدار ورودی شما فاقد فاصله است", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("لطفاً بعداً دوباره تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if(InputTxt.Text == "")
            {
                MessageBox.Show("!ورودی نباید خالی باشد", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputTxt.Focus();
            }
            else
            {
                MessageBox.Show("لطفاً بعداً دوباره تلاش کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void MetRefStartBtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(RefTxt.Text);
            
            RefMet(num);
            ResMetRef.Text = "Result: " + num + "";
        }

        private void MetStartBtn_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(Txt.Text);

            Met(ref num);
            ResMet.Text = "Result: " + num + "";


        }

        
    }
}
