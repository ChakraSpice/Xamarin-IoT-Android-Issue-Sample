using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace IoTX
{ 
    public class IoT
    {
        private DeviceClient deviceClient;

        public IoT(string connectionString)
        {
            deviceClient = DeviceClient.CreateFromConnectionString(connectionString, TransportType.Http1);
        }

        public async Task SendMessage(object data)
        {
            try
            {
                Message message = new Message(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)));
                if (deviceClient != null)
                {
                    await deviceClient.SendEventAsync(message);
                }
                else Debug.WriteLine("Message failed to send" + JsonConvert.SerializeObject(data));
            }
            catch
            {
                Debug.WriteLine("EXCEPTION!");
            }
        }
    }
}
