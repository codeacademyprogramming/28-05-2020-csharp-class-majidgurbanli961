# 02.05.2020-csharp-class

### Oxumalı olduğunuz materiallar
- c# class and object
- From c# OOP -> c# Properties
https://www.w3schools.com/cs/cs_oop.asp


### Tabşırıq

"Invoice" adinda bir class yaradin hansi ki ozunde asagindaki 3 fieldleri

 string account
 string customer
 string provider
 
 bu 3 field cemi bir defe teyin olunmalidir (constructor vasitesi ile teyin olunur yeni) ve teyin olunduqdan sonra hec bir yerde deyisdirile bilmemelidir.
 
 ve 2 property saxlayir.
 
 string article
 string quantity
 
 bu 2 field ise class dan obyekt yarannan sonra teyin olunmalidir yeni:
  var obj = new Invoice(a,b,c)
  obj.article
  
Bu invoice class nin meqsedi. Biz yeni bir mehsul sifaris eden zaman bu Invoice class nan obyekt yaradiriq ve onun icindeki CostCalculation methodunu cagiririq hansi ki bir parameter qebul edir (bool needEdv) ve mehsulun umumi deyeri ve mehsul haqqinda melumat qaytarir. Meselen needEdv eger true gelse onda mehsulun deyeri = mehsulun deyeri * sayi + edv olur. Eger false gelse onda tekce ele mehsulun deyerini * sayi qaytarir. 

Edv nin hesablanma qaydasi en besit olaraq. Mehsulun deyeri * 0.18

"Articil" lar evvelceden teyin olunub meselen:

laptop - 1400 AZN
SD-cadr - 30 AZN
USB-hab - 12 AZN

Invoice class nin yaradilma qaydasi Main nin icinde bu cur olacaq

Invoice inv = new Invoice(678904, "Alex", "Foxtrot") {Article = "USB-hab", Quantity = 6};
inv.CostCalculation(true);


Ugurlar.

  
 
 
 
