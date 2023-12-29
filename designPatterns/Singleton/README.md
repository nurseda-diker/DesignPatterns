# Singleton Tasarım Deseni

## 🎯Nedir?

Singleton tasarım deseni, bir sınıfın yalnızca bir örneğinin oluşturulmasına izin verir ve bu örneğe genel bir erişim noktası sağlar.

## 🤔Neden kullanılır ?

Bu desen genellikle, bir nesnenin yalnızca bir kere oluşturulması ve tüm uygulama boyunca paylaşılması gerektiği durumlarda kullanılır. Örneğin bir uygulamanın yapılandırma ayarları, genellikle tek bir noktadan erişilebilen bir yapılandırma yöneticisi kullanılarak yönetilir. 
Bu, ayarların tek bir yerden yönetilmesini sağlar ve uygulama genelinde tutarlılık sağlar. Veritabanı bağlantı yönetimi veya loglama işlemleri için tek bir noktadan erişilebilen bir obje sağlamak
bu deseninin kullanımına örnek gösterilebilir.
