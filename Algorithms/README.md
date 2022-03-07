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

Binary search ikili arama

Arama algoritmasýný optimize etmek için, veriler hakkýnda varsayýmlarda bulunmak gerekecektir.
Örneðin datanýn sýralý olduðunu biliyorsak, ortadan baþlayabilir daha sonra öðenin nerede olmaý gerektiðine göre dizinin baþýna veya sonuna doðru ilerlenebilir.
Böyle bir case de binary search kullanýlabilinir.
Binary search divide-and-conquer algoritmasýdýr. böl ve yönet, aramak için **her adýmda sahip olduðu eleman sayýsýný yarýya indirir**
Örneðin sýralý bir dizide {0,2,8,19,23,45,79}  45 numarasýný arýyorum. dizinin ortasýndan 19 dan baþlar 19, 45'den küçük olduðu için
sona doðru ilerler. ve ikinci adýmda 45 tam dizinin ortasýnda kalacaðý için direk bulur. 6 kere karþýlaþtýrma yapmak yerine 2 kere arama yaparak
daha hýzlý bir þekilde sonuç alýnýr. eðer her öðeye tek tek bakmak gerekirse 
Linear search kullanýlýr. Ve O(n) doðrusal  zamanda çalýþýr. Ama Binary search'te eleman sayýsýný bildiðimiz için her karþýlaþtýrmada
O(log(n)) zaman kadar çalýþýr. Yani daha hýzlý sonuç alýnabilir. **Bu yapabilmek için ilk önce dizinin sýralandýðýný varsaydým. Yoksa çalýþmaz.**
