﻿using System;
using System.Collections.Generic;
using System.Globalization;
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

            //// 정적 생성자 예시1
            //Console.WriteLine("첫 번째 위치");
            //Console.WriteLine(Sample.value);        // Sample.value 값 조회 전에 생성자 호출
            //Console.WriteLine("두 번째 위치");
            //Sample sample = new Sample();
            //Console.Write("세 번째 위치");

            // 정적 생성자 예시2
            Console.WriteLine("첫 번째 위치");
            Sample sample = new Sample();              // Sample 객체 생성 전, 레퍼런스 변수 생성 전에 정적 생성자 호출
            Console.WriteLine("두 번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세 번째 위치");

            Item item1 = new Item("고구마", 1500);
            Item item2 = new Item("감자", 1500);
            Item item3 = new Item("옥수수", 1500);
            Item item4 = new Item("토란", 1500);
            Console.WriteLine(item1.id);
            // item1.id = 11;
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            Console.WriteLine(item4.id);

            Console.WriteLine(Item.ApplicationName);

            Box box = new Box(100, 100);
            // Console.WriteLine(box.getHeight());
            // box.setWidtht(200);
            // Console.WriteLine(box.Area());
            Console.WriteLine(box.Heigth);
            box.Width = 50;
            Console.WriteLine(box.Area);

            // 값 복사 vs 참조 복사Add commentMore actions
            // 값 복사(value) : 값이 매개변수로 넘어가서 원본에 영향 X
            int a = 10;
            Change(a);
            Console.WriteLine(a);

            // 참조 복사(reference) : 객체의 레퍼런스(주소값)가 넘어가서 원본에 영향 O
            Test test = new Test();
            Change(test);
            Console.WriteLine(test.value);

            Test testA = new Test();
            Test testB = testA;     // 같은 레퍼런스를 가리킴
            testA.value = 10;
            testB.value = 20;
            Console.WriteLine("testA: " + testA);

            // 재귀함수를 이용한 피보나치수 구하기Add commentMore actions
            Console.WriteLine(Fibonacci.GetM(1));
            Console.WriteLine(Fibonacci.GetM(8));

        }
        static void Change(int input)
        {
            input = 20;
        }

        static void Change(Test input)
        {
            input.value = 20;
        }

        class Test
        {
            public int value = 10;

            // 객체 출력 시 value가 출력되도록 override
            public override string ToString()
            {
                return value.ToString();
            }
        }

        //// 오버로딩 주의점
        //public static int TestOver(int input) { return 0; }

        public static bool TestOver(float input) { return true; }
        public class Fibonacci
        {
            public static long Get(int i)
            {
                Console.WriteLine("Get(" + i + ") 호출");
                if (i < 0) { return 0; }
                if (i == 0) { return 1; }
                if (i == 1) { return 1; }
                return Get(i - 2) + Get(i - 1);
            }

            private static Dictionary<int, long> memo = new Dictionary<int, long>();
            public static long GetM(int i)
            {
                long value = 0;
                if (memo.ContainsKey(i))
                {
                    value = memo[i];
                }
                else
                {
                    if (i < 0) { value = memo[i] = 0; }
                    if (i == 1) { value = memo[i] = 1; }
                    if (i == 2) { value = memo[i] = 1; }
                    if (i > 2)
                    {
                        memo[i] = GetM(i - 2) + GetM(i - 1);
                        value = memo[i];
                    }

                }
                return value;
            }
        }
    }
}
