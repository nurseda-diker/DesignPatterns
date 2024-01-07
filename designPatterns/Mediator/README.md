# Mediator Tasarım Deseni

## 🎯Nedir?

Mediator tasarım deseni, bir grup nesne arasındaki etkileşimi düzenlemek ve bu nesneler arasındaki bağımlılıkları azaltmak amacını taşır. Bu desen, nesneler arasındaki iletişimi merkezi bir ara birim (mediator) üzerinden gerçekleştirir. Nesneler, birbirleriyle doğrudan iletişim kurmak yerine, bu ara birim aracılığıyla etkileşime geçerler. Mediator, sistemin karmaşıklığını azaltır ve nesneler arasındaki bağımlılıkları azaltarak sistemin daha bakımı kolay, esnek ve genişletilebilir olmasını sağlar. 

## 🤔Neden kullanılır ?

Mediator tasarım deseni, bir sistemdeki nesneler arasındaki sıkı bağımlılıkları azaltmak ve iletişimi düzenlemek istediğimiz durumlarda kullanılır. Özellikle birbirleriyle doğrudan etkileşim halinde olan nesnelerin sayısı arttıkça veya sistemdeki değişikliklerin diğer nesneler üzerindeki etkilerini kontrol altında tutmak istediğimizde kullanışlıdır. Örneğin, bir grafiksel kullanıcı arayüzü uygulamasında, butonlar, metin kutuları ve menüler arasındaki etkileşimleri düzenlemek için Mediator deseni kullanılabilir. Bu desen, bağımlılıkları merkezi bir noktada toplar, böylece sistemdeki değişiklikler daha yönetilebilir olur ve nesneler arasındaki iletişim karmaşıklığı azaltılır.

