char [] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
Console.WriteLine("Please enter your message here: ");
string userSecretMessage = Console.ReadLine();
char [] secretMessage = userSecretMessage.ToCharArray();

char[] encryptedMessage = new char [secretMessage.Length];

for (int i = 0; i < secretMessage.Length; i++)
{
    char letter = secretMessage[i];
    int letterNumber = Array.IndexOf(alphabet, letter);
    int movedLetter = (letterNumber + 3) % alphabet.Length;
    char encryptedCharacter = alphabet[movedLetter];
    encryptedMessage[i] = encryptedCharacter;
    
}
string finalWord = string.Join("", encryptedMessage); //needed to use string.Join because we need to combine the characters together
                                                      //can't use encryptedMessage in Console.WriteLine because Console.WriteLine only takes strings
Console.WriteLine($"{finalWord} is the secret word");


