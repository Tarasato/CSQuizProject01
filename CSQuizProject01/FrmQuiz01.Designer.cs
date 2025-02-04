namespace CSQuizProject01
{
    partial class FrmQuiz01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuiz01));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbIDCard = new System.Windows.Forms.MaskedTextBox();
            this.rbGeneralPublic = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbMember = new System.Windows.Forms.RadioButton();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mcPicked = new System.Windows.Forms.MonthCalendar();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbService = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btNew = new System.Windows.Forms.Button();
            this.cbConfirm = new System.Windows.Forms.CheckBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbService = new System.Windows.Forms.Label();
            this.lbMember = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIDCard = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "โปรแกรม Internet Cafe";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbIDCard);
            this.groupBox1.Controls.Add(this.rbGeneralPublic);
            this.groupBox1.Controls.Add(this.rbStudent);
            this.groupBox1.Controls.Add(this.rbMember);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mcPicked);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 70);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(551, 252);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลผู้ใช้บริการ";
            // 
            // mtbIDCard
            // 
            this.mtbIDCard.Location = new System.Drawing.Point(407, 33);
            this.mtbIDCard.Mask = "#-####-#####-##-#";
            this.mtbIDCard.Name = "mtbIDCard";
            this.mtbIDCard.Size = new System.Drawing.Size(139, 23);
            this.mtbIDCard.TabIndex = 5;
            this.mtbIDCard.Click += new System.EventHandler(this.mtbIDCard_Click);
            // 
            // rbGeneralPublic
            // 
            this.rbGeneralPublic.AutoSize = true;
            this.rbGeneralPublic.Location = new System.Drawing.Point(273, 205);
            this.rbGeneralPublic.Margin = new System.Windows.Forms.Padding(2);
            this.rbGeneralPublic.Name = "rbGeneralPublic";
            this.rbGeneralPublic.Size = new System.Drawing.Size(152, 21);
            this.rbGeneralPublic.TabIndex = 4;
            this.rbGeneralPublic.TabStop = true;
            this.rbGeneralPublic.Text = "บุคคลทั่วไป ไม่มีส่วนลด";
            this.rbGeneralPublic.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(273, 169);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(165, 21);
            this.rbStudent.TabIndex = 4;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "นักเรียน/นักศึกษา ลด 5%";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbMember
            // 
            this.rbMember.AutoSize = true;
            this.rbMember.Location = new System.Drawing.Point(273, 134);
            this.rbMember.Margin = new System.Windows.Forms.Padding(2);
            this.rbMember.Name = "rbMember";
            this.rbMember.Size = new System.Drawing.Size(114, 21);
            this.rbMember.TabIndex = 4;
            this.rbMember.TabStop = true;
            this.rbMember.Text = "สมาชิก ลด 10%";
            this.rbMember.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(321, 66);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(225, 23);
            this.tbName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(270, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ชื่อ-สกุล";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "รหัสประจำตัวประชาชน";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "วันที่ใช้บริการ";
            // 
            // mcPicked
            // 
            this.mcPicked.Location = new System.Drawing.Point(37, 62);
            this.mcPicked.Margin = new System.Windows.Forms.Padding(7);
            this.mcPicked.Name = "mcPicked";
            this.mcPicked.TabIndex = 0;
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(154, 73);
            this.tbTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(150, 23);
            this.tbTime.TabIndex = 3;
            this.tbTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTime_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbService);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 337);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(371, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ข้อมูลการใช้บริการ";
            // 
            // cbbService
            // 
            this.cbbService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbService.FormattingEnabled = true;
            this.cbbService.Items.AddRange(new object[] {
            "อินเตอร์เน็ต ชั่วโมงละ 20.50 บาท",
            "พิมพ์งาน ชั่วโมงละ 10.50 บาท",
            "เล่นเกมส์ Offline ชั่วโมงละ 15.50 บาท",
            "เล่นเกมส์ Online  ชั่วโมงละ 25.50 บาท"});
            this.cbbService.Location = new System.Drawing.Point(140, 25);
            this.cbbService.Margin = new System.Windows.Forms.Padding(2);
            this.cbbService.Name = "cbbService";
            this.cbbService.Size = new System.Drawing.Size(221, 24);
            this.cbbService.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(318, 76);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "ชั่วโมง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "จำนวนการใช้บริการ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "ประเภทการใช้บริการ";
            // 
            // btNew
            // 
            this.btNew.Location = new System.Drawing.Point(435, 348);
            this.btNew.Margin = new System.Windows.Forms.Padding(2);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(135, 32);
            this.btNew.TabIndex = 3;
            this.btNew.Text = "เริ่มใหม่";
            this.btNew.UseVisualStyleBackColor = true;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // cbConfirm
            // 
            this.cbConfirm.AutoSize = true;
            this.cbConfirm.Location = new System.Drawing.Point(393, 390);
            this.cbConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.cbConfirm.Name = "cbConfirm";
            this.cbConfirm.Size = new System.Drawing.Size(115, 17);
            this.cbConfirm.TabIndex = 4;
            this.cbConfirm.Text = "ยืนยันการชำระเงิน";
            this.cbConfirm.UseVisualStyleBackColor = true;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(512, 386);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(57, 24);
            this.btCalculate.TabIndex = 3;
            this.btCalculate.Text = "คำนวณ";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // lbExit
            // 
            this.lbExit.Location = new System.Drawing.Point(434, 416);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(135, 32);
            this.lbExit.TabIndex = 3;
            this.lbExit.Text = "จบโปรแกรม";
            this.lbExit.UseVisualStyleBackColor = true;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(87, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "ข้อมูลการชำระเงิน";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbTime);
            this.groupBox3.Controls.Add(this.lbService);
            this.groupBox3.Controls.Add(this.lbMember);
            this.groupBox3.Controls.Add(this.lbName);
            this.groupBox3.Controls.Add(this.lbIDCard);
            this.groupBox3.Controls.Add(this.lbDate);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbTotal);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(589, 22);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(342, 427);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Aqua;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTime.ForeColor = System.Drawing.Color.Red;
            this.lbTime.Location = new System.Drawing.Point(129, 225);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(197, 21);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "-";
            // 
            // lbService
            // 
            this.lbService.BackColor = System.Drawing.Color.Aqua;
            this.lbService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbService.ForeColor = System.Drawing.Color.Red;
            this.lbService.Location = new System.Drawing.Point(129, 193);
            this.lbService.Name = "lbService";
            this.lbService.Size = new System.Drawing.Size(197, 21);
            this.lbService.TabIndex = 5;
            this.lbService.Text = "-";
            // 
            // lbMember
            // 
            this.lbMember.BackColor = System.Drawing.Color.Aqua;
            this.lbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbMember.ForeColor = System.Drawing.Color.Red;
            this.lbMember.Location = new System.Drawing.Point(129, 160);
            this.lbMember.Name = "lbMember";
            this.lbMember.Size = new System.Drawing.Size(197, 21);
            this.lbMember.TabIndex = 5;
            this.lbMember.Text = "-";
            // 
            // lbName
            // 
            this.lbName.BackColor = System.Drawing.Color.Aqua;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbName.ForeColor = System.Drawing.Color.Red;
            this.lbName.Location = new System.Drawing.Point(129, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(197, 21);
            this.lbName.TabIndex = 5;
            this.lbName.Text = "-";
            // 
            // lbIDCard
            // 
            this.lbIDCard.BackColor = System.Drawing.Color.Aqua;
            this.lbIDCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbIDCard.ForeColor = System.Drawing.Color.Red;
            this.lbIDCard.Location = new System.Drawing.Point(129, 93);
            this.lbIDCard.Name = "lbIDCard";
            this.lbIDCard.Size = new System.Drawing.Size(197, 21);
            this.lbIDCard.TabIndex = 5;
            this.lbIDCard.Text = "-";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Aqua;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbDate.ForeColor = System.Drawing.Color.Red;
            this.lbDate.Location = new System.Drawing.Point(129, 62);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(197, 21);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSQuizProject01.Properties.Resources.chip;
            this.pictureBox1.Location = new System.Drawing.Point(111, 267);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbTotal
            // 
            this.lbTotal.BackColor = System.Drawing.Color.Aqua;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(16, 379);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(310, 31);
            this.lbTotal.TabIndex = 0;
            this.lbTotal.Text = "0.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 225);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 15);
            this.label15.TabIndex = 1;
            this.label15.Text = "จำนวนการใช้บริการ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(18, 193);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "ประเภทการใช้บริการ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 160);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 15);
            this.label13.TabIndex = 1;
            this.label13.Text = "ประเภทผู้ใช้บริการ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(76, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "ชื่อ-สกุล";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 93);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "รหัสประจำตัวประชาชน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(52, 62);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "วันที่ใช้บริการ";
            // 
            // FrmQuiz01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 471);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbConfirm);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.lbExit);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmQuiz01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรม Quiz01";
            this.Load += new System.EventHandler(this.FrmQuiz01_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcPicked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbMember;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbGeneralPublic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.CheckBox cbConfirm;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Button lbExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox mtbIDCard;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbIDCard;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbService;
        private System.Windows.Forms.Label lbMember;
        private System.Windows.Forms.Label lbTime;
    }
}

