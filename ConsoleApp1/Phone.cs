using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Phone
    {
        public string Model { get; set; }
        public string Price { get; set; }

        public void Call(string number)
        {
            Dialing(number);
        }

        private void Dialing(string number) { }
    }

    public class PhoneWithCamera : Phone
    {
        public void GetPhoto()
        {
            var capture = GetCapture();
            SavePhoto(capture);
        }
        private Photo GetCapture()
        {
            return new Photo();
        }
        private void SavePhoto(object capture){ }
    }

    public class SmartPhone : PhoneWithCamera
    {

    }

    public class Photo
    {
        public string Name { get; set; }
        public int Size
        {
            get { return Height * Weight; }
        }

        public int Height { get; set; }
        public int Weight { get; set; }
        public Photo()
        {
            Name = "Photo("+DateTime.Now.ToString()+")";
        }

    }
}
