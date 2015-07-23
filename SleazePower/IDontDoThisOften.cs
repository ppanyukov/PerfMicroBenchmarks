// To Mike :)

namespace SleazePower
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// This code is totally awesome. Enough documentation already.
    /// </summary>
    public static class I
    {
        public static class Donʼt
        {
            public static class Do
            {
                public static class This
                {
                    public static class Often
                    {
                        public static class But
                        {
                            public static class When
                            {
                                public static class I
                                {
                                    public static class Do
                                    {
                                        public static class I
                                        {
                                            public static class Always
                                            {
                                                public static class Cast
                                                {
                                                    public static class From<TSourceType>
                                                    {
                                                        public static class To<TTargetType>
                                                        {
                                                            // It's not only awesome it's also FAST!
                                                            [MethodImpl(MethodImplOptions.AggressiveInlining)]
                                                            public static TTargetType ForScience(TSourceType obj)
                                                            {
                                                                return FuckYeahClr<TSourceType, TTargetType>.Cast(obj);
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            /// <summary>
            /// Boring bit of code here.
            /// </summary>
            /// <typeparam name="TSourceType">The type to teleport from from.</typeparam>
            /// <typeparam name="TTargetType">The type to teleport to.</typeparam>
            private static class FuckYeahClr<TSourceType, TTargetType>
            {
                private static readonly Func<TSourceType, TTargetType> teleporter;

                static FuckYeahClr()
                {
                    teleporter = CreateTeleporter();
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                public static TTargetType Cast(TSourceType obj)
                {
                    return teleporter(obj);
                }

                private static Func<TSourceType, TTargetType> CreateTeleporter()
                {
                    var someMethod = new DynamicMethod(
                        name: "FuckYeaCLR - EnumToWhatever",
                        returnType: typeof(TTargetType),
                        parameterTypes: new Type[] { typeof(TSourceType) },
                        m: Assembly.GetExecutingAssembly().ManifestModule);

                    var il = someMethod.GetILGenerator();
                    il.Emit(OpCodes.Ldarg_0); // Load arg_0 onto the stack (of type object)
                    il.Emit(OpCodes.Ret);

                    return (Func<TSourceType, TTargetType>)someMethod.CreateDelegate(typeof(Func<TSourceType, TTargetType>));
                }
            }
        }
    }
}