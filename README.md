# Tasarım Desenleri Projesi

Bu proje, C# programlama dilini kullanarak çeşitli tasarım desenleri üzerine örnekler içermektedir.

##  ℹ️ Tasarım Desenleri Nedir?

Tasarım desenleri, yazılım mühendisliğinde karşılaşılan genel problemlere yönelik önerilen çözüm yollarını sağlayan tekrarlanabilir ve ölçeklenebilir çözüm şablonlarıdır. Bu şablonlar, belirli tasarım sorunlarına karşı test edilmiş ve etkili çözümler sunarak yazılım geliştirme süreçlerini iyileştirmeyi amaçlar.

## 🚀 Neden Tasarım Desenleri Kullanılır?

Tasarım desenleri kullanmanın bazı avantajları şunlardır:

- **Tekrar Kullanılabilirlik:** Tasarım desenleri, genel sorunları ele almak için oluşturulmuş tekrar kullanılabilir şablonlardır. Bu sayede, aynı tasarım problemleri için sürekli benzer çözümler yazmak yerine, bu şablonları kullanarak geliştirme sürecini hızlandırabilirsiniz.

- **Mimari Esneklik:** Tasarım desenleri, yazılım mimarisini daha esnek hale getirerek değişikliklere daha iyi adapte olmayı sağlar. Bu, yazılımın ölçeklendirilebilir ve sürdürülebilir olmasına yardımcı olur.

- **Ortak Dil:** Tasarım desenleri, geliştirici ekibinin birbirleriyle daha etkili iletişim kurmalarına yardımcı olacak bir ortak dil sağlar. Belirli bir desenin adını kullanarak, ekibin tasarım kararları ve uygulamaları hakkında daha kolay konuşmalarını sağlar.

## 📂 Proje İçeriği

Proje içinde aşağıdaki tasarım desenleri örnekleri bulunmaktadır:

### Creational (Oluşturucu) Desenler
Oluşturucu tasarım desenleri, nesnelerin oluşturulmasıyla ilgilenir ve nesnelerin nasıl oluşturulduğunu kontrol etmeye odaklanır. Temel amaç, bir nesnenin oluşturulma sürecini soyutlamak ve bu süreci mümkün olduğunca bağımsız hale getirmektir. Oluşturucu tasarım desenleri şunları içerir:
- [Singleton Pattern](./Singleton) 🏠: Tek bir örneğinin olduğundan emin olmak için kullanılır.
- [Factory Method Pattern](./FactoryMethod) 🏭: Alt sınıfların bir ürün oluşturmasını sağlayan bir yöntem tanımlar.
- [Abstract Factory Pattern](./AbstractFactory) 🏭: İlgili veya bağımlı nesnelerin bir ailesini oluşturmak için kullanılır.
- [Prototype Pattern](./Prototype) 🔄: Bir nesnenin kopyasını oluşturmak için kullanılır.
- [Builder Pattern](./Builder) 🛠️: Karmaşık nesnelerin adım adım inşa edilmesini sağlar.
- [Multiton Pattern](./Multiton) 🏰: Belirli bir anahtar ile ilişkilendirilmiş sınıfların tek örneklerini oluşturmak için kullanılır.

### Structural (Yapısal) Desenler
Yapısal tasarım desenleri, sınıfların veya nesnelerin birbirleriyle nasıl bağlandığını düzenlemek için kullanılır. Temel amaç, sistemdeki bileşenler arasındaki ilişkileri organize etmek ve sağlamak için tasarım şablonları sunmaktır. Yapısal tasarım desenleri şunları içerir:
- [Facade Pattern](./Facade) 🏰: Bir alt sistemden gelen karmaşık bir seti basitleştirmek için kullanılır.
- [Adapter Pattern](./Adapter) 🔄: Farklı bir arabirim sağlayan bir sınıfın mevcut bir arabirimi uygulamasını sağlar.
- [Composite Pattern](./Composite) 🌲: Nesnelerin hiyerarşik ağaçlarına tek bir nesne gibi davranmak için kullanılır.
- [Proxy Pattern](./Proxy) 🔒: Başka bir nesneye erişimi kontrol etmek veya üzerine ek işlevsellik eklemek için kullanılır.
- [Decorator Pattern](./Decorator) 🎨: Bir nesneye dinamik olarak yeni sorumluluklar eklemek için kullanılır.
- [Bridge Pattern](./Bridge) 🌉: Soyutlamayı uygulamadan ayrı bir hiyerarşi oluşturmak için kullanılır.
- [Dependency Injection Pattern](./DependencyInjection) 🚰: Bağımlılıkları enjekte etmek için kullanılır.

### Behavioral (Davranışsal) Desenler
Davranışsal tasarım desenleri, nesneler arasındaki işbirliği, iletişim ve sorumlulukları düzenlemek için tasarlanmıştır. Temel amaç, nesnelerin davranışlarını tanımlamak ve düzenlemek için tasarım şablonları sunmaktır. Davranışsal tasarım desenleri şunları içerir:
- [Strategy Pattern](./Strategy) 🎯: Bir algoritmayı temsil eden bir aile içindeki algoritmaları tanımlar ve değiştirilebilir kılar.
- [Observer Pattern](./Observer) 👀: Bir nesnenin durumunda bir değişiklik olduğunda, bağımlı nesneler bu değişiklikten haberdar edilir.
- [Chain of Responsibility Pattern](./ChainOfResponsibility) 🔗: İstekleri işleyen nesneler zinciri oluşturmak için kullanılır.
- [Memento Pattern](./Memento) 🕰️: Bir nesnenin iç durumunu kaydetmek ve geri yüklemek için kullanılır.
- [Template Method Pattern](./TemplateMethod) 📑: Bir algoritmanın yapısını tanımlar, ancak bazı adımları alt sınıflara bırakır.
- [State Pattern](./State) 🚦: Bir nesnenin davranışını durum değişikliklerine bağlı olarak değiştirmek için kullanılır.
- [Mediator Pattern](./Mediator) 🤝: Nesneler arasındaki iletişimi merkezi bir noktaya taşımak için kullanılır.
- [Command Pattern](./Command) 📜: Bir isteği bir nesne olarak temsil etmek ve bu isteği parametreli bir şekilde sıralamak için kullanılır.
- [Visitor Pattern](./Visitor) 🛠️: Bir nesne yapısındaki her elemana yeni bir işlem eklemek için kullanılır.
- [Null Object Pattern](./NullObject) 🅾️: Null nesneleri kullanarak kontrol ifadelerini azaltmak için kullanılır.

## 📬Benimle İletişime Geçin

Eğer sorularınız varsa veya projeye katkıda bulunmak istiyorsanız, benimle iletişime geçmekten çekinmeyin: </br> </br>
[![LinkedIn](https://img.shields.io/badge/LinkedIn-Connect-blue?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/nursedadiker/)
[![Gmail](https://img.shields.io/badge/Gmail-Send%20an%20Email-red?style=for-the-badge&logo=gmail&logoColor=white)](mailto:nursedadiker760@gmail.com)
