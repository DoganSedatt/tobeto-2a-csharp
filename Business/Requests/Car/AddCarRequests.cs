namespace Business
{
    public class AddCarRequest
    {
        public string Name { get; set; }
        public int ModelYear { get; set; }
        public AddCarRequest(string name,int modelYear)
        {
            Name = name;
            ModelYear = modelYear;
        }
    }
}