using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinInventar
{
    public class DbHandling
    {
        public string Constring;

        public DbHandling(string dbname, string dbserver)
        {
            string password = "pownbi";
            if (dbserver == "ELITEBOOK\\SQLEXPRESS") password = "610311";
            Constring = "Data Source=" + dbserver + ";Initial Catalog=" + dbname + ";User Id=sa;Password=" + password;
        }

        public DataTable GetData(string sql)
        {
            var dataliste = new DataTable();
            using (var con = new SqlConnection(Constring))
            {
                con.Open();
                var comm = new SqlCommand();
                comm.CommandText = sql;
                comm.Connection = con;
                var adrReader = new SqlDataAdapter(comm);
                try
                {
                    adrReader.Fill(dataliste);
                }
                catch (Exception)
                {
                    MessageBox.Show(@"Fehler beim abrufen der Daten von IT_Inventar");
                }
                adrReader.Dispose();
                con.Close();
                con.Dispose();
            }
            return dataliste;
        }

        public DataTable GetGattung(int gattungID, bool defaultentry)
        {
            string sql = "Select ID, Bezeichnung from tblGattung Order By Bezeichnung";
            if (gattungID > 0)
                sql = "Select ID, Bezeichnung from tblGattung Where ID=" + gattungID;
            DataTable gattung = GetData(sql);
            if (defaultentry)
            {
                return DefaultInsert(gattung);
            }
            return gattung;
        }

        public DataTable GetGruppierung(int gattungID, int gruppierungID, bool defaultentry)
        {
            string sql;
            if (gruppierungID == 0)
            {
                if (gattungID == 0)
                {
                    sql = "Select ID, Bezeichnung from tblGruppierung Order By Bezeichnung";
                }
                else
                {
                    sql = "Select ID, Bezeichnung from tblGruppierung where GattungsID=" + gattungID +
                          " Order By Bezeichnung";
                }
            }
            else
            {
                {
                    sql = "Select ID, Bezeichnung from tblGruppierung where ID=" + gruppierungID;
                }
            }
            DataTable gruppierung = GetData(sql);
            if (defaultentry)
            {
                return DefaultInsert(gruppierung);
            }
            return gruppierung;
        }

        private DataTable DefaultInsert(DataTable table)
        {
            {
                DataRow dr = table.NewRow();
                dr[0] = 0;
                dr[1] = "- alle -";
                table.Rows.InsertAt(dr, 0);
                return table;
            }
        }


        public DataTable GetviewGeraeteKpl()
        {
            string sql = "Select * from viewGeraeteKpl";
            DataTable geraetekpl = GetData(sql);
            return geraetekpl;
        }

        public DataTable GetGeraete(int gattungID, int gruppierungID, string suchbegriff, bool inaktive)
        {
            string sql = "Select * from tblGeraete Where 1=1";
            if (suchbegriff !="") sql += " AND Bezeichnung like '%" + suchbegriff + "%'";
            if (gruppierungID>0)
            {
                sql += " AND GruppierungsID=" + gruppierungID;
            }
            else
            {
                if (gattungID > 0)
                    sql += " AND GruppierungsID IN (Select ID from tblGruppierung where GattungsID=" + gattungID + ")";
            }
            sql += " Order by Bezeichnung";
            DataTable geraete = GetData(sql);
            return geraete; 
        }
    }
}
