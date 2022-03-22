static string Get_HTML(string Url)
{
    System.Net.WebResponse Result = null;
    string Page_Source_Code;
    try
    {
        System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
        Result = req.GetResponse();
        System.IO.Stream RStream = Result.GetResponseStream();
        System.IO.StreamReader sr = new System.IO.StreamReader(RStream);
        new System.IO.StreamReader(RStream);
        Page_Source_Code = sr.ReadToEnd();
        sr.Dispose();
    }
    catch
    {
        // error while reading the url: the url dosen’t exist, connection problem...
        Page_Source_Code = "";
    }
    finally
    {
        if (Result != null) Result.Close();
    }
    return Page_Source_Code;
}



string VerificaString(string texto)
{
    if (texto.Contains("senha") || texto.Contains("promoção") || texto.Contains("black friday"))
    {
        return "suspicious";
    }
    else return "safe";
}

Console.WriteLine(VerificaString(Get_HTML("http://www.mocky.io/v2/5e18df272f00007e0097e1b4")));