Bu proje, temel programlama becerilerini geliştirmek ve veritabanı / müşteri yönetimi gibi konulara giriş yapmak amacıyla oluşturulmuştur. 

Değişkenler, veri tipleri, kullanıcı girdisi ve konsol çıktısı gibi C#'ın temel özellikleri ile Müşteri Yönetim Sistemleri İçin basit bir giriş, kayıt sistemi veya satınalma takibi gibi ticari uygulamalar için temel oluşturmak amacı ile yapılmıştr. Mağaza ya da e-ticaret sistemlerinde, kullanıcıların harcamalarını takip edip puan kazandıran bir sistemin temelini öğrenmek ve göstermek için de kullanılabilir. 

# Kullanıcı Bilgileri ve Harcama Takip Uygulaması

Bu proje, kullanıcıdan kişisel bilgiler (T.C. Kimlik Numarası, ad, soyad, telefon numarası, yaş) ve satın aldığı ürünlerin fiyatlarını alarak toplam harcama üzerinden puan hesaplayan bir C# uygulamasıdır.

### Proje Özellikleri:
- Kullanıcı bilgilerini toplar.
- İlk ve ikinci ürün fiyatlarını sorar.
- Toplam harcamayı hesaplar ve bunun %10'unu puan olarak kullanıcıya verir.
- Kullanıcıya özel bir mesaj ve bildirim çıktısı verir.

### Amaç:
Bu proje, temel C# programlama bilgilerini uygulamak için geliştirilmiştir. Değişkenler, veri tipleri ve kullanıcı girdisi gibi konular üzerinde pratik yapmayı amaçlar. Aynı zamanda basit bir müşteri kayıt ve harcama takip sistemi için temel oluşturur.

### Örnek Kullanım:
1. Kullanıcı bilgilerini girer.
2. Ürün fiyatlarını girer.
3. Uygulama toplam harcamayı ve kazandığı puanı ekrana yazdırır.
4. Bildirim ve kaydedilen bilgiler ekrana çıktı olarak verilir.

### Veri Tipleri:
- **T.C. Kimlik Numarası** ve **Telefon Numarası**: String olarak tutulur çünkü aritmetik işlem yapılmaz.
- **Yaş**: Tamsayı olduğu için int kullanılır.
- **Ürün Fiyatları**: Ondalıklı sayılar olabileceği için decimal olarak alınır.

### Gelecek Geliştirmeler:
- Veritabanına veri kaydetme.
- Daha gelişmiş puanlama algoritmaları.

EN/
This project was created to develop basic programming skills and provide an introduction to topics such as database / customer management. 

The basic features of C#, such as variables, data types, user input and console output, were used to create a simple introduction to Customer Management Systems, a registration system or a basis for commercial applications such as purchase tracking. In store or e-commerce systems, it can also be used to learn and demonstrate the basics of a system that tracks users' spending and earns points. 

# User Information and Spending Tracker Application

This project is a C# application that collects personal information from the user (ID number, name, surname, phone number, age) and product prices, then calculates points based on total spending.

### Features:
- Collects user information.
- Asks for the price of the first and second products.
- Calculates total spending and gives 10% of it as points to the user.
- Displays a personalized message and notification as output.

### Purpose:
This project was developed to practice fundamental C# programming skills. It focuses on variables, data types, and user input. It also serves as a foundation for a basic customer registration and spending tracking system.

### Example Usage:
1. The user enters their personal information.
2. They input the prices of the products they bought.
3. The application calculates the total spending and displays the points earned.
4. Notifications and saved information are printed as output.

### Data Types:
- **ID Number** and **Phone Number**: Stored as strings since no arithmetic operations are performed.
- **Age**: Stored as an integer because it's a whole number.
- **Product Prices**: Stored as decimals to handle floating-point values.

### Future Improvements:
- Adding database support for saving user data.
- More advanced point calculation algorithms.
