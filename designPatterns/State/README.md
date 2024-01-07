# State Tasarım Deseni

## 🎯Nedir?

State tasarım deseni, nesne yönelimli programlamada kullanılan bir tasarım deseni olup bir nesnenin durumunu temsil etmek ve duruma bağlı olarak farklı davranışları değiştirmek amacını taşır. Bu desen, bir nesnenin iç durumunu ayrı nesne sınıfları olarak modeller ve bu durumları temsil eden sınıflar arasında geçiş yapmayı sağlar. Bir kontekst sınıfı, iç durum nesnesini değiştirerek farklı davranışları tetikler. Bu sayede, bir nesnenin davranışları, iç durumu değiştirmeden dinamik bir şekilde değiştirilebilir. State tasarım deseni, duruma bağlı davranışların düzenli ve genişletilebilir bir şekilde yönetilmesini sağlar.

## 🤔Neden kullanılır ?

State tasarım deseni, bir nesnenin davranışlarını duruma bağlı olarak değiştirmek istediğimiz durumlarda kullanılır. Özellikle bir nesnenin iç durumu, farklı durumlar arasında değiştiğinde ve bu durum değişiklikleri nesnenin davranışlarını etkilediğinde kullanışlıdır. Örneğin, bir otomobil nesnesini ele alalım; otomobilin durumu park, sürüş, duraklama gibi farklı olabilir ve her durumda otomobilin davranışları (hızlanma, frenleme, vb.) değişebilir. State tasarım deseni, bu durumları ayrı sınıflar olarak temsil ederek, duruma bağlı davranışları kolayca yönetmemize olanak tanır. Bu desen, durum geçişlerini düzenli hale getirir, kodun anlaşılabilirliğini artırır ve yeni durumlar eklemeyi veya mevcut durumları değiştirmeyi kolaylaştırır, bu da sistemdeki esnekliği artırır.
