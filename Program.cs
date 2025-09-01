using DesafioPOO.Models;

var nokia = new Nokia("1199998877", "Nokia Plus", "123456789", 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

var iphone = new Iphone("12999997766", "iPhone 12", "987654321", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Facebook");