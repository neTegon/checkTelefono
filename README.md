# checkTelefono

In questo programma, dato un vettore di stringhe, controlla che nei numeri di telefono inseriti esista un numero cellulare italiano e lo restituisce
###Spiegazione codice
Ho creato una funzione nella quale  si scorreva tutto il vettore di stringhe, nel quale, dopo aver controllato, tramite un'espressione regolare, che il numero iniziasse con il +, il 3 o lo 0 e che tutti gli altri caratteri 
fossero dei numeri, verifico che la stringa abbia la lunghezza giusta e che il numero inizi con le cifre corrette. Se non trova un numero di telefono corretto ritorna una stringa vuota.
```
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
``` 
