# finalodevi-kutuphane
<ul>kütüphane oluşturarak araba satış listesi oluşturacağım, her bilgisini girdiğim aracı aynı zamanda da veri tabanına kaydedilmiş olacak.</ul>
<ul>Bu bilgiler ise öncelik olarak aracın markası, aracın üretildiği ülke, aracın kilometre durumu ve aracın kaç model olduğu olacak.</ul>
<ul>İlk başta en üst kısımda araç ülkeleri listesi var ve o liste içine araç markaları bulunmakta. bu listelerin altında da bunların fiyatını gösterecek bilgi alanı var.</ul>
<ul>Filtrelemeyi _DataView_ özelliğine _Rowfilter_ ekleyerek yaptım. Böylelikle textbox üzerinden filtreleme yapabilirsiniz.</ul>
<ul>Liste içinde seçtiğimiz aracın fiyat bilgisi aşağıda yer almaktadır. Farklı listelerden birden fazla seçme imkanı buluyor. Daha sonrasında bu seçtiklerimizi listeye ekle diyerek daha geniş bir düzeyde görebiliyoruz. </ul>
<ul>Listeye de butonlar ekledim. Bu butonlar listeden seçili olanı kaldır var. Tüm listeyi sıfırlama var.</ul>
<ul>Listeden seçili satırı kaldırmak _RemoveAt_ komutundan yararlandım. Böylelikle listeden seçtiğimiz satırı siliyoruz.</ul>
<ul>Listeyi sıfırlamak için _Items.Clear_ komutunu kullandım. Böylelikle tüm listeyi sıfırlayabiliyoruz.</ul>
<ul>_SqlConnection_ bağlantı komutunu kullanarak veri tabanına bağlandım.</ul>
<ul>Veri tabanında da araçlara ulaşabiliyoruz. Daha sonrasına veri tabanı içerisine filtreleme özelliğimizi ekledim. Böylelikle istediğim aracı veri tabanında aratabiliriz. </ul>
<ul>Veri tabanına ekleme yapma özelliği de mevcut. Textbox'a bilgiler girerek bunları veri tabanına ekleyebiliyoruz.</ul>
<ul>Veri tabanına eklendikten sonra _messagebox_ komutu kullanarak bize bir mesaj veriyor. _"Başarıyla Kaydedildi"_ mesajını gördükten sonra veri tabanına bilgilerin eklendiğini göreceksiniz.</ul>
<ul>Butonuma veri tabanına ekleme kodunu yazdım. Textbox'a _string_ komutu işleyerek her bir text box ayrı ayrı tablolara ekleme özelliği kazandı.</ul>
<ul>Tabi bu özellikleri eklerken de _insert into_ özelliğinden de yararlandım. Yoksa sağlıklı şekilde çalışmazdı. </ul>
<ul>Insert Into komutundan önce _SqlCommand_ kodunu çağırdım.</ul>
<ul>Veri tabanına ekledikten sonra Textbox'ı temizleme butonu da ekledim. Buton içersine _textbox.Clear_ koyarak boylelikle kısa ve hızlı şekilde textbox silinebiliyordu. Böylelikle textbox'ı tek tek silme gibi sorunu ortadan kaldırdım.</ul>
<ul>Bunları yaparken de otomatik id atama özelliğini de ekledim. Id cakışması gibi bir sorunla karşılaşmayacağız. Bu otomatik id özelliğini SQL içerisnde id kısmına _Primary Key_ verdim Daha sonrasında da _identity_ alanına giderek orada No olan özellikleri Yes olarak değiştirdim. Böylelikle id'mizi otomatik kendisi verdi. ID çakışması gibi sorunlardan kurtulduk. </ul>
<ul>Her yeni veri girişinde o veriye yeni bir id atayacak. böylelikle veri tabanındaki karmasayı önleyebilirsiniz.</ul>
