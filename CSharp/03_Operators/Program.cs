namespace _03_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazım Prensipleri
            /* Yazılımda yazma prensipleri vardır.
             * CamelCase=adSoyad;
             * SnakeCase=ad_soyad;
             * PascalCase=AdSoyad;
             * UpperCase=ADSOYAD;
             * LowerCase=adsoyad;
             * 
             * Programlama yapılarında tanımlanan yapılar ingilizce karakterleri uygun olmalıdır 
             * ***Hatalı Yazımlar****
             * 1sayı,ad soyad,ad?soyad,ad!soyad,?adSoyad,!adsoyad,ad-soyad
             * 
             * Doğru tanımlar
             * sayi1,adSoyad,ad_soyad,adsoyad_,_adsoyad
             * 
             * değişken vb.yapılarda kullanmamamız
             * gereken karakterler(İ,ı,ğ,ç,ş,ö,ü) vb yapılar kullanılmamalıdır.
             * fakat "bu alanda istediğimiz gibi yazabiliriz"

             */
            #endregion

            #region Operatörler 
            /* Aritmatik Operatörler
             * Toplama +
             * Çıkartma -
             * Çarpma *
             * Bölme /
             * Mod % mod bir sayının bölümünden kalan değerdir.
            */
            /* Atama Operatörleri
             * = Atama operatörü sağdaki değeri soldaki değişkene atar.
             * += Var olan değerin üstüne ekleme 
             * -= Var olan değeri azaltma
             * *= Var olan değeri çarpma
             *  /= Var olan değeri bölme
             *  .Erişim operatörü
             *  ++ bir artırma
             *  -- bir azaltma
            
             */
            #region Atama operatörleri
            //int sayi = 10;
            //Console.WriteLine(sayi);
            //sayi += 6;
            //Console.WriteLine(sayi);
            //sayi -= 3;
            //Console.WriteLine(sayi);
            //sayi *= 9;
            //Console.WriteLine(sayi);
            //sayi /= 8;
            //Console.WriteLine(sayi);

            //int sayi = 10;
            ////Console.WriteLine(sayi - 5);
            ////Console.WriteLine(sayi+10);
            //sayi = 30;//Burası günceller
            //Console.WriteLine(sayi);
            //int sayi2 = 10;
            //sayi2 += 30;//Burası var olan değere ekleme yapar.
            //Console.WriteLine(sayi2);
            //Console.WriteLine();//. ile erişebiliriz.
            //int sayi = 10;
            //sayi++;
            //sayi++;
            //sayi--;
            //Console.WriteLine(sayi);
            //int a = 5;
            //int b = ++a;
            //int c = a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            #endregion

            /*Karşılaştırma operatörleri 
             * Karşılaştırma operatörleri daima true veya false değer dönderir.
             * > Büyüktür
             * < Küçüktür
             * >= Büyük eşittir.
             * <=Küçük eşittir.
             * == Eşittir.
             * != eşit değildir.
             * ! değil zıt yapıda çalışır 
             
             */
            #region Karşılaştırma örnekleri
            //int sayi = 10;
            //int sayi2 = 5;
            //bool dogru = false;

            //bool sonuc = sayi > sayi2;
            //bool sonuc2 = sayi < sayi2;
            //bool sonuc3 = sayi >= sayi2;
            //bool sonuc4 = sayi <= sayi2;
            //bool sonuc5 = sayi != sayi2;
            //bool sonuc6 = sayi == sayi2;
            //Console.WriteLine(sonuc);//T
            //Console.WriteLine(sonuc2);//F
            //Console.WriteLine(sonuc3);//T
            //Console.WriteLine(sonuc4);//F
            //Console.WriteLine(sonuc5);//T
            //Console.WriteLine(sonuc6);//F
            //Console.WriteLine(!dogru);//örneğin:Açıksa kapat kapalıysa aç


            #endregion
            /* Mantıksal operatörler
             * And(ve)&& or(veya)||
             * Birden fazla koşul durumunda kullanılan mantıksal ifadeler
             * True 1 false 0
             * Ve && matematik de çarpma işlemine benzer 
             * başlangıç  bitiş  sonuc
             *    0         1      0
             *    1         0      0
             *    1         1      1
             *    0         0      0
             *    
             *    
             * Or(veya) || matematik de toplama işlemine benzer
             *    0        1       1
             *    1        0       1
             *    0        0       0
             *    1        1       1

           */
            #region Mantıksal örnekleri
            //int sayi = 10;
            //int sayi2 = 10;
            //int sayi3 = 5;
            //bool cevap = sayi > sayi3 && sayi >= sayi2;
            //bool cevap2 = sayi < sayi3 && sayi == sayi2;
            //bool cevap3 = sayi == sayi3 && sayi2 == sayi3;
            //bool cevap4 = sayi3 <= sayi2 && sayi >= sayi3;
            //Console.WriteLine(cevap);//T
            //Console.WriteLine(cevap2);//F
            //Console.WriteLine(cevap3);//F
            //Console.WriteLine(cevap4);//T
            //bool cevap5 = sayi > sayi3 || sayi >= sayi2;
            //bool cevap6 = sayi < sayi3 || sayi >= sayi2;
            //bool cevap7 = sayi == sayi3 || sayi2 == sayi3;
            //bool cevap8 = sayi3 <= sayi2 || sayi >= sayi3;
            //Console.WriteLine("|| örneği");
            //Console.WriteLine(cevap5);//T
            //Console.WriteLine(cevap6);//T
            //Console.WriteLine(cevap7);//F
            //Console.WriteLine(cevap8);//T
            #endregion
            #endregion

            /*Kısa yol tuşları                                              
             * cw+tab Console.WriteLine();                                  
             * Ctrl+K+C Yorum satırı                                        
             * Ctrl+K+U Yorumsatırından çıkar                               
             * Ctrl+D imlecin olduğu satırı bir alt satıra kopyalar         
             * Ctrl+Z Geri alma                                             
             * Ctrl+Y ileri alma                                            
             * Alt+shift+Yukarı aşağı yön tuşu birden fazla imleç oluşturma 
             * Ctrl+A tüm sayfayı seç
             * Ctrl+K+D Sayfayı düzenle
             * Ctrl+L imlecin olduğu satırı siler
             * Ctrl+C Kopyala
             * Ctrl+V yapıştır
             * Ctrl+S kaydet
             * End satır sonuna git
             * Home satır başına git
             * shift+end imlecteki satırı seçer
             * Ctrl+B build etme
             * Ctrl+F search
             * Ctrl+H değiştirme
             * Ctrl+G Satır yapısı

            
            
            */
            #region Kısayollar
            /*
                Visual Studio
Keyboard shortcuts
Code editing
Ctrl+ Space Complete word
Ctrl + Shift + Space Show signature help
Alt + ↑ / ↓ Move line up / down
Ctrl + D Duplicate line
Ctrl + Shift + L Delete line
Ctrl + Enter Insert line below
Ctrl + Shift + Enter Insert line above
Ctrl + ↑ / ↓ Scroll line up / down
Ctrl + PgUp / PgDn Scroll page up / down
Shift + mouse wheel Scroll page horizontally
Ctrl + / Toggle line comment
Ctrl + Shift + / Toggle block comment
Ctrl + K + D Format document
Ctrl + K + F Format selection
Alt + / Ask Copilot (inline chat)
Ctrl + E + W Toggle word wrap
Ctrl + R + W Toggle view whitespace
Shift + Alt + L + S Sort lines
Shift + Alt + L + J Join lines
Search and replace
Ctrl + F Find
Ctrl + H Replace
Ctrl + Shift + F Find in files
Ctrl + Shift + H Replace in files
F8 / Shift F8 Go to next / previous error
Refactoring
Ctrl + . or Alt + Enter Show quick actions
Ctrl + R + M Extract method
Ctrl + R + I Extract interface
Ctrl + R + R Rename
Ctrl + R + G Remove and sort usings
Ctrl + K + E Code cleanup
Ctrl + K + S Surround with (if, try, etc.)
Shift + Alt + L + S Sort lines
Shift + Alt + L + J Join lines
Navigation
Ctrl + Q or Ctrl + Shift + P Feature search
Ctrl + T Code search
Ctrl + G Go to line
F8 / Shift + F8 Go to next / prev error
F12 Go to definition
Alt + F12 Peek definition
Ctrl + F12 Go to implementation
Shift + F12 Find all references
Alt + Home Go to base class
Ctrl + - / Ctrl + Shift - Navigate backward / forward
Ctrl + Shift + backspace Go to last edit location
Ctrl + Shift + ↑ / ↓ Go to next / prev reference
Ctrl + K + K Toggle bookmark
Ctrl + K + N/P Go to next / prev bookmark
Ctrl + K + L Clear all bookmarks
Debugging
F5 Start/continue debugging
Shift + F5 Stop debugging
Ctrl + F5 Start without debugging
F9 Toggle breakpoint
Ctrl + Shift + F9 Clear all breakpoints
F10 Step over
F11 Step into
Shift + F11 Step out
Ctrl + Alt + P Attach to process…
Shift + Alt + P Reattach to process
Alt + F2 Launch profiler
Shift + Alt + F2 Relaunch profiler
Multi caret and selection
Ctrl + Alt + mouse click Insert caret
Shift + Alt + . Insert next matching caret
Shift + Alt + ; Insert all matching carets
Shift + Alt + , Remove last caret
Shift + Alt + / Move last caret down
Shift +Alt + ↑ / ↓ Column (box) selection
Alt + drag mouse Column (box) selection
Shift + Alt = / - Expand / collapse selection
Projects and solutions
Ctrl + Shift + N New project
Ctrl + Shift + O Open project
Ctrl + B Build selection
Ctrl + Shift + B Build solution
Ctrl + Shift + A Add new item
Shift + Alt + A Add existing item
Shift + F2 Quick add item
Alt + Enter Properties
File management
Ctrl + N New file
Ctrl + O Open file
Ctrl + Shift + S, Save all
Ctrl + Alt + PgUp / PgDn Go to document on left / right
Ctrl + F4 Close tab
Ctrl + K + Z Restore closed tabs
Ctrl + [ + S Reveal active file in Explorer
Ctrl + TAB Cycle through tabs
F7 / Shift + F7 Toggle designer and code view
F4 Properties
Windows and display
Shift + Alt + Enter Toggle full screen
Ctrl + dblclick on window Toggle last dock/float location
Ctrl + Alt + 1-9 Switch saved window layout
Shift + ESC Close active tool window
Ctrl + Alt + L Activate Solution Explorer
Ctrl + \ + C Activate GitHub Copilot Chat
Ctrl + \ + E Activate Error List
Ctrl + Alt + O Activate Output window
ESC Set focus on editor
Git
Alt + G + C Git Changes window
Alt + G + M Git Repository window
Ctrl + Alt + F3 Branch picker
Ctrl + Alt + F4 Repository picker
Ctrl + E + C Git actions menu
Ctrl + Enter Commit
Unit testing
Ctrl + E + T Test Explorer
Ctrl + R + A Run all tests
Ctrl + R + L Repeat last run
Ctrl + R + U Run until failure
Ctrl + R + F Run failed tests
Ctrl + R + N Run not run tests
Ctrl + R + Del Clear all results
            */
            #endregion

        }
    }
}
