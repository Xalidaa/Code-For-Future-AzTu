/*task 1: İstifadəçinin pensiya yaşına çatıb-çatmadığını müəyyən edən proqram yazın.
Daxil edilən yaş müsbət olmalıdır.
Yaş 125-dən kiçik olmalıdır.
Yaşa əsasən istifadəçinin pensiya yaşına çatıb-çatmadığı müəyyən edilməlidir
*/
let age = 50
if (age > 65 && age < 125) {
    console.log('Pensiya yaşina çatmisan')
}
else if (age < 65 && age > 0) {
    console.log('Pensiya yaşina çatmamisan')
}
else {
    console.log('Düzgün qiymet daxil edin')
}

/*task 2: Üç ədədə əsasən üçbucağın növünü müəyyən edən proqram yazın.
Daxil edilən 3 ədəd müsbət olmalıdır.
Əgər bütün tərəflər bərabərdirsə → “Bərabəryanlı üçbucaq”
Əgər iki tərəf bərabərdirsə → “Bərabəryanlı üçbucaq”
Əgər heç biri bərabər deyilsə → “Müxtəliftərəfli üçbucaq”
*/

let a = 4
let b = 6
let c = 6

if (a == b && b == c) {
    console.log('Beraberterefli')
}

else if ((a == b && b != c) || (b == c && c != a) || (a == c && c != b)) {
    console.log('Beraberyanli')
}

else if (a != b && b != c && a != c) {
    console.log('Müxtelif terefli')
}

else {
    console.log('Düzgün qiymetler daxil edin')
}

/* task 3: Daxil edilən ədədin cüt və ya tək olduğunu tapan proqram yazın.
Ədəd müsbət olmalıdır.
*/

let number = 25
if (number % 2 == 0) {
    console.log('Eded cütdür')
}
else if (number % 2 != 0) {
    console.log('Eded tekdir')
}
else {
    console.log('Müsbet eded daxil edin')
}

/*task 4: Daxil edilən 1–12 arası ədədə uyğun ay adını yazan proqram yazın.
Ədəd 1–12 aralığında olmalıdır.
switch operatoru ilə yazılmalıdır.
Məsələn: 2 daxil edildikdə → “Fevral”.
*/

let month = 7

switch (month) {
    case 1:
        console.log('Yanvar');
        break;
    case 2:
        console.log('Fevral');
        break;
    case 3:
        console.log('Mart');
        break;
    case 4:
        console.log('Aprel');
        break;
    case 5:
        console.log('May');
        break;
    case 6:
        console.log('İyun');
        break;
    case 7:
        console.log('İyul');
        break;
    case 8:
        console.log('Avqust');
        break;
    case 9:
        console.log('Sentyabr');
        break;
    case 10:
        console.log('Oktyabr');
        break;
    case 11:
        console.log('Noyabr');
        break;
    case 12:
        console.log('Dekabr');
        break;
}


/* task 5: Daxil edilən ədədin kvadratını tapan proqram yazın.
Ədəd müsbət olmalıdır.
*/
let num = 8
console.log(num * num)

/*Task 6: Daxil edilən ədədin 5-ə bölünüb-bölünmədiyini tapan proqram yazın.
Əgər tam bölünürsə → “Bölündü” yazılsın.
Əgər tam bölünmürsə → qalıq hesablanıb göstərilsin.
Ədəd müsbət olmalıdır.
*/

let eded = 23
if (eded % 5 == 0) {
    console.log("Bolundu")
}
else {
    console.log(eded % 5)
}

/*Task 7: Daxil edilən 2 ədədin hasilinin cüt və ya tək olduğunu göstərən proqram yazın.
Hər iki ədəd müsbət olmalıdır.
*/

let eded1 = 12
let eded2 = 5
let hasil = eded1 * eded2
if (hasil % 2 == 0) {
    console.log("Hasil cut ededdir.")
}
else {
    console.log("Hasil tek ededdir.")
}

/*Task 8: Daxil edilən  ədədin 3-ə bölünüb-bölünmədiyini tapan proqram yazın.
Ədəd müsbət olmalıdır.
*/

let n = 81
if (n % 3 == 0) {
    console.log("Bolunur")
}
else {
    console.log("Bolunmur")
}

/*Task 9: Daxil edilən 3 müsbət ədədin ortalamasını tapan proqram yazın.
Bütün ədədlər müsbət olmalıdır.
*/

let num1 = 67
let num2 = 32
let num3 = 4
console.log((num1 + num2 + num3) / 3)

/*Task 10: Tələbənin balına görə qiymətini təyin edən proqram yazın.
Bal 0-dan böyük və 100-dən kiçik olmalıdır.
Qiymətləndirmə:
90 və yuxarı → “A”
80–89 → “B”
70–79 → “C”
60–69 → “D”
59 və aşağı → “F”
*/

