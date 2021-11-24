using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    interface ISpeaker
    {
        void LoudSpeaker();
        void Microphone();
    }
    interface IFrontCamera
    {
        void Camera();
    }
    interface IRearCamera
    {
        void Camera();
    }
    class Mobile : ISpeaker, IFrontCamera, IRearCamera//Multiple Inheritence from Interfaces is supoorted in C#
    {
        //public void Camera()
        //{
        //    Console.WriteLine("Camera() method in Mobile Classs");
        //}
        
        void IFrontCamera.Camera()
        {
            Console.WriteLine("FrontCamera() method in Mobile Classs");
        }

        void IRearCamera.Camera()
        {
            Console.WriteLine("RearCamera() method in Mobile Classs");
        }

        public void FrontCamera()
        {
            IFrontCamera ifc = new Mobile();
            ifc.Camera();
        }
        public void RearCamera()
        {
            IRearCamera irc = new Mobile();
            irc.Camera();
        }
       

        public void LoudSpeaker()
        {
            Console.WriteLine("LoudSpeaker() method in Mobile Classs");
        }

        public void Microphone()
        {
            Console.WriteLine("Microphone() method in Mobile Classs");
        }


    }
    class Laptop : ISpeaker
    {
        public void LoudSpeaker()
        {
            Console.WriteLine("LoudSpeaker() method in Laptop Classs");
        }

        public void Microphone()
        {
            Console.WriteLine("Micorphone() method in Laptop Classs");
        }
    }
    class WorkingWithInterfaces
    {
        static void Main(string[] args)
        {
            //ISpeaker speakerObj = new Mobile();
            //speakerObj.LoudSpeaker();
            //speakerObj.Microphone();
            //Console.WriteLine("*************************");
            //speakerObj = new Laptop();
            //speakerObj.LoudSpeaker();
            //speakerObj.Microphone();

            //demonstration of explicit implementation of the Interface Methods.
            Mobile obj = new Mobile();
            //obj.Camera();//error
            obj.FrontCamera();
            obj.RearCamera();

            IFrontCamera ifc = new Mobile();
            ifc.Camera();

            IRearCamera irc = new Mobile();
            irc.Camera();

            Console.Read();

        }
    }
    //class Demo:Mobile,Laptop//Inheritence from multiple base classes is not supported C#
    //{

    //}
}
