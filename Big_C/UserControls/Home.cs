using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Big_C.UserControls;
using Big_C.Model;
using System.Data.SqlClient;

namespace Big_C.UserControls
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ReplaceContent(UserControl userControlToReplace)
        {
            // Xóa nội dung hiện tại của User Control 2 (nếu cần)
            this.Controls.Clear();

            // Thêm User Control 1 vào User Control 2
            userControlToReplace.Dock = DockStyle.Fill;
            this.Controls.Add(userControlToReplace);
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {

        }
    }
}
