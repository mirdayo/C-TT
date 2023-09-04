namespace _01Basic
{
    partial class winform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn_btn = new System.Windows.Forms.Button();
            this.led01On = new System.Windows.Forms.Button();
            this.led01Off = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TEMP_BOX = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.SUN_BOX = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DIS_BOX = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textArea_Remove = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.Dis_conn_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortNumber
            // 
            this.PortNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.Items.AddRange(new object[] {
            });
            this.PortNumber.Location = new System.Drawing.Point(6, 24);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(136, 23);
            this.PortNumber.TabIndex = 0;
            this.PortNumber.SelectedIndexChanged += new System.EventHandler(this.PortNumber_SelectedIndexChanged);
            //this.PortNumber.SelectedIndex = 0; 이거 맨날 삭제당해 대신 윈폼 열리는 순간에 장치 포트 인식하게 바꿈
            // 
            // conn_btn
            // 
            this.conn_btn.Location = new System.Drawing.Point(174, 14);
            this.conn_btn.Name = "conn_btn";
            this.conn_btn.Size = new System.Drawing.Size(75, 40);
            this.conn_btn.TabIndex = 1;
            this.conn_btn.Text = "연결";
            this.conn_btn.UseVisualStyleBackColor = true;
            this.conn_btn.Click += new System.EventHandler(this.conn_btn_Click);
            // 
            // led01On
            // 
            this.led01On.Location = new System.Drawing.Point(6, 24);
            this.led01On.Name = "led01On";
            this.led01On.Size = new System.Drawing.Size(102, 76);
            this.led01On.TabIndex = 2;
            this.led01On.Text = "LED_ON";
            this.led01On.UseVisualStyleBackColor = true;
            this.led01On.Click += new System.EventHandler(this.led01On_Click);
            // 
            // led01Off
            // 
            this.led01Off.Location = new System.Drawing.Point(147, 24);
            this.led01Off.Name = "led01Off";
            this.led01Off.Size = new System.Drawing.Size(102, 76);
            this.led01Off.TabIndex = 5;
            this.led01Off.Text = "LED_OFF";
            this.led01Off.UseVisualStyleBackColor = true;
            this.led01Off.Click += new System.EventHandler(this.led01Off_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PortNumber);
            this.groupBox1.Controls.Add(this.conn_btn);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 65);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "포트 연결";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.led01On);
            this.groupBox2.Controls.Add(this.led01Off);
            this.groupBox2.Location = new System.Drawing.Point(27, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 122);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LED 제어";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textArea);
            this.groupBox3.Location = new System.Drawing.Point(324, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 210);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "로그 확인";
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(17, 34);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textArea.Size = new System.Drawing.Size(222, 158);
            this.textArea.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TEMP_BOX);
            this.groupBox4.Location = new System.Drawing.Point(27, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(255, 70);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "온도 센서";
            // 
            // TEMP_BOX
            // 
            this.TEMP_BOX.Enabled = false;
            this.TEMP_BOX.Location = new System.Drawing.Point(7, 24);
            this.TEMP_BOX.Multiline = true;
            this.TEMP_BOX.Name = "TEMP_BOX";
            this.TEMP_BOX.Size = new System.Drawing.Size(242, 31);
            this.TEMP_BOX.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.SUN_BOX);
            this.groupBox5.Location = new System.Drawing.Point(27, 335);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(255, 70);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "조도 센서";
            // 
            // SUN_BOX
            // 
            this.SUN_BOX.Enabled = false;
            this.SUN_BOX.Location = new System.Drawing.Point(7, 25);
            this.SUN_BOX.Multiline = true;
            this.SUN_BOX.Name = "SUN_BOX";
            this.SUN_BOX.Size = new System.Drawing.Size(242, 32);
            this.SUN_BOX.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.DIS_BOX);
            this.groupBox6.Location = new System.Drawing.Point(324, 247);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 70);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "초음파 센서";
            // 
            // DIS_BOX
            // 
            this.DIS_BOX.Enabled = false;
            this.DIS_BOX.Location = new System.Drawing.Point(17, 25);
            this.DIS_BOX.Multiline = true;
            this.DIS_BOX.Name = "DIS_BOX";
            this.DIS_BOX.Size = new System.Drawing.Size(232, 32);
            this.DIS_BOX.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textArea_Remove);
            this.groupBox7.Location = new System.Drawing.Point(324, 335);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(125, 70);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "로그 비우기";
            // 
            // textArea_Remove
            // 
            this.textArea_Remove.Location = new System.Drawing.Point(17, 25);
            this.textArea_Remove.Name = "textArea_Remove";
            this.textArea_Remove.Size = new System.Drawing.Size(92, 39);
            this.textArea_Remove.TabIndex = 0;
            this.textArea_Remove.Text = "비우기";
            this.textArea_Remove.UseVisualStyleBackColor = true;
            this.textArea_Remove.Click += new System.EventHandler(this.textArea_Remove_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.Dis_conn_btn);
            this.groupBox8.Location = new System.Drawing.Point(455, 335);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(125, 70);
            this.groupBox8.TabIndex = 15;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "연결 해제";
            // 
            // Dis_conn_btn
            // 
            this.Dis_conn_btn.Location = new System.Drawing.Point(17, 25);
            this.Dis_conn_btn.Name = "Dis_conn_btn";
            this.Dis_conn_btn.Size = new System.Drawing.Size(92, 39);
            this.Dis_conn_btn.TabIndex = 0;
            this.Dis_conn_btn.Text = "해제";
            this.Dis_conn_btn.UseVisualStyleBackColor = true;
            this.Dis_conn_btn.Click += new System.EventHandler(this.Dis_conn_btn_Click);
            // 
            // winform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 427);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "winform";
            this.Text = "WINFORMTEST";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn_btn;
        private System.Windows.Forms.Button led01On;
        private System.Windows.Forms.Button led01Off;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TEMP_BOX;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox SUN_BOX;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox DIS_BOX;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button textArea_Remove;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button Dis_conn_btn;
    }
}

