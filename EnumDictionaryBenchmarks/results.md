# Enum Dictionary Get Value Benchmark Results

(These results are from the more correct benchmark which includes compiler/optimizer spoiler.
Looks more real now.)

## Results


### Release, x64

	========= Running on ===========
	        PROCESSOR_ARCHITECTURE: AMD64
	        PROCESSOR_IDENTIFIER: Intel64 Family 6 Model 58 Stepping 9, GenuineIntel
	        PROCESSOR_LEVEL: 6
	        PROCESSOR_REVISION: 3a09
	        NUMBER_OF_PROCESSORS: 4
	        FrameworkVersion:
	        FrameworkVersion32:

	========= Compiled as ===========
	        Configuration: Release
	        Platform: x64
	================================

	Iterations: 1,000 (warmup)
	        EmptyMethodCall: 00:00:00.0000012 (833,333,333) ops/sec
	        LoopGetValueArray: 00:00:00.0000036 (277,777,778) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0000033 (303,030,303) ops/sec
	        LoopGetValueMapEnum: 00:00:00.0026950 (371,058) ops/sec
	        LoopGetValueMapString: 00:00:00.0001337 (7,479,432) ops/sec
	        LoopGetValueMapByte: 00:00:00.0014039 (712,301) ops/sec

	Spoiler values: 975,000
	Iterations: 1,000,000
	        EmptyMethodCall: 00:00:00 (0) ops/sec
	        LoopGetValueArray: 00:00:00.0031946 (313,028,235) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0032347 (309,147,680) ops/sec
	        LoopGetValueMapEnum: 00:00:00.2329608 (4,292,568) ops/sec
	        LoopGetValueMapString: 00:00:00.1076482 (9,289,519) ops/sec
	        LoopGetValueMapByte: 00:00:00.0596974 (16,751,148) ops/sec

	Spoiler values: 975,975,000
	Iterations: 10,000,000
	        EmptyMethodCall: 00:00:00 (0) ops/sec
	        LoopGetValueArray: 00:00:00.0315080 (317,379,713) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0312720 (319,774,878) ops/sec
	        LoopGetValueMapEnum: 00:00:02.0289521 (4,928,653) ops/sec
	        LoopGetValueMapString: 00:00:01.0708150 (9,338,681) ops/sec
	        LoopGetValueMapByte: 00:00:00.5947670 (16,813,307) ops/sec

	Spoiler values: 10,725,975,000
	Iterations: 100,000,000
	        EmptyMethodCall: 00:00:00.0000003 (333,333,333,333,333) ops/sec
	        LoopGetValueArray: 00:00:00.3019300 (331,202,597) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.3020595 (331,060,602) ops/sec
	        LoopGetValueMapEnum: 00:00:19.6941285 (5,077,656) ops/sec
	        LoopGetValueMapString: 00:00:10.7497231 (9,302,565) ops/sec
	        LoopGetValueMapByte: 00:00:05.9751781 (16,735,903) ops/sec

	Spoiler values: 108,225,975,000



### Release, x86

	========= Running on ===========
	        PROCESSOR_ARCHITECTURE: x86
	        PROCESSOR_IDENTIFIER: Intel64 Family 6 Model 58 Stepping 9, GenuineIntel
	        PROCESSOR_LEVEL: 6
	        PROCESSOR_REVISION: 3a09
	        NUMBER_OF_PROCESSORS: 4
	        FrameworkVersion:
	        FrameworkVersion32:

	========= Compiled as ===========
	        Configuration: Release
	        Platform: x86
	================================

	Iterations: 1,000 (warmup)
	        EmptyMethodCall: 00:00:00.0000009 (1,111,111,111) ops/sec
	        LoopGetValueArray: 00:00:00.0000051 (196,078,431) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0000051 (196,078,431) ops/sec
	        LoopGetValueMapEnum: 00:00:00.0006375 (1,568,627) ops/sec
	        LoopGetValueMapString: 00:00:00.0001364 (7,331,378) ops/sec
	        LoopGetValueMapByte: 00:00:00.0003281 (3,047,851) ops/sec

	Spoiler values: 475,000
	Iterations: 1,000,000
	        EmptyMethodCall: 00:00:00 (0) ops/sec
	        LoopGetValueArray: 00:00:00.0044859 (222,920,707) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0052638 (189,976,823) ops/sec
	        LoopGetValueMapEnum: 00:00:00.1555531 (6,428,673) ops/sec
	        LoopGetValueMapString: 00:00:00.1205184 (8,297,488) ops/sec
	        LoopGetValueMapByte: 00:00:00.0538111 (18,583,526) ops/sec

	Spoiler values: 475,475,000
	Iterations: 10,000,000
	        EmptyMethodCall: 00:00:00 (0) ops/sec
	        LoopGetValueArray: 00:00:00.0483302 (206,909,965) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.0481367 (207,741,702) ops/sec
	        LoopGetValueMapEnum: 00:00:01.5158216 (6,597,082) ops/sec
	        LoopGetValueMapString: 00:00:01.2147863 (8,231,901) ops/sec
	        LoopGetValueMapByte: 00:00:00.5413634 (18,471,880) ops/sec

	Spoiler values: 5,225,475,000
	Iterations: 100,000,000
	        EmptyMethodCall: 00:00:00.0000003 (333,333,333,333,333) ops/sec
	        LoopGetValueArray: 00:00:00.4778280 (209,280,327) ops/sec
	        LoopGetValueArray_WithMethodCall: 00:00:00.4842616 (206,499,958) ops/sec
	        LoopGetValueMapEnum: 00:00:15.0906790 (6,626,607) ops/sec
	        LoopGetValueMapString: 00:00:12.0556295 (8,294,880) ops/sec
	        LoopGetValueMapByte: 00:00:05.4245168 (18,434,822) ops/sec

	Spoiler values: 52,725,475,000

