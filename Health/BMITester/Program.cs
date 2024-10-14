using BMI;

namespace BMITester
{
    internal class Program
    {

        static void Main(string[] args) //svm tab psvm bên java
        {
            Console.WriteLine(BMICaculator.GetBMI(60, 1.7));    
        }
        //trong class chứa field/ attribute và methods >> gọi chung là: member of a class
        //filed/ attribute: có 2 dạng, method cũng z
        //static và non-static
        //class lever vatianance và instance variable 

        //static void Main(string[] args)
        //{
        //    //PrinBMIV2(60, 1.7);
        //    double bmi = GetBMI(60, 1.7);
        //    Console.WriteLine("BMI : " + bmi);
        //    Console.WriteLine("BMI : {0} ", bmi);
        //    Console.WriteLine($"BMI : {bmi}");
        //    Console.WriteLine("BMI : " + GetBMI(60, 1.7));
        //    Console.WriteLine($"BMI : {GetBMI(60, 1.7)}");
        //}
        //Challange:viết hàm tính và in ra chỉ số BMI(body mass index:chỉ số khối của cơ thể - Do tình trạng mập ốm của ai đó theo chiều cao và cân nặng
        //BMI = weight (kg) / high(m)*2;
        //Bmi [18.5..24.9] => on
        //Triết lí thiết kế hàm: 1 hàm được thiết kế tốt thì hàm đố nên thuộc style
        //Hàm nhận đầu vào và trả ra kết quả, hàm kh nên có lệnh nhập và in trong code hàm
        //Lý do thiết kế hàm style nhận vào trả ra sẽ giúp hàm linh hoạt hơn trong ách nó để sử dụng trong các biểu thức khác
        //Tăng tính sử dụng lại - reuse mức cao
        //Ví dụ lúc ta viết hàm kiểm tra N có là số nto hay không
        //For (int i = 2: i < n; i++)
        //Giang hồ chứng minh chỉ cần for đến căn bậc 2 
        //For (int i = 2:i <= Math.Sqrt(n); i++)


        // Kỹ thuật cái dây nịt
        // GetBMI: tên hàm - Signature of a method 
        // { code của hàm - Body of a method } 
        // { Thân hàm, implement of method }
        // nếu hàm chỉ có duy nhất 1 lệnh thì ra có thể áp dụng quy tắc rút gọn để hàm chỉ còn cái dây nịt mức tối thiểu
        // ta dẹp bỏ {, RETURN, } chỉ còn cái tên hàm nối với code => thân hàm qua kí tự =>
        // tên hàm => thân hàm 
        // kỹ thuật rút gọn hàm chỉ có 1 lệnh đc gọi là expression bodied, epression bodied 
        // thân hàm viết giống như biểu thức!!!
        // cấm tuyệt đối kh dc nhầm lẫn => với 1 khái niệm khác - biểu thức LAMBDA - LAMBDA EXPRESSION
        // cũng xài chung kí hiệu => học sau!!!
        static double GetBMIV2(double weight, double height) => weight / Math.Pow(height, 2);
        
        static double GetBMI(double weight, double height)
        {
            return weight / Math.Pow(height,2);
        }
    
        static void PrinBMIV3(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine("BMI (W: {0}; H: {1}) = {2}", weight, height, bmi);
        }
        static void PrinBMIV2(double weight, double height)
        {
            double bmi = weight / Math.Pow(height, 2);
            Console.WriteLine("BMI (W: {0}; H: {1}) = {2}", weight, height, bmi);
        }
        static void PrinBMI(double weight, double height)
        {
            double bmi = weight / (height * height);
            Console.WriteLine("BMI (W: {0}; H: {1}) = {2}", weight, height, bmi);
        }


    }
}
