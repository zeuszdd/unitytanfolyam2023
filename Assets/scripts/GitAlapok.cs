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
    
    Egy repository vagy röviden repo egy projektet reprezentál annak minden korábbi állapotával együtt. Git repo-t többféleképp hozhatunk létere:
    
    1. Újonnan létrehozzuk egy meglévõ mappából, aztán ezt a repository-t publikálhatjuk egy git szerverre.
    2. Klónozhatunk meglévõ repository-t egy git szerverrõl.
- Klónozás
    
    Klónozás az a mûvelet, amikor egy szerveren már létezõ git. repository-ból egy lokális másolatot készítünk.
    
- Stage
    
    Ha egy lokális repository-ban bármi változás történik egy fájlon: Létrejön, törlõdik, módosul, akkor azt a git automatikusa és nagyon gyorsan “észreveszi”. Ekkor lehetõségünk van ezt a fájlt stage-elni. Ha egy fájl stage állapotban van, ez azt jelenti, hogy készenáll arra, hogy “elmentsük” a változást.
    
- Commit
    
    A Commit egy adott állapotát reprezentálja a projektünknek. Érdemes a commit-ra úgy tekinteni, mint egy “checkpoint” vagy egy mentés egy játékban. Ha egyszer készítettünk egy commit-ot, arra késõbb bármikor visszaállhatunk. A commit parancs kiadásakor a stage állapotban lévõ fájlok változásai kerülnek mentésre.
    
    A commit, azaz egy adagnyi változás mentése a repository-nak csak a lokális verzióján történik meg. Ez a mûvelet nem fog semmilyen változást eredményezni a szerveren.
    
- Push
    
    A push mûvelet kiadásával lehet egy aktuális lokális commit-okat. Feltölteni a szerverre. 
    
- Fetch
    
    A fetch mûvelettel lekérhetõ, hogy a szerveren tárolt verzióján a repository-nak van-e bármi olyan új commit-ja, ami nincs még meg a mi lokális repo-nkban.
    
- Pull
    
    A pull mûvelettel lehet a szerveren tárolt repository új commit-jait letölteni a lokális repo-nkba.
    

Két fajta repository-t tudunk létrehozni, egyik a publikus és másik a privát. A publikus repository-k bárki számára hozzá férhetõk, ám ez nem azt jelenti, hogy bárki módosítani is tud rajtuk. Ehhez extra jogosultság kell.

A privát repository-k csak a felhasználók egy csoportja számára elérhetõ: Ezek a projekt tulajdonosa, létrehozója és minden olyan felhasználó akinek a projektgazda jogot ad ehhez.

Javaslom, gyakorláshoz nyugodtan használjatok publikus repository-kat.

### A GitHub

A GitHub egy weboldal, ami egyben a legnépszerûbb online Git szerver szolgáltató is. Használatával nem szükséges nekünk egy git szervert telepíteni és fenntartani.

Ingyenesen használható minden felhasználó számára…

- publikus repository-kra korlátlanul.
- privát repository-k esetén 15 gigabyte tárhelyig.

Ha kifogynánk a privát repository helybõl, akkor lehet késõbb magasabb fizetõs csomagra elõfizetni vagy a projektet más git szerverre migrálni, de ettõl egyelõre nem kell félni.

A továbbiakat ezen szerver használatával mutatom be. Javaslom mindenkinek, hogy használja bátran a GitHub-ot most a tanulás alatt és utána is. Ehhez legelõször mindenki regisztráljon egy fiókot magának az oldalon!

[GitHub: Let’s build from here](http://github.com/)

### Git szoftver telepítése

A git alapvetõen egy parancssori szoftver, de mi ezen leckében nem fogjuk megismerni a parancssoron keresztüli használatát. Helyette egy kényelmes asztali felhasználói felületen keresztül fogjuk elérni a legfõbb funkcióit. Ettõl függetlenül a parancssori verziót mindenképp érdemes telepíteni és hosszútávon legalább a legfontosabb parancsok megtanulása is javasolt.

A parancssori git innen tölthetõ le:

[Git - Downloads](https://git-scm.com/downloads)

A git-hez számtalan asztali kliens alkalmazás használható különbözõ szintû funkcionalitással. Ezek közül mi most a GitHub saját szoftverét, a GitHub Desktop-ot fogjuk használni.

A GitHub Desktop innen tölthetõ le:

[GitHub Desktop](https://desktop.github.com/)

Telepítsük a fenti szoftvereket, majd jelentkezzünk be a GitHub Desktop alkalmazásba!

### Hozzunk létre egy repo-t!

Két lehetõségünk van repository-t létrehozni.

1. Egyik módszer az, hogy a GitHub webes felületén a szerveren hozunk létre egy üres repo-t, majd utána klónozzok azt, lokális másolatot hozva létre belõle.
    1. Új repot a GitHub weboldalán bejelentkezve a nagy zöld New feliratú gomb megnyomásával tudunk létrehozni.
    2. Adjunk neki egy nevet és ne változtassunk semmi egyebet a beállításokon.


         */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
