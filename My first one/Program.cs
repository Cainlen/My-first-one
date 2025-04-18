// See https://aka.ms/new-console-template for more information  
//Console.WriteLine("Hello, Wisttt hehehehehee its my first code!!!");  

using System.Text;

Console.WriteLine("Lovely Day init");
Console.WriteLine("Sunny Day");
Console.WriteLine("Semi windy day");

string userOption, displayOption;
userOption = "Audio";
Console.WriteLine(userOption);
userOption = "Video";
Console.WriteLine(userOption);
userOption = "Graphics";
Console.WriteLine(userOption);
displayOption = "Resolution";
Console.WriteLine(displayOption);

int gameScore;
gameScore = 100;
Console.WriteLine(gameScore);

decimal particlesPerMillion;
particlesPerMillion = 0.000001m;
Console.WriteLine(particlesPerMillion);

bool processedCustomer;
processedCustomer = true;
Console.WriteLine(processedCustomer);

string firstName = ("Bob");
int messages = (3);
decimal temperature = (34.4m);

Console.Write("Hello, "); Console.Write(firstName); Console.Write("! You have "); Console.Write(messages);
Console.Write(" messages in your inbox. The temperature is "); Console.Write(temperature);
Console.Write(" celsius.");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");

Console.WriteLine("Hello\"World\"!");

Console.WriteLine("c:\\temp\\myfile.txt");

{
    // Generate a receipt for a customer
    Console.WriteLine("Generating Receipt for Customer \"Big Company\",,,,\n");
    Console.WriteLine("Receipt number 2501\t\tCompleted sucesssfully\n");
    Console.WriteLine("Receipt number 2502\t\tCompleted sucesssfully");
    Console.WriteLine("\nOutput Directojary:\t");
    Console.WriteLine(@"C:\Username\Invoices
    (This is where invoices go to)");
}
    {
        // Set console encoding to UTF-8
        Console.OutputEncoding = Encoding.UTF8;

        // To generate Japanese invoices:
        // Nihon no seikyū-sho o seisei suru ni wa
        Console.Write("\n\n日本の請求書を生成するには\n");

        Console.WriteLine(@"c:\invoices\app.exe -j");
        Console.WriteLine(" ");
        Console.WriteLine(@"C:\Username\docusments\my games
(This is where my games are stored)");
    }