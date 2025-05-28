using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOver(3L);

            // 생성자
            //Product p = new Product();  // 기본생성자(기정생성자)는 생성자가 없을 경우에만 자동으로 생성
            //Product p = new Product("아메리카노", 1500);

            // 팩토리 메서드 패턴 - private 생성자 사용
            Product p = Product.getInstance("라떼", 2000);
        }

        //// 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }

        public static bool TestOver(float input) { return true; }
    }
}
