# Enum Dictionary Get Value Benchmark Results


## Environment

	PROCESSOR_ARCHITECTURE: x86
	PROCESSOR_IDENTIFIER: Intel64 Family 6 Model 58 Stepping 9, GenuineIntel
	PROCESSOR_LEVEL: 6
	PROCESSOR_REVISION: 3a09
	NUMBER_OF_PROCESSORS: 4
	FrameworkVersion: 
	FrameworkVersion32: 


## Results

### Debug, AnyCPU

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0000923 (3,267,973,856 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0006646 (454,132,606 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0001174 (2,570,694,087 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0004594 (657,030,223 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0052662 (57,319,729,450 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.1722994 (1,751,960,882 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1308371 (2,307,156,337 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0672463 (4,488,894,475 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.0580628 (51,988,832,798 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:01.6817452 (1,794,931,902 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.2414586 (2,431,509,247 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.6291340 (4,798,052,374 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:00.5680493 (53,140,073,513 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:16.5407003 (1,824,963,981 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:12.4366932 (2,427,187,175 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:06.2296640 (4,845,555,431 ops/sec, nanosecond precision)




### Debug, x86

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0000905 (3,333,333,333 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0006553 (460,617,227 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0001174 (2,570,694,087 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0004343 (694,927,032 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0053203 (56,737,588,652 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.1748477 (1,726,426,935 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1262965 (2,390,103,061 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0640970 (4,709,450,454 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.0510747 (59,102,004,148 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:01.6425895 (1,837,719,111 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.2098344 (2,495,067,252 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.6306044 (4,786,864,842 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:00.5149699 (58,617,368,678 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:16.6044858 (1,817,953,450 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:12.1426668 (2,485,959,858 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:06.2831762 (4,804,287,038 ops/sec, nanosecond precision)



### Debug, x64

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0003088 (977,517,106 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0018329 (164,690,382 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0001125 (2,680,965,147 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0012243 (246,548,323 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0120642 (25,021,268,077 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.2318205 (1,302,135,893 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1205470 (2,504,100,464 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0644130 (4,686,343,059 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.1241781 (24,308,779,845 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:02.1970852 (1,373,919,463 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.1680718 (2,584,274,483 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.6366480 (4,741,424,067 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:01.2191332 (24,760,363,016 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:22.0225315 (1,370,695,382 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:11.7397223 (2,571,285,879 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:06.4518862 (4,678,660,037 ops/sec, nanosecond precision)




### Release, AnyCPU

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0001246 (2,421,307,506 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0005508 (547,945,205 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0001110 (2,717,391,304 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0003848 (784,313,725 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0013574 (222,370,469,201 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.1818919 (1,659,566,488 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1188683 (2,539,463,259 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0517883 (5,828,762,611 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.0138406 (218,097,751,412 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:01.5625189 (1,931,892,296 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.1584768 (2,605,678,503 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.5253968 (5,745,406,116 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:00.1417165 (213,003,887,320 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:15.9610290 (1,891,242,868 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:11.5277121 (2,618,575,309 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:05.2753429 (5,722,126,990 ops/sec, nanosecond precision)



### Release, x86

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0000854 (3,533,568,904 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0006185 (488,042,947 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0001119 (2,695,417,789 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0003181 (948,766,603 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0014006 (215,517,241,379 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.1557232 (1,938,450,325 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1157899 (2,606,977,314 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0525749 (5,741,549,873 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.0137175 (220,055,894,197 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:01.5725207 (1,919,604,653 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.1711312 (2,577,523,530 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.5299634 (5,695,899,351 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:00.1401484 (215,387,266,304 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:15.5966416 (1,935,428,342 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:11.7673928 (2,565,239,623 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:05.6499094 (5,342,772,801 ops/sec, nanosecond precision)


### Release, x64

	Iterations: 1,000.00 (warmup)
		LoopGetValueArray: 00:00:00.0000003 (1,000,000,000,000 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.0015905 (189,789,333 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.0004150 (727,272,727 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0013336 (226,346,763 ops/sec, nanosecond precision)


	Iterations: 1,000,000.00 
		LoopGetValueArray: 00:00:00.0002716 (1,111,111,111,111 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:00.2294337 (1,315,682,141 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:00.1112677 (2,712,931,186 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.0627145 (4,813,269,220 ops/sec, nanosecond precision)


	Iterations: 10,000,000.00 
		LoopGetValueArray: 00:00:00.0027267 (1,107,051,920,735 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:02.1449812 (1,407,293,552 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:01.1038455 (2,734,638,102 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:00.6087538 (4,958,684,242 ops/sec, nanosecond precision)


	Iterations: 100,000,000.00 
		LoopGetValueArray: 00:00:00.0280523 (1,076,067,189,635 ops/sec, nanosecond precision)
		LoopGetValueMapEnum: 00:00:21.4245541 (1,408,952,648 ops/sec, nanosecond precision)
		LoopGetValueMapString: 00:00:10.9559082 (2,755,242,344 ops/sec, nanosecond precision)
		LoopGetValueMapByte: 00:00:06.0641649 (4,977,797,034 ops/sec, nanosecond precision)

