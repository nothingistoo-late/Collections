namespace Poems
{
    // Mỗi tập tin src code sẽ phải thuộc về một thư mục nào đó và xuất thân từ đâu hay là đang ở căn phòng nào, căn phòng này, thư mục này đang ở được gọi là package, còn C# được gọi là NameSpace không gian đặt tên, nơi chứa các class/tập tin src code
    // package java.utill;
    // package poems;

    //tại sao cần có package, NameSpace: giúp cho người đọc quản lí nhiều tập tin src code tốt hơn, chia src code thành cấc thư mục theo nhóm chức năng, giúp 1 project có nhiều src code, nhiều class có quyền trùng tên nhau miễn là khác tên package, khác NameSpace.
    internal class Program 
    {
        //field/ attribute/ property và method
        //static and non-static
        //instance variable & class variable & method
        static void Main(string[] args)
        {
            PrintSongXuanQuynhV6();
            //PrintPath();   
            //Console.ReadLine();

        }
        // có câu: static thì chơi với static
        //CHALLANGE #1: In ra bài thơ sóng của XQ
        static void PrintSongXuanQuynhV6()
        {
            int year = 1967;
            Console.WriteLine("Sóng {0} {1} năm", year, (2024 - year));
            // place holder: kĩ thuật điền vào chỗ trống 
            // {0} {1].... các biến bắt đầu từ 0 
            //



            Console.WriteLine(@$"Sóng\n {year} {2024 - year} năm");

            // INTERPOLATION: phép nội suy,nhìn sâu vào chuỗi xem có chỗ nào là biến không, nếu có thì điền vào 

            Console.WriteLine(@"Sóng " + year +" "+(2024 - year)+@" 
Liệu mai sau phai vội mau không bước bên cạnh nhau
Thì ta có đau
Đôi mi nhòe phai ai sẽ lau
Ai sẽ đến lau nỗi đau này
Vô tâm quay lưng ta thờ ơ lạnh lùng băng giá như vậy sao
Và không biết nhau
Lặng im băng qua chẳng nói một lời
Rồi niềm đau có chóng quên
Hay càng quên càng nhớ thêm
Vấn vương vết thương lòng xót xa");
        }
        static void PrintSongXuanQuynhV2()
        {
            Console.WriteLine("No one can change the past\r\n\r\nLiệu mai sau phai vội mau không bước bên cạnh nhau\r\nThì ta có đau\r\nĐôi mi nhòe phai ai sẽ lau\r\nAi sẽ đến lau nỗi đau này\r\nVô tâm quay lưng ta thờ ơ lạnh lùng băng giá như vậy sao\r\nVà không biết nhau\r\nLặng im băng qua chẳng nói một lời\r\nRồi niềm đau có chóng quên\r\nHay càng quên càng nhớ thêm\r\nVấn vương vết thương lòng xót xa\r\n\r\nĐừng như con nít\r\nTừng mặn nồng đắm say\r\nCớ sao khi chia tay\r\nTa xa lạ đến kỳ lạ\r\nAi dám nói trước sau này\r\nChằng ai biết trước tương lai sau này\r\nTình yêu đâu biết mai này có vẹn nguyên\r\nCòn nguyên như lời ta đã hứa trước đây\r\nDẫu cho giông tố xô xa rời\r\nCòn mãi những điều đẹp đẽ say đắm một thời\r\nNụ cười và giọt nước mắt rơi từng trao cùng ta\r\nNhìn lại về phía mặt trời\r\n\r\nRap\r\n\r\nTương lai ngày mai ai nào hay\r\nYêu thương rồi buông đôi bàn tay\r\nMong manh đường duyên như vận may\r\nChia ly hợp tan nhanh còn hơn mây trời bay\r\nQuyên nhau vờ như chưa từng quen\r\nQuyên luôn mặt quên luôn cả tên\r\nQuên đi làm sao mà đòi quên\r\nKhi câu thề xưa vẫn vẹn nguyên nên đừng cố quên\r\nVấn vương cũng chẳng sao mà\r\nNhớ nhung cũng chẳng sao mà\r\nĐớn đau cũng chẳng sao mà\r\nDù có đắng cay ta cũng chẳng sao đâu\r\nChân thành khi còn bên nhau\r\nVà trân trọng hơn mỗi phút giây\r\nHơn mỗi phút giây\r\nThành thật bên nhau mỗi phút giây\r\n\r\nLời\r\n\r\nRồi niềm đau cũng có chóng quên\r\nHay càng quên càng nhớ thêm\r\nVấn vương vết thương lòng xót xa\r\nĐừng như con nít\r\nTừng mặn nồng đắm say\r\nCớ sao khi chia tay\r\nTa xa lạ đến kỳ lạ\r\nAi dám nói trước sau này\r\nChằng ai biết trước tương lai sau này\r\nTình yêu đâu biết mai này có vẹn nguyên\r\nCòn nguyên như lời ta đã hứa trước đây\r\nDẫu cho giông tố xô xa rời\r\nCòn mãi những điều đẹp đẽ say đắm một thời\r\nNụ cười và giọt nước mắt rơi từng trao cùng ta\r\nNhìn lại về phía mặt trời\r\n\r\nĐiệp khúc\r\n\r\nAi dám nói trước sau này\r\nChằng ai biết trước tương lai sau này\r\nTình yêu đâu biết mai này có vẹn nguyên\r\nCòn nguyên như lời ta đã hứa trước đây\r\nDẫu cho giông tố xô xa rời\r\nCòn mãi những điều đẹp đẽ say đắm một thời\r\nNụ cười và giọt nước mắt rơi từng trao cùng ta\r\nNhìn lại về phía mặt trời");
            //\n mỗi khi xuất hiện trong "" thì được hiểu theo nghĩa không phải là in \n mà là in xuống hàng - kí tự đặc biệt
            // dấu + là toán tử = operetor để nối các chuỗi, String Concatenation

        }
        static void PrintSongXuanQuynhV4()
        {
            Console.WriteLine("Dữ dội và dịu êm\r\nỒn ào và lặng lẽ\r\nSông không hiểu nổi mình\r\nSóng tìm ra tận bể\r\n\r\nÔi con sóng ngày xưa\r\nVà ngày sau vẫn thế\r\nNỗi khát vọng tình yêu\r\nBồi hồi trong ngực trẻ\r\n\r\nTrước muôn trùng sóng bể\r\nEm nghĩ về anh, em\r\nEm nghĩ về biển lớn\r\nTừ nơi nào sóng lên?\r\n\r\nSóng bắt đầu từ gió\r\nGió bắt đầu từ đâu?\r\nEm cũng không biết nữa\r\nKhi nào ta yêu nhau\r\n\r\nCon sóng dưới lòng sâu\r\nCon sóng trên mặt nước\r\nÔi con sóng nhớ bờ\r\nNgày đêm không ngủ được\r\nLòng em nhớ đến anh\r\nCả trong mơ còn thức\r\n\r\nDẫu xuôi về phương bắc\r\nDẫu ngược về phương nam\r\nNơi nào em cũng nghĩ\r\nHướng về anh - một phương\r\n\r\nỞ ngoài kia đại dương\r\nTrăm nghìn con sóng đó\r\nCon nào chẳng tới bờ\r\nDù muôn vời cách trở\r\n\r\nCuộc đời tuy dài thế\r\nNăm tháng vẫn đi qua\r\nNhư biển kia dẫu rộng\r\nMây vẫn bay về xa\r\n\r\nLàm sao được tan ra\r\nThành trăm con sóng nhỏ\r\nGiữa biển lớn tình yêu\r\nĐể ngàn năm còn vỗ");
        }
        //@ đứng trước 1 cái chuỗi sẽ phế võ công các kí tự đặc biệt trong chuỗi trở lại kí tự bth
        // \n vẫn là in ra \n luôn chứ kh xuống hàng
        // @ biến chuỗi thành có sao in vậy 
        // @ gọi là kĩ thuật chuỗi nguyên bản - RAW STRING 
        // @ gọi là Verbatim String
        // có bên java 

        // khi nào xài verbatim
        // 1.phế võ công kí tự đặc biệt
        // 2. dùng để lưu tên của các đường dẫn tập tin, thư mục, chuỗi kết nối csdl do tên sever hay kèm theo kí tự đặc biệt nên ta trả chuỗi theo nguyên bản kh bị hiểu sai í nghĩa
        
        static void PrintSongXuanQuynhV5()
        {
            Console.WriteLine(@"Liệu \n mai sau phai vội mau không bước bên cạnh nhau
<html>
    <head>
        <title>Konichiwa</title>
    </head>
    <body>
    </body>
</html>


            Lời

            Rồi niềm đau cũng có chóng quên
            Hay càng quên càng nhớ thêm
            Vấn vương vết thương lòng xót xa
            Đừng như con nít
            Từng mặn nồng đắm say
            Cớ sao khi chia tay
            Ta xa lạ đến kỳ lạ
            Ai dám nói trước sau này
            Chằng ai biết trước tương lai sau này
            Tình yêu đâu biết mai này có vẹn nguyên
            Còn nguyên như lời ta đã hứa trước đây
            Dẫu cho giông tố xô xa rời
            Còn mãi những điều đẹp đẽ say đắm một thời
            Nụ cười và giọt nước mắt rơi từng trao cùng ta
            Nhìn lại về phía mặt trời");
        }
        static void PrintSongXuanQuynh()
        {
            Console.WriteLine("Sóng bắt đầu từ gió");// cw+tab = sout in java 
            Console.WriteLine("Gió bắt đầu từ đâu");
            Console.WriteLine("Anh cũng không biết nữa");
            Console.WriteLine("Khi nào ta yêu nhau!!!");
        }
        //challange #2 in ra đường dẫn sau 
        // C:\Program FIles\ dotnet
        // C:\news\showbiz
        static void PrintPath()
        {
            Console.WriteLine(@"D:\FPT\FA24\PRN212\Session02-Language\Collections\Poems\bin\Debug\net8.0");
        }
    }
}
