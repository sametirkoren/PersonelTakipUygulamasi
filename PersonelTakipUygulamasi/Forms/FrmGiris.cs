using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipUygulamasi.Forms
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private string _veriTabaniSecimi;

        private void rdBtnSQLite_CheckedChanged(object sender, EventArgs e)
        {
            _veriTabaniSecimi = "SQLite";
        }

        private void rdBtnSqlServer_CheckedChanged(object sender, EventArgs e)
        {
            _veriTabaniSecimi = "SqlServer";
        }

        FrmAnaMenu _frmAnaMenu;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (rdBtnSQLite.Checked == false && rdBtnSqlServer.Checked == false)
            {
                MessageBox.Show("Lütfen Çalışmak İstediğiniz Veritabanı Teknolojisini Seçiniz...");
            }
            else
            {
                if (_frmAnaMenu == null || _frmAnaMenu.IsDisposed)
                {
                    _frmAnaMenu = new FrmAnaMenu(_veriTabaniSecimi);
                    _frmAnaMenu.Show();
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
