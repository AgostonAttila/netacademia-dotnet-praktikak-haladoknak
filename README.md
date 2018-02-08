# Netacademia .NET praktik�k halad�knak tanfolyam

https://netacademia.hu/Tanfolyam/net-praktikak-haladoknak

Gyakorlatorient�lt tanfolyamunkon egy val�s webalkalmaz�s �r�sa k�zben ismerkedhetsz meg a .NET keretrendszer �s a Visual Studio sok-sok hasznos kieg�sz�t�j�vel. A tematika sz�mos olyan technol�gi�t egybegy�jt, amelyek desktop alkalmaz�sok k�sz�t�se k�zben is roppant hasznosak lehetnek. F�leg olyan apr�s�gok �sszess�g�t mutatjuk be, melyekre fontoss�guk ellen�re �ltal�ban nem nagyon sz�nunk id�t. A .NET fejleszt�s annyira �sszetett� v�lt napjainkra, hogy a programoz�k szinte fejben sem tudj�k tartani a sok k�l�nleges szolg�ltat�st, melyeket �pp hogy munk�juk megk�nny�t�s�re hoztak l�tre a redmondi fi�k. A nagy rohan�sban pedig sajnos minim�lis az es�ly arra, hogy valaki egymaga �tr�gja mag�t ezeken.

## (Web) WebGrease, WebOptimiaztion, Bundling
�tn�zz�k a st�luslapok �s script f�jlok belinkel�si probl�m�it, sz�sz�ty�r mivoltukat. Ezek mindennapos fejleszt�i kih�v�sok, b�r gyakran megfeledkez�nk r�luk. Most megismerked�nk egy eleg�ns megold�ssal az egym�st�l f�gg� scriptek, st�luslapok egyszer� csomagol�s�ra �s t�m�r�t�s�re.

## (Any) Azure Storage, CloudClient, SAS, REST API - Upload from JS
R�viden bemutatom a Windows Azure management fel�let�t. A mad�rt�vlati �ttekint�s ut�n azonban az Azure Storage-ra koncentr�lunk. A saj�ts�gos f�jlszervert megsz�l�tjuk desktop alkalmaz�sb�l, web szerverr�l �s HTML lapr�l Javascript seg�ts�g�vel. Megvizsg�ljuk, hogyan lehet jogosults�ghoz k�tni a f�jlok el�r�s�t olvas�sra vagy ak�r �r�sra.

## (Any) TFS in the cloud, SCORM basics
Be kell vallanom, hogy a k�zelm�ltig a Subversion volt a bej�ratott, kedvenc verzi�z�m. Most azonban ingyenesen haszn�lhat� a Visual Studio szervere egy cloud szolg�ltat�sk�nt. �s nem csak verzi�z�st szolg�ltat. Megmutatom, hogy lehet elkezdeni haszn�lni, besz�l�nk r�la mi�rt j� ez nek�nk. A verzi�z�son k�v�l megmutatom m�g a munkaszervez� fel�letet is. Ennek kapcs�n � hogy �rtelmet nyerjen ez a szolg�ltat�s � egy gyorstalpal� SCORM alaptanfolyamot is bes�r�tek.

## (Any) Unittest, Mocking. Auto build and deploy
Az el�z� alkalom folytat�sak�nt m�g k�t roppant hasznos szolg�ltat�st mutatok be a Team Foundation Services-ben. Az egyik az automatiz�lt tesztek v�grehajt�sa, a m�sik a Windows Azure-ral val� egy�ttm�k�d�s (deploy). Az automatiz�lt teszt v�grehajt�s aprop�j�n a szok�sosn�l egy picit m�lyebbre ny�lunk a unittesztel�sbe. P�r fontos, gyakran fejt�r�st okoz� tesztel�si probl�m�t k�rbej�runk, mint pl. a t�bbsz�l� k�dok tesztel�si lehet�s�ge vagy a tesztek szepar�lhat�s�ga a tesztelni nem k�v�nt r�szekt�l.

## (Any) Visual Studio Nuget Manager Console
A NuGetek �nmagukban is nagyon hasznos l�nyek, de most a vel�k �rkezett konzolra koncentr�lunk. Ez ugyanis val�j�ban egy PowerShell parancssor. �s PowerShellb�l ak�r a VisualStudiot is ir�ny�thatjuk.

## (Any) Code scaffolding, T4 templates
Egy k�t NuGet haszn�lat�val olyan k�dgener�torokhoz juthatunk, amik megn�velik hat�konys�gunkat � vagy ha �gy jobban tetszik, elv�gzik a piszkos munk�t helyett�nk. Ehhez felhaszn�ljuk a PowerShell parancssort �s megmutatom a T4 template haszn�lat�t. A v�g�n testre is szabunk saj�t sz�j�z�nk szerint egy k�dgener�tort.

## (Any) NuGet csomag k�sz�t�se
NuGet csomagok nem csak arra j�k, hogy let�lt�gess�k, amit m�sok k�sz�tettek. Arra is nagyon j�l haszn�lhat�k, hogy saj�t eszk�zt�rat tartsunk fenn. Ezt az eszk�zt�rat, azt�n ha szeretn�nk, megoszthatjuk a vil�ggal, de haszn�lhatjuk �ket kiz�r�lag saj�t k�rnyezetben is. A NuGet k�sz�t�s r�k�nyszer�t minket a m�g modul�risabb gondolkod�sra, ami pedig nagy seg�ts�g a k�d �jrahasznos�t�s�ban.

