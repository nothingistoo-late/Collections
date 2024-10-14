namespace BMI
{
    /// <summary>
    /// this class offers methods for evaluating the healthy status based on weight and height
    /// Scenario #1 Mr. An wants to create a user a uniform order
    /// </summary>
    public class BMICaculator
    {
       /// <summary>
       /// Returns the BMI indicator of someone
       /// hàm trả về chỉ số của ai đó 
       /// </summary>
       /// <param name="weight">Weight is inder kg</param>
       /// <param name="height">Height is under m</param>
       /// <returns></returns>
        public static double GetBMI(double weight,double height) => weight / Math.Pow(height, 2);
    }
}
