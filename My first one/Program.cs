// See https://aka.ms/new-console-template for more information  
//Console.WriteLine("Hello, Wisttt hehehehehee its my first code!!!");  

using System.Text;

Console.WriteLine("Lovely Day init");
Console.WriteLine("Sunny Day");
Console.WriteLine("Semi windy day");

string[] userOptions = { "Audio", "Video", "Graphics" };
foreach (var option in userOptions)
{
    Console.WriteLine(option);
}

string displayOption = "Resolution";
Console.WriteLine(displayOption);

int gameScore = 100;
Console.WriteLine(gameScore);

decimal particlesPerMillion = 0.000001m;
Console.WriteLine(particlesPerMillion);

bool processedCustomer = true;
Console.WriteLine(processedCustomer);

string firstName = "Bob";
int messages = 3;
decimal temperature = 34.4m;

Console.WriteLine($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");

Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello\"World\"!");
Console.WriteLine("c:\\temp\\myfile.txt");

// Generate a receipt for a customer
Console.WriteLine("Generating Receipt for Customer \"Big Company\",,,,\n");
for (int i = 2501; i <= 2502; i++)
{
    Console.WriteLine($"Receipt number {i}\t\tCompleted successfully");
}
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"C:\Username\Invoices
(This is where invoices go to)");

// Set console encoding to UTF-8
Console.OutputEncoding = Encoding.UTF8;

// To generate Japanese invoices:
Console.WriteLine("\n\n日本の請求書を生成するには");
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.WriteLine("\nc:\"Username\"documents\"my games\n(This is where my games are stored)");