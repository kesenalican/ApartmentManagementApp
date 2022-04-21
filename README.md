# ApartmentManagementApp
This is an apartment management app. 

# .Net Core Bitirme Projesi</br>
Açıklama : Bir sitede yöneticisiniz. Sitenizde yer alan dairelerin aidat ve ortak kullanım
elektrik, su ve doğalgaz faturalarının yönetimini bir sistem üzerinden yapacaksınız.</br>
İki tip kullanıcınız var:</br>
1-Admin/Yönetici</br>
● Daire bilgilerini girebilir.</br>
● İkamet eden kullanıcı bilgilerini girer.</br>
● Daire başına ödenmesi gereken aidat ve fatura bilgilerini girer(Aylık olarak). Toplu veya
tek tek atama yapılabilir.</br>
● Gelen ödeme bilgilerini görür.</br>
● Gelen mesajları görür.</br>
● Mesajların okunmuş/okunmamış/yeni mesaj olduğu anlaşılmalı.</br>
● Aylık olarak borç-alacak listesini görür.</br>
● Kişileri listeler, düzenler, siler.</br>
● Daire/konut bilgilerini listeler, düzenler siler.</br>
2-Kullanıcı</br>
● Kendisine atanan fatura ve aidat bilgilerini görür.</br>
● Sadece kredi kartı ile ödeme yapabilir.</br>
● Yöneticiye mesaj gönderebilir.</br>
● Mesajların okunmuş/okunmamış/yeni mesaj olduğu anlaşılmalı.</br>
● Yaptığı ödemelerini görür.</br>
Daire/Konut bilgilerinde:</br>
● Hangi blokda</br>
● Durumu (Dolu-boş)</br>
● Tipi (2+1 vb.)</br>
● Bulunduğu kat</br>
● Daire numarası</br>
● Daire sahibi veya kiracı</br>
Kullanıcı bilgilerinde</br>
● Ad-soyad</br>
● TCNo</br>
● E-Mail</br>
● Telefon</br>
● Araç bilgisi(varsa plaka no)</br>
Sistem kullanılmaya başladığında ilk olarak,</br>
1.Yönetici daire bilgilerini girer.</br>
2.Kullanıcı bilgilerini girer.Giriş yapması için otomatik olarak bir şifre</br>
oluşturulur. 3.Kullanıcıları dairelere atar
4.Ay bazlı olarak aidat bilgilerini girer.</br>
5.Ay bazlı olarak fatura bilgilerini girer</br>
Arayüz dışında kullanıcıların kredi kartı ile ödeme yapabilmesi için ayrı bir servis
yazılacaktır.</br>
Bu serviste sistemde ki her bir kullanıcı için banka bilgileri (bakiye, kredi kartı no
vb.) kontrol edilerek ödeme yapılması sağlanır.</br>
Ödeme sadece kredi kartı ile yapılabilir.</br>
Projede kullanılacaklar:</br>
1.Web projesi backend için .Net Core, frontend için
Razorkullanılmalı.</br>
2.Sistemin yönetimi/database için MS SQL Server kullanılmalı.</br>
3.Kredi kartı servisi için. Veriler mongodb de tutulmalı. Servis .Net WebApi olarak
yazılacaktır.</br>
4.Mümkün olduğu kadar derslerde işlenen konular projeye entegre edilmelidir.</br>
