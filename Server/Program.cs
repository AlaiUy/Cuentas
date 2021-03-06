﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(8080);
            ChannelServices.RegisterChannel(channel, false);

            ServiceClass object1 = new ServiceClass();

            // Creates the single instance of ServiceClass. All clients
            // will use this instance.

            ObjRef ref1 = RemotingServices.Marshal(object1, "object1uri");
            Console.WriteLine("ObjRef.URI: " + ref1.URI);

            Console.WriteLine("Running. Press Enter to end publication.");
            Console.ReadLine();

            // This unregisters the object from publication, but leaves
            // the channel listening.
            RemotingServices.Disconnect(object1);
            Console.WriteLine();
            Console.WriteLine("Disconnected the object. Client now receives a RemotingException.");
            Console.WriteLine("Press Enter to unregister the channel.");
            Console.ReadLine();

            // At this point, the ServerClass object still exists. The server
            // could republish it.

            // This unregisters the channel, but leaves the application 
            // domain running.
            ChannelServices.UnregisterChannel(channel);
            Console.WriteLine("Unregistered the channel. Client now receives a WebException.");

            // The ServerClass object still exists. The server could
            // reregister the channel and republish the object.
            Console.WriteLine("The host application domain is still running. Press Enter to stop the process.");
            Console.ReadLine();

            // The ServiceClass object's Finalize method writes a message to
            // the console. A single object will almost always succeed in 
            // running its Finalize method before the Console is finalized;
            // in a larger application, you could ensure that all objects 
            // finalize before the application ends by calling the garbage 
            // collector and waiting.
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
