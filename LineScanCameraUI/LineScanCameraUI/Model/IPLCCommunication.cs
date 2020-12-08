using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SXJLibrary
{
    public interface IPLCCommunication
    {
        /// <summary>
        /// 置位M
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">布尔值</param>
        void SetM(string address, bool value);
        /// <summary>
        /// 读取M
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns>返回布尔值</returns>
        bool ReadM(string address);
        /// <summary>
        /// 批量置位M
        /// </summary>
        /// <param name="address">起始地址</param>
        /// <param name="value">布尔值数组</param>
        void SetMultiM(string address, bool[] value);
        /// <summary>
        /// 批量读取M
        /// </summary>
        /// <param name="address">其实地址</param>
        /// <param name="length">长度</param>
        /// <returns>返回布尔值数组</returns>
        bool[] ReadMultiM(string address, ushort length);
        /// <summary>
        /// 读单字
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns>返回值</returns>
        int ReadD(string address);
        /// <summary>
        /// 写单字
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">设置值</param>
        void WriteD(string address, short value);
        /// <summary>
        /// 写多个单字
        /// </summary>
        /// <param name="address">起始地址</param>
        /// <param name="value">设置值数组</param>
        void WriteMultD(string address, short[] value);
        /// <summary>
        /// 写双字
        /// </summary>
        /// <param name="address">地址</param>
        /// <param name="value">设置值</param>
        void WriteW(string address, int value);
        /// <summary>
        /// 写多个双字
        /// </summary>
        /// <param name="address">起始地址</param>
        /// <param name="value">设置值数组</param>
        void WriteMultW(string address, int[] value);
        /// <summary>
        /// 读双字
        /// </summary>
        /// <param name="address">地址</param>
        /// <returns>返回值</returns>
        int ReadW(string address);
        /// <summary>
        /// 读多个双字
        /// </summary>
        /// <param name="address">起始地址</param>
        /// <param name="length">长度</param>
        /// <returns>返回值数组</returns>
        int[] ReadMultiW(string address, ushort length);
    }
}
