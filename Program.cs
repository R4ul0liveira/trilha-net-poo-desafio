using System.ComponentModel;
using DesafioPOO.Models;
// Desafio Finalizado!!

Console.WriteLine("Smartphone Nokia: ");
Nokia nokia = new Nokia(numero: "88888888", modelo: "Modelo 1100", imei: "0000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Iphone(numero: "7777777", modelo: "Modelo 15 PRO MAX", imei: "8787", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("instagram");