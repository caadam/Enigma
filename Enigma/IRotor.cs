namespace Enigma
{
    using System.Collections.Generic;

    public interface IRotor
    {
        /// <summary>
        /// 
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 
        /// </summary>
        List<RotorMapping> Mapping { get; }

        /// <summary>
        /// 
        /// </summary>
        string Layout { get; }

        /// <summary>
        /// Sets/Gets the internal ring offset
        /// </summary>
        int Ringstellung { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int Inbound(int position);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        int Outbound(int position);

        /// <summary>
        /// 
        /// </summary>
        bool IsTurnoverPoint(int position);
    }
}