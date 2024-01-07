# Command Tasarım Deseni

## 🎯Nedir?

Command tasarım deseni, nesne yönelimli programlamada kullanılan bir tasarım desenidir. Bu desen, bir isteği nesne olarak soyutlar ve bu isteği içeren komutları bir nesne içinde kapsülerleştirir. Temelde, bir komutu bir nesne olarak ele alır ve bu komutu çağıran sınıf ile komutu gerçekleştiren sınıf arasındaki bağımlılığı azaltarak sistemdeki esnekliği artırır. 

## 🤔Neden kullanılır ?

Command tasarım deseni, bir isteği nesne olarak soyutlamak ve bu isteği içeren komutları bir nesne içinde kapsülerleştirerek kullanıldığı durumlarda özellikle faydalıdır. Sistemdeki bağımlılıkları azaltmak, geri al/yinele işlemlerini yönetmek, sıra takibi yapmak veya kullanıcı arayüzlerindeki butonlar gibi istemcilerle alıcılar arasındaki bağlantıyı gevşetmek istediğimiz durumlarda Command deseni kullanışlı olabilir. Ayrıca, işlemleri parametreleştirerek sırayla gerçekleştirmek veya sıraya koymak gibi durumlarda da Command deseni tercih edilebilir, çünkü bu durumda her bir işlem bir nesne olarak ele alınabilir, parametrelerle özelleştirilebilir ve yönetilebilir.
