﻿namespace WinForm08_MenuAndTap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄미리보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다시실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.사용자지정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.메뉴연습중ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.메뉴2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(433, 433);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(425, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForm08_MenuAndTap.Properties.Resources._29;
            this.pictureBox1.Location = new System.Drawing.Point(19, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(425, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinForm08_MenuAndTap.Properties.Resources._0;
            this.pictureBox2.Location = new System.Drawing.Point(17, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 390);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.toolStripSeparator,
            this.저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.toolStripSeparator1,
            this.인쇄ToolStripMenuItem,
            this.인쇄미리보기ToolStripMenuItem,
            this.toolStripSeparator2,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("새로만들기ToolStripMenuItem.Image")));
            this.새로만들기ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.새로만들기ToolStripMenuItem.Text = "새로 만들기";
            this.새로만들기ToolStripMenuItem.Click += new System.EventHandler(this.새로만들기ToolStripMenuItem_Click);
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("열기ToolStripMenuItem.Image")));
            this.열기ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(224, 6);
            // 
            // 저장ToolStripMenuItem
            // 
            this.저장ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("저장ToolStripMenuItem.Image")));
            this.저장ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            this.저장ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.저장ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.저장ToolStripMenuItem.Text = "저장";
            // 
            // 다른이름으로저장ToolStripMenuItem
            // 
            this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
            this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.다른이름으로저장ToolStripMenuItem.Text = "다른 이름으로 저장";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("인쇄ToolStripMenuItem.Image")));
            this.인쇄ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            // 
            // 인쇄미리보기ToolStripMenuItem
            // 
            this.인쇄미리보기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("인쇄미리보기ToolStripMenuItem.Image")));
            this.인쇄미리보기ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.인쇄미리보기ToolStripMenuItem.Name = "인쇄미리보기ToolStripMenuItem";
            this.인쇄미리보기ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.인쇄미리보기ToolStripMenuItem.Text = "인쇄 미리 보기";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(224, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소ToolStripMenuItem,
            this.다시실행ToolStripMenuItem,
            this.toolStripSeparator3,
            this.잘라내기ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.toolStripSeparator4,
            this.모두선택ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 실행취소ToolStripMenuItem
            // 
            this.실행취소ToolStripMenuItem.Name = "실행취소ToolStripMenuItem";
            this.실행취소ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.실행취소ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.실행취소ToolStripMenuItem.Text = "실행 취소";
            // 
            // 다시실행ToolStripMenuItem
            // 
            this.다시실행ToolStripMenuItem.Name = "다시실행ToolStripMenuItem";
            this.다시실행ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.다시실행ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.다시실행ToolStripMenuItem.Text = "다시 실행";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(207, 6);
            // 
            // 잘라내기ToolStripMenuItem
            // 
            this.잘라내기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("잘라내기ToolStripMenuItem.Image")));
            this.잘라내기ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
            this.잘라내기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.잘라내기ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.잘라내기ToolStripMenuItem.Text = "잘라내기";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("복사ToolStripMenuItem.Image")));
            this.복사ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("붙여넣기ToolStripMenuItem.Image")));
            this.붙여넣기ToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(207, 6);
            // 
            // 모두선택ToolStripMenuItem
            // 
            this.모두선택ToolStripMenuItem.Name = "모두선택ToolStripMenuItem";
            this.모두선택ToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.모두선택ToolStripMenuItem.Text = "모두 선택";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.사용자지정ToolStripMenuItem,
            this.옵션ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 사용자지정ToolStripMenuItem
            // 
            this.사용자지정ToolStripMenuItem.Name = "사용자지정ToolStripMenuItem";
            this.사용자지정ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.사용자지정ToolStripMenuItem.Text = "사용자 지정";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(172, 26);
            this.옵션ToolStripMenuItem.Text = "옵션";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.메뉴연습중ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 메뉴연습중ToolStripMenuItem
            // 
            this.메뉴연습중ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.메뉴1ToolStripMenuItem,
            this.메뉴2ToolStripMenuItem});
            this.메뉴연습중ToolStripMenuItem.Name = "메뉴연습중ToolStripMenuItem";
            this.메뉴연습중ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.메뉴연습중ToolStripMenuItem.Text = "메뉴 연습중";
            // 
            // 메뉴1ToolStripMenuItem
            // 
            this.메뉴1ToolStripMenuItem.Name = "메뉴1ToolStripMenuItem";
            this.메뉴1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.메뉴1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.메뉴1ToolStripMenuItem.Text = "메뉴1";
            // 
            // 메뉴2ToolStripMenuItem
            // 
            this.메뉴2ToolStripMenuItem.Name = "메뉴2ToolStripMenuItem";
            this.메뉴2ToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.메뉴2ToolStripMenuItem.Text = "메뉴2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem 저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄미리보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다시실행ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 모두선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 사용자지정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 메뉴연습중ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 메뉴2ToolStripMenuItem;
    }
}

