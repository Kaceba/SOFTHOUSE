using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class TIPOLOGIECONTRATTI
{
    public TIPOLOGIECONTRATTI()
    {
     
    }

    public class AGGIORNADB
    {
        public int CodiceTipoContratto;
        public string DescrizioneTipoContratto;
        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIECONTRATTI_Insert";
            cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

            c.EseguiSPcmdparam(cmd);

        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "TIPOLOGIECONTRATTI_Update";
            cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
            cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

            c.EseguiSPcmdparam(cmd);
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("TIPOLOGIECONTRATTI_SelectAll");
    }
    public DataTable SELECT(int CodiceTipoContratto) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "TIPOLOGIECONTRATTI_SelectOne";
        cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);

        return c.EseguiSPselectparam(cmd);
    }
    public bool CHECKONE(string DescrizioneTipoContratto)
    {
        CONNESSIONE c = new CONNESSIONE();
        DataTable dt = new DataTable();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandText = "TIPOLOGIECONTRATTI_CheckOne";
        cmd.Parameters.AddWithValue("@DescrizioneTipoContratto", DescrizioneTipoContratto);

        dt = c.EseguiSPselectparam(cmd);

        return dt.Rows.Count > 0;
    }
    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("TIPOLOGIECONTRATTI_SELECTFORDDL");
    }
}