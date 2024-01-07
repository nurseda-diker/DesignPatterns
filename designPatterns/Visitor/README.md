# Visitor Tasarım Deseni

## 🎯Nedir?

Visitor tasarım deseni, bir nesne yapısını aynı tutarken, bu nesne yapısı üzerinde yeni işlemler eklemek istediğimiz durumlar için kullanılır. Visitor deseni, bir "ziyaretçi" nesnesi oluşturarak, nesne yapısındaki elemanları ziyaret eder ve bu elemanlara özgü işlemleri gerçekleştirmek için gerekli olan metotları sağlar. Bu sayede, yeni işlemler eklemek istendiğinde mevcut nesne hiyerarşisini değiştirmek zorunda kalmadan, yeni bir ziyaretçi sınıfı ekleyerek genişletme yapabiliriz. 

## 🤔Neden kullanılır ?

Visitor tasarım deseni, bir nesne yapısının üzerinde farklı işlemler gerçekleştirmek istendiği durumlarda kullanılır. Özellikle nesne yapısı genellikle değişmeyen, ancak bu nesneler üzerinde yeni işlemler eklemek veya mevcutları değiştirmek istendiğinde faydalıdır. Visitor deseni, açık kapalı ilkesine (Open/Closed principle) uyan bir tasarım deseni olarak, yeni işlemler eklemeyi kolaylaştırır ve mevcut nesne hiyerarşisini değiştirmek zorunda kalmadan genişletilebilir bir yapı sağlar. Örneğin, bir dil ağacı üzerinde farklı işlemler gerçekleştirmek, belirli türdeki nesneleri ziyaret ederek analiz yapmak veya dönüşümler uygulamak istendiğinde Visitor tasarım deseni kullanışlı olabilir.
