using ArduinoController.Models;

namespace ArduinoController.Entities
{
    public class DataBase
    {
        private List<CarNumber> carNumbers;
        public DataBase() 
        {
            carNumbers = new List<CarNumber>()
            {
                new CarNumber("У666МР111"),
                new CarNumber("А064АА124"),
                new CarNumber("С902СС156"),
                new CarNumber("Т888ММ721"),
                new CarNumber("Т888АМ341"),
                new CarNumber("Т888РМ13"),
                new CarNumber("Т888ЕЕ99"),
            };
        }

        public void AddNumber(CarNumber carNumber)
        {
            if (!carNumbers.Contains(carNumber))
                carNumbers.Add(carNumber);
        }

        public IEnumerable<CarNumber> GetCarNumbers() 
        {
            return carNumbers.ToArray();
        }

        public bool CheckCarNumber(CarNumber carNumber)
        {
            if (carNumbers.Contains(carNumber))
                return true;
            else
                return false;
        }

        public void DeleteCarNumber(CarNumber carNumber)
        {
            if (carNumbers.Contains(carNumber))
                carNumbers.Remove(carNumber);
        }
    }
}
