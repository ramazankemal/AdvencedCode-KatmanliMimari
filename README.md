# AdvencedCode-KatmanliMimari
Basit-Katmanli-Mimari çalışmama göre üst seviye çalışmam olan AdvencedCode içeriğinde ekstradan Core katmanı ve FluentValidation özelliklerini barındırıyor.
Core katmanın görevi genel olarak bakıldığında projede tüm katmanlarda veya 1 den fazla katmanlarda ortak kullanmak istediğim ve kod tekrarına engel olmak 
istediğim yapıyı barındırmakta, örneğin DataAccess katmanında Concrete sınıflarımda tekrarladığım CRUD işlemlerimi Core Katmanı içerisinde EfEntityRepositoryBase
sınıfı içerisinde yaparak birden çok Concrete sınıfımı bu sınıf ile ilişkilendirerek kod tekrarından kurtulmuş oluyorum ve aynı zamanda farklı
teknolojiler(EntityFramework,NHibernate,...) ile çalışmayada uyumluluk sağlamış bulunmaktayım yani projenin tamamına etki etmeden yeni teknolojiye uygun
RepositoryBase sınıfı yazarak projeyi yeni teknolojiye uygun hale getirebiliyorum.

Oluşturmuş olduğum Generic Result yapısını ise yine Core katmanı içerisinde barındırıyorum.Oluşturmuş olduğum Result yapısıyla Message,Success yanıtlarını
döndürebiliyor.Veri dönüşü sağlayan metotlarda ise buna ek olarak liste halinde veya tek nesne halinde data dönüşü yapabiliyorum.
