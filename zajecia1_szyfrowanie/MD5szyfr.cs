using System.Security.Cryptography;
using System.Text;

public class MD5szyfr
{
    string hash { get; set; }
    public string zaszyfrujMD5(string textDoZaszyfrowania,string haslo)
    {
        try
        {
            hash = haslo;
            byte[] data = UTF8Encoding.UTF8.GetBytes(textDoZaszyfrowania);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] klucz = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = klucz, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] wynik = transform.TransformFinalBlock(data, 0, data.Length);
                    string text = Convert.ToBase64String(wynik, 0, wynik.Length);
                    return text;
                }
            }
        }
        catch (Exception e)
        {
            return "błąd przy wykonywaniu funkcji: " + e;
        } 
    }


    public string odSzyfrujMD5(string textMD5, string haslo)
    {
        try
        {
            hash = haslo;
            byte[] data = Convert.FromBase64String(textMD5);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] klucz = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = klucz, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] wynik = transform.TransformFinalBlock(data, 0, data.Length);
                    String text = UTF8Encoding.UTF8.GetString(wynik);
                    return text;
                }
            }
        }
        catch(Exception e) {
            return "błąd przy wykonywaniu funkcji: "+ e ;
        }
    }
}
