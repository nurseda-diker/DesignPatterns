# Memento Tasarım Deseni

## 🎯Nedir?

Memento tasarım deseni, bir nesnenin iç durumunu kaydedip daha sonra geri yükleyebilme yeteneği sağlayan bir davranışsal tasarım desenidir. Bu desen, nesne durumunun geçmiş bir durumunu muhafaza etmek ve gerektiğinde bu durumu geri yüklemek amacıyla kullanılır. Memento deseni, nesneler arasında bağımlılıkları azaltarak ve bir nesnenin durumunu dışa açmadan bu durumu yöneterek, özellikle geri alma (undo) mekanizmaları veya geçmiş durumları izleme gibi senaryolarda kullanışlıdır. Bir nesnenin durumu, Memento adı verilen özel bir nesne aracılığıyla kaydedilir ve bu Memento nesnesi daha sonra kullanılarak nesnenin önceki bir durumuna geri dönülebilir.

## 🤔Neden kullanılır ?

Memento tasarım deseni, bir nesnenin iç durumunun geçmiş durumlarını koruyup geri yüklemek istendiği durumlarda kullanılır. Özellikle bir nesnenin durumunun bir noktadan sonra değişebileceği ve bu değişikliklere geri dönebilme ihtiyacı duyulduğunda Memento deseni tercih edilir. Geri alma (undo) mekanizmaları, geçmiş durumları izleme, kullanıcı işlemlerini geri alma veya ileri alma gibi senaryolar Memento deseninin kullanımına uygun örneklerdir. Bu tasarım deseni, nesne durumunun dışa açılmadan, nesnenin kendi içinde yönetilmesini sağlayarak, esnek ve modüler bir geri alma mekanizması oluşturmayı amaçlar.
