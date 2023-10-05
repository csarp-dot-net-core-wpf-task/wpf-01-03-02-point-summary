# wpf-01-03-02-point-summary
## Grid nézet és adatkötés.

Készítse WPF alkalmazást, amely egy felvételiző felvételi pontszámát kéri be és számítja ki!  
A WPF alkalmazás váza legyen a következő  

![Minta](https://github.com/csarp-dotnet-core-wpf-task/wpf-01-04-02-point-summary/blob/main/minta.jpg)

A nézetet egészítse ki a felvételiző öszpontszámának megjelenítésével!

Nyissa meg a Felveteli PointSummary.cs állományt!  
Fejezze be a Name, MathScore, NativeLanguageScore és TotalScore tulajdonságok kódját!  

Használja fel a model mappába lévő PointSummary osztályt:  
Az első szövegbeviteli mezőhöz kösse a Name tulajdonsághoz. Az értéket a felhasználó adja meg!  
A második szövegbeviteli mezőt kösse a MathScore tulajdonsághoz. Az értéket a felhasználó adja meg!  
A harmatik szövegbeviteli mezőt kösse a NativeLanuageScore tulajdonsághoz. Az értéket a felhasználó adja meg!  
A negyedik szövegbeviteli mezőt kösse a AverageScore tulajdonsághoz. Ez az érték számított adat, a felhasználó nem módosíthatja.  
Az ötödik szövegbeviteli mezőt kösse a TotalScore tulajdonsághoz. Ez az érték számított adat, a felhasználó nem módosíthatja.  
Az hatodik szövegbeviteli mezőt kösse a Score tulajdonsághoz. Ez az érték számított adat, a felhasználó nem módosíthatja.  

Továbbfejlesztés (Mindenkinek kötelező) 
Fejlessze tovább úgy a PointSummary osztályt egy szöveges tulajdonsággal, amely „Felvi Ferenc felvételt nyert!” vagy a „Felvi Ferenc nem lett felvéve!” üzenetet adja vissza. Ha az átlagpontszám 70-nél nagyobb akkor vették fel! 
