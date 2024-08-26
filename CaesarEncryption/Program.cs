char[] alphabet = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ".ToCharArray();    //Enter the letters of the alphabet in this field.
char[] plainText = "AçıkMetin".ToUpper().ToCharArray();    //Enter the plain text in this field.
int key = 3;    //Enter the key in this field.

string cipherText = string.Empty;
for (int i = 0; i < plainText.Length; i++)
{
    int ndx = (Array.IndexOf(alphabet, plainText[i]) + key) % alphabet.Length;
    cipherText += alphabet[ndx];
}
Console.WriteLine(cipherText);
