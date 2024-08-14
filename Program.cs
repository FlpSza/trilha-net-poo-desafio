using DesafioPOO.Models;

Console.WriteLine("Smartfone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Tijolão", imei: "abc", memoria: 50);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero:"654321", modelo: "XR", imei: "ldalksjd", memoria:124);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
