namespace WinForm04_MessageBox
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbyesno = new System.Windows.Forms.RadioButton();
            this.rbokcancel = new System.Windows.Forms.RadioButton();
            this.rbok = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbquestion = new System.Windows.Forms.RadioButton();
            this.rbinformation = new System.Windows.Forms.RadioButton();
            this.rberror = new System.Windows.Forms.RadioButton();
            this.btnshow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbyesno);
            this.groupBox1.Controls.Add(this.rbokcancel);
            this.groupBox1.Controls.Add(this.rbok);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rbyesno
            // 
            this.rbyesno.AutoSize = true;
            this.rbyesno.Location = new System.Drawing.Point(6, 74);
            this.rbyesno.Name = "rbyesno";
            this.rbyesno.Size = new System.Drawing.Size(70, 19);
            this.rbyesno.TabIndex = 2;
            this.rbyesno.TabStop = true;
            this.rbyesno.Text = "YesNo";
            this.rbyesno.UseVisualStyleBackColor = true;
            // 
            // rbokcancel
            // 
            this.rbokcancel.AutoSize = true;
            this.rbokcancel.Location = new System.Drawing.Point(6, 49);
            this.rbokcancel.Name = "rbokcancel";
            this.rbokcancel.Size = new System.Drawing.Size(92, 19);
            this.rbokcancel.TabIndex = 1;
            this.rbokcancel.TabStop = true;
            this.rbokcancel.Text = "OkCancel";
            this.rbokcancel.UseVisualStyleBackColor = true;
            // 
            // rbok
            // 
            this.rbok.AutoSize = true;
            this.rbok.Location = new System.Drawing.Point(6, 24);
            this.rbok.Name = "rbok";
            this.rbok.Size = new System.Drawing.Size(48, 19);
            this.rbok.TabIndex = 0;
            this.rbok.TabStop = true;
            this.rbok.Text = "OK";
            this.rbok.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbquestion);
            this.groupBox2.Controls.Add(this.rbinformation);
            this.groupBox2.Controls.Add(this.rberror);
            this.groupBox2.Location = new System.Drawing.Point(223, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 135);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Icon";
            // 
            // rbquestion
            // 
            this.rbquestion.AutoSize = true;
            this.rbquestion.Location = new System.Drawing.Point(6, 74);
            this.rbquestion.Name = "rbquestion";
            this.rbquestion.Size = new System.Drawing.Size(88, 19);
            this.rbquestion.TabIndex = 2;
            this.rbquestion.TabStop = true;
            this.rbquestion.Text = "Question";
            this.rbquestion.UseVisualStyleBackColor = true;
            // 
            // rbinformation
            // 
            this.rbinformation.AutoSize = true;
            this.rbinformation.Location = new System.Drawing.Point(6, 49);
            this.rbinformation.Name = "rbinformation";
            this.rbinformation.Size = new System.Drawing.Size(99, 19);
            this.rbinformation.TabIndex = 1;
            this.rbinformation.TabStop = true;
            this.rbinformation.Text = "Information";
            this.rbinformation.UseVisualStyleBackColor = true;
            // 
            // rberror
            // 
            this.rberror.AutoSize = true;
            this.rberror.Location = new System.Drawing.Point(6, 24);
            this.rberror.Name = "rberror";
            this.rberror.Size = new System.Drawing.Size(58, 19);
            this.rberror.TabIndex = 0;
            this.rberror.TabStop = true;
            this.rberror.Text = "Error";
            this.rberror.UseVisualStyleBackColor = true;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(176, 184);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 4;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 231);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MessageBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbyesno;
        private System.Windows.Forms.RadioButton rbokcancel;
        private System.Windows.Forms.RadioButton rbok;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbquestion;
        private System.Windows.Forms.RadioButton rbinformation;
        private System.Windows.Forms.RadioButton rberror;
        private System.Windows.Forms.Button btnshow;
    }
}

