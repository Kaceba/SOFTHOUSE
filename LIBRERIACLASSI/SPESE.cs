using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SPESE
/// </summary>
public class SPESE
{
    public SPESE()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public class AGGIORNADB
    {
        public int CodiceSpesa;
        public int CodiceAzienda;
        public int CodiceTipoSpesa;
        public decimal Importo;
        public string DataSpesa;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SPESE_INSERT";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);
            cmd.Parameters.AddWithValue("@Importo", Importo);
            cmd.Parameters.AddWithValue("@DataSpesa", DataSpesa);

            c.EseguiSPcmdparam(cmd);
        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SPESE_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpesa);
            cmd.Parameters.AddWithValue("@Importo", Importo);
            cmd.Parameters.AddWithValue("@DataSpesa", DataSpesa);

            c.EseguiSPcmdparam(cmd);
        }
        public bool DELETE()
        {
            CONNESSIONE c = new CONNESSIONE();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SPESE_DELETE";
            cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);

            dt = c.EseguiSPselectparam(cmd);

            return dt.Rows.Count > 0;
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("SPESE_SELECTALL");
    }
    public DataTable SELECT(int CodiceSpesa) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "SPESE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceSpesa", CodiceSpesa);

        return c.EseguiSPselectparam(cmd);
    }

}
