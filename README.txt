# 📦 Inbentarioa26 — ADB Taldea

### ERRONKA 3 · 1PAAG3 · Izarraitz LHII · 2025-2026

## ⚠️ GARRANTZITSUA — MySQL zerbitzariaren IP helbidea

Programa exekutatu aurretik, **MySQL zerbitzariaren IP helbidea aldatu behar duzu** `DBKonexioa.cs` fitxategian, zerbitzariaren IPa **ez baita estatikoa** eta aldatu egiten baita.

### Urratsak:

1. Ireki `DBKonexioa.cs` fitxategia.
2. Bilatu lerro hau:
   ```csharp
   private readonly string _cs = "server=192.168.80.24;port=3306;database=inbentarioa26;uid=root;pwd=root;SslMode=None;";
   ```
3. Aldatu `192.168.80.24` zenbakia gelako MySQL zerbitzariaren uneko IP helbidearekin.
4. Gorde fitxategia (`Ctrl + S`) eta birkonpilatu proiektua (`F6`).
5. Exekutatu programa (`F5`).
---

## 📝 Proiektuaren deskribapena

Izarraitz LHIIko gailu digitalen inbentarioa kudeatzeko aplikazio bat da.
Ikastetxeko ordenagailuak eta inprimagailuak erregistratu, editatu eta ezabatzeko aukera ematen du.
Erabiltzaile sistema bat du, eta rola arabera baimen ezberdinak ditu bakoitzak.

---

## 🔗 Estekak

🌐 Web Orrialdea:
https://anunez25-spec.github.io/Inbentarioa26/Markatze/index.html

📚 Dokumentazio Teknikoa (DocFX):
https://anunez25-spec.github.io/Inbentarioa26/Downloads/ADB-Erronka3_1/ADB-Erronka3/PROGRAMA/Dokumentazioa/index.html

📦 Instaladorea (ERRONKA3.exe):
https://github.com/anunez25-spec/Inbentarioa26/releases/latest

---

## 📁 Repositorioaren egitura

PROGRAMA/Kodea — C# kodea (Visual Studio proiektua)
PROGRAMA/Dokumentazioa — DocFX dokumentazio teknikoa
PROGRAMA/DatuBasea — MySQL script-a
Markatze — Web orrialdea

---

## ⚙️ Instalazioa

1. ERRONKA3.exe deskargatzeko ( https://github.com/anunez25-spec/Inbentarioa26/releases/tag/APLIKAZIOA )
2. Fitxategian dobla-klik egin
3. Ikastetxeko sare berera konektatu (ezinbestekoa)

---

## 👥 Erabiltzailea

Izena: admin
Pasahitza: 12345
Rola: admin

---

## 🛠️ Teknologia

- Lengoaia: C# .NET 10
- Interfazea: Windows Forms
- Datu-basea: MySQL
- Arkitektura: POO — 3 geruza
- Dokumentazioa: DocFX

---

## 👨‍💻 Garatzaileak

ADB Taldea
