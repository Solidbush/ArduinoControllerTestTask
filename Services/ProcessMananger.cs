using ArduinoController.Entities;
using ArduinoController.Models;

namespace ArduinoController.Services
{
    public class ProcessMananger : IProcessCheker
    {
        private List<Models.CarNumber> carNumberQueue;
        private DataBase dataBase;

        public ProcessMananger()
        {
            carNumberQueue = new List<CarNumber>();
            dataBase = new DataBase();
        }

        public void AddNewCarNumberInDB(CarNumber carNumber)
        {
            dataBase.AddNumber(carNumber);
        }

        public void AddNumberInQueue(CarNumber newCarNumber)
        {
            if (dataBase.CheckCarNumber(newCarNumber))
                carNumberQueue.Add(newCarNumber);
        }

        public void DeleteCarNumberFromDB(CarNumber carNumber)
        {
            dataBase.DeleteCarNumber(carNumber);
        }

        public void DeleteNumberInQueue(CarNumber carNumber)
        {
            if (carNumberQueue.Contains(carNumber))
                carNumberQueue.Remove(carNumber);
        }

        public IEnumerable<CarNumber> GetAllCarNumbersInQueue()
        {
            return carNumberQueue;
        }
    }
}
