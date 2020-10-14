using System;
using System.Xml.Resolvers;

namespace Firmware
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Firmware");

            Ecu edc17cp14 = new Ecu("Tricore", 4064, "Bosch", "0281030223");
            edc17cp14.FWgetInfo();


        }
    }


    class FW  // superclass
    {
        public FW(string FWdevice,int FWkb, string FWproducer, string FWnumber)
        {
            device = FWdevice;
            kb = FWkb;
            producer = FWproducer;
            number = FWnumber;

        }

        public void FWgetInfo()
        {
            Console.WriteLine($"FW Get Info \nDevice: {device} | Kb: {kb} |producer: {producer}|number: {number} ");
        }

        private string device;
        private int kb;
        private string producer;
        private string number;

    }

    class Ecu : FW  
    {
        public Ecu(string deviceEcu, int kbEcu, string producerEcu, string numberEcu) : base(deviceEcu, kbEcu, producerEcu, numberEcu)
        {
            Console.WriteLine("ECU");
        }
    }

    class Airbag
    {

    }

    class Dashboard
    {

    }

    class BodyComputer 
    {

    }


}
