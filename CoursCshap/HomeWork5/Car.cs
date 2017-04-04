using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public class Car
    {
        public Detail[] DetailsArray;
        private uint _countOfWheel;
        private uint _countOfDoor;
        private uint NumberofWheel { get; }
        private uint NumberofDoor { get; set; }
        public string Model;

        private string _model
        {
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(value), "Ошибка - модел автомобил");
                Model = value;
            }
        }

        public Car(uint countOfWheel, uint countOfDoor, uint numberofWheel, uint numberofDoor, string model)
        {
            _countOfWheel = countOfWheel;
            _countOfDoor = countOfDoor;
            NumberofWheel = numberofWheel;
            NumberofDoor = numberofDoor;
            this.DetailsArray = InitializeDetailsArrray();
            this._model = model;
        }

        private Detail[] InitializeDetailsArrray()
        {
            return new Detail[] { new Body(), new Wheel(NumberofWheel), new Door(NumberofDoor), };
        }
    }
}
