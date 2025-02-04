using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSQuizProject01
{
    public partial class FrmQuiz02 : Form
    {
        public FrmQuiz02()
        {
            InitializeComponent();
        }

        private void FrmQuiz02_Load(object sender, EventArgs e)
        {
            btCancel_Click(sender, e);
        }

        private void mtbIDCard_Click(object sender, EventArgs e)
        {
            string rawID = mtbIDCard.Text.Replace("-", "").Trim();
            if (rawID.Length == 0)
            {
                mtbIDCard.SelectionStart = 0;
            }
        }

        private void tbCalling_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalData.keyNumberAndDotOnly(sender, e);
        }

        private void cbCalling_Click(object sender, EventArgs e)
        {
            if (cbCalling.Checked == true)
            {
                tbCalling.Enabled = true;
            }
            else if (cbCalling.Checked == false)
            {
                tbCalling.Enabled = false;
                tbCalling.Text = "";
            }
        }

        private void cbInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInternet.Checked == true)
            {
                tbInternet.Enabled = true;
            }
            else if (cbInternet.Checked == false)
            {
                tbInternet.Enabled = false;
                tbInternet.Text = "";
            }
        }

        private void cbWater_Click(object sender, EventArgs e)
        {
            if (cbWater.Checked == true)
            {
                tbWater.Enabled = true;
            }
            else if (cbWater.Checked == false)
            {
                tbWater.Enabled = false;
                tbWater.Text = "";
            }
        }

        private void cbPower_Click(object sender, EventArgs e)
        {
            if (cbPower.Checked == true)
            {
                tbPower.Enabled = true;
            }
            else if (cbPower.Checked == false)
            {
                tbPower.Enabled = false;
                tbPower.Text = "";
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            mtbIDCard.Text = "";
            tbName.Text = "";
            tbLastName.Text = "";
            rbMr.Checked = true;
            dtPicker.Value = DateTime.Now;
            cbbRoomType.SelectedIndex = 0;
            cbCalling.Checked = false;
            tbCalling.Text = "";
            tbCalling.Enabled = false;
            cbInternet.Checked = false;
            tbInternet.Text = "";
            tbInternet.Enabled = false;
            cbWater.Checked = false;
            tbWater.Text = "";
            tbWater.Enabled = false;
            cbPower.Checked = false;
            tbPower.Text = "";
            tbPower.Enabled = false;

            lbDate.Text = "-";
            lbIDCard.Text = "-";
            lbFullName.Text = "-";

            lbCalling.Text = "0";
            lbInternet.Text = "0";
            lbWater.Text = "0";
            lbPower.Text = "0";

            lbTotalCalling.Text = "0.00";
            lbTotalInternet.Text = "0.00";
            lbTotalWater.Text = "0.00";
            lbTotalPower.Text = "0.00";
            lbTotal.Text = "0.00";
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            string rawID = mtbIDCard.Text.Replace("-", "").Trim();
            if (rawID.Length != 13)
            {
                GlobalData.showWarningMSG("กรุณากรอกเลขบัตรประชาชนให้ครบ");
            }
            else if (tbName.Text.Length == 0)
            {
                GlobalData.showWarningMSG("กรุณากรอกชื่อ");
            }else if(tbLastName.Text.Length == 0)
            {
                GlobalData.showWarningMSG("กรุณากรอกนามสกุล");
            }
            else
            {
                CultureInfo cultureInfo = new CultureInfo("th-TH");
                lbDate.Text = dtPicker.Value.ToString("dd/MMMM/yyyy", cultureInfo);
                lbIDCard.Text = mtbIDCard.Text;
                if(rbMr.Checked == true)
                {
                    lbFullName.Text = "นาย " + tbName.Text + " " + tbLastName.Text;
                }
                else if (rbMrs.Checked == true)
                {
                    lbFullName.Text = "นาง " + tbName.Text + " " + tbLastName.Text;
                }
                else if (rbMiss.Checked == true)
                {
                    lbFullName.Text = "นางสาว " + tbName.Text + " " + tbLastName.Text;
                }
                double totalCalling = 0;
                double totalInternet = 0;
                double totalWater = 0;
                double totalPower = 0;
                if (cbCalling.Checked == true)
                {
                    totalCalling = double.Parse(tbCalling.Text.Trim()) * 1.5;
                    lbCalling.Text = tbCalling.Text;
                    lbTotalCalling.Text = totalCalling.ToString("0.00");
                }
                if (cbInternet.Checked == true)
                {
                    totalInternet = double.Parse(tbInternet.Text.Trim()) * 0.5;
                    lbInternet.Text = tbInternet.Text;
                    lbTotalInternet.Text = totalInternet.ToString("0.00");
                }
                if (cbWater.Checked == true)
                {
                    totalWater = double.Parse(tbWater.Text.Trim()) * 12.5;
                    lbWater.Text = tbWater.Text;
                    lbTotalWater.Text = totalWater.ToString("0.00");
                }
                if (cbPower.Checked == true)
                {
                    totalPower = double.Parse(tbPower.Text.Trim()) * 15.75;
                    lbPower.Text = tbPower.Text;
                    lbTotalPower.Text = totalPower.ToString("0.00");
                }
                double total = totalCalling + totalInternet + totalWater + totalPower;
                lbTotal.Text = total.ToString("0.00");
            }
        }
    }
}
