# Observer Tasarım Deseni

## 🎯Nedir?

Observer tasarım deseni, bir nesnenin durumunda meydana gelen değişiklikleri takip eden ve bu değişikliklere tepki gösteren bağımlı nesneler arasında bir iletişim kurmayı sağlayan bir davranışsal tasarım desenidir. Bu desen, bir nesnenin durumu değiştikçe ve diğer nesneler bu değişikliklere tepki gösterdiğinde, bağımlı nesneleri otomatik olarak güncelleyerek sıkı bağımlılıkları azaltır. Gözlemleyen (Observer) ve gözlenen (Subject) arasındaki bu zayıf bağımlılıklar, sistemin daha esnek, genişletilebilir ve bakımı daha kolay hale gelmesini sağlar.

## 🤔Neden kullanılır ?

Observer tasarım deseni, özellikle bir nesnenin durumunda meydana gelen değişikliklerin diğer nesneleri etkilemesi veya bu değişikliklere tepki göstermesi gereken durumlarda observer deseni kullanışlıdır. Örneğin, bir modelin görünümüne veya bir veri kaynağına bağlı olan arayüz bileşenleri arasında senkronizasyon sağlamak, olay tabanlı sistemlerde güncellemeleri yayınlamak veya dağıtmak gibi senaryolarda observer deseni tercih edilir. Bu desen, sistemdeki bağımlılıkları azaltarak genişletilebilir ve sürdürülebilir bir tasarım sunar.
