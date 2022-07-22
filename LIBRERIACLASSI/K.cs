using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Descrizione di riepilogo per K
/// </summary>
public static class K
{
    public static int IVA;
    public static SqlConnection conn;
    public static int righegriglia;
    public static string miouser = "doita05@setsistemi.it";
    public static string miapw = "corsodoita";
    public static int porta = 25;
    //^di solito è un intero, 10 o 15 roba così. cambia da provider a provider

    public static string host = "setsistemi.it";


    static K()
    {
        IVA = 22;
        righegriglia = 20;
    }
}

