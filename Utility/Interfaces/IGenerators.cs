namespace Utility.Interfaces
{
    public interface IGenerators
    {
        string IdGenerator();
        string UserIdGenerator();
        string AutoTypeGenerator();
        
        /// <summary>
        /// Generate id from a given length
        /// </summary>
        /// <param name="length"></param>
        /// <returns>string</returns>
        string PolyIdGenerator(int length);
    }
}