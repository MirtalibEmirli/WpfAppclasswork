using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models;

public class userr
{
    public userr(string? ad, string? soyAd, string? gender, string? city, bool? step)
    {
        Ad = ad;
        SoyAd = soyAd;
        Gender = gender;
        this.city = city;
        this.step = step;
    }
    
    public string? Ad{ get; set; } 
    public string? SoyAd{ get; set; } 
    public string? Gender{ get; set; } 
    public string? city{ get; set; } 
    public bool? step{ get; set; }
    public override string ToString()
    {
        return $" Ad => { Ad} Soyad =>  {SoyAd} Gender =>  {Gender} City =>  {city} Step =>  {step}";
    }
}
