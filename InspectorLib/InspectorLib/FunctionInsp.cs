using System;
using System.Collections.Generic;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string chiefInspector = "Васильев Василий Иванович";
        private string carInspectionName = "Автоинспекция г. Чита";
        private List<string> workers = new List<string>() { "Иванов И.И.", "Зиронов Т.А.", "Миронов А.В.", "Васильев В.И." };
        private Random random = new Random();


        public string GetInspector()
        {
            return chiefInspector;
        }

        public string GetCarInspection()
        {
            return carInspectionName;
        }

        public bool SetInspector(string fullName)
        {
            if (workers.Contains(fullName))
            {
                chiefInspector = fullName;
                return true;
            }
            return false;
        }

        public string GenerateNumber(char symbol, int number, int code = 75) // код региона по умолчанию 75
        {
            return $"{symbol.ToString().ToUpper()}{number:D3}_{code:D2}"; // D3 - 3 цифры, D2 - 2 цифры
        }

        public List<string> GetWorker()
        {
            return workers;
        }

        public bool AddWorker(string fullName)
        {
            if (!workers.Contains(fullName))
            {
                workers.Add(fullName);
                return true;
            }
            return false;
        }

        public int GenerateRandomNumber()
        {
            return random.Next(1, 1000); // Генерирует случайное число от 1 до 999
        }
    }
}
