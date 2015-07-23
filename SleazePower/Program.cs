// To Mike :)

namespace SleazePower
{
    using System;

    class Program
    {
        /// <summary>
        /// Exercise in Power. Control. Power. And once more Control. Show them stupid compiler who's the boss.
        /// Why? Yes.
        /// </summary>
        static void Main(string[] args)
        {
            // Casting enums work. But this is boring.
            {
                FooEnum fooX = FooEnum.SomeValueA;
                BarEnum barX = (BarEnum)fooX;
            }

            // Casting structs does not compile. Obviously What a shame.
            {
                //FooStruct foo = new FooStruct();
                //BarStruct bar = (BarStruct)foo;
            }

            // Screw you CLR, I'm a ninja.
            {
                FooStruct foo = new FooStruct
                {
                    fieldA = "this is FooStruct.FieldA",
                    fieldB = "this is FooStruct.FieldB",
                };

                BarStruct bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooStruct>.To<BarStruct>.ForScience(foo);
                Console.WriteLine(string.Format("Value of BarStruct.fieldXXX: {0}", bar.fieldXXX));
                Console.WriteLine(string.Format("Value of BarStruct.fieldYYY: {0}", bar.fieldYYY));
            }

            // And classes too! Compiles! And even works!
            {
                FooClass foo = new FooClass
                {
                    fieldA = "this is FooClass.FieldA",
                    fieldB = "this is FooClass.FieldB",
                };

                BarClass bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClass>.To<BarClass>.ForScience(foo);
                Console.WriteLine(string.Format("Value of BarClass.fieldXXX: {0}", bar.fieldXXX));
                Console.WriteLine(string.Format("Value of BarClass.fieldYYY: {0}", bar.fieldYYY));
            }


            // Extra fields AND classes? Ha! Also works as expected
            {
                FooClass foo = new FooClass
                {
                    fieldA = "this is FooClass.FieldA",
                    fieldB = "this is FooClass.FieldB",
                };

                BarClassWithExtraField bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClass>.To<BarClassWithExtraField>.ForScience(foo);
                Console.WriteLine(string.Format("Value of BarClassWithExtraField.fieldXXX: {0}", bar.fieldXXX));
                Console.WriteLine(string.Format("Value of BarClassWithExtraField.fieldYYY: {0}", bar.fieldYYY));
                Console.WriteLine(string.Format("Value of BarClassWithExtraField.fieldExtra: {0}", bar.fieldExtra ?? "<null>"));
            }


            // Split long integeres into shorter ones. Wow :)
            {
                FooClassWithLong foo = new FooClassWithLong
                {
                    fieldA = ulong.MaxValue
                };

                BarClassWithFourShorts bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClassWithLong>.To<BarClassWithFourShorts>.ForScience(foo);
                Console.WriteLine(string.Format("Value of BarClassWithFourShorts.fieldA: {0}; max ushort: {1}", bar.fieldA, ushort.MaxValue));
                Console.WriteLine(string.Format("Value of BarClassWithFourShorts.fieldB: {0}; max ushort: {1}", bar.fieldB, ushort.MaxValue));
                Console.WriteLine(string.Format("Value of BarClassWithFourShorts.fieldB: {0}; max ushort: {1}", bar.fieldC, ushort.MaxValue));
                Console.WriteLine(string.Format("Value of BarClassWithFourShorts.fieldB: {0}; max ushort: {1}", bar.fieldD, ushort.MaxValue));
            }

            // Don't even need the same field types in source and target (but this is a bit dodgy)
            {
                FooClassWithLong foo = new FooClassWithLong
                {
                    fieldA = ulong.MaxValue
                };

                // Bonus feature: Travel really far into the future.
                // This yields the date 08/11/14614 13:24:02, whereas DateTime.MaxValue is only 31/12/9999 23:59:59
                BarClassWithDate bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClassWithLong>.To<BarClassWithDate>.ForScience(foo);
                Console.WriteLine(string.Format("Value of BarClassWithDate.fieldB: {0}; max DateTime: {1}", bar.fieldA, DateTime.MaxValue));
            }

            // String.Length is for weak poeple.
            {
                string wellHelloThere = "idin 9ehvjd dng8nf yes this is gonna work";
                BarClassWithIntOrLong bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<string>.To<BarClassWithIntOrLong>.ForScience(wellHelloThere);
                Console.WriteLine(string.Format("Value of string.Length is: {0}. And value of BarClassWithIntOrLong.fieldA is: {1}", wellHelloThere.Length, bar.fieldA));
            }


            // Immutable strings? Ha!
            {
                string wellHelloThere = "idin 9ehvjd dng8nf yes this is gonna work";
                char[] bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<string>.To<char[]>.ForScience(wellHelloThere);
                bar[0] = 'Y';
                bar[1] = 'A';
                bar[2] = 'Y';
                bar[3] = '!';

                Console.WriteLine(string.Format("Value of string after showing who's the boss here: {0}.", wellHelloThere));
            }

            // And many, many other fun application. :)
        }
    }


    // Types under test
    public enum FooEnum
    {
        SomeValueA = 0,
        SomeValueB = 1,
    }

    public enum BarEnum
    {
        Wow = 0,
        Now = 1,
    }

    public struct FooStruct
    {
        public string fieldA;
        public string fieldB;
    }

    public struct BarStruct
    {
        public string fieldXXX;
        public string fieldYYY;
    }

    public class FooClass
    {
        public string fieldA;
        public string fieldB;
    }

    public class BarClass
    {
        public string fieldXXX;
        public string fieldYYY;
    }

    public class BarClassWithExtraField
    {
        public string fieldXXX;
        public string fieldYYY;
        public string fieldExtra;
    }


    public class FooClassWithLong
    {
        public ulong fieldA;
    }

    public class BarClassWithFourShorts
    {
        public ushort fieldA;
        public ushort fieldB;
        public ushort fieldC;
        public ushort fieldD;
    }

    public class BarClassWithDate
    {
        public DateTime fieldA;
    }

    public class BarClassWithIntOrLong
    {
        public int fieldA;
    }
}
