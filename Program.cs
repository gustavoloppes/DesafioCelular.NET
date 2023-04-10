using DesafioPOO.Models;

Nokia nokia = new Nokia (numero: "9999999", modelo: "N1", imei: "1234", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("TELEGRAM");

Iphone iphone = new Iphone (numero: "888888", modelo: "14pro", imei: "4321", memoria: 518);
iphone.Ligar();
iphone.InstalarAplicativo("WHATSAPP");