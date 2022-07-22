using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per COMMESSE
/// </summary>
public class COMMESSE
{
    public COMMESSE()
    {
        //
        // TODO: aggiungere qui la logica del costruttore
        //
    }

    public class AGGIORNADB
    {
        public int CodiceCommessa;
        public int CodiceCliente;
        public int CodiceAzienda;
        public int CodiceTipoCommessa;
        public string DescrizioneCommessa;
        public string DataInizioCommessa;
        public string DataFineCommessa;
        public decimal ImportoTotale;
        public decimal ImportoOrario;
        public decimal ImportoMensile;
        public decimal ImportoTrasferta;
        public decimal ImportoKm;
        public decimal ImportoPasti;
        public decimal ImportoPernottamenti;
        public int CommessaChiusa;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "COMMESSE_INSERT";
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
            cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);
            cmd.Parameters.AddWithValue("@DescrizioneCommessa", DescrizioneCommessa);
            cmd.Parameters.AddWithValue("@DataInizioCommessa", DataInizioCommessa);
            cmd.Parameters.AddWithValue("@DataFineCommessa", DataFineCommessa);
            cmd.Parameters.AddWithValue("@ImportoTotale", ImportoTotale);
            cmd.Parameters.AddWithValue("@ImportoOrario", ImportoOrario);
            cmd.Parameters.AddWithValue("@ImportoMensile", ImportoMensile);
            cmd.Parameters.AddWithValue("@ImportoTrasferta", ImportoTrasferta);
            cmd.Parameters.AddWithValue("@ImportoKm", ImportoKm);
            cmd.Parameters.AddWithValue("@ImportoPasti", ImportoPasti);
            cmd.Parameters.AddWithValue("@ImportoPernottamenti", ImportoPernottamenti);
            cmd.Parameters.AddWithValue("@CommessaChiusa", CommessaChiusa);

            c.EseguiSPcmdparam(cmd);
        }

        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "COMMESSE_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
            cmd.Parameters.AddWithValue("@CodiceAzienda", CodiceAzienda);
            cmd.Parameters.AddWithValue("@CodiceCliente", CodiceCliente);
            cmd.Parameters.AddWithValue("@CodiceTipoCommessa", CodiceTipoCommessa);
            cmd.Parameters.AddWithValue("@DescrizioneCommessa", DescrizioneCommessa);
            cmd.Parameters.AddWithValue("@DataInizioCommessa", DataInizioCommessa);
            cmd.Parameters.AddWithValue("@DataFineCommessa", DataFineCommessa);
            cmd.Parameters.AddWithValue("@ImportoTotale", ImportoTotale);
            cmd.Parameters.AddWithValue("@ImportoOrario", ImportoOrario);
            cmd.Parameters.AddWithValue("@ImportoMensile", ImportoMensile);
            cmd.Parameters.AddWithValue("@ImportoTrasferta", ImportoTrasferta);
            cmd.Parameters.AddWithValue("@ImportoKm", ImportoKm);
            cmd.Parameters.AddWithValue("@ImportoPasti", ImportoPasti);
            cmd.Parameters.AddWithValue("@ImportoPernottamenti", ImportoPernottamenti);
            cmd.Parameters.AddWithValue("@CommessaChiusa", CommessaChiusa);

            c.EseguiSPcmdparam(cmd);
        }

    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("COMMESSE_SELECTALLVIEW");
    }

    public DataTable SELECT(int CodiceCommessa) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "COMMESSE_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);

        return c.EseguiSPselectparam(cmd);
    }

    public DataTable SELECTFORDDL()
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("COMMESSE_SELECTFORDDL");
    }

}