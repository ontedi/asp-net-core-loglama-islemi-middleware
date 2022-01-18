using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AspNetCoreMiddleware
{
    public class LoglamaIslemiMiddleware
    {
        private readonly RequestDelegate _rdIstek;
        public LoglamaIslemiMiddleware(RequestDelegate rdIstek)
        {
            _rdIstek = rdIstek;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            string strIp = httpContext.Connection.RemoteIpAddress.ToString();
            string strTarayiciBilgileri = httpContext.Request.Headers["User-Agent"];
            string strAdresSatiri = httpContext.Request.QueryString.ToString();
            string strPatika = "D:/calisma-masasi/dotnetcore/ornekler/AspNetCoreMiddleware/log.txt";
            using (StreamWriter swYazici = System.IO.File.AppendText(strPatika))
            {
                swYazici.WriteLine("#### Request (BASLANGIC) ####");
                swYazici.WriteLine("Ip Adresi: " + strIp);
                swYazici.WriteLine("Tarayıcı Bilgileri: " + strTarayiciBilgileri);
                swYazici.WriteLine("Adres Satiri: " + strAdresSatiri);
                swYazici.WriteLine("Tarih: " + DateTime.Now);
                swYazici.WriteLine("#### Request (BITIS) ####");
                swYazici.WriteLine("\n");
            }
            await _rdIstek.Invoke(httpContext);
        }
    }
}
