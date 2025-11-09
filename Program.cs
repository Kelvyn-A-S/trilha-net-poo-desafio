using System.Reflection.Metadata;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia.");
Smartphone nokia = new Nokia(numero: "23456-789", modelo: "Modelo 1", imei: "12345567899", memoria: 64);
nokia.Apresentar();
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone.");
Smartphone iphone = new Iphone(numero: "13456-789", modelo: "Modelo 4", imei: "1234556231", memoria: 128);
iphone.Apresentar();
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
