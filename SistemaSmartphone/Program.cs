using SistemaSmartphone.Models;

Console.WriteLine("Smartphone Samsung");
Samsung samsung = new Samsung(numero: "1198888-6666", modelo: "S22 Ultra",imei:"2334NASANS23OASMSDDFPEEP", memoria: 512);
samsung.Ligar();
samsung.InstalarAplicativo("Whatsapp.apk");
samsung.InstalarAplicativo("telegram.ipa");
samsung.InstalarAplicativo("asasasas");
samsung.InstalarAplicativo("chrome.exe");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "1198765-4321", modelo: "Iphone 13 Pro Max", imei: "2534OPQLAS23OASMSDDTRACY",memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp.ipa");
iphone.InstalarAplicativo("telegram.top.ipa");
iphone.InstalarAplicativo("facebook.apk");