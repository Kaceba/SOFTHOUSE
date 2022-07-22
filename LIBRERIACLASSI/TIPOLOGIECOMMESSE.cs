using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class TIPOLOGIECOMMESSE
{
    public TIPOLOGIECOMMESSE()
    {
        
    }

    public class AGGIORNADB
    {
        public int CodiceTipoCommessa;
        public string DescrizioneTipoCommessa;
        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIECOMMESSE_INSERT";
            cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);

            c.EseguiSPcmdparam(cmd);

        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIECOMMESSE_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);
            cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);

            c.EseguiSPcmdparam(cmd);
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("TIPOLOGIECOMMESSE_SELECTALL");
    }
    public DataTable SELECT(int CodiceTipoCommessa) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIECOMMESSE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);

        return c.EseguiSPselectparam(cmd);
    }
    public bool CHECKONE(string DescrizioneTipoCommessa)
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "TIPOLOGIECOMMESSE_CHECKONE";
        cmd.Parameters.AddWithValue("@DescrizioneTipoCommessa", DescrizioneTipoCommessa);

        dt = c.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;

    }

    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("TIPOLOGIECOMMESSE_SELECTFORDDL");
    }
}