using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        string temp;

        int i;
        for (i=0; i<input.Length;i++)
        {
            temp= input[i];
            if (System.Text.RegularExpressions.Regex.IsMatch(temp, "^[+,0,3]{1}[0-9]*$"))
            {
                 if((temp.Substring(0,5)=="00393" && temp.Length==14) || (temp.Substring(0,4)=="+393" && temp.Length==13) || (temp[0]=='3' && temp.Length==10))
                {
                    return temp;
                }
            }  
        }
        return "";
    }
}