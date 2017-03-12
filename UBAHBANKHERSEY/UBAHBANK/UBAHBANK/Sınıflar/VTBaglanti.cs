using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace UBAHBANK.Sınıflar
{
    class VTBaglanti
    {
        public MySqlConnection myConn;
        public MySqlDataAdapter dataAdapter;
        public DataSet dataSet1;
        public DataTable tablo;
        public MySqlCommand cmd;
        MySqlDataReader dr;


        public void mysqlBaglan()
        {
            string connect = @"server=localhost;database=UBAHBANK;uid=abdullah;password=abdullah;";

            try
            {
                myConn = new MySqlConnection(connect);
                myConn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void kaydet(string komut)
        {
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(komut, myConn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable Listele(string tabloadi)
        {
            string komut = @"select * from " + tabloadi;
            mysqlBaglan();
            try
            {
                dataAdapter = new MySqlDataAdapter(komut, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablo;
        }
        //üzerinde çalışılacak
        //arama methodu
        public DataTable Ara(string tabloadi, string sutun, string key)
        {
            string komut = @"select * from " + tabloadi + " where " + sutun + " like '%" + key + "%'";

            mysqlBaglan();
            try
            {
                dataAdapter = new MySqlDataAdapter(komut, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tablo;
        }

        //Sisteme yetkisine göre giriş vermek için hazırlanılan metod
        public bool giris(string kartno, string sifre)
        {
            int count = 0;
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand("select * from TBLKART where K_No='" + kartno + "' and K_Sifre='" + sifre + "'", myConn);

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            myConn.Close();
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable Secim(string sorgu)
        {
            try
            {
                dataAdapter = new MySqlDataAdapter(sorgu, myConn);
                dataSet1 = new DataSet();
                dataAdapter.Fill(dataSet1);
                tablo = dataSet1.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return tablo;
        }

        public int sqlSayi(string sqlAsk, string Sutun)
        {
            int sonuc = 0;
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(sqlAsk, myConn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    sonuc = Convert.ToInt32(dr[Sutun].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return sonuc;
        }

        public string sqlKelime(string sorgu,string sutun)
        {
            string kelime="";
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(sorgu, myConn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kelime = (dr[sutun].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return kelime;
        }

        public bool sqlVarlik(string sorgu)
        {
            int count = 0;
            mysqlBaglan();
            try
            {
                cmd = new MySqlCommand(sorgu, myConn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count ++;
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (count > 0) return true;
            else return false;
        }
    }
}
