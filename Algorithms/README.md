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

