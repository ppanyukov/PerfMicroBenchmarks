// To Mike :)

namespace SleazePower
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

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

            // Is someone over-protective of their code?
            // Did someone read too many blogs on the benefits of "encapsulation"?
            // Have they thought to hide cool useful fields using "private" keyword?
            // Fools! It's Encapsulation-Boomcapsulation time! Turn their private fields into public!
            {
                FooClassWithPrivateFields foo = new FooClassWithPrivateFields(fieldA: "private field A", fieldB: "private field B");
                BarClassWithEverythingPublic bar = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClassWithPrivateFields>.To<BarClassWithEverythingPublic>.ForScience(foo);
                Console.WriteLine("Private field A? Not anymore!: {0}", bar.fieldAPublic);
                Console.WriteLine("Private field B? Not anymore!: {0}", bar.fieldBPublic);
            }


            // Arrays of T. Turn them into Arrays of Y!
            {
                var fooThings = new FooClass[]
                {
                    new FooClass{fieldA = "foo.FieldA 1", fieldB = "foo.FieldB 1"},
                    new FooClass{fieldA = "foo.FieldA 2", fieldB = "foo.FieldB 2"}
                };

                // This will not compile.
                //var barThings = (BarClass[])fooThings;

                // But we don't care!
                var barThings = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<FooClass[]>.To<BarClass[]>.ForScience(fooThings);
                foreach (var bar in barThings)
                {
                    Console.WriteLine("Array. bar.fieldXXX: {0}", bar.fieldXXX);
                    Console.WriteLine("Array. bar.fieldYYY: {0}", bar.fieldYYY);
                }
            }


            // Linq and enumerables -- no problem!
            {
                var fooArray = new FooClass[]
                {
                    new FooClass{fieldA = "foo.FieldA 1", fieldB = "foo.FieldB 1"},
                    new FooClass{fieldA = "foo.FieldA 2", fieldB = "foo.FieldB 2"}
                };

                var fooThingsEnumerable = fooArray.AsEnumerable();

                // This will throw InvalidCastException.
                //var barThings = (IEnumerable<BarClass>)fooThingsEnumerable;

                // But we don't care!
                var barThings = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<IEnumerable<FooClass>>.To<IEnumerable<BarClass>>.ForScience(fooThingsEnumerable);
                foreach (var bar in barThings)
                {
                    Console.WriteLine("Enumerable. bar.fieldXXX: {0}", bar.fieldXXX);
                    Console.WriteLine("Enumerable. bar.fieldYYY: {0}", bar.fieldYYY);
                }
            }


            // Enhanced polymorphism without class hierarchy - Turn dogs into cats!
            {
                var cat = new Cat();

                // This will not compile.
                //var dog = (Dog)cat;

                // But we don't care!
                var dog = I.Donʼt.Do.This.Often.But.When.I.Do.I.Always.Cast.From<Cat>.To<Dog>.ForScience(cat);
                Console.WriteLine("Cat says: {0}", cat.SaySomething());
                Console.WriteLine("Cat became dog: {0}", dog.SaySomething());
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

    public class FooClassWithPrivateFields
    {
        private string fieldA;
        private string fieldB;

        public FooClassWithPrivateFields(string fieldA, string fieldB)
        {
            this.fieldA = fieldA;
            this.fieldB = fieldB;
        }
    }

    public abstract class BarClassWithEverythingPublic
    {
        public string fieldAPublic;
        public string fieldBPublic;
    }

    public class Cat
    {
        public string SaySomething()
        {
            return "Meaew meawe";
        }
    }

    public class Dog
    {
        public string SaySomething()
        {
            return "Woof woof!";
        }
    }
}
