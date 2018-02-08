# Netacademia .NET praktikák haladóknak tanfolyam

https://netacademia.hu/Tanfolyam/net-praktikak-haladoknak

Gyakorlatorientált tanfolyamunkon egy valós webalkalmazás írása közben ismerkedhetsz meg a .NET keretrendszer és a Visual Studio sok-sok hasznos kiegészítõjével. A tematika számos olyan technológiát egybegyûjt, amelyek desktop alkalmazások készítése közben is roppant hasznosak lehetnek. Fõleg olyan apróságok összességét mutatjuk be, melyekre fontosságuk ellenére általában nem nagyon szánunk idõt. A .NET fejlesztés annyira összetetté vált napjainkra, hogy a programozók szinte fejben sem tudják tartani a sok különleges szolgáltatást, melyeket épp hogy munkájuk megkönnyítésére hoztak létre a redmondi fiúk. A nagy rohanásban pedig sajnos minimális az esély arra, hogy valaki egymaga átrágja magát ezeken.

## (Web) WebGrease, WebOptimiaztion, Bundling
Átnézzük a stíluslapok és script fájlok belinkelési problémáit, szószátyár mivoltukat. Ezek mindennapos fejlesztõi kihívások, bár gyakran megfeledkezünk róluk. Most megismerkedünk egy elegáns megoldással az egymástól függõ scriptek, stíluslapok egyszerû csomagolására és tömörítésére.

## (Any) Azure Storage, CloudClient, SAS, REST API - Upload from JS
Röviden bemutatom a Windows Azure management felületét. A madártávlati áttekintés után azonban az Azure Storage-ra koncentrálunk. A sajátságos fájlszervert megszólítjuk desktop alkalmazásból, web szerverrõl és HTML lapról Javascript segítségével. Megvizsgáljuk, hogyan lehet jogosultsághoz kötni a fájlok elérését olvasásra vagy akár írásra.

## (Any) TFS in the cloud, SCORM basics
Be kell vallanom, hogy a közelmúltig a Subversion volt a bejáratott, kedvenc verziózóm. Most azonban ingyenesen használható a Visual Studio szervere egy cloud szolgáltatásként. És nem csak verziózást szolgáltat. Megmutatom, hogy lehet elkezdeni használni, beszélünk róla miért jó ez nekünk. A verziózáson kívül megmutatom még a munkaszervezõ felületet is. Ennek kapcsán – hogy értelmet nyerjen ez a szolgáltatás – egy gyorstalpaló SCORM alaptanfolyamot is besûrítek.

## (Any) Unittest, Mocking. Auto build and deploy
Az elõzõ alkalom folytatásaként még két roppant hasznos szolgáltatást mutatok be a Team Foundation Services-ben. Az egyik az automatizált tesztek végrehajtása, a másik a Windows Azure-ral való együttmûködés (deploy). Az automatizált teszt végrehajtás apropóján a szokásosnál egy picit mélyebbre nyúlunk a unittesztelésbe. Pár fontos, gyakran fejtörést okozó tesztelési problémát körbejárunk, mint pl. a többszálú kódok tesztelési lehetõsége vagy a tesztek szeparálhatósága a tesztelni nem kívánt részektõl.

## (Any) Visual Studio Nuget Manager Console
A NuGetek önmagukban is nagyon hasznos lények, de most a velük érkezett konzolra koncentrálunk. Ez ugyanis valójában egy PowerShell parancssor. És PowerShellbõl akár a VisualStudiot is irányíthatjuk.

## (Any) Code scaffolding, T4 templates
Egy két NuGet használatával olyan kódgenerátorokhoz juthatunk, amik megnövelik hatékonyságunkat – vagy ha úgy jobban tetszik, elvégzik a piszkos munkát helyettünk. Ehhez felhasználjuk a PowerShell parancssort és megmutatom a T4 template használatát. A végén testre is szabunk saját szájízünk szerint egy kódgenerátort.

## (Any) NuGet csomag készítése
NuGet csomagok nem csak arra jók, hogy letöltögessük, amit mások készítettek. Arra is nagyon jól használhatók, hogy saját eszköztárat tartsunk fenn. Ezt az eszköztárat, aztán ha szeretnénk, megoszthatjuk a világgal, de használhatjuk õket kizárólag saját környezetben is. A NuGet készítés rákényszerít minket a még modulárisabb gondolkodásra, ami pedig nagy segítség a kód újrahasznosításában.

