using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class AZIENDE
{
    public AZIENDE()
    {

    }

    public class AGGIORNADB
    {
        public int CodiceAzienda;
        public string RagioneSociale;
        public string PartitaIva;
        public string Indirizzo;
        public string Citta;
        public string Cap;
        public string Provincia;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AZIENDE_INSERT";
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            c.EseguiSPcmdparam(cmd);
        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AZIENDE_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            c.EseguiSPcmdparam(cmd);
        }
        public bool CHECKONE()
        {
            CONNESSIONE c = new CONNESSIONE();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "AZIENDE_CHECKONE";
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            dt = c.EseguiSPselectparam(cmd);

            return dt.Rows.Count > 0;
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("AZIENDE_SELECTALL");
    }

    public DataTable SELECT(int CodiceAzienda) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "AZIENDE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);

        return c.EseguiSPselectparam(cmd);
    }

    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("AZIENDE_SELECTFORDDL");
    }

}
