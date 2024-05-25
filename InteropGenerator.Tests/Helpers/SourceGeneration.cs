﻿using System.Text;

namespace InteropGenerator.Tests.Helpers;

internal static class SourceGeneration {
    public static (string, string) GetInitializerSource(string containingNamespace, string containingType, IEnumerable<string> functionNames) {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("// <auto-generated/>");
        stringBuilder.AppendLine("namespace InteropGenerator.Runtime.Generated;");
        stringBuilder.AppendLine("public static class Addresses");
        stringBuilder.AppendLine("{");
        stringBuilder.AppendLine("    public static void Initialize()");
        stringBuilder.AppendLine("    {");
        foreach (string functionName in functionNames) {
            string namespaceWithDot = string.IsNullOrEmpty(containingNamespace) ? string.Empty : containingNamespace + ".";
            stringBuilder.AppendLine($"""        InteropGenerator.Runtime.Resolver.GetInstance.RegisterAddress(global::{namespaceWithDot}{containingType}.Addresses.{functionName});""");
        }
        stringBuilder.AppendLine("    }");
        stringBuilder.Append('}');
        return ("InteropGenerator.Runtime.Generated.Addresses.g.cs", stringBuilder.ToString());
    }

    public static (string, string) GetFixedSizeArraySource(IEnumerable<int> sizes) {
        StringBuilder stringBuilder = new();
        stringBuilder.AppendLine("// <auto-generated/>");
        stringBuilder.Append("namespace InteropGenerator.Runtime.Generated;");
        foreach (int size in sizes) {
            stringBuilder.Append("\r\n");
            stringBuilder.AppendLine($"[InlineArray({size})]");
            stringBuilder.AppendLine($"public struct FixedSizeArray{size}<T> where T : unmanaged");
            stringBuilder.AppendLine("{");
            stringBuilder.AppendLine("    private T _element0;");
            stringBuilder.Append('}');
        }
        return ("InteropGenerator.Runtime.Generated.FixedArrays.g.cs", stringBuilder.ToString());
    }

    public static (string, string) GetEmptyGenerationSource(string structName) {
        return ($"{structName}.InteropGenerator.g.cs", 
            $$"""
              // <auto-generated/>
              unsafe partial struct {{structName}}
              {
              }
              """);
    }
}
