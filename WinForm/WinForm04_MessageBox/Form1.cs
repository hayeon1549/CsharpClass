using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons msgBoxBtn;
        MessageBoxIcon msgBoxIcon;

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (this.rbok.Checked == true)
                msgBoxBtn = MessageBoxButtons.OK;
            else if (this.rbokcancel.Checked)
                msgBoxBtn = MessageBoxButtons.OKCancel;
            else if (this.rbyesno.Checked)
                msgBoxBtn = MessageBoxButtons.YesNo;

            if (this.rberror.Checked == true)
                msgBoxIcon = MessageBoxIcon.Error;
            else if (this.rbinformation.Checked == true)
                msgBoxIcon = MessageBoxIcon.Information;
            else if (this.rbquestion.Checked == true)
                msgBoxIcon = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스 입니다.", "알림", msgBoxBtn, msgBoxIcon);
        }
    }
}
