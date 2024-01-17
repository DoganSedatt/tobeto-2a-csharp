using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Transmission
{
    public class AddTransmissionRequests
    {//Burada hangi verileri gönderecek isek onları yazıyoruz
        public string Name { get; set; }

        public AddTransmissionRequests(string name)
        {
            Name = name;
        }
    }
}
