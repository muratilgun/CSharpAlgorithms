Big-O notasyonu = algoritmalarý karþýlaþtýrmamýzý saðlar.
Arama algoritmalarýný karþýlaþtýrma
1. Aranýlan öðe listenin ilk veya son elemaný olacak ise eðer, giriþ boyutu ne olursa olsun sadece ilk veya son elemanýný kontrol etmek
gerekiyor. 
- Bu yüzden sabit bir zamanýn O aldýðý söylenebilinir.
2. Aranýlan öðe listede bir yerdeyse ama listede yeri bilinmiyorsa,  her elemaný kontrol etmek gerekiyor. 
- Best case : aranýlan ilk öðenin olmasý
- Worst case : listede öðenin olmamasý bu her öðeyi kontrol etmek anlamýna geliyor.

çoðu algoritmada iyi durum ve kötü durum senaryo performans süreleri deðerlendirilir.

1. algoritmada best case : O(1) worst case: O(1) sabit süre
2. algoritmada best case : O(1) worst case: O(n) yada linear n giriþ boyutunu ifade eder(input) linear artýþ eðilimi

1. algoritmada öðenin olduðunu varsayýyoruz. best case ve worst case birbirini keser ayný süreyi ifade eder.
2. algoritmada bu varsayým yapýlmaz worst case de süre çok uzayacaktýr.

Diðer zaman karþýlaþtýrmalarý
- O(1) yada sabit zaman(constant)
- O(log(n)) yada logaritmik zaman
- O(n) yada linear zaman
- O(n²) yada üstsel zaman
- O(n!) yada faktöriyel zaman 
sabit zaman en verimli olanýdýr. n² en verimsiz olanýdýr.


Validation Algorithm Doðrulama algortimasý
Bir giriþ dizesinin olup olmadýðý doðrulanýr Belirli özelliklere veya niteliklere sahiptir.
Örneðin bir dizenin tamamamýnýn büyük harf olup olmadýðýný veya en az bir numara varmý kontrol eder. 
Daha sonra output olarak true veya false döner. 
Doðrulama Algoritmasý ile **Giriþ verilerinin bazý belirli özellikleri garanti edilebilir.**

string ifadeleri iþlemeden önce ortak bir formda normalleþtirmek yardýmcý olabilir.
Baþka bir seçenek ise giriþleri sýnýrlandýrmaktýr. Örneðin giriþ veri olarak sadece küçük harflerin alýnmasý gibi bunun içinde
validation algoritmasý ile herhangibir girdi türünü reddebiliriz.

Dize içerisinde veri aramak algoritma kurarken çok kullanýlan bir yöntemdir. Bir dizi verisi hakkýnda yapýlan varsayýmlara baðlý olarak,
algoritma çok  veya az verimli bir hale gelebilir.
Eðer gelen string deðer hakkýnda hiç birþey bilinmiyorsa, her karakteri tek tek kontrol etmek gerekecektir.
Aranýlan veriyi bulmak için dizenin karakterlerinin olduðunu biliyorsak ve çeþitli alfabetik sýralamayla algoritma optimize edilebilinir.

Linear search yada sequential search(sýralý arama)

Bir arama algoritmasýyla genellikle aramak gereken veriler girilir. Ve çýktý olarak true/false veya aranýlan veriyi daha fazla veriyle geri döndürülür.