# Tim Squadra
---
# e-Dnevnik

### Članovi tima:
- Haris Palić :grinning:
- Tarik Pašalić :suspect:
- Ramiz Zaketović :cop:

---

## Opis Teme

Kako sve više ulazimo u svijet gdje su informacije na dohvat ruke, tako se stvorila i potreba za jednostavnijim te bržim pristupom informacijama. 

**e-Dnevnik** :blue_book: je razvijen kako za potrebe nastavnika/profesora tako i za roditelja i učenika. Omogućava roditelju i učeniku pregled ocjena, uvid u njegove izostanke, bilješke te druge informacije, a nastavniku/profesoru olakšava unos ocjena i prisustva te pojednostavljuje ispravke u slučaju greške.

---

## Procesi

#### Registracija i prijava
*Nastavnika/profesora*, *roditelja* i *učenika* registruje *administrator* sistema. Prilikom registracije dodjeljuje im se jednistveno korisničko ime i lozinka. Prilikom prijave, svi akteri imaju mogućnost promjene lozinke. *Nastavnik/profesor* nakon prijave biraa razred te odjeljenje.

#### Unos ocjena, prisustva i napomena
*Nastavnik/profesor* nakon prijave unosi ocjene *učenika*, prisustvo *učenika* ili napomenu o *učeniku*.  U slučaju unosa napomene, sistem *nastavniku/profesoru* nudi opciju obavještavanja *roditelja* putem maila. U slučaju unosa X (moguće mijenjati u postavkama) negativnih ocjena ili Y neopravdanih izostanaka, sistem automatski obavještava *roditelja* putem maila.

#### Unos predmeta
*Nastavnik/profesor* unosi podatke o svom predmetu. Sistem nudi i mogućnost izmjene unesenih podataka.

#### Pregled ocjena, prisustva i napomena
*Učenik* i *roditelj* nakon prijave imaju uvid u stanje *učenika* (ocjene i prisustvo). *Roditelj* može izabrati opciju da pravda neopravdane izostanke ( ne više od ukupno X neopravdanih izostanaka), nakon čega sistem obavještava *nastavnika/profesora*. *Nastavnik/profesor* bira da li će opravdati neopravdane izostanke. U slučaju da odbije opravdanje, sistem obavještava *roditelja* o neprihvaćanju opravdanja za izostanke. *Roditelj* ima opciju pregleda napomena.

#### Kreiranje izvještaja
Nakon prijave, *nastavnik/profesor* odabire opciju kreiranja izvještaja. Može se odabrati izvještaj za cijeli razred, za cijeli predmet ili za pojedinačnog *učenika*. 

---

## Funkcionalnosti

* Mogućnost unosa ocjene učenika
* Mogućnost unosa prisustva učenika
* Mogućnost unosa napomene učenika
* Mogućnost unosa predmeta i opisa predmeta
* Mogućnost prijave u sistem sa različitim privilegijama
* Mogućnost obavještavanja roditelja putem maila
* Mogućnost pregleda ocjena i prisustva učenika (roditelj/učenik)
* Mogućnost pregleda podataka po svim razredima (nastavnici/profesori)
* Mogućnost kreiranja izvještaja

---

## Akteri

**Administrator** – Osoba koja registruje ostale aktere, resetuje lozinke te održava sistem
**Nastavnik/profesor** – Osoba koja dodaje predmete, upisuje ocjene, prisustvo i napomene
**Roditelj** – Osoba koja ima uvid u ocjene, prisustvo i napomene učenika te može primati obavještenja o aktivnostima vezanih za učenika (disciplinske mjere i slično)
**Učenik** – Osoba koja ima uvid u svoje ocjene i prisustvo
