namespace Enigma
{
    using System.Collections.Generic;

    public interface IReflector
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
    }

}
