using System;

public class SzyfrCezara
{
    public String szyfrCezaraSzyfrujący(String szyfrowanyTxt, int klucz)
    {
        Słownik słownik = new Słownik();
        string zaSzyfrowany = "";
        char zmienianiaLitera, literaPoZmianie;

        for (int i = 0; i < szyfrowanyTxt.Length; i++)
        {
            zmienianiaLitera = (char)szyfrowanyTxt[i];
            literaPoZmianie = słownik.zamiana(zmienianiaLitera, klucz);
            zaSzyfrowany += literaPoZmianie;
        }

        return zaSzyfrowany;
    }
    public String szyfrCezaraDeszyfrujący(String deszyfrowanyTxt, int klucz)
    {
        Słownik słownik = new Słownik();
        string rozSzyfrowany = "";
        char zmienianiaLitera, literaPoZmianie;

        for (int i = 0; i < deszyfrowanyTxt.Length; i++)
        {
            zmienianiaLitera = (char)deszyfrowanyTxt[i];
            literaPoZmianie = słownik.odmiana(zmienianiaLitera, klucz);
            rozSzyfrowany += literaPoZmianie;
        }

        return rozSzyfrowany;

    }

}