let bal = 67
if (bal >= 0 && bal <= 100) {
    if (bal >= 90) {
        console.log('A')
    }
    else if (bal >= 80 && bal <= 89) {
        console.log('B')
    }
    else if (bal >= 70 && bal <= 79) {
        console.log('C')
    }
    else if (bal >= 60 && bal <= 69) {
        console.log('D')
    }
    else {
        console.log('F')
    }
}
else {
    console.log('Daxil etdiyiniz bal düzgün deyil.')
}

/*Task 11: Yaşa görə insanın kateqoriyasını müəyyən edən proqram yazın.
Ədəd müsbət olmalıdır.
18-dən az → “Yeniyetmə”
18–64 arası → “Yetkin”
65 və yuxarı → “Yaşlı”
*/

let yas = 78
if (yas > 0) {
    if (yas < 18) {
        console.log('Yeniyetme')
    }
    else if (yas >= 18 && yas <= 64) {
        console.log('Yetkin')
    }
    else {
        console.log('Yaşli')
    }
}
else {
    console.log('Düzgün yas qeyd edin.')
}

/*Task 12: Daxil edilən saata uyğun salamlaşma çıxaran proqram yazın.
Ədəd müsbət olmalı və 0–24 aralığında olmalıdır.
0–11 → “Sabahınız xeyir”
12–17 → “Günortanız xeyir”
18–24 → “Axşamınız xeyir”
*/

let saat = 13
if (saat >= 0 && saat <= 24) {
    if (saat >= 0 && saat <= 11) {
        console.log('Sabahiniz xeyir')
    }
    else if (saat >= 12 && saat <= 17) {
        console.log('Gunortaniz xeyir')
    }
    else {
        console.log('Axşaminiz xeyir')
    }
}
else {
    console.log('Düzgün vaxt qeyd edin')
}

/*Task 13: Daxil edilən x və y ədədlərinə görə nəticə hesablayan proqram yazın.
Əgər x > 0 və y < 0 → 4x + 2y + 4 hesablayın
Əgər x > 0 və y == 0 → 2x - y + 3 hesablayın
Əgər x < 0 və y > 0 → 3x + 4y + 3 hesablayın
*/

let x = 12
let y = -23
if (x > 0 && y < 0) {
    console.log(4 * x + 2 * y + 4)
}
else if (x > 0 && y == 0) {
    console.log(2 * x - y + 3)
}
else if (x < 0 && y > 0) {
    console.log(3 * x + 4 * y + 3)
}

/*Task 14: 1-dən 100-ə qədər ədədlər üçün FizzBuzz proqramı yazın.
3-ə bölünəndə → “Fizz”
5-ə bölünəndə → “Buzz”
Hər ikisinə bölünəndə → “FizzBuzz”
*/

for (let i = 1; i <= 100; i++) {
    if ((i % 3 == 0) && (i % 5 != 0)) {
        console.log('Fizz')
    }
    else if ((i % 5 == 0) && (i % 3 != 0)) {
        console.log('Buzz')
    }
    else if ((i % 3 == 0) && (i % 5 == 0)) {
        console.log('FizzBuzz')
    }
}


/*Task 15: Verilmiş sözün palindrom olub-olmadığını yoxlayan proqram
Verilmiş söz tərsinə oxunduqda da eyni olmalıdır.
*/

let word = 'tut'
let rev = ''
for (let i = word.length - 1; i >= 0; i--) {
    rev += word[i]
}
if (rev == word) {
    console.log('Polindrom')
}
else {
    console.log('Polindrom deyil')
}

/*Task 16: Verilmiş ədədin faktorialını tapan proqram yazın.
Ədəd müsbət olmalıdır.
*/

let N = 5
let p = 1
for (let i = 1; i <= N; i++) {
    p = p * i
}
console.log(p)


/*Task 17: Verilmiş bir array-dəki ən böyük ədədi tapan proqram yazın.
Array-də yalnız ədədlər olmalıdır.*/

let lis = [5, 2, 13, 11, 34]
let max = lis[0]
for (let i = 0; i < lis.length; i++) {
    if (lis[i] > max) {
        max = lis[i];
    }
}
console.log(max);

/*Task 18: Verilmiş bir array-dəki ən kiçik ədədi tapan proqram yazın.
Array-də yalnız ədədlər olmalıdır.
*/

let lis = [5, 2, 13, 11, 34]
let min = lis[0]
for (let i = 0; i < lis.length; i++) {
    if (lis[i] < min) {
        min = lis[i];
    }
}
console.log(min);

/*Task 19:  Verilmiş bir array-in elementlərinin cəmini tapan proqram yazın.
Array-də yalnız ədədlər olmalıdır.
*/

let list = [5, 2, 13, 11, 34]
sum = 0
for (let i = 0; i < list.length; i++) {
    sum = sum + i
}
console.log(sum)

/*Task 20:  Sözlərdən ibarət bir array-də ən uzun sözü tapan proqram yazın.
Array-də yalnız sözlər olmalıdır.
*/

let words = ["apple", "top", "blue"]
const splStrArray = words.split(' ');
let longestWord = "";
for (let index = 0; index < splStrArray.length; index++) {
    if (splStrArray[index].length > longestWord.length) {
        longestWord = splStrArray[index];
    }
}
console.log(longestWord)