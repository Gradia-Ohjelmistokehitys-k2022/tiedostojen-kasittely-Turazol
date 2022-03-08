# Tiedostojen-kasittely

# Olio-ohjelmointi
Gradia olio-ohjelmoinnin tiedostojen käsittely (repository).

C#-kirja löytyy http://www.csharpcourse.com/ linkin takaa.

# Oppimistavoitteita: 

## Osaamistavoitteita ja tutustumisen kohteita

  +  Tiedostojen käsittely
  +  Tiedostojen sisällön käsittely
  +  FileStream
  +  BufferedStream
  +  Readers and Writers
  +  Serialisointi: 
      + binary ja JSON
      + https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/

# Git ohje

# SSH avaimen luonti Githubia varten
Perjantaina 13. elokuuta Github muutti kirjautumisvaatimuksiaan ja login/salasana kirjautuminen ei enää toimi. Tämän takia luomme kaikille SSH avaimet ja käytämme niitä autentikointiin Githubin kanssa.
**HUOM! Jos pääset normaalisti kirjautumaan Githubiin ei SSH avaimiin siirtyminen ole pakollista. Tee siis nämä vaiheet vain jos Github ei enää päästä sinua sisään!**

1. Avaa GitBash ```olio-ohjelmointi-2022-kevat``` hakemistossa.
2. Kokeile komentoa ```ssh -T git@github.com```. Mikäli komennon vastauksesta löytyy kohta ```...You've successfully authenticated...``` olet valmis eikä tätä ohjetta tarvitse seurata pidemmälle. Mikäli autentikointi taas epäonnistuu jatka kohtaan 3.
3. ```ls ~/.ssh``` - Mikäli komento onnistuu ja tulostaa hakemiston josta löytyy tiedostot ```id_rsa``` ja ```id_rsa.pub``` hyppää kohtaan 5. Mikäli tiedostot puuttuvat tai koko ```.ssh``` hakemisto puuttuu siirry kohtaan 4.
4. ```ssh-keygen -t rsa -b 2048``` - Vastaa jokaiseen kysymykseen painamalla enteriä (älä siis muuta oletusvastauksia.)
5. ```ls ~/.ssh``` - Nyt komennon pitäisi tulostaa hakemisto josta löytyy tiedostot ```id_rsa``` ja ```id_rsa.pub```.
6. ```cat ~/.ssh/id_rsa.pub``` - Tulostaa konsoliin julkisen avaimesi. Kopioi avain talteen. Esimerkki avaimesta alla.
7. Mene githubin avaintenhallintasivulle ```https://github.com/settings/keys```
8. Klikkaa vihreää "New SSH key" painiketta.
9. Keksi avaimelle nimi "Title" kenttään.
10. Liitä kohdassa 6 kopioimasi avain "Key" kenttään.
11. Klikkaa vihreää "Add SSH key" painiketta.
12. Kokeile GitBashissa että yhteys toimii nyt: ```ssh -T git@github.com```. Mikäli komennon vastauksesta nyt löytyy kohta ```...You've successfully authenticated...``` siirry kohtaan 13. Muussa tapauksessa ota yhteyttä opettajaan. Jos ssh valittaa ettei tunne githubin palvelinta ja kysyy haluatko varmasti lisätä tämän palvelimen tunnettujen palvelimien listalle, vastaa ```yes``` (kirjoita sana yes kokonaan).

*Esimerkki kohdan 6. ja 10. avaimesta:*
```
ssh-rsa AAAAB3NzaC1yc2EAAAADAQABAAABAQDdFIDeYjLcmRENhfZC16feD6/TJ1WrpSAfBkxr2v2+u5tbiNsSHLLV0rhqwmajZXkEBSjL97PyT3LVNemMa82BI3BB53t5An61DO8GgP0IY+jQef6P5HoFnfD2Pxu4PxpAjse5dZaZa7GR8nyLEzYUh38C+/p7H5eMNolZiSqgPHFtPDXwa6GvY2gYUDdhFGZmNMXFZ3sTVMjtdA/CDsO4kNCG8CFddTsFsrBhiS1j9nvARd2MgaN+3EL5beehTjr1/BZqyRc5vcfM2SUCqaFbdxq6Y1dXfGGLzNrwvVCa36a4LrNOoeQn930Ay15VhQ8xKBIta/IQY42e2RFfzeiN karri@sanxion
```

