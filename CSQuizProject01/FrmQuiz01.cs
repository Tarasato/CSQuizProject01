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
    public partial class FrmQuiz01 : Form
    {
        public FrmQuiz01()
        {
            InitializeComponent();
        }

        private void FrmQuiz01_Load(object sender, EventArgs e)
        {
            rbMember.Checked = true;
            cbbService.SelectedIndex = 0;
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ต้องการจบโปรแกรมหรือไม่", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(result == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            tbTime.Text = "";
            mtbIDCard.Text = "";
            tbName.Text = "";
            rbMember.Checked = true;
            cbbService.SelectedIndex = 0;
            lbTotal.Text = "0.00";
            lbDate.Text = "-";
            lbTime.Text = "-";
            lbIDCard.Text = "-";
            lbName.Text = "-";
            lbTime.Text = "-";
            lbService.Text = "-";
            lbMember.Text = "-";
            mtbIDCard.Focus();
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            // ตรวจสอบข้อผิดพลาดก่อน
            if (!cbConfirm.Checked)
            {
                MessageBox.Show("กรุณายืนยันการชำระเงิน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string rawID = mtbIDCard.Text.Replace("-", "").Trim();
            if (rawID.Length == 0)
            {
                MessageBox.Show("กรุณากรอกเลขบัตรประชาชน", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbIDCard.Focus();
                return;
            }
            if (rawID.Length < 13)
            {
                MessageBox.Show("กรุณากรอกเลขบัตรประชาชนให้ครบ 13 หลัก", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtbIDCard.Focus();
                return;
            }

            if (tbName.Text.Trim().Length == 0)
            {
                MessageBox.Show("กรุณากรอกชื่อ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbName.Focus();
                return;
            }

            if (tbTime.Text.Trim().Length == 0)
            {
                MessageBox.Show("กรุณากรอกระยะเวลาใช้บริการ", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTime.Focus();
                return;
            }

            // ถ้าทุกอย่างถูกต้องแล้ว ให้ตั้งค่า
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            lbDate.Text = DateTime.Now.ToString("dd/MMMM/yyyy", cultureInfo);

            lbIDCard.Text = mtbIDCard.Text.Trim();
            lbName.Text = tbName.Text.Trim();
            lbTime.Text = tbTime.Text.Trim();
            lbService.Text = cbbService.Text;

            // ตรวจสอบประเภทสมาชิก
            lbMember.Text = rbMember.Checked ? "สมาชิก ลด 10%" :
                          rbStudent.Checked ? "นักเรียน/นักศึกษา ลด 5%" :
                          "บุคคลทั่วไป ไม่มีส่วนลด";

            // คำนวณราคา

            // กำหนดอัตราค่าบริการตามประเภทที่เลือก
            double rate = 0;
            switch (cbbService.SelectedIndex)
            {
                case 0: rate = 20.50; break;
                case 1: rate = 10.50; break;
                case 2: rate = 15.50; break;
                case 3: rate = 25.50; break;
            }

            // คำนวณค่าบริการรวม
            double total = rate * double.Parse(tbTime.Text.Trim());

            // คำนวณส่วนลด
            double discount = rbMember.Checked ? 0.10 :
                              rbStudent.Checked ? 0.05 :
                              0.00;

            total -= total * discount;

            lbTotal.Text = total.ToString("N2");
        }

        private void mtbIDCard_Click(object sender, EventArgs e)
        {
            string rawID = mtbIDCard.Text.Replace("-", "").Trim();
            if (rawID.Length == 0)
            {
                mtbIDCard.SelectionStart = 0;
            }
        }

        private void tbTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalData.keyNumberAndDotOnly(sender, e);
        }
    }
}