## (Any) Codefirst DB versioning
A Microsoft aktu�lis adatel�r� keretrendszere (Entity Framework) lehet�s�get ad az adatb�ziskezel�s t�bb oldalr�l val� megk�zel�t�s�re. B�r mindegyiknek megvan a saj�t el�nye �s helye az univerzumban, a magam r�sz�r�l, amikor csak lehet, a Codefirst nev� ir�nyzatot v�lasztom. N�ha olyan probl�m�k is megoldhat�k vele, amire nem is sz�m�tottunk. Itt most az adatb�zisfejleszt�s k�zbeni s�mav�ltoz�sainak verzi�zott k�vet�s�r�l fogok besz�lni. Kipr�b�ljuk �s megbesz�lj�k, mikor haszn�lhat�, �s mikor nem.

## (Any) Multiple datacontexts
Az Entity Framework DataContext szeml�lete teszi lehet�v� a Framework sz�m�ra, hogy sz�mos automatizmussal seg�tse munk�nkat. P�ld�ul k�d- vagy adatb�zis gener�l�s, verzi�figyel�s stb. Ehhez azonban egy olyan Datacontext l�trehoz�sa sz�ks�ges, amiben minden adatb�zis objetumunk teljes terjedelm�ben megtal�lhat�. Megmutatom, hogy lehet ezt �gy megoldani, hogy az alkalmaz�sunkban minden egyes r�szfeladat megkapja a saj�t DataContext p�ld�ny�t, amiben csak annyi objektum �s csak annyi tulajdons�ggal szerepel, ami az adott feladathoz sz�ks�ges. Mindezt �gy, hogy tov�bbra is egy adatb�zisb�l dolgozunk, �s nem vesz�tj�k el az EF el�nyeit.

## (Web) Sass, Less, CoffeScript, TypeScript
N�gy olyan technol�gia (igaz�b�l csak kett�) amir�l tanfolyamon m�g sosem besz�ltem. Igaz�b�l nem is k�l�n�ll� technol�gi�k, hanem k�t megl�v� webes nyelv f�l� h�zott, programoz� bar�t r�teg. Megn�zz�k, hogy lehet karbantarthat� m�don, struktur�ltan st�luslapot illetve JavaScript k�dot �rni.

## (Web) JQuery Plugin �r�sa �s az unobtrusive
Tal�n a JQuery az, ami eddig a legt�bbet seg�tett enyh�teni a JavaScriptben val� fejleszt�s borzalmait. Hogy maxim�lisan ki tudjuk haszn�lni az el�nyeit, megn�zz�k, hogyan lehet b�v�teni. Egy f�st alatt megfejtj�k az unobtrusive sz� jelent�s�t �s jelent�s�g�t is.

## (Web) Knockout.js
Ez a JavaScript k�nyvt�r lehet�v� teszi az adatk�t�st html �s JavaScript k�zt. Majdnem olyan szinten mint ahogy azt a XAML k�rnyezetben megszokhatt�k akik ilyet haszn�ltak. �gy azt�n nem meglep� hogy az MVVM m�dszertan is alkalmazhat� kliens oldalon tiszt�n JavaScript �s HTML k�rnyezetben is. Nem v�letlen h�vj�k KO-nak.

## (Any) MEF2
Megn�zz�k hogyan lehet a new kulcsz� n�lk�l interface alapon fel�p�teni a futsidej� objektumhierarchi�nkat. Durv�n flexibiliss� t�ve �gy alkalmaz�sunkat.

## (Web) ClaimBased auth mvc4, asp.net 4.5
ASP.Net-ben az authentik�ci� sosem volt gyenge l�ncszem. Sem biztons�gi sem pedig programozhat�s�gi szempontb�l. Az elm�lt egy, m�sf�l �vben azonban a piramis cs�cs�ra ker�lt Claim based authentik�ci� megval�s�t�sa sajnos nem volt olyan egyszer� �s mag�t�l �rtet�d�, mint ahogy azt eddig megszoktuk. Mostanra az lett. �gy gyerekj�t�k az OpenId, Gmail, Facebook, Yahoo vagy LiveId alap� bejelentkez�s megval�s�t�sa.

## (Web) Saj�t megold�sok 1 - Nyelves�t�si megold�s
T�bb nyelven besz�l� weblap k�sz�t�se visszat�r� probl�ma. Sajnos az MVC-ben nem kapunk konyhak�sz megold�st. Megmutatok p�r lehet�s�get �s a v�g�n k�z�sen elk�sz�t�nk egy kellemesen haszn�lhat� MVC bar�t resource kezel�t.

## (Web) Saj�t megold�sok 2 - Domain discriminator, CacheTrick, Repository el�nyei
A sz�vegek adatb�zsiban t�rol�sa �nnmag�ban m�g nem jelent t�bbnyelv�s�get. Ehhez a sz�vegeket t�bb v�ltozatban is t�rolni kell. Ez esetben viszont k�l�nbs�get kell tudni tenni a va�ltozatok k�zt lek�rdez�skor. Ezt val�s�tjuk meg egy eleg�ns m�dszerrel.

## (Web) Saj�t megold�sok 3 - Lev�lk�ld�s szerkeszthet� sablon alapj�n
Regisztr�ci�s lev�l, elfelejtett jelsz�, megrendel�s visszaigazol�s. Ezekhez hasonl� automata levelek k�ld�se nem ritkas�g. Tartalmuk viszont gyakran v�ltozik az �zemeltet�, megrendel� ig�nyei szerint. A legegyszer�b, ha a tartalom szerkeszt�s�t r� b�zzuk. Ehhez k�sz�t�nk el egy megold�st, amivel a weblapon kereszt�l szabhat�k tester az automata levelek.

## (Web) Saj�t megold�sok 4 - A k�telez� pipa esete �s a bool k�l�nb�z� megjelen�si form�i
Az MVC b�v�t�s gy�ngyszemei: saj�t validator �s saj�t megjelen�t� ill. szerkeszt� sablonok