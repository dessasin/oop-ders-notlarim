# Notlar 

## Bellek Bölgeleri
1. Stack (değer tip , değişkenler)
2. Heap (referans tip,Türetilen nesnelerin saklandığı alan)
3. Register ( micro işlemci üzerinde bulunan bellek bölgeleri,L1-L2 )
4. Static (Tüm nesnelerin saklandığı alan)
5. Sabit (program başında tanımlanıp hiç değişmeyen nesneleri tutan bölge,sabit değişkenler)
6. Ram olmayan bölge ( Hdd yada Ssd saklama alanı)

---
### Sabitler 
* Sabitlere atama yaparken ilk değer verilmek zorundadır
* Sabitler sonradan değiştirilemez
* Sabitlere değer atanırken sadece farklı sabitler kullanılabilir

### Genel Uyarılar
* Kod bloklarını { } ifadeleri ile istediğimiz gibi ayrıştırabiliriz.Ancak dikkat edilmesi geren bir nokta bulunmaktadır;
<br>
	* _"Değişkenler tanımlı oldukları kod blokları içerisinde geçerli olur"._
<br>

* **Checked** blokları tür dönüşümlerinde yapılan taşma durumlarını kontrol etmek için kulanılır eğer taşma durumu varsa program hata verip çalışmaz ancak taşma olmadığı durumlarda program çalışacaktır varsayılan olarak **Unchecked**'dir.

* Checked ve Unchecked iç içe kullanılabilir

**Objeler** 
Boxing yöntemi ile kullanılan değişkendir oluşturulan değişkenin türü belirtilmez ancak içeriğine verilen değer değişkenin değer tipini belirler 


* **Bileşik Atama Operatörleri** değişkeni kendisi ile işleme sokmak istediğimizde kullandığımız ifadelerdir

* **Karşılaştırma** operatörlerinde ilk işleme giren değişken soldaki değişkendir < > == != durmlarında eğer soldaki sayı ilk şartı karşılıyorsa işlem soncu ona göre belirlenir

* **Karşılaştırma** operatörlerinde tersi durumu sorgulamak için operatör önüne _" ! "_ işareti konulması yeterlidir
* **Mantıksal Operatörler** "&&">>"Ve Bağlacı" , " || " >> "Veya Bağlacı"

* **Bitsel Operatörler** bit düzeyinde sorgu yapan operatörlerdir & | 


### Tür Dönüşümleri
* Tür dönüşümlerinde değer taşmaları sebebi ile değişken değer hataları oluşabilir
* Herhangi bir veri tipinde char veri tipine dönüşüm mümkün değildir

### Aritmetik işlemler

* Matematiksel işlemlerde bölme yaparken kesirli ifade alabilmek için double değişkenleri double değişkenler ile bölmek gerekmektedir.

* Aritmetik işlemlerde işlem önceliği bulunmaktadır

* **++degisken** şeklinde kullanılan artırma ve azaltma işlemlerinde ileyiş şu şekildedir;
	**++degisken** yapıldığında önce değişken değeri artırılır sonra ekrana yazılır
	**degisken++** önce ekrana yazdırılır sonrasında değişken artırılır


