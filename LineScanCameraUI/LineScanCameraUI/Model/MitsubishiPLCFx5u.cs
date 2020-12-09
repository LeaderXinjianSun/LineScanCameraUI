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
            try
            {
                int _add = int.Parse(address.Substring(1,address.Length - 1)) + +8192;
                int[] values = Fx5u.ModbusRead(1, 1, _add);
                if (values != null)
                {
                    return values[0] == 1;
                }
                else
                {
                    return false;
                }
            }
            catch                
            {
                return false;
            }
            
        }

        public bool[] ReadMultiM(string address, ushort length)
        {
            try
            {
                int _add = int.Parse(address.Substring(1, address.Length - 1)) + +8192;
                int[] values = Fx5u.ModbusRead(1, 1, _add,length);
                
                if (values != null)
                {
                    bool[] rst = new bool[values.Length];
                    for (int i = 0; i < values.Length; i++)
                    {
                        rst[i] = values[i] == 1;
                    }
                    return rst;
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public int[] ReadMultiW(string address, ushort length)
        {
            throw new NotImplementedException();
        }

        public int ReadW(string address)
        {
            try
            {
                int _add = int.Parse(address.Substring(1, address.Length - 1));
                int[] values = Fx5u.ModbusRead(1, 3, _add, 2);
                if (values != null)
                {
                    return Convert.ToInt32(values[1].ToString("X4") + values[0].ToString("X4"), 16);
                }
                else
                {
                    return 0;
                }
            }
            catch 
            {
                return 0;
            }
        }

        public void SetM(string address, bool value)
        {
            try
            {
                int _add = int.Parse(address.Substring(1, address.Length - 1)) + 8192;
                int[] _values = new int[1];
                _values[0] = value ? 1 : 0;
                Fx5u.ModbusWrite(1, 15, _add, _values);
            }
            catch 
            {

            }
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
            try
            {
                int _add = int.Parse(address.Substring(1, address.Length - 1));
                int[] _values = new int[2];
                _values[1] = Convert.ToInt32(value.ToString("X8").Substring(0, 4), 16);
                _values[0] = Convert.ToInt32(value.ToString("X8").Substring(4, 4), 16);
                Fx5u.ModbusWrite(1, 16, _add, _values);
            }
            catch
            {

            }
        }
    }
}
