using ArduinoController.Models;

namespace ArduinoController.Services
{
    public interface IProcessCheker
    {
        public void AddNumberInQueue(CarNumber newCarNumber);

        public void DeleteNumberInQueue(CarNumber carNumber);

        public void AddNewCarNumberInDB(CarNumber carNumber);

        public void DeleteCarNumberFromDB(CarNumber carNumber);

        public IEnumerable<CarNumber> GetAllCarNumbersInQueue();

    }
}
