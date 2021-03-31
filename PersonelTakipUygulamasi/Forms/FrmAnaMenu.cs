using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelTakipUygulamasi.DataAccess.Abstract;
using PersonelTakipUygulamasi.DataAccess.Concrete.SQLite;
using PersonelTakipUygulamasi.DataAccess.Concrete.SqlServer;
using PersonelTakipUygulamasi.Entities.Concrete;

namespace PersonelTakipUygulamasi.Forms
{
    public partial class FrmAnaMenu : Form
    {
        public FrmAnaMenu(string veriTabani)
        {
            InitializeComponent();

            switch (veriTabani)
            {
                case "SQLite":
                    _calisanDal = new SQLiteCalisanDal();
                    break;
                case "SqlServer":
                    _calisanDal = new SqlServerCalisanDal();
                    break;
            }
        }

        private ICalisanDal _calisanDal;
        Calisan _calisan;
        private int _secilenCalisanId;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private bool BosKayitKontrol()
        {
            bool kontrol = true;
            foreach (Control item in pnlAraclar.Controls )
            {
                if (item.Text == string.Empty || item.Text == " ")
                {
                    kontrol = false;
                }
            }

            return kontrol;
        }

        private void AlanlariTemizle()
        {
            foreach (Control item in pnlAraclar.Controls)
            {
                if(item.GetType().Name != "Label")
                {
                    item.Text = string.Empty;
                }

            }

            dateDogumTarihi.Format = DateTimePickerFormat.Custom;
            dateDogumTarihi.CustomFormat = " ";
        }

