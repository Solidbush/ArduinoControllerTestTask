namespace ArduinoController.Models
{
    public class CarNumber : IEquatable<CarNumber>
    {
        private const int BeginSeria = 0;
        private const int SeriaLength = 6;
      
        public CarNumber(string number) 
        {
            string tempNumber = number.Trim().ToLower();
            Number = tempNumber.Substring(BeginSeria, SeriaLength);
            Region = tempNumber.Substring(SeriaLength);
        }

        public string Number { get; set; }
        public string Region { get; set; }

        public bool Equals(CarNumber? other)
        {
            if (other == null)
                return false;

            if (Region == other.Region && Number == other.Number)
                return true;
            else
                return false;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as CarNumber);
        }

        public override int GetHashCode()
        {
            throw new NotImplementedException();
        }
    }
}
