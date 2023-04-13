using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GitAlapok : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*
        - Repository
    
    Egy repository vagy r�viden repo egy projektet reprezent�l annak minden kor�bbi �llapot�val egy�tt. Git repo-t t�bbf�lek�pp hozhatunk l�tere:
    
    1. �jonnan l�trehozzuk egy megl�v� mapp�b�l, azt�n ezt a repository-t publik�lhatjuk egy git szerverre.
    2. Kl�nozhatunk megl�v� repository-t egy git szerverr�l.
- Kl�noz�s
    
    Kl�noz�s az a m�velet, amikor egy szerveren m�r l�tez� git. repository-b�l egy lok�lis m�solatot k�sz�t�nk.
    
- Stage
    
    Ha egy lok�lis repository-ban b�rmi v�ltoz�s t�rt�nik egy f�jlon: L�trej�n, t�rl�dik, m�dosul, akkor azt a git automatikusa �s nagyon gyorsan ��szreveszi�. Ekkor lehet�s�g�nk van ezt a f�jlt stage-elni. Ha egy f�jl stage �llapotban van, ez azt jelenti, hogy k�szen�ll arra, hogy �elments�k� a v�ltoz�st.
    
- Commit
    
    A Commit egy adott �llapot�t reprezent�lja a projekt�nknek. �rdemes a commit-ra �gy tekinteni, mint egy �checkpoint� vagy egy ment�s egy j�t�kban. Ha egyszer k�sz�tett�nk egy commit-ot, arra k�s�bb b�rmikor vissza�llhatunk. A commit parancs kiad�sakor a stage �llapotban l�v� f�jlok v�ltoz�sai ker�lnek ment�sre.
    
    A commit, azaz egy adagnyi v�ltoz�s ment�se a repository-nak csak a lok�lis verzi�j�n t�rt�nik meg. Ez a m�velet nem fog semmilyen v�ltoz�st eredm�nyezni a szerveren.
    
- Push
    
    A push m�velet kiad�s�val lehet egy aktu�lis lok�lis commit-okat. Felt�lteni a szerverre. 
    
- Fetch
    
    A fetch m�velettel lek�rhet�, hogy a szerveren t�rolt verzi�j�n a repository-nak van-e b�rmi olyan �j commit-ja, ami nincs m�g meg a mi lok�lis repo-nkban.
    
- Pull
    
    A pull m�velettel lehet a szerveren t�rolt repository �j commit-jait let�lteni a lok�lis repo-nkba.
    

K�t fajta repository-t tudunk l�trehozni, egyik a publikus �s m�sik a priv�t. A publikus repository-k b�rki sz�m�ra hozz� f�rhet�k, �m ez nem azt jelenti, hogy b�rki m�dos�tani is tud rajtuk. Ehhez extra jogosults�g kell.

A priv�t repository-k csak a felhaszn�l�k egy csoportja sz�m�ra el�rhet�: Ezek a projekt tulajdonosa, l�trehoz�ja �s minden olyan felhaszn�l� akinek a projektgazda jogot ad ehhez.

Javaslom, gyakorl�shoz nyugodtan haszn�ljatok publikus repository-kat.

### A GitHub

A GitHub egy weboldal, ami egyben a legn�pszer�bb online Git szerver szolg�ltat� is. Haszn�lat�val nem sz�ks�ges nek�nk egy git szervert telep�teni �s fenntartani.

Ingyenesen haszn�lhat� minden felhaszn�l� sz�m�ra�

- publikus repository-kra korl�tlanul.
- priv�t repository-k eset�n 15 gigabyte t�rhelyig.

Ha kifogyn�nk a priv�t repository helyb�l, akkor lehet k�s�bb magasabb fizet�s csomagra el�fizetni vagy a projektet m�s git szerverre migr�lni, de ett�l egyel�re nem kell f�lni.

A tov�bbiakat ezen szerver haszn�lat�val mutatom be. Javaslom mindenkinek, hogy haszn�lja b�tran a GitHub-ot most a tanul�s alatt �s ut�na is. Ehhez legel�sz�r mindenki regisztr�ljon egy fi�kot mag�nak az oldalon!

[GitHub: Let�s build from here](http://github.com/)

### Git szoftver telep�t�se

A git alapvet�en egy parancssori szoftver, de mi ezen leck�ben nem fogjuk megismerni a parancssoron kereszt�li haszn�lat�t. Helyette egy k�nyelmes asztali felhaszn�l�i fel�leten kereszt�l fogjuk el�rni a legf�bb funkci�it. Ett�l f�ggetlen�l a parancssori verzi�t mindenk�pp �rdemes telep�teni �s hossz�t�von legal�bb a legfontosabb parancsok megtanul�sa is javasolt.

A parancssori git innen t�lthet� le:

[Git - Downloads](https://git-scm.com/downloads)

A git-hez sz�mtalan asztali kliens alkalmaz�s haszn�lhat� k�l�nb�z� szint� funkcionalit�ssal. Ezek k�z�l mi most a GitHub saj�t szoftver�t, a GitHub Desktop-ot fogjuk haszn�lni.

A GitHub Desktop innen t�lthet� le:

[GitHub Desktop](https://desktop.github.com/)

Telep�ts�k a fenti szoftvereket, majd jelentkezz�nk be a GitHub Desktop alkalmaz�sba!

### Hozzunk l�tre egy repo-t!

K�t lehet�s�g�nk van repository-t l�trehozni.

1. Egyik m�dszer az, hogy a GitHub webes fel�let�n a szerveren hozunk l�tre egy �res repo-t, majd ut�na kl�nozzok azt, lok�lis m�solatot hozva l�tre bel�le.
    1. �j repot a GitHub weboldal�n bejelentkezve a nagy z�ld New felirat� gomb megnyom�s�val tudunk l�trehozni.
    2. Adjunk neki egy nevet �s ne v�ltoztassunk semmi egyebet a be�ll�t�sokon.


         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
