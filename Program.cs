using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testes com o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9 9999-9999", modelo: "G60 5G", imei: "123456789123456", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Testes com o Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "9 8765-4321", modelo: "14 Pro Max", imei: "987654321098765", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("DIO");