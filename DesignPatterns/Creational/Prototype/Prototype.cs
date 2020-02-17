using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{

    public interface IPrototype<T>
    {
        T Clone();
    }

    public class ElectronicDevice : IPrototype<ElectronicDevice>
    {
        public Screen Screen { get; set; }
        public ElectronicDevice()
        {

        }
        public ElectronicDevice(ElectronicDevice electronicDevice)
        {
            Screen = electronicDevice.Screen.Clone();
        }
        public ElectronicDevice Clone()
        {
            return new ElectronicDevice(this);
        }
    }

    public class Mobile : ElectronicDevice, IPrototype<Mobile>
    {
        public Camera Camera { get; set; }
        public RAM RAM { get; set; }
        public Mobile()
        {

        }
        public Mobile(Mobile mobile) : base(mobile)
        {
            Camera = mobile.Camera.Clone();
            RAM = mobile.RAM.Clone();
        }
        public new Mobile Clone()
        {
            return new Mobile(this);
        }
    }
}