        private void GridViewDuzenle()
        {
            dgwCalisanlar.Columns["Id"].Visible = false;
            dgwCalisanlar.Columns["Adi"].HeaderText = "ADI";
            dgwCalisanlar.Columns["SoyAdi"].HeaderText = "SOYADI";
            dgwCalisanlar.Columns["TCKimlikNo"].HeaderText = "TC KİMLİK NO";
            dgwCalisanlar.Columns["PersonelNo"].HeaderText = "PERSONEL NO";
            dgwCalisanlar.Columns["DogumTarihi"].HeaderText = "DOĞUM TARİHİ";
            dgwCalisanlar.Columns["Departman"].HeaderText = "DEPARTMAN";
            dgwCalisanlar.Columns["Unvan"].HeaderText = "ÜNVAN";
            dgwCalisanlar.Columns["Durumu"].HeaderText = "DURUMU";

            dgwCalisanlar.ClearSelection();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!BosKayitKontrol())
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz...");
            }
            else
            {
                _calisan = new Calisan
                {
                    Adi = tbxAdi.Text,
                    SoyAdi = tbxSoyAdi.Text,
                    TCKimlikNo = tbxTCKimlikNo.Text,
                    PersonelNo = tbxPersonelNo.Text,
                    DogumTarihi = dateDogumTarihi.Value,
                    Departman = cbxDepartman.Text,
                    Unvan = cbxUnvan.SelectedItem.ToString(),
                    Durumu = cbxDurumu.Text
                };

                bool islem = _calisanDal.Kaydet(_calisan);
                if (islem)
                {
                    dgwCalisanlar.DataSource =  _calisanDal.Listele("where Durumu = 'Aktif Çalışan'");
                    GridViewDuzenle();
                    AlanlariTemizle();

                    MessageBox.Show("Kayıt İşlemi Yapıldı...");

                }

            }
        }

        private void FrmAnaMenu_Load(object sender, EventArgs e)
        {
            dgwCalisanlar.DataSource = _calisanDal.Listele("where Durumu = 'Aktif Çalışan'");
            GridViewDuzenle();
           
            AlanlariTemizle();

        }

        private void dateDogumTarihi_ValueChanged(object sender, EventArgs e)
        {
            dateDogumTarihi.Format = DateTimePickerFormat.Short;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            AlanlariTemizle();
            _secilenCalisanId = 0;
            dgwCalisanlar.DataSource = _calisanDal.Listele("where Durumu = 'Aktif Çalışan'");
            GridViewDuzenle();
        }

        private void dgwCalisanlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _secilenCalisanId = Convert.ToInt32(dgwCalisanlar.CurrentRow.Cells[0].Value.ToString());
            tbxAdi.Text = dgwCalisanlar.CurrentRow.Cells[1].Value.ToString();
            tbxSoyAdi.Text = dgwCalisanlar.CurrentRow.Cells[2].Value.ToString();
            tbxTCKimlikNo.Text = dgwCalisanlar.CurrentRow.Cells[3].Value.ToString();
            tbxPersonelNo.Text = dgwCalisanlar.CurrentRow.Cells[4].Value.ToString();
            dateDogumTarihi.Format = DateTimePickerFormat.Short;
            dateDogumTarihi.Value = Convert.ToDateTime(dgwCalisanlar.CurrentRow.Cells[5].Value.ToString());
            cbxDepartman.Text = dgwCalisanlar.CurrentRow.Cells[6].Value.ToString();
            cbxUnvan.Text = dgwCalisanlar.CurrentRow.Cells[7].Value.ToString();
            cbxDurumu.Text = dgwCalisanlar.CurrentRow.Cells[8].Value.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_secilenCalisanId == 0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğiniz Kaydı Seçiniz...");
            }
            else if (!BosKayitKontrol())
            {
                MessageBox.Show("Lütfen Zorunlu Alanları Doldurunuz...");
            }
            else
            {
                _calisan = new Calisan
                {
                    Id = _secilenCalisanId,
                    Adi = tbxAdi.Text,
                    SoyAdi = tbxSoyAdi.Text,
                    TCKimlikNo = tbxTCKimlikNo.Text,
                    PersonelNo = tbxPersonelNo.Text,
                    DogumTarihi = dateDogumTarihi.Value,
                    Departman = cbxDepartman.Text,
                    Unvan = cbxUnvan.SelectedItem.ToString(),
                    Durumu = cbxDurumu.Text
                };

                bool islem = _calisanDal.Guncelle(_calisan);
                if (islem)
                {
                    dgwCalisanlar.DataSource = _calisanDal.Listele("WHERE Durumu = 'Aktif Çalışan'");
                    GridViewDuzenle();
                    AlanlariTemizle();
                   
                    MessageBox.Show("Güncelleme İşlemi Yapıldı...");

                }

                _secilenCalisanId = 0;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_secilenCalisanId == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Kaydı Seçiniz...");
            }
            else
            {
                DialogResult onay =
                    MessageBox.Show(
                        "Seçilen kayıt Kalıcı Olarak Silinecektir.\nKayıt Silme İşlemini Onaylıyor musunuz ?","Kayıt Silme Onayı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (onay == DialogResult.Yes)
                {
                    bool islem = _calisanDal.Sil(_secilenCalisanId);
                    if (islem)
                    {
                        dgwCalisanlar.DataSource = _calisanDal.Listele("WHERE Durumu = 'Aktif Çalışan'");
                        GridViewDuzenle();
                        AlanlariTemizle();
                        MessageBox.Show("Seçtiğiniz Kayıt Veri Tabanınından Kalıcı Olarak Silindi");
                    }

                   
                }

                _secilenCalisanId = 0;
            }
        }

        private string KosulCumlesiOlustur()
        {
            string kosulCumlesi = string.Empty;

            List<string> alanlar = new List<string>();

            foreach (Control item in pnlAraclar.Controls)
            {
                if(item.Tag == null) continue;

                string alanAdi = item.Tag.ToString();
                string deger = string.Empty;

                if(String.IsNullOrEmpty(item.Text) || item.Text == " ") continue;

                deger = item.Text;


                if (item.Name == "dateDogumTarihi")
                {
                    alanlar.Add($"{alanAdi} = '{deger}'");
                }

                else
                {
                    alanlar.Add($"{alanAdi} LIKE '%{deger}%'");
                }

            }

            if (alanlar.Count > 0) kosulCumlesi = $"WHERE {string.Join(" AND ", alanlar)}";



            return kosulCumlesi;
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            DialogResult onay =
                MessageBox.Show(
                    "Veri Tabanındaki Bütün Kayıtlar Kalıcı Olarak Silinecektir.\nKayıt Silme İşlemini Onaylıyor musunuz ? ", "Kayıt Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                bool islem = _calisanDal.Sil(string.Empty);
                if (islem)
                {
                    dgwCalisanlar.DataSource = null;
                    MessageBox.Show("Seçtiğiniz Kayıt Veri Tabanınından Kalıcı Olarak Silindi");
                }

                
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            dgwCalisanlar.DataSource = _calisanDal.Listele(KosulCumlesiOlustur());
            GridViewDuzenle();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            _calisan = _calisanDal.Getir(KosulCumlesiOlustur());
            if (_calisan != null)
            {
                MessageBox.Show(_calisan.Id.ToString() + "\n" + _calisan.Adi + "\n" + _calisan.SoyAdi + "\n" +
                                _calisan.TCKimlikNo + "\n" + _calisan.PersonelNo + "\n" +
                                _calisan.DogumTarihi.ToString() + "\n" + _calisan.Departman + "\n" + _calisan.Unvan +
                                "\n" + _calisan.Durumu);
            }
        }
    }
}
