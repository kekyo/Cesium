using System.Diagnostics.CodeAnalysis;
using CommandLine;

namespace Cesium.Compiler;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class Arguments
{
    [Value(index: 0)]
    public string? InputFilePath { get; init; }

    [Value(index: 1)]
    public string? OutputFilePath { get; init; }
}
