using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class TIPOLOGIESPESE
{
    public TIPOLOGIESPESE()
    {
    
    }
    public class AGGIORNADB
    {
        public int CodiceTipoSpese;
        public string DescrizioneTipoSpese;
        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIESPESE_INSERT";
            cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpese);

            c.EseguiSPcmdparam(cmd);

        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIESPESE_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpese);
            cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpese);

            c.EseguiSPcmdparam(cmd);
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("TIPOLOGIESPESE_SELECTALL");
    }
    public DataTable SELECT(int CodiceTipoSpese) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIESPESE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceTipoSpesa", CodiceTipoSpese);

        return c.EseguiSPselectparam(cmd);
    }
    public bool CHECKONE(string DescrizioneTipoSpese)
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "TIPOLOGIESPESE_CHECKONE";
        cmd.Parameters.AddWithValue("@DescrizioneTipoSpesa", DescrizioneTipoSpese);

        dt = c.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }
}