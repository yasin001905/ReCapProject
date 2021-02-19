using System;
using System.Collections.Generic;
using System.Text;

namespace ReCap.ConsoleUI
{
    class DersNot
    {/*
      Önclikle mimariyi oluşturuyoruz. 
        Entities, Dal, Business, UI katmanları oluşturduktan sonra
        Bu katmanlar içerisinde klasörlemeye gidiyoruz. *Abstrack ve Concrete klasörleri oluşturuyoruz.
        Entities Concrete klasörü içerisinde classları oluşturup tablolarımızın property lerini veriyoruz.
        Daha sonra hiçbir class boş kalmasın mantığında entities abstrack ' ta IEntity interface i oluşturup Concrete deki claslara implement ediyoruz : IEntity şeklinde.

        Daha sonra Data Access Layerda Veri Erişim yapıyoruz. Sql, Exell vs gibi yerlerden verilere erişim yapacağız.
        Dal Abstrack klasörü içerisinde entities concrete içerisindeki clasların interface i oluşturuyoruz. 
        ICarDal, IBrandDal gibi...
        Daha sonra interface içerisinde Ekleme Silme güncelleme Getirme fonksiyonlarını yazıyoruz 
        Örn: List<Car> GetAll(); gibi ...
        Bu tür operasyonları yaptıktan sonra Dal Concrete klasörü içerisinde alternatif klasörleri oluşturuyoruz.
        EntityFramework, InMemory gibi vs...
        InMemory kısmında oluşturduğumuz interface i iş yapan class haline getireceğiz.
        InMemoryCarDal gibi buna ICarDal ı implemente ediyoruz.

        inmemoryCarDal içerisinde nesnemizi (Car) list olarak alıyoruz. List<Car> _cars; olarak daha sonra 
        Ctor ile constracter oluşturup car ' ı içerisinde newleyoruz. İçerisine ürünleri giriyoruz.
        _cars = new List<Car> { 
        
        new Car{ Id = 1  }
        new Car{ Id = 2  } vs gibi
        
        };

      
        => Lambda işareti
        Linq - Language Integrated Query

        Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId); gönderdiğim ürün id sine sahip olan listedeki ürünü bul !!!****

        Burada Add,Delete , Update , Getall operasyonlarının içerisini doldurduktan sonra 
        Business Abstrack ta Serviceleri yazıyoruz. ICarService, IColorService, IBrandService interfaceleri vs. 

        Bunlar iş katmanında kullanacağımız servis operasyonları 
        Daha sonra iş katmanında İş kodlarını yazdığımız clasları oluşturuyoruz CarManager gibi bunlara service leri implement ediyoruz.

      
      */
    }
}
