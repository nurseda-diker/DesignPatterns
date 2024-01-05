# Adapter Tasarım Deseni

## 🎯Nedir?

Adapter tasarım deseni, farklı arayüzlere sahip iki sınıfın veya nesnelerin birbirleriyle uyumlu çalışmasını sağlamak amacıyla kullanılan bir yapısal tasarım desenidir. Bu desen, mevcut bir sınıfın veya nesnenin arayüzünü değiştirmeden, istemci tarafından kullanılan bir arayüze uyumlu hale getirmek için bir adaptör sınıfı kullanır. Bu sayede, uyumsuz yapılar birbirleriyle entegre edilebilir ve sistemler arası iletişim sağlanabilir. Adapter tasarım deseni, özellikle mevcut bir kod tabanını genişletmek, dış kaynaklı kütüphaneleri entegre etmek veya uyumsuz arayüzleri birleştirmek istendiğinde kullanılır, bu sayede kodun esnekliği artar ve bakım daha kolay hale gelir.

## 🤔Neden kullanılır ?

Adapter tasarım deseni, farklı arayüzlere sahip olan sınıfları veya nesneleri birbirleriyle uyumlu hale getirmek amacıyla kullanılır. Genellikle şu durumlar için uygundur: mevcut bir sistemdeki bir bileşenin arayüzü değiştirildiğinde, mevcut bir sınıfın veya kütüphanenin kullanıldığı bir projede, dış kaynaklı bir kütüphanenin projeye entegre edildiğinde veya bir alt sistemdeki bir bileşenin, projede kullanılan arayüzle uyumlu hale getirilmesi gerektiğinde kullanılır. Adapter deseni, mevcut kodun değiştirilmeden uyumlu bir yapıya entegre edilmesine olanak tanır ve sistemler arası uyumsuzlukları gidererek farklı yapıların birbirleriyle sorunsuz bir şekilde çalışmasını sağlar.
