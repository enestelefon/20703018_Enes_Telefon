# finalodevi-kutuphane
<ul>kütüphane oluşturarak araba satış listesi oluşturacağım, her bilgisini girdiğim aracı aynı zamanda da veri tabanına kaydedilmiş olacak.</ul>
<ul>bu bilgiler ise öncelik olarak aracın markası, aracın üretildiği ülke, aracın kilometre durumu ve aracın kaç model olduğu olacak.
<ul>İlk başta en üst kısımda araç ülkeleri listesi var ve o liste içine araç markaları bulunmakta. bu listelerin altında da bunların fiyatını gösterecek bilgi alanı var.
<ul>Filtrelemeyi DataView özelliğine Rowfilter ekleyerek yaptım. Böylelikle textbox üzerinden filtreleme yapabilirsiniz.
<ul>Liste içinde seçtiğimiz aracın fiyat bilgisi aşağıda yer almaktadır. Farklı listelerden birden fazla seçme imkanı buluyor. Daha sonrasında bu seçtiklerimizi listeye ekle diyerek daha geniş bir düzeyde görebiliyoruz. 
<ul>Listeye de butonlar ekledim. Bu butonlar listeden seçili olanı kaldır var. Tüm listeyi sıfırlama var.
<ul>Listeden seçili satırı kaldırmak RemoveAt komutundan yararlandım. Böylelikle listeden seçtiğimiz satırı siliyoruz.
<ul>Listeyi sıfırlamak için Items.Clear komutunu kullandım. Böylelikle tüm listeyi sıfırlayabiliyoruz.
SqlConnection bağlantı komutunu kullanarak veri tabanına bağlandım.
Veri tabanında da araçlara ulaşabiliyoruz. Daha sonrasına veri tabanı içerisine filtreleme özelliğimizi ekledim. Böylelikle istediğim aracı veri tabanında aratabiliriz. 
Veri tabanına ekleme yapma özelliği de mevcut. Textbox'a bilgiler girerek bunları veri tabanına ekleyebiliyoruz.
Veri tabanına eklendikten sonra messagebox komutu kullanarak bize bir mesaj veriyor. "Başarıyla Kaydedildi" mesajını gördükten sonra veri tabanına bilgilerin eklendiğini göreceksiniz.
Butonuma veri tabanına ekleme kodunu yazdım. Textbox'a string komutu işleyerek her bir text box ayrı ayrı tablolara ekleme özelliği kazandı.
Tabi bu özellikleri eklerken de insert into özelliğinden de yararlandım. Yoksa sağlıklı şekilde çalışmazdı. 
Insert Into komutundan önce SqlCommand kodunu çağırdım.
Veri tabanına ekledikten sonra Textbox'ı temizleme butonu da ekledim. Buton içersine textbox.Clear koyarak boylelikle kısa ve hızlı şekilde textbox silinebiliyordu. Böylelikle textbox'ı tek tek silme gibi sorunu ortadan kaldırdım.
Bunları yaparken de otomatik id atama özelliğini de ekledim. Id cakışması gibi bir sorunla karşılaşmayacağız. Bu otomatik id özelliğini SQL içerisnde id kısmına Primary Key verdim Daha sonrasında da identity alanına giderek orada No olan özellikleri Yes olarak değiştirdim. Böylelikle id'mizi otomatik kendisi verdi. ID çakışması gibi sorunlardan kurtulduk. 
Her yeni veri girişinde o veriye yeni bir id atayacak. böylelikle veri tabanındaki karmasayı önleyebilirsiniz.
