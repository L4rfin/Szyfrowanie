using System;

public class Słownik
{
    private Char[] litery = { ' ','a','A', 'ą','Ą', 'b','B', 'c','C', 'ć','Ć', 'd','D', 'e','E', 'ę','Ę', 'f','F', 'g','G', 'h','H', 'i','I','v','V', 'j','J', 'k','K', 'l','L', 'ł','Ł', 'q','Q', 'm','M', 'n','N', 'ń','Ń', 'o','O', 'ó','Ó', 'p','P', 'r','R', 's','S', 'ś','Ś', 't','T', 'u','U', 'w','W','x','X', 'y','Y', 'z','Z', 'ź','Ź','ż','Ż', '.', ',', '?', ':', '\"', '[', '{', ']', ']', '!',';', '\\', '/', '\'', '-', '_', '=', '+', '|', '`', '~', '@', '#', '$', '%', '^', '&', '*', '(',')', '<','>','1','2','3','4','5','6','7','8','9','0' };

    public char zamiana(char literaDozamiany, int klucz)
    {
        int x = 0;
        char literaZamieniona = ' ';
        bool wielkalitera = false;
        if (Char.IsUpper(literaDozamiany)==true)
        {
            wielkalitera = true;
            char.ToLower(literaDozamiany);
        }
        for (int i = 0; i < this.litery.Length; i++)
        {
            if (literaDozamiany == litery[0])
            {
                literaZamieniona = (char)32;
                break;
            }
            if (this.litery[i] == literaDozamiany)
            {
                x = i;
                break;
            }
        }
        if (this.litery.Length < (klucz+x))
        {
            x = (klucz + x) - litery.Length+1;
        }
        if (literaDozamiany != litery[0])
        {
            if ((x+klucz)== this.litery.Length) { x = 1; }
            literaZamieniona = this.litery[x + klucz];
        }
        if (wielkalitera==true)
        {
            char.ToUpper(literaZamieniona);
        }
        return literaZamieniona;
    }
    public char odmiana(char literaDozamiany, int klucz) 
    {
        int x = 0;
        char literaZamieniona = ' ';
        bool wielkalitera = false;
        if (Char.IsUpper(literaDozamiany) == true)
        {
            wielkalitera = true;
            char.ToLower(literaDozamiany);
        }
        for (int i = 0; i < this.litery.Length; i++)
        {
            if (literaDozamiany == litery[0])
            {
                literaZamieniona = (char)32;
                break;
            }
            if (this.litery[i] == literaDozamiany)
            {
                x = i;
                break;
            }
        }
        if (0 > (x-klucz))
        {
            x = litery.Length -(klucz + x);
        }
        if (literaDozamiany != litery[0])
        {
            literaZamieniona = this.litery[x - klucz];
        }
        if (wielkalitera == true)
        {
            char.ToUpper(literaZamieniona);
        }
        return literaZamieniona;

    }

}
