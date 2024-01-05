# Builder Tasarım Deseni

## 🎯Nedir?


Builder tasarım deseni, creational (oluşturucu) tasarım desenlerinden biridir ve karmaşık nesne oluşturma süreçlerini yönetmek, adım adım inşa etmek ve nesnenin farklı sunumlarına sahip olmasını sağlamak amacıyla kullanılır. Bu desen, bir nesne oluşturma sürecini soyut bir arayüz üzerinden adım adım yürüten ve bu adımları farklı şekillerde implemente eden bir sınıf hiyerarşisi içerir. 

## 🤔Neden kullanılır ?

Builder tasarım deseni, özellikle karmaşık nesnelerin adım adım oluşturulması ve farklı sunum varyasyonlarının yönetilmesi gerektiği durumlarda kullanılır. Bu desen, bir nesnenin yapısını oluşturan adımların sıralı bir şekilde gerçekleştirilmesini sağlar, ancak bu adımların nasıl gerçekleştirileceği ConcreteBuilder sınıfları tarafından belirlenir. Böylece, aynı nesne için farklı oluşturma süreçleri uygulanabilir ve istemciler, oluşturulan nesnenin farklı sunumlarına sahip olabilir. Builder tasarım deseni, nesne oluşturma süreçlerini modülerleştirir, değişikliklere açık hale getirir ve aynı yapıdaki nesnelerin farklı varyasyonlarının oluşturulmasını kolaylaştırır, bu da kodun daha esnek ve bakımı daha kolay hale gelmesini sağlar.
