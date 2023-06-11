using System;
using System.Web;
using System.Collections.Specialized;

public class QueryString
{
    public void printString(string url)
    {
        //string url = "https://www.google.com/?val1=11111&val2=22222&val3=33333";
        Uri uri = new Uri(url);
        string queryString = uri.Query;
        //Console.WriteLine(queryString);

        NameValueCollection nvc = HttpUtility.ParseQueryString(queryString);
        foreach(string key in nvc.Keys) {
            Console.WriteLine(key + "==" + HttpUtility.UrlDecode(nvc[key]));
        }
        //nvc["val1"] = "12345";
        //Console.WriteLine(nvc.ToString());
    }
}

