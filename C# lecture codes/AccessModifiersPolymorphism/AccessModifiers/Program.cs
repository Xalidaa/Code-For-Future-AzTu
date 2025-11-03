using ProductObject;
using MilkObject;
using BookObject;

Product product = new Product("prod_1","desc_1",10);
Book book = new Book("book_1","desc_1",10,"Nizami");
//Console.WriteLine(product.Name);

Milk milk = new Milk("milk_1", "desc_1", 10, 3);
//Console.WriteLine(milk.Name);
// error verir cunki Name private-dir ve sadece oz classinin icinde access oluna biler
//oz classinin miraslarinda bele olmur

milk.SayName();
book.SayName();
product.SayName();

//filedlerin access modifierleri
//private field sadece oz classi icinde isleyir; sen onu gedib miras aldigin classda ve ya program.csde
//birbasa istifade ede bilmirsen

//protected fieldi hem oz classinda, hem de miras aldiginda istifade ede bilirsen
//program.csde birbasa istifade ede bilmirsen, amma miras class uzerinden ede bilirsen
//meselen milk.Name birbasa print ede bilmirsen, error verir, amma milk.SayName() methodu uzerinden isleyecek
//cunki SayName methodu miras alanin methodudur, onun da bu fieldi istifade etmeye icazesi var


// polymorphism prinsipine aid olanlar: 

// 1. bir classdan bir nece miras almaq
// 2. methodlar arasinda overloading prosesi olarsa
// 3. override prosesi bas vererse

