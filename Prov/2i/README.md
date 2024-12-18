[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/hkMpMOVR)
# Prov-2i

![Jultomte](https://usercontent.one/wp/sagolikjul.sagolikt.me.uk/wp-content/uploads/2017/01/santa47.gif)

## Kortfattad förklaring
Det är jul och dags att dela ut julklappar. Vem får sin julklapp i år?\
Din uppgift är att skapa ett program som hanterar en lista med julklappar och kopplar dem till personer.

## Programkörning
* Skapa ett program som fungerar enligt exemplet nedan.
* Öppna terminalen **Ctrl + Ö**, skriv och kör:
```shell
.\net8.0\Prov2i.exe
```

### Del 1
* Du ska skapa ett program för att dela ut julklappar.
* Först anger man **hur många** julklappar som ska delas ut.
* Sedan skriver man in julklapparna som sparas i en **lista**.
* Man ska kunna skriva ut **listan** på alla julklappar.
* Man ska kunna **byta ut** julklapparna.

### Del 2
* Utöka programmet så att man kan ange **vem** som får julklappen.
* Se till att **programmet inte kraschar** om man skriver in felaktig data som ålder eller namn.
* Kontrollera att man bara kan mata in vettig data.
### Del 3
* Utöka programmet så att en person kan få **flera** julklappar.

## OBS!
* Du får titta bara på [C# referens](https://csharp.progdocs.se/lathund)
* Ej tillåtet: 
  * Hjälp under provets gång från någon annan än lärare.  
  * AI-verktyg (ChatGPT, Copilot mfl), alla chattprogram och liknande (Discord, Steam mfl). 
  * Alla webbläsarflikar ska stängas ned.
* Öppna en ny terminalen **Ctrl + Skift + Ö** och skapa kodfilerna: 
```shell
dotnet new console
```
* Kommentera din kod.
* Indentera din kod så den är tydlig att följa.
* **Synka** ofta med github, med en kort kommentar om vad du gjort.
* **Kom ihåg**: Ta en del i taget och fokusera på den innan du går vidare. Det är bättre att lösa någon del helt än att lösa flera till hälften.

## Exempel på programkörning
```
🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁
🎄  Julklappslistan  🎄
🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁🎁

🎅 Hur många julklappar vill du dela ut i år? 3

🎄 Julklappar 🎄
🎅 Ange julklapp 🎁 1: Sockor
🎅 Ange julklapp 🎁 2: Strumpor
🎅 Ange julklapp 🎁 3: Bok

🌟 Välj ett alternativ:
1. Byt ut en julklapp
2. Lista alla julklappar
3. Avsluta programmet
🎅 Ange ditt val: 2

🎄 Lista över julklappar 🎄
🎁 Sockor
🎁 Strumpor
🎁 Bok

🌟 Välj ett alternativ:
1. Byt ut en julklapp
2. Lista alla julklappar
3. Avsluta programmet
🎅 Ange ditt val: 1

🎁 Lista över julklappar:
🎁 1. Sockor
🎁 2. Strumpor
🎁 3. Bok
🎅 Ange numret på julklappen du vill byta ut: 1
🎅 Ange den nya julklappen: Mössa
🎅 Julklappen 🎁 'Sockor' har ersatts med 'Mössa'.

🌟 Välj ett alternativ:
1. Byt ut en julklapp
2. Lista alla julklappar
3. Avsluta programmet
🎅 Ange ditt val: 2

🎄 Lista över julklappar 🎄
🎁 Mössa
🎁 Strumpor
🎁 Bok

🌟 Välj ett alternativ:
1. Byt ut en julklapp
2. Lista alla julklappar
3. Avsluta programmet
🎅 Ange ditt val: 3

🔔🔔🔔🔔🔔🔔🔔🔔🔔🔔
🔔 Gooood Juuuul! 🔔
🔔🔔🔔🔔🔔🔔🔔🔔🔔🔔
```
