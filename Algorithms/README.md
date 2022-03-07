Big-O notasyonu = algoritmalar� kar��la�t�rmam�z� sa�lar.
Arama algoritmalar�n� kar��la�t�rma
1. Aran�lan ��e listenin ilk veya son eleman� olacak ise e�er, giri� boyutu ne olursa olsun sadece ilk veya son eleman�n� kontrol etmek
gerekiyor. 
- Bu y�zden sabit bir zaman�n O ald��� s�ylenebilinir.
2. Aran�lan ��e listede bir yerdeyse ama listede yeri bilinmiyorsa,  her eleman� kontrol etmek gerekiyor. 
- Best case : aran�lan ilk ��enin olmas�
- Worst case : listede ��enin olmamas� bu her ��eyi kontrol etmek anlam�na geliyor.

�o�u algoritmada iyi durum ve k�t� durum senaryo performans s�releri de�erlendirilir.

1. algoritmada best case : O(1) worst case: O(1) sabit s�re
2. algoritmada best case : O(1) worst case: O(n) yada linear n giri� boyutunu ifade eder(input) linear art�� e�ilimi

1. algoritmada ��enin oldu�unu varsay�yoruz. best case ve worst case birbirini keser ayn� s�reyi ifade eder.
2. algoritmada bu varsay�m yap�lmaz worst case de s�re �ok uzayacakt�r.

Di�er zaman kar��la�t�rmalar�
- O(1) yada sabit zaman(constant)
- O(log(n)) yada logaritmik zaman
- O(n) yada linear zaman
- O(n�) yada �stsel zaman
- O(n!) yada fakt�riyel zaman 
sabit zaman en verimli olan�d�r. n� en verimsiz olan�d�r.


Validation Algorithm Do�rulama algortimas�
Bir giri� dizesinin olup olmad��� do�rulan�r Belirli �zelliklere veya niteliklere sahiptir.
�rne�in bir dizenin tamamam�n�n b�y�k harf olup olmad���n� veya en az bir numara varm� kontrol eder. 
Daha sonra output olarak true veya false d�ner. 
Do�rulama Algoritmas� ile **Giri� verilerinin baz� belirli �zellikleri garanti edilebilir.**

string ifadeleri i�lemeden �nce ortak bir formda normalle�tirmek yard�mc� olabilir.
Ba�ka bir se�enek ise giri�leri s�n�rland�rmakt�r. �rne�in giri� veri olarak sadece k���k harflerin al�nmas� gibi bunun i�inde
validation algoritmas� ile herhangibir girdi t�r�n� reddebiliriz.

Dize i�erisinde veri aramak algoritma kurarken �ok kullan�lan bir y�ntemdir. Bir dizi verisi hakk�nda yap�lan varsay�mlara ba�l� olarak,
algoritma �ok  veya az verimli bir hale gelebilir.
E�er gelen string de�er hakk�nda hi� bir�ey bilinmiyorsa, her karakteri tek tek kontrol etmek gerekecektir.
Aran�lan veriyi bulmak i�in dizenin karakterlerinin oldu�unu biliyorsak ve �e�itli alfabetik s�ralamayla algoritma optimize edilebilinir.

Linear search yada sequential search(s�ral� arama)

Bir arama algoritmas�yla genellikle aramak gereken veriler girilir. Ve ��kt� olarak true/false veya aran�lan veriyi daha fazla veriyle geri d�nd�r�l�r.

Binary search ikili arama

Arama algoritmas�n� optimize etmek i�in, veriler hakk�nda varsay�mlarda bulunmak gerekecektir.
�rne�in datan�n s�ral� oldu�unu biliyorsak, ortadan ba�layabilir daha sonra ��enin nerede olma� gerekti�ine g�re dizinin ba��na veya sonuna do�ru ilerlenebilir.
B�yle bir case de binary search kullan�labilinir.
Binary search divide-and-conquer algoritmas�d�r. b�l ve y�net, aramak i�in **her ad�mda sahip oldu�u eleman say�s�n� yar�ya indirir**
�rne�in s�ral� bir dizide {0,2,8,19,23,45,79}  45 numaras�n� ar�yorum. dizinin ortas�ndan 19 dan ba�lar 19, 45'den k���k oldu�u i�in
sona do�ru ilerler. ve ikinci ad�mda 45 tam dizinin ortas�nda kalaca�� i�in direk bulur. 6 kere kar��la�t�rma yapmak yerine 2 kere arama yaparak
daha h�zl� bir �ekilde sonu� al�n�r. e�er her ��eye tek tek bakmak gerekirse 
Linear search kullan�l�r. Ve O(n) do�rusal  zamanda �al���r. Ama Binary search'te eleman say�s�n� bildi�imiz i�in her kar��la�t�rmada
O(log(n)) zaman kadar �al���r. Yani daha h�zl� sonu� al�nabilir. **Bu yapabilmek i�in ilk �nce dizinin s�raland���n� varsayd�m. Yoksa �al��maz.**
