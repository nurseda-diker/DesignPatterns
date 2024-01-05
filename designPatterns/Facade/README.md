# Facade Tasarım Deseni

## 🎯Nedir?

Facade tasarım deseni, creational (oluşturucu) tasarım desenlerinden biridir ve bir alt sistemdeki karmaşık bir grup nesnenin arayüzünü basitleştirmek amacıyla kullanılır. Bu desen, bir facade (cephe) sınıfı oluşturarak alt sistemdeki nesnelerin karmaşıklığını gizler ve istemci uygulamaya daha kullanıcı dostu ve anlaşılır bir arayüz sunar. Facade, alt sistemdeki detayları ele alır ve istemciye sadece gerekli olan bir arayüz sağlar, böylece istemci kodu alt sistemdeki değişikliklere karşı daha dirençli hale gelir ve daha kolay bakım yapılabilir.

## 🤔Neden kullanılır ?

Facade tasarım deseni, bir yazılım uygulamasında karmaşık bir alt sistem bulunduğunda ve istemci kodunun bu alt sistemle doğrudan etkileşim kurmak yerine basitleştirilmiş bir arayüz üzerinden iletişimde bulunmasının gerektiği durumlarda kullanılır. Özellikle büyük projelerde veya dış kaynaklı kütüphanelerin kullanıldığı durumlarda, alt sistemdeki detayların karmaşıklığını gizleyerek istemci kodunun daha sade ve bakımı kolay hale gelmesini sağlar. Ayrıca, alt sistemde yapılan değişikliklere karşı esneklik sağlar ve bu değişikliklerin istemci kodunu etkilememesini sağlar. Facade tasarım deseni, bir uygulamanın bakımını kolaylaştırır ve istemcinin alt sistemle olan etkileşimini daha düzenli bir şekilde yönetir.
