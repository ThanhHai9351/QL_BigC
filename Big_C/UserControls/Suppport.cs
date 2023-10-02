using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Big_C.UserControls
{
    public partial class Suppport : UserControl
    {
        public Suppport()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPhanHoi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cảm ơn bạn đã gửi phản hồi . Chúng tôi sẽ khắc phục sớm nhất có thể!");
            txtHoTro.Text = "";
        }
    }
}
