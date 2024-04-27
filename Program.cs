using DesafioPOO.Models;

﻿using DesafioPOO.Models;

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia(numero: "00001", modelo: "ABC-1", imei: "0001", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
Smartphone iphone = new Iphone(numero: "00002, modelo: "ABC-2", imei: "0002", memoria: 32);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");
