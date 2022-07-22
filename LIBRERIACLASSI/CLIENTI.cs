using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class CLIENTI
{
    public CLIENTI()
    {
      
    }
    public class AGGIORNADB
    {
        public int CodiceCliente;
        public string RagioneSociale;
        public string PartitaIva;
        public string CodiceFiscale;
        public string Indirizzo;
        public string Cap;
        public string Citta;
        public string Provincia;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "CLIENTI_INSERT";
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            c.EseguiSPcmdparam(cmd);
        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "CLIENTI_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            c.EseguiSPcmdparam(cmd);
        }
        public bool CHECKONE()
        {
            CONNESSIONE c = new CONNESSIONE();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "CLIENTI_CHECKONE";
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);

            dt = c.EseguiSPselectparam(cmd);

            return dt.Rows.Count > 0;
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("CLIENTI_SELECTALL");
    }
    public DataTable SELECT(int CodiceCliente) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "CLIENTI_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);

        return c.EseguiSPselectparam(cmd);
    }

    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("CLIENTI_SELECTFORDDL");
    }
}
