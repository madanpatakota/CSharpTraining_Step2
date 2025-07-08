using System;

namespace RemotingSystem
{
    /// <summary>
    /// Interface provides rules and it would't implemenet
    /// </summary>

    interface IRemote
    {
        void PowerOn();
        void PowerOff();

        void ChangeChannel(int channerlNumber);

        void IncreaseVolume();

    }
    //I would like to take the contract of IRemote

    interface IRemotePrice
    {
        string getPriceDetails();
    }
    //ctrl+.
    
    interface IRemoteLocationDetails
    {
        string getLocation();
    }
    
    class SonyRemote : IRemote , IRemotePrice
    {
        public void ChangeChannel(int channerlNumber)
        {
            Console.WriteLine($"Sony TV changed to channel {channerlNumber}.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Sony TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("Sony TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("Sony TV is now ON.");
        }
    
        public string getPriceDetails()
        {
            return "500Rupees";
        }

    }

    class LGRemote : IRemote , IRemoteLocationDetails
    {
        public void ChangeChannel(int channerlNumber)
        {
            Console.WriteLine($"LG TV changed to channel {channerlNumber}.");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("LG TV volume increased.");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG TV is now Off.");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG TV is now On.");
        }
   
        public string getLocation()
        {
            return "Bengolore";
        }


    }



    // Before implement check the - Interface along with Class 
    class Program
    {
        static void Main()
        {
            IRemote lgremote = new LGRemote();
            lgremote.ChangeChannel(1);

            IRemote sonyremote = new SonyRemote();
            sonyremote.ChangeChannel(9);

            IRemotePrice remotePrice = new SonyRemote();
            string price = remotePrice.getPriceDetails();
            Console.WriteLine(price);

            IRemoteLocationDetails locationDetails = new LGRemote();
            string location =  locationDetails.getLocation();
            Console.WriteLine(location);

        }
    }

}




