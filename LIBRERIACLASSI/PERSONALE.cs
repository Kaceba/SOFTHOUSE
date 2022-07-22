using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PERSONALE
/// </summary>
public class PERSONALE
{
    public PERSONALE()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public class AGGIORNADB
    {
        public int CodicePersonale;
        public int CodiceAzienda;
        public int CodiceTipoContratto;
        public string RagioneSociale;
        public string Cognome;
        public string Nome;
        public string PartitaIva;
        public string CodiceFiscale;
        public string Indirizzo;
        public string Citta;
        public string Provincia;
        public string Cap;
        public string DataNascita;
        public string CostoMensile;
        public string DataInizioCollaborazione;
        public string DataFineCollaborazione;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "PERSONALE_INSERT";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@Cognome", Cognome);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@DataNascita", DataNascita);
            cmd.Parameters.AddWithValue("@CostoMensile", CostoMensile);
            cmd.Parameters.AddWithValue("@DataInizioCollaborazione", DataInizioCollaborazione);
            cmd.Parameters.AddWithValue("@DataFineCollaborazione", DataFineCollaborazione);

            c.EseguiSPcmdparam(cmd);
        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "PERSONALE_UPDATE";
            cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@Cognome", Cognome);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@DataNascita", DataNascita);
            cmd.Parameters.AddWithValue("@CostoMensile", CostoMensile);
            cmd.Parameters.AddWithValue("@DataInizioCollaborazione", DataInizioCollaborazione);
            cmd.Parameters.AddWithValue("@DataFineCollaborazione", DataFineCollaborazione);

            c.EseguiSPcmdparam(cmd);
        }
        public bool CHECKONE()
        {
            CONNESSIONE c = new CONNESSIONE();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "PERSONALE_CHECKONE";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceTipoContratto", CodiceTipoContratto);
            cmd.Parameters.AddWithValue("@RagioneSociale", RagioneSociale);
            cmd.Parameters.AddWithValue("@Cognome", Cognome);
            cmd.Parameters.AddWithValue("@Nome", Nome);
            cmd.Parameters.AddWithValue("@PartitaIva", PartitaIva);
            cmd.Parameters.AddWithValue("@CodiceFiscale", CodiceFiscale);
            cmd.Parameters.AddWithValue("@Indirizzo", Indirizzo);
            cmd.Parameters.AddWithValue("@Citta", Citta);
            cmd.Parameters.AddWithValue("@Provincia", Provincia);
            cmd.Parameters.AddWithValue("@Cap", Cap);
            cmd.Parameters.AddWithValue("@DataNascita", DataNascita);
            cmd.Parameters.AddWithValue("@CostoMensile", CostoMensile);
            cmd.Parameters.AddWithValue("@DataInizioCollaborazione", DataInizioCollaborazione);
            cmd.Parameters.AddWithValue("@DataFineCollaborazione", DataFineCollaborazione);

            dt = c.EseguiSPselectparam(cmd);

            return dt.Rows.Count > 0;
        }
    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("PERSONALE_SELECTALL");
    }
    public DataTable SELECT(int CodicePersonale) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "PERSONALE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);

        return c.EseguiSPselectparam(cmd);
    }

    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("PERSONALE_SELECTFORDDL");
    }

}