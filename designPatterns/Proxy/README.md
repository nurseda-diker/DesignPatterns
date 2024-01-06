# Proxy Tasarım Deseni

## 🎯Nedir?

Proxy tasarım deseni, bir nesnenin yerine geçen ve bu nesnenin davranışını kontrol eden bir başka nesnenin kullanılmasını sağlayan bir yapısal tasarım desenidir. Proxy, gerçek nesnenin yaratılma veya yüklenme maliyeti yüksekse, erişim kontrolü sağlanması gerekiyorsa veya nesnenin önbelleklenmesi gibi ek işlevselliğe ihtiyaç duyulduğunda kullanılır. Proxy, istemcinin gerçek nesne ile etkileşimini sağlar ve bu sırada ek işlevselliği uygular. Gerçek nesne, proxy tarafından yönetilen bir şekilde kullanılır, bu sayede istemcinin gerçek nesneye olan erişimini kontrol etmek mümkün olur.

## 🤔Neden kullanılır ?

Proxy tasarım deseni, birkaç durumda kullanışlıdır. Birincisi, gerçek nesnenin yaratılma veya yüklenme maliyeti yüksekse ve bu nesneye olan erişim kontrol edilmek isteniyorsa kullanılabilir. İkincisi, gerçek nesnenin önbelleğe alınması gerekiyorsa, yani aynı işlemlerin tekrar tekrar yapılması gerekiyorsa proxy tasarım deseni tercih edilebilir. Son olarak, güvenlik kontrolleri gibi ek işlevselliğin eklenmesi durumunda da proxy kullanılabilir. Proxy tasarım deseni, nesnenin kullanımını kontrol etmek ve istemcinin etkileşimi sırasında ek işlevselliği uygulamak için bir ara katman sağlar.
