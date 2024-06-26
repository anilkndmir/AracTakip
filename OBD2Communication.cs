using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCareProApp
{
    public class OBD2Communication
    {
        private SerialPort _serialPort;

        public OBD2Communication(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        public void SendCommand(string command)
        {
            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(command);
            }
        }

        public string ReadResponse()
        {
            if (_serialPort.IsOpen)
            {
                return _serialPort.ReadLine();
            }
            return null;
        }
    }
}
