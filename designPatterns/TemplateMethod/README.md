# Template Method Tasarım Deseni

## 🎯Nedir?

Template Method tasarım deseni, nesne yönelimli programlamada kullanılan bir tasarım deseni olup bir algoritmanın yapısını tanımlar ancak bu algoritmanın belirli adımlarını alt sınıflara bırakarak, alt sınıfların bu adımları kendi özel ihtiyaçlarına göre uyarlamasına olanak tanır. Temel algoritma, bir üst sınıf içinde genel olarak tanımlanır ve belirli adımlar (metodlar) alt sınıflar tarafından uygulanabilir şekilde bırakılır. Böylece, farklı alt sınıflar aynı temel algoritmayı kullanabilir ancak belirli adımları kendi özel mantıklarıyla uygulayabilirler. Bu desen, kod tekrarını azaltmak, bakımı kolaylaştırmak ve genişletmeyi desteklemek gibi avantajlar sağlar.

## 🤔Neden kullanılır ?

Template Method tasarım deseni, bir algoritmanın genel yapısını tanımlayan ancak belirli adımların alt sınıflar tarafından uyarlanmasına izin veren durumlarda kullanılır. Eğer bir grup sınıf benzer bir algoritmayı paylaşıyorsa, ancak belirli adımları farklı implemente etmek gerekiyorsa Template Method deseni kullanışlı olabilir. Bu desen, aynı temel algoritmayı paylaşan ancak bu algoritmanın belirli kısımlarını özelleştirmek isteyen sınıflar arasında kod tekrarını önler ve bakımı kolaylaştırır. Ayrıca, bir üst sınıfın genel algoritmasını değiştirmek istendiğinde, sadece bu sınıfı güncellemek yeterli olacaktır, bu da sistemin daha esnek ve genişletilebilir olmasını sağlar.
