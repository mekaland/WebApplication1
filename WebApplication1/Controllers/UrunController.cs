using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
	public class UrunController : Controller
	{
		//contoller içeriisne bir ürün listesi oluşturduk ve bu listeyi ilgili viewe model olarak göndericem 
	
		public IActionResult Index()
		{
			List<Urun> urunler = new List<Urun>()
			{
				new Urun(){UrunId = 1,UrunAdi="s21",Aciklama="idare eder",Fiyat=200,Satistami=true},
				new Urun(){UrunId = 2,UrunAdi="s22",Aciklama="idare eder",Fiyat=300,Satistami=false},
				new Urun(){UrunId = 3,UrunAdi="s23",Aciklama="idare eder",Fiyat=400,Satistami=true},
				new Urun(){UrunId = 4,UrunAdi="s24",Aciklama="idare eder",Fiyat=500,Satistami=false},
				new Urun(){UrunId = 5,UrunAdi="s25",Aciklama="idare eder",Fiyat=600,Satistami=true},
			};

			ViewBag.urunSayisi = urunler.Count();
			return View(urunler);
		}
	}
}