## (Any) Codefirst DB versioning
A Microsoft aktuális adatelérõ keretrendszere (Entity Framework) lehetõséget ad az adatbáziskezelés több oldalról való megközelítésére. Bár mindegyiknek megvan a saját elõnye és helye az univerzumban, a magam részérõl, amikor csak lehet, a Codefirst nevû irányzatot választom. Néha olyan problémák is megoldhatók vele, amire nem is számítottunk. Itt most az adatbázisfejlesztés közbeni sémaváltozásainak verziózott követésérõl fogok beszélni. Kipróbáljuk és megbeszéljük, mikor használható, és mikor nem.

## (Any) Multiple datacontexts
Az Entity Framework DataContext szemlélete teszi lehetõvé a Framework számára, hogy számos automatizmussal segítse munkánkat. Például kód- vagy adatbázis generálás, verziófigyelés stb. Ehhez azonban egy olyan Datacontext létrehozása szükséges, amiben minden adatbázis objetumunk teljes terjedelmében megtalálható. Megmutatom, hogy lehet ezt úgy megoldani, hogy az alkalmazásunkban minden egyes részfeladat megkapja a saját DataContext példányát, amiben csak annyi objektum és csak annyi tulajdonsággal szerepel, ami az adott feladathoz szükséges. Mindezt úgy, hogy továbbra is egy adatbázisból dolgozunk, és nem veszítjük el az EF elõnyeit.

## (Web) Sass, Less, CoffeScript, TypeScript
Négy olyan technológia (igazából csak kettõ) amirõl tanfolyamon még sosem beszéltem. Igazából nem is különálló technológiák, hanem két meglévõ webes nyelv fölé húzott, programozó barát réteg. Megnézzük, hogy lehet karbantartható módon, strukturáltan stíluslapot illetve JavaScript kódot írni.

## (Web) JQuery Plugin írása és az unobtrusive
Talán a JQuery az, ami eddig a legtöbbet segített enyhíteni a JavaScriptben való fejlesztés borzalmait. Hogy maximálisan ki tudjuk használni az elõnyeit, megnézzük, hogyan lehet bõvíteni. Egy füst alatt megfejtjük az unobtrusive szó jelentését és jelentõségét is.

## (Web) Knockout.js
Ez a JavaScript könyvtár lehetõvé teszi az adatkötést html és JavaScript közt. Majdnem olyan szinten mint ahogy azt a XAML környezetben megszokhatták akik ilyet használtak. Így aztán nem meglepõ hogy az MVVM módszertan is alkalmazható kliens oldalon tisztán JavaScript és HTML környezetben is. Nem véletlen hívják KO-nak.

## (Any) MEF2
Megnézzük hogyan lehet a new kulcszó nélkül interface alapon felépíteni a futsidejû objektumhierarchiánkat. Durván flexibilissé téve így alkalmazásunkat.

## (Web) ClaimBased auth mvc4, asp.net 4.5
ASP.Net-ben az authentikáció sosem volt gyenge láncszem. Sem biztonsági sem pedig programozhatósági szempontból. Az elmúlt egy, másfél évben azonban a piramis csúcsára került Claim based authentikáció megvalósítása sajnos nem volt olyan egyszerû és magától értetõdõ, mint ahogy azt eddig megszoktuk. Mostanra az lett. Így gyerekjáték az OpenId, Gmail, Facebook, Yahoo vagy LiveId alapú bejelentkezés megvalósítása.

## (Web) Saját megoldások 1 - Nyelvesítési megoldás
Több nyelven beszélõ weblap készítése visszatérõ probléma. Sajnos az MVC-ben nem kapunk konyhakész megoldást. Megmutatok pár lehetõséget és a végén közösen elkészítünk egy kellemesen használható MVC barát resource kezelõt.

## (Web) Saját megoldások 2 - Domain discriminator, CacheTrick, Repository elõnyei
A szövegek adatbázsiban tárolása önnmagában még nem jelent többnyelvûséget. Ehhez a szövegeket több változatban is tárolni kell. Ez esetben viszont különbséget kell tudni tenni a vaáltozatok közt lekérdezéskor. Ezt valósítjuk meg egy elegáns módszerrel.

## (Web) Saját megoldások 3 - Levélküldés szerkeszthetõ sablon alapján
Regisztrációs levél, elfelejtett jelszó, megrendelés visszaigazolás. Ezekhez hasonló automata levelek küldése nem ritkaság. Tartalmuk viszont gyakran változik az üzemeltetõ, megrendelõ igényei szerint. A legegyszerûb, ha a tartalom szerkesztését rá bízzuk. Ehhez készítünk el egy megoldást, amivel a weblapon keresztül szabhatók tester az automata levelek.

## (Web) Saját megoldások 4 - A kötelezõ pipa esete és a bool különbözõ megjelenési formái
Az MVC bõvítés gyöngyszemei: saját validator és saját megjelenítõ ill. szerkesztõ sablonok