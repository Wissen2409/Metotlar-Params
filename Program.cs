


// Metotlar belli sayılarda parametre alırlar
// bu parametreleri bir keyword ile sınırsız hale getirmek mümkündür ? 


// Params keyword'ü, bir metodun sınırsız adet parametre almasını sağlar.


// Kullalım : 

using System.Text;

SinirsizParametre(10,20,30,10,230,40,20,10,20,40,2043,203,2030,30402,34040,2030304,302020,10);

static void SinirsizParametre(params int[] parameters){


// Params keyword'ü ile sınırsız parametreli bir metot yazabilirsiniz, 

// PArams ile alınan sınırsız parametrelere metot içerisinde nasıl erişebiliriz.

// Params ile gelen parametreler dizi üzerinden yakalanabilir

// Örnek : Yukarıda girilen sınırsız adet parametre değerlerinin ortalamalasını alalım
int toplam = 0;
foreach(int item in parameters){
toplam+=item;

}
Console.WriteLine("Toplam : {0} Ortalama : {1}",toplam,toplam/parameters.Length);
}
