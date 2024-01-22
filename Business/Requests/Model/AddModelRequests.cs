using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Model
{
    public class AddModelRequests
    {
        //Ekleme yaparken direkt varlığımızı değilde varlığımıza denk gelen  DTO'yu kullanırız
        //Prop ve cons tanımlicaz
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }

        public AddModelRequests(string modelName,int modelYear, int dailyPrice,int brandId,int fuelId,int transmissionId )
        {
            ModelName = modelName;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;

        }




    }
}
