namespace DigitalTubeTool
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        // my variable
        private uint pin_value = 0;
        private uint pin_value_n = 1;
        private uint[] pin_value_arr = new uint[8] { 1, 1, 1, 1, 1, 1, 1, 1 };  


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.segname1 = new System.Windows.Forms.TextBox();
            this.segvalue1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.segname8 = new System.Windows.Forms.TextBox();
            this.segvalue8 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.segname7 = new System.Windows.Forms.TextBox();
            this.segvalue7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.segname6 = new System.Windows.Forms.TextBox();
            this.segvalue6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.segname5 = new System.Windows.Forms.TextBox();
            this.segvalue5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.segname4 = new System.Windows.Forms.TextBox();
            this.segvalue4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.segname3 = new System.Windows.Forms.TextBox();
            this.segvalue3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.segname2 = new System.Windows.Forms.TextBox();
            this.segvalue2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.codevalue = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 18);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(18, 97);
            this.button2.TabIndex = 4;
            this.button2.Text = " ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(162, 214);
            this.button8.Margin = new System.Windows.Forms.Padding(2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(22, 23);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 232);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 18);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(40, 126);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(97, 18);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(138, 140);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(18, 97);
            this.button3.TabIndex = 10;
            this.button3.Text = " ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 34);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(18, 97);
            this.button6.TabIndex = 11;
            this.button6.Text = " ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 140);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(18, 97);
            this.button5.TabIndex = 12;
            this.button5.Text = " ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // segname1
            // 
            this.segname1.Location = new System.Drawing.Point(2, 9);
            this.segname1.Margin = new System.Windows.Forms.Padding(2);
            this.segname1.Name = "segname1";
            this.segname1.Size = new System.Drawing.Size(21, 21);
            this.segname1.TabIndex = 13;
            this.segname1.Text = "a";
            this.segname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.segname1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // segvalue1
            // 
            this.segvalue1.AutoSize = true;
            this.segvalue1.Location = new System.Drawing.Point(8, 46);
            this.segvalue1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue1.Name = "segvalue1";
            this.segvalue1.Size = new System.Drawing.Size(11, 12);
            this.segvalue1.TabIndex = 14;
            this.segvalue1.Text = "1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.segname1);
            this.panel1.Controls.Add(this.segvalue1);
            this.panel1.Location = new System.Drawing.Point(10, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 74);
            this.panel1.TabIndex = 15;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.panel1);
            this.panel10.Location = new System.Drawing.Point(203, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(285, 100);
            this.panel10.TabIndex = 31;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.segname8);
            this.panel8.Controls.Add(this.segvalue8);
            this.panel8.Location = new System.Drawing.Point(248, 17);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(26, 74);
            this.panel8.TabIndex = 22;
            // 
            // segname8
            // 
            this.segname8.Location = new System.Drawing.Point(2, 9);
            this.segname8.Margin = new System.Windows.Forms.Padding(2);
            this.segname8.Name = "segname8";
            this.segname8.Size = new System.Drawing.Size(21, 21);
            this.segname8.TabIndex = 13;
            this.segname8.Text = "dp";
            this.segname8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue8
            // 
            this.segvalue8.AutoSize = true;
            this.segvalue8.Location = new System.Drawing.Point(8, 46);
            this.segvalue8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue8.Name = "segvalue8";
            this.segvalue8.Size = new System.Drawing.Size(11, 12);
            this.segvalue8.TabIndex = 14;
            this.segvalue8.Text = "1";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.segname7);
            this.panel7.Controls.Add(this.segvalue7);
            this.panel7.Location = new System.Drawing.Point(214, 17);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(26, 74);
            this.panel7.TabIndex = 21;
            // 
            // segname7
            // 
            this.segname7.Location = new System.Drawing.Point(2, 9);
            this.segname7.Margin = new System.Windows.Forms.Padding(2);
            this.segname7.Name = "segname7";
            this.segname7.Size = new System.Drawing.Size(21, 21);
            this.segname7.TabIndex = 13;
            this.segname7.Text = "g";
            this.segname7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue7
            // 
            this.segvalue7.AutoSize = true;
            this.segvalue7.Location = new System.Drawing.Point(8, 46);
            this.segvalue7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue7.Name = "segvalue7";
            this.segvalue7.Size = new System.Drawing.Size(11, 12);
            this.segvalue7.TabIndex = 14;
            this.segvalue7.Text = "1";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.segname6);
            this.panel6.Controls.Add(this.segvalue6);
            this.panel6.Location = new System.Drawing.Point(180, 17);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 74);
            this.panel6.TabIndex = 20;
            // 
            // segname6
            // 
            this.segname6.Location = new System.Drawing.Point(2, 9);
            this.segname6.Margin = new System.Windows.Forms.Padding(2);
            this.segname6.Name = "segname6";
            this.segname6.Size = new System.Drawing.Size(21, 21);
            this.segname6.TabIndex = 13;
            this.segname6.Text = "f";
            this.segname6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue6
            // 
            this.segvalue6.AutoSize = true;
            this.segvalue6.Location = new System.Drawing.Point(8, 46);
            this.segvalue6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue6.Name = "segvalue6";
            this.segvalue6.Size = new System.Drawing.Size(11, 12);
            this.segvalue6.TabIndex = 14;
            this.segvalue6.Text = "1";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.segname5);
            this.panel5.Controls.Add(this.segvalue5);
            this.panel5.Location = new System.Drawing.Point(146, 17);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(26, 74);
            this.panel5.TabIndex = 19;
            // 
            // segname5
            // 
            this.segname5.Location = new System.Drawing.Point(2, 9);
            this.segname5.Margin = new System.Windows.Forms.Padding(2);
            this.segname5.Name = "segname5";
            this.segname5.Size = new System.Drawing.Size(21, 21);
            this.segname5.TabIndex = 13;
            this.segname5.Text = "e";
            this.segname5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue5
            // 
            this.segvalue5.AutoSize = true;
            this.segvalue5.Location = new System.Drawing.Point(8, 46);
            this.segvalue5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue5.Name = "segvalue5";
            this.segvalue5.Size = new System.Drawing.Size(11, 12);
            this.segvalue5.TabIndex = 14;
            this.segvalue5.Text = "1";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.segname4);
            this.panel4.Controls.Add(this.segvalue4);
            this.panel4.Location = new System.Drawing.Point(112, 17);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(26, 74);
            this.panel4.TabIndex = 18;
            // 
            // segname4
            // 
            this.segname4.Location = new System.Drawing.Point(2, 9);
            this.segname4.Margin = new System.Windows.Forms.Padding(2);
            this.segname4.Name = "segname4";
            this.segname4.Size = new System.Drawing.Size(21, 21);
            this.segname4.TabIndex = 13;
            this.segname4.Text = "d";
            this.segname4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue4
            // 
            this.segvalue4.AutoSize = true;
            this.segvalue4.Location = new System.Drawing.Point(8, 46);
            this.segvalue4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue4.Name = "segvalue4";
            this.segvalue4.Size = new System.Drawing.Size(11, 12);
            this.segvalue4.TabIndex = 14;
            this.segvalue4.Text = "1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.segname3);
            this.panel3.Controls.Add(this.segvalue3);
            this.panel3.Location = new System.Drawing.Point(78, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(26, 74);
            this.panel3.TabIndex = 17;
            // 
            // segname3
            // 
            this.segname3.Location = new System.Drawing.Point(2, 9);
            this.segname3.Margin = new System.Windows.Forms.Padding(2);
            this.segname3.Name = "segname3";
            this.segname3.Size = new System.Drawing.Size(21, 21);
            this.segname3.TabIndex = 13;
            this.segname3.Text = "c";
            this.segname3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue3
            // 
            this.segvalue3.AutoSize = true;
            this.segvalue3.Location = new System.Drawing.Point(8, 46);
            this.segvalue3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue3.Name = "segvalue3";
            this.segvalue3.Size = new System.Drawing.Size(11, 12);
            this.segvalue3.TabIndex = 14;
            this.segvalue3.Text = "1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.segname2);
            this.panel2.Controls.Add(this.segvalue2);
            this.panel2.Location = new System.Drawing.Point(44, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(26, 74);
            this.panel2.TabIndex = 16;
            // 
            // segname2
            // 
            this.segname2.Location = new System.Drawing.Point(2, 9);
            this.segname2.Margin = new System.Windows.Forms.Padding(2);
            this.segname2.Name = "segname2";
            this.segname2.Size = new System.Drawing.Size(21, 21);
            this.segname2.TabIndex = 13;
            this.segname2.Text = "b";
            this.segname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // segvalue2
            // 
            this.segvalue2.AutoSize = true;
            this.segvalue2.Location = new System.Drawing.Point(8, 46);
            this.segvalue2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.segvalue2.Name = "segvalue2";
            this.segvalue2.Size = new System.Drawing.Size(11, 12);
            this.segvalue2.TabIndex = 14;
            this.segvalue2.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = global::DigitalTubeTool.Properties.Settings.Default.msb;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.confirm.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DigitalTubeTool.Properties.Settings.Default, "confirm", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.confirm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.confirm.Location = new System.Drawing.Point(51, 273);
            this.confirm.Margin = new System.Windows.Forms.Padding(2);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(71, 26);
            this.confirm.TabIndex = 32;
            this.confirm.Text = global::DigitalTubeTool.Properties.Settings.Default.confirm;
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(413, 193);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 106);
            this.textBox9.TabIndex = 33;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // codevalue
            // 
            this.codevalue.AutoSize = true;
            this.codevalue.Location = new System.Drawing.Point(27, 19);
            this.codevalue.Name = "codevalue";
            this.codevalue.Size = new System.Drawing.Size(29, 12);
            this.codevalue.TabIndex = 34;
            this.codevalue.Text = "0xff";
            this.codevalue.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.codevalue);
            this.panel11.Location = new System.Drawing.Point(221, 225);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(87, 54);
            this.panel11.TabIndex = 35;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button10.Location = new System.Drawing.Point(319, 235);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 32);
            this.button10.TabIndex = 36;
            this.button10.Text = "记录";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(78, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 37;
            this.label11.Text = "a";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(426, 310);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "create by wkk";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(122, 76);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "b";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(122, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 16);
            this.label14.TabIndex = 40;
            this.label14.Text = "c";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(78, 214);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 16);
            this.label15.TabIndex = 41;
            this.label15.Text = "d";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(37, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 42;
            this.label16.Text = "e";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(37, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 16);
            this.label17.TabIndex = 43;
            this.label17.Text = "f";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(78, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(15, 16);
            this.label18.TabIndex = 44;
            this.label18.Text = "g";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(161, 193);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 16);
            this.label19.TabIndex = 45;
            this.label19.Text = "dp";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(249, 208);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 46;
            this.label20.Text = "码值";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DigitalTubeTool.Properties.Settings.Default, "共阴", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton2.Location = new System.Drawing.Point(182, 10);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = global::DigitalTubeTool.Properties.Settings.Default.共阴;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.radioButton2);
            this.panel9.Controls.Add(this.radioButton1);
            this.panel9.Location = new System.Drawing.Point(203, 34);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(285, 37);
            this.panel9.TabIndex = 23;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::DigitalTubeTool.Properties.Settings.Default, "共阳", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioButton1.Location = new System.Drawing.Point(54, 10);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 16);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = global::DigitalTubeTool.Properties.Settings.Default.共阳;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 331);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "DigitalTubeTool";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox segname1;
        private System.Windows.Forms.Label segvalue1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label codevalue;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox segname8;
        private System.Windows.Forms.Label segvalue8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox segname7;
        private System.Windows.Forms.Label segvalue7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox segname6;
        private System.Windows.Forms.Label segvalue6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox segname5;
        private System.Windows.Forms.Label segvalue5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox segname4;
        private System.Windows.Forms.Label segvalue4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox segname3;
        private System.Windows.Forms.Label segvalue3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox segname2;
        private System.Windows.Forms.Label segvalue2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

