using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProgram
{
    public partial class BorrowAndReturn : Form
    {
        Borrow borrow_form = new Borrow();
        Return return_form = new Return();
        public BorrowAndReturn()
        {
            InitializeComponent();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            return_form.Hide();
            borrow_form.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            borrow_form.Hide();
            return_form.Show();
        }

        private void BorrowAndReturn_Load(object sender, EventArgs e)
        {
            borrow_form.TopLevel = false;
            return_form.TopLevel = false;
            this.Controls.Add(borrow_form);
            this.Controls.Add(return_form);

            borrow_form.Parent = this.panel;
            return_form.Parent = this.panel;

            //자식 폼의 타이틀을 없앤다
            borrow_form.Text = return_form.Text = "";
            borrow_form.ControlBox = return_form.ControlBox = false;
            borrow_form.Show();
        }
        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
