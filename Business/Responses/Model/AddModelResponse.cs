using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Model
{
    public class AddModelResponse
    {
        //AddModelREquests sınıfında ,Model eklerken kullanıcının vermesi gereken alanları yazdık
        //Bu sınıfta ise kullanıcın ekleyemeyeceği ancak eklenmesi gereken alanları yazıyoruz
        public int Id { get; set; }
        public string ModelName { get; set; }
        public DateTime CreatedAt { get; set; }

        
        public AddModelResponse(int id,string modelName,DateTime createdAt)
        {
            Id = id;
            ModelName = modelName;
            CreatedAt = createdAt;
           
            
        }
    }
}
