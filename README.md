# finalodevi-kutuphane
kütüphane oluşturarak araba satış listesi oluşturacağım, her bilgisini girdiğim aracı aynı zamanda da veri tabanına kaydedilmiş olacak. 
bu bilgiler ise öncelik olarak aracın markası, aracın üretildiği ülke, aracın kilometre durumu ve aracın kaç model olduğu olacak.
İlk başta en üst kısımda araç ülkeleri listesi var ve o liste içine araç markaları bulunmakta. bu listelerin altında da bunların fiyatını gösterecek bilgi alanı var.
Liste içinde seçtiğimiz aracın fiyat bilgisi aşağıda yer almaktadır. Farklı listelerden birden fazla seçme imkanı buluyor. Daha sonrasında bu seçtiklerimizi listeye ekle diyerek daha geniş bir düzeyde görebiliyoruz.
Listeye de buton ekledim. Bu butonlar listeden seçili olanı kaldır var. Tüm listeyi sıfırlama var.
Veri tabanı bağladım. Veri tabanında da araçlara ulaşabiliyoruz. Veri tabanı içerisine filtreleme özelliği ekledim. Böylelikle istediğim aracı veri tabanında araytabiliriz. 
Veri tabanına ekleme yapma özelliği de mevcut. Textbox'a bilgiler girerek bunları veri tabanına ekleyebiliyoruz. Veri tabanına ekledikten sonra Textbox'ı temizleme butonu da ekledim. Böylelikle textbox'ı tek tek silme gibi sorunu ortadan kaldırdım.
Bunları yaparken de otomatik id atama özelliğini de ekledim. Id cakışması gibi bir sorunla karşılaşmayacağız.
Her yeni veri girişinde o veriye yeni bir id atayacak. böylelikle veri tabanındaki karmasayı önleyebileceğim.
