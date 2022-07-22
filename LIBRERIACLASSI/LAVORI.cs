using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Descrizione di riepilogo per LAVORI
/// </summary>
public class LAVORI
{
    public LAVORI()
    {

    }

    public class AGGIORNADB
    {
        public int CodiceLavoro;
        public int CodicePersonale;
        public int CodiceCommessa;
        public string DataLavoro;
        public decimal OreLavoro;
        public decimal Trasferta;
        public int Km;
        public decimal Pasti;
        public decimal Pernottamenti;

        public void INSERT()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "LAVORI_INSERT";
            cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
            cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
            cmd.Parameters.AddWithValue("@DataLavoro", DataLavoro);
            cmd.Parameters.AddWithValue("@OreLavoro", OreLavoro);
            cmd.Parameters.AddWithValue("@Trasferta", Trasferta);
            cmd.Parameters.AddWithValue("@Km", Km);
            cmd.Parameters.AddWithValue("@Pasti", Pasti);
            cmd.Parameters.AddWithValue("@Pernottamenti", Pernottamenti);

            c.EseguiSPcmdparam(cmd);
        }


        public void UPDATE()
        {
            CONNESSIONE c = new CONNESSIONE();
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "LAVORI_UPDATE";
            cmd.Parameters.AddWithValue("@CodiceLavoro", CodiceLavoro);
            cmd.Parameters.AddWithValue("@CodicePersonale", CodicePersonale);
            cmd.Parameters.AddWithValue("@CodiceCommessa", CodiceCommessa);
            cmd.Parameters.AddWithValue("@DataLavoro", DataLavoro);
            cmd.Parameters.AddWithValue("@OreLavoro", OreLavoro);
            cmd.Parameters.AddWithValue("@Trasferta", Trasferta);
            cmd.Parameters.AddWithValue("@Km", Km);
            cmd.Parameters.AddWithValue("@Pasti", Pasti);
            cmd.Parameters.AddWithValue("@Pernottamenti", Pernottamenti);

            c.EseguiSPcmdparam(cmd);
        }


    }

    public DataTable SELECT() //SelectAll
    {
        CONNESSIONE c = new CONNESSIONE();

        return c.EseguiSp("LAVORI_SELECTALL");
    }

    public DataTable SELECT(int CodiceLavoro) // SelectOne
    {
        CONNESSIONE c = new CONNESSIONE();
        SqlCommand cmd = new SqlCommand();

        cmd.CommandText = "LAVORI_SELECTONE";
        cmd.Parameters.AddWithValue("@CodiceLavoro", CodiceLavoro);

        return c.EseguiSPselectparam(cmd);
    }

}
