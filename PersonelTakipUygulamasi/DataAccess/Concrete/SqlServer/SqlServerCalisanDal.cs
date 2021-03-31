using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonelTakipUygulamasi.DataAccess.Abstract;
using PersonelTakipUygulamasi.Entities.Concrete;
using PersonelTakipUygulamasi.Tools.Connection.SQLite;
using PersonelTakipUygulamasi.Tools.Connection.SqlServer;

namespace PersonelTakipUygulamasi.DataAccess.Concrete.SqlServer
{
    public class SqlServerCalisanDal : ICalisanDal
    {
        public Calisan Getir(string kosulCumlesi)
        {
            Calisan _calisan = null;

            try
            {
                int _sonuc = 0;
                using (SqlCommand command = new SqlCommand($"SELECT COUNT (*) Calisanlar {kosulCumlesi}", SqlServerBaglanti.Connection))
                {
                    SqlServerBaglanti.BaglantiAc();
                    _sonuc = Convert.ToInt32(command.ExecuteScalar());
                }
                if (_sonuc > 1)
                {
                    MessageBox.Show("Yapılan sorgu sonucunda 1'den fazla kayıt bulundu...\nLütfen daha fazla kriter ile arama yapınız...");
                }
                else if (_sonuc == 1)
                {
                    using (SqlCommand command = new SqlCommand($"SELECT * FROM Calisanlar {kosulCumlesi}", SqlServerBaglanti.Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                _calisan = new Calisan
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    Adi = reader["Adi"].ToString(),
                                    SoyAdi = reader["SoyAdi"].ToString(),
                                    TCKimlikNo = reader["TCKimlikNo"].ToString(),
                                    PersonelNo = reader["PersonelNo"].ToString(),
                                    DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                    Departman = reader["Departman"].ToString(),
                                    Unvan = reader["Unvan"].ToString(),
                                    Durumu = reader["Durumu"].ToString()

                                };

                            }
                        }
                    }
                }
                return _calisan;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }

        public bool Guncelle(Calisan calisan)
        {
            string sorguCumlesi = "Update Calisanlar SET Adi=@p1,SoyAdi=@p2,TCKimlikNo=@p3,PersonelNo=@p4,DogumTarihi=@p5,Departman=@p6,Unvan=@p7,Durumu=@p8 where Id=@p9)";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SqlServerBaglanti.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Adi);
                    command.Parameters.AddWithValue("@p2", calisan.SoyAdi);
                    command.Parameters.AddWithValue("@p3", calisan.TCKimlikNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.Departman);
                    command.Parameters.AddWithValue("@p7", calisan.Unvan);
                    command.Parameters.AddWithValue("@p8", calisan.Durumu);
                    command.Parameters.AddWithValue("@p9", calisan.Id);
                    SqlServerBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }

        public bool Kaydet(Calisan calisan)
        {
            string sorguCumlesi = "INSERT INTO Calisanlar (Adi,SoyAdi,TCKimlikNo,PersonelNo,DogumTarihi,Departman,Unvan,Durumu) Values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)";
            try
            {
                using (SqlCommand command = new SqlCommand(sorguCumlesi, SqlServerBaglanti.Connection))
                {
                    command.Parameters.AddWithValue("@p1", calisan.Adi);
                    command.Parameters.AddWithValue("@p2", calisan.SoyAdi);
                    command.Parameters.AddWithValue("@p3", calisan.TCKimlikNo);
                    command.Parameters.AddWithValue("@p4", calisan.PersonelNo);
                    command.Parameters.AddWithValue("@p5", calisan.DogumTarihi);
                    command.Parameters.AddWithValue("@p6", calisan.Departman);
                    command.Parameters.AddWithValue("@p7", calisan.Unvan);
                    command.Parameters.AddWithValue("@p8", calisan.Durumu);
                    SqlServerBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }

        public List<Calisan> Listele(string kosulCumlesi)
        {
            List<Calisan> calisanlar = new List<Calisan>();
            try
            {
                using (SqlCommand command = new SqlCommand($"SELECT * FROM Calisanlar {kosulCumlesi}", SqlServerBaglanti.Connection))
                {
                    SqlServerBaglanti.BaglantiAc();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Calisan _calisan = new Calisan
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Adi = reader["Adi"].ToString(),
                                SoyAdi = reader["SoyAdi"].ToString(),
                                TCKimlikNo = reader["TCKimlikNo"].ToString(),
                                PersonelNo = reader["PersonelNo"].ToString(),
                                DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                                Departman = reader["Departman"].ToString(),
                                Unvan = reader["Unvan"].ToString(),
                                Durumu = reader["Durumu"].ToString()

                            };
                            calisanlar.Add(_calisan);
                        }
                    }
                    return calisanlar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }

        public bool Sil(string kosulCumlesi)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"DELETE FROM Calisanlar {kosulCumlesi}", SqlServerBaglanti.Connection))
                {
                    SqlServerBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }

        public bool Sil(int id)
        {
            try
            {
                using (SqlCommand command = new SqlCommand($"DELETE FROM Calisanlar where Id=@p1", SqlServerBaglanti.Connection))
                {
                    command.Parameters.AddWithValue("@p1", id);
                    SqlServerBaglanti.BaglantiAc();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            finally
            {
                SqlServerBaglanti.BaglantiKapat();
            }
        }
    }
}
