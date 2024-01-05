# Factory Method Tasarım Deseni

## 🎯Nedir?

Factory Method tasarım deseni, bir nesnenin örneklenmesi sürecini alt sınıflara bırakan ve böylece nesne oluşturma işlemini bir interfaceden türetilmiş sınıflara devreden bir creational (oluşturucu) tasarım desenidir. Bu desen, bir sınıfın hangi nesneyi oluşturacağını alt sınıflara bırakarak, nesne oluşturma işlemini genişletilebilir ve değiştirilebilir hale getirir.

## 🤔Neden kullanılır ?

Factory Method tasarım deseni, bir nesnenin oluşturulma sürecini soyutlayarak ve bu süreci alt sınıflara bırakarak esnek ve genişletilebilir bir tasarım sağlar. Bu desen, nesne oluşturma sürecindeki değişikliklere karşı dirençli olmayı ve yeni nesne türlerini eklemeyi kolaylaştırarak yazılım tasarımını iyileştirir. Ayrıca, Factory Method, tek sorumluluk ilkesine uyar ve alt sınıflar aracılığıyla nesne oluşturma işlemlerini düzenleyerek bakımı daha kolay ve anlaşılır hale getirir. Sistemdeki bileşenlerin geniş bir ailesi olduğunda veya farklı platformlarda çalışacak nesnelerin oluşturulması gerektiğinde kullanışlıdır. Bu tasarım deseni, bir sınıfın kendisini değiştirmeden alt sınıflar aracılığıyla farklı nesne türleri oluşturabilme ihtiyacı olan durumlarda tercih edilir.