# Repositorion kloonaaminen omalle koneelle
Tämä tehdään vain kerran kurssin aluksi. Olet saanut itsellesi linkin github-classroomiin, joka luo sinulle automaattisesti repositoryn. Valitse oma nimesi listasta.

1. Avaa GitBash hakemistoon jonka alle haluat tehtäväkansion. Tämä onnistuu klikkaamalla oikealla hiirennapilla hakemistoa Windows Explorerissa ja valitsemalla "Avaa GitBash tässä."
2. kirjoita komento ```git clone "oma repository, joka löytyy Code napin takaa GitHubista" esim. git@github.com:Gradia-Ohjelmistokehitys-k2022/unittests-pohja.git```

# Uusien tehtävänantojen hakeminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet main haarassa (branch), ja että sinulla ei ole avoimia muutoksia (jotka näkyvät punaisena tai vihreänä). Mikäli niitä on, tallenna ne ensin komennoilla ```git add .```, ```git commit -m "Muutokset talteen."```.
2. <mark>Tämä tehdään vain kerran.</mark> Lisätään alkuperäinen pohja haettavaksi seuraavalla komennolla, jos muutoksia materiaaleihin tulee.```git remote add upstream https://github.com/Gradia-Ohjelmistokehitys-k2022/Tiedostojen-kasittely-pohja```
3. Haetaan uusin versio upstreamista ``git pull upstream main --allow-unrelated-histories`` --allow-unrelated-histories voi ratkaista githubclassroomiin liittyviä ongelmia.
4. Jos merge conflicteja tulee, niin ne ratkotaan :) Esim. visual studio 2022 on helppo työkalu confliktien ratkomiselle.


# Oman työn palauttaminen
Kaikki tämä tehdään GitBashissä harjoitustehtävän hakemistossa.
1. ```git status``` - tarkista että olet omassa haarassa (branch), ja että sinulla ON avoimia muutoksia (jotka näkyvät punaisena).
2. ```git add .```
3. ```git status``` - tarkista että muutokset näkyvät nyt vihreinä.
4. ```git commit -m "Tehtävän <se ja se> palautus."``` - laita palauttamasi tehtävän nimi ja/tai numero kommenttiin.
5. ```git push``` 

# Muita hyödyllisiä komentoja GitBashissä

## ```cd```
Siirtyy toiseen hakemistoon, esim. ```cd 00_Hevonen``` siirtyy hakemistoon ```00_Hevonen```

## ```ls```
Listaa nykyisen hakemiston sisällön, eli tässä hakemistossa olevat tiedostot ja hakemistot.

## ```git status```
Kertoo missä haarassa (branch) olet, ja mitä tiedostoja olet muokannut (näkyy punaisena), mitkä on merkitty (staged) lisättäväksi repositorioon (näkyy vihreänä). Lisäksi komento kertoo onko oma kopiosi haarasta samalla tasolla kuin GitHub palvelimella oleva, vai onko sinulla paikallisia muutoksia joita et ole vielä työntänyt (push) palvelimelle.

## ```git log```
Listaa nykyisen haarasi (branchin) viimeisimmän version, sekä kaikki sitä suoraan edeltävät versiot.

## ```git log --graph --all --decorate```
Piirtää konsoliin graafin koko repositorion sisällöstä. Kaikkien haarojen kaikki versiot yhtenä (isona) tekstigrafiikkakuvana.

## Materiaali
Kurssin materiaali on lisensoitu Creative Commons BY-NC-SA 4.0 -lisenssillä, joten voit käyttää ja levittää sitä vapaasti.
