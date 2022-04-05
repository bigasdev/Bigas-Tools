using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BigasMath{
    /// <summary>
    /// Use this class to handle basic math
    /// </summary>
    public static class BMath
    {
        /// <summary>
        /// Return a list of distinct random numbers
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static List<int> GetRnd(int amount, int max){
            List<int> localList = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                var n = Random.Range(0,max);
                while(localList.Contains(n)){
                    n = Random.Range(0,max);
                }
                localList.Add(n);
            }
            return localList;
        }
    }
    /// <summary>
    /// Use this class to handle percentage math
    /// </summary>
    public static class BMathPercentage
    {
        /// <summary>
        /// Return an float from a total by a percentage
        /// </summary>
        /// <param name="percentage"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetFloatFromPercentage(float percentage, float total){
            return (percentage/100)*total;
        }
        /// <summary>
        /// Return an percentage float using a number and a total.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public static float GetPercentageFromFloat(float number, float total){
            return (number/total)*100;
        }
    }
}
