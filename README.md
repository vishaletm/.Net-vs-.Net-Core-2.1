# Performance Improvements in .NET Core
This examples are taken from ## [.NET Blog](https://blogs.msdn.microsoft.com/dotnet/2017/06/07/performance-improvements-in-net-core/) written by by  [Stephen Toub - MSFT](https://social.msdn.microsoft.com/profile/Stephen+Toub+-+MSFT)  

There are 5 examples taken from the blog, each of them are available as separate functions

     QueCollection() - Example using Queue
     SortedSetExample() - Example using sortedset
     Concat() - Example using Linq Concat
     OrderBy() - Example use Linq Order By
     Serialize() - Example use BinaryFromatter serialization. 
*Separate projects are created for .Net Core 2.1 and .Net 4.6.1*

# Test Result 
*All values are in seconds*
![Test results](https://raw.githubusercontent.com/vishaletm/.Net-vs-.Net-Core-2.1/master/core_performance_test_result.png)
