using System.Numerics;

namespace GenericMathSupport;

internal class Mathinator
{
    public T SumArray<T>(T[] _values) where T : INumber<T>
    {
        T result = T.Zero;
        foreach (T i in _values)
        {
            result += i;
        }
        return result;
    }
    #region old way
    //public int SumArray(int[] _values)
    //{
    //    int result = 0;
    //    foreach (int i in _values)
    //    {
    //        result += i;
    //    }
    //    return result;
    //}

    //public double SumArray(double[] _values)
    //{
    //    double result = 0.0;
    //    foreach (double i in _values)
    //    {
    //        result += i;
    //    }
    //    return result;
    //} 
    #endregion
}
