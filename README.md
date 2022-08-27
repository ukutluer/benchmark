# Benchmark
## Same API in different programming languages for benchmarking

Basic greetings api prepared in different languages. HttpRequest console application prepared in .netcore with benchmarkDotNet library which make http request to prepared apis. 

You can compare according to the ratio field. Here I am based on .netcore so this field has a value of 1.00 for .netcore. You can find mean response times, allocated memory etc. according to different languages apis.

BenchmarkDotNet library used for benchmarking.

Benchmark test results are below.

Sample Test Result 1:
|              Method |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|-------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|
|         GetGoResult |   488.8 us |  9.67 us | 21.42 us |  0.27 |    0.01 | 2.4414 |     16 KB |
| GetSpringBootResult |   861.3 us |  7.46 us |  6.23 us |  0.50 |    0.01 | 1.9531 |     17 KB |
|     GetNodeJsResult |   811.1 us | 16.09 us | 25.04 us |  0.47 |    0.02 | 2.9297 |     18 KB |
|    GetNetCoreResult | 1,749.1 us | 33.89 us | 44.06 us |  1.00 |    0.00 | 3.9063 |     28 KB |

Sample Test Result 2:
|              Method |       Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Allocated |
|-------------------- |-----------:|---------:|---------:|------:|--------:|-------:|----------:|
|         GetGoResult |   456.2 us |  4.34 us |  4.06 us |  0.26 |    0.00 | 1.9531 |     16 KB |
| GetSpringBootResult |   897.4 us | 16.12 us | 27.81 us |  0.51 |    0.02 | 1.9531 |     17 KB |
|     GetNodeJsResult |   825.1 us | 16.25 us | 27.14 us |  0.46 |    0.02 | 2.9297 |     18 KB |
|    GetNetCoreResult | 1,763.1 us | 14.08 us | 11.76 us |  1.00 |    0.00 | 3.9063 |     28 KB |


