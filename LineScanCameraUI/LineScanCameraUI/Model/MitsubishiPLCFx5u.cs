using DXH.Modbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXJLibrary
{
    public class MitsubishiPLCFx5u : IPLCCommunication
    {
        public event EventHandler<bool> ConnectStateChanged;
        public DXHModbusTCP Fx5u;
        
        public MitsubishiPLCFx5u(string ip, int port)
        {
            Fx5u = new DXHModbusTCP(ip, port);
            Fx5u.ConnectStateChanged += Fx5u_ConnectStateChanged;
        }

        private void Fx5u_ConnectStateChanged(object sender, string e)
        {
            if (ConnectStateChanged != null)
                ConnectStateChanged(null, e == "Connected");
        }

        public void Start()
        {
            Fx5u.StartConnect();
        }
        public int ReadD(string address)
        {
            throw new NotImplementedException();
        }

        public bool ReadM(string address)
        {
            throw new NotImplementedException();
        }

        public bool[] ReadMultiM(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public int[] ReadMultiW(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public int ReadW(string address)
        {
            throw new NotImplementedException();
        }

        public void SetM(string address, bool value)
        {
            throw new NotImplementedException();
        }

        public void SetMultiM(string address, bool[] value)
        {
            throw new NotImplementedException();
        }

        public void WriteD(string address, short value)
        {
            throw new NotImplementedException();
        }

        public void WriteMultD(string address, short[] value)
        {
            throw new NotImplementedException();
        }

        public void WriteMultW(string address, int[] value)
        {
            throw new NotImplementedException();
        }

        public void WriteW(string address, int value)
        {
            throw new NotImplementedException();
        }
    }
}
