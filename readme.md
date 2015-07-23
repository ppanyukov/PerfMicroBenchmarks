# PerfMicroBenchmarks

A collection of micro benchmarks I do/did at some point for one reason or another.

All are .NET (C#) for the time being.

Some detail:

- **EnumDictionaryBenchmarks**

	The cost of using C# `enum` types as keys in `Dictionary<TEnum, TSomeOtherType>` vs `int` vs `string` vs `raw arrays`.

	Very interesting results!

	I also used this benchmark for test and compare performance of Azure VMs. [Iwrote about it here](http://ppanyukov.github.io/2015/07/23/performance-of-azure-vms.html).

<br/>

- **YieldBenchmarks**

	The cost of using `IEnumerable<T>` produced with `yield return` in C# vs `raw arrays`.

	Obviously nothing beats arrays.

<br/>


- **SerializationBenchmarks/ObjectCreationBenchmarks**

	Benchmarks related to perfomance of deserialization in .NET.

	Examines relative costs of object creation in various ways,
	which is very important in high performance deserialization.

	Compares: `direct call to constructor` vs `FormatterServices.GetUninitializedObject` vs `Activator.CreateInstance` vs `Ctor via Reflection`

<br/>

