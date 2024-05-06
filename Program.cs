using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Efetuado testes ✌🏼

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "(16) 99876-1515", modelo: "iPhone 15", imei: "EF141560", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(16) 99880-2989", modelo: "Nokia ???", imei: "EN142780", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Mastercard");