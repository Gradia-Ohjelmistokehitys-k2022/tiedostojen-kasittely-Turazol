

# Tiedostojen käsittely C#-kielessä

## Osaamistavoitteita

  +  Tiedostojen käsittely
  +  Tiedostojen sisällön käsittely
  +  FileStream
  +  BufferedStream
  +  Readers and Writers
  +  Serialisointi: 
      + binary ja JSON
      + https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/

## 12.1

- 12.1 Luo uusi luokka, jonka nimi on Tiedosto
- Tee pääohjelma (main), joka kysyy tiedoston nimen ja 
tulostaa tiedon siitä onko annetun niminen tiedosto olemassa.

### Esimerkki:
Anna tiedoston nimi: foo.txt
Tiedosto foo.txt on olemassa.

Anna tiedoston nimi: c:/autoexec.bat
Tiedostoa c:/autoexec.bat ei ole olemassa.


## 12.2
- Jatka tehtävän 12.1 pääohjelmaa:
- luo ja avaa tekstitiedosto teksti1.txt siten, että sen sisältö tyhjenee, kun se avataan.
- Kirjoita tiedostoon rivi ”Hello world!”
- Kirjoita tiedostoon rivi ”Uusi rivi tässä.”
- sulje tiedosto

Tarkista tiedoston sisältö.

## 12.3

- tarkista ennen avaamista onko teksti1.txt olemassa. Tee 12.1 -kohdan pääohjelman koodista tarvittaessa oma metodi +bool OnOlemassa(string nimi);
Jos tiedosto on olemassa:
- avaa tekstitiedosto teksti1.txt
- Tee metodit, jotka lukevat rivit rivi kerrallaan 
  a) taulukoksi 
  b) listaksi 
  c) merkkijonoksi (string)
- tulosta a, b ja c -kohtien tiedot
- sulje tiedosto

## 12.4
- avaa tekstitiedosto teksti1.txt peräänkirjoitusta varten. Tiedoston vanha sisältö säilyy avattaessa ja kirjoittaminen alkaa tiedoston lopusta.
- tulosta tiedoston jo olemassa oleva sisältö. Käytä jotain kohdan 12.3. metodia.
- lisää tiedostoon rivi ”Huuhaa!”
- sulje tiedosto
- avaa tekstitiedosto uudelleen vain lukemista varten
- lue ja tulosta tiedoston sisältö rivi kerrallaan
- sulje tiedosto

## 12.5 
- avaa tektitiedosto teksti1.txt lukemista varten
- lue tiedoston sisältö merkki (char) kerrallaan ja tulosta luetut merkit pilkulla erotettuna.
- sulje tiedosto.
Malli:
H,e,l,l,o, ,w,o,r,l,d,!,

## 12.6
-Avaa (luo) tiedosto oma_binaari.bin kirjoittamista varten. Vanha sisältö saa nollautua avattaessa.
-kirjoita tiedostoon liukuluku 3,14159265 ja kokonaisluku -1
-sulje tiedosto
-avaa tiedosto
-lue tiedostosta arvot float f ja int i ja tulosta ne.
-sulje tiedosto
-tarkastele tiedoston sisältöä tekstieditorilla (notepad tms.) ja kerro mitä näet. Vihje: ei saa näkyä 3,14159265-1

## 12.7
Tee ohjelma, joka tulostaa hakemiston sisällön. Kerro myös tiedostojen pvm + koko.

### Esimerkki:  
.
..
munbinaari.bin	22.01.2022        8 bytes
teksti1.txt		22.01.2022      117 bytes


## 12.8 
Käytä C#-kielen FileStream luokkia hyväksesi seuraavassa tehtävässä. https://docs.microsoft.com/en-us/dotnet/api/system.io.filestream.seek?view=net-5.0
-Tee ohjelma, joka tulostaa ElainLuokka.dll tiedoston sisällön joka kymmenennen tavun takaperin, välilyönneillä erotettuina heksadesimaalikoodeina. 
Esim:
0xFE 0xA7 0x00 …



