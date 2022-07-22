using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per News
/// </summary>
public class NEWS
{
    public NEWS()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }

    public class AGGIORNADB
    {
        public int CodiceNews;
        public int CodiceAzienda;
        public DateTime DataNews;
        public string Titolo;
        public string News;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "NEWS_INSERT";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@DataNews", DataNews);
            cmd.Parameters.AddWithValue("@Titolo", Titolo);
            cmd.Parameters.AddWithValue("@News", News);
            c.EseguiSPcmdparam(cmd);

        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "NEWS_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceNews", CodiceNews);
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@DataNews", DataNews);
            cmd.Parameters.AddWithValue("@Titolo", Titolo);
            cmd.Parameters.AddWithValue("@News", News);

            c.EseguiSPselectparam(cmd);
        }

        public void ELIMINA()
        {
           CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand("NEWS_DELETE");
            cmd.Parameters.AddWithValue("@CodiceNews", CodiceNews);
            c.EseguiSPcmdparam(cmd);
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("NEWS_SELECTALL");

    }

    public DataTable SELECT(int CodiceNews) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "NEWS_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceNews", CodiceNews);

        return c.EseguiSPselectparam(cmd);
    }
}