using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using TailwindWPF.Styling;

namespace TailwindWPF.XSD
{
    public static class XsdGenerator
    {
        /// <summary>
        /// Generate a XSD file for autocomplete IntelliSense
        /// </summary>
        public static void GenerateTailwindXsd(string outputPath = "TailwindWPF.xsd")
        {
            Console.WriteLine("Generate schema XSD");

            var xsd = CreateTailwindSchema();
            File.WriteAllText(outputPath, xsd, Encoding.UTF8);

            Console.WriteLine($"Schema path: {Path.GetFullPath(outputPath)}");
        }

        private static string CreateTailwindSchema()
        {
            var sb = new StringBuilder();

            // XML Schema header
            sb.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            sb.AppendLine("<xs:schema");
            sb.AppendLine("    targetNamespace=\"clr-namespace:TailwindWPF.Styling;assembly=TailwindWPF\"");
            sb.AppendLine("    xmlns:tw=\"clr-namespace:TailwindWPF.Styling;assembly=TailwindWPF\"");
            sb.AppendLine("    xmlns:xs=\"http://www.w3.org/2001/XMLSchema\"");
            sb.AppendLine("    elementFormDefault=\"qualified\">");
            sb.AppendLine();

            // Class types
            sb.AppendLine("  <xs:simpleType name=\"TailwindClassType\">");
            sb.AppendLine("    <xs:annotation>");
            sb.AppendLine("      <xs:documentation>Classes Tailwind CSS disponibles dans TailwindWPF</xs:documentation>");
            sb.AppendLine("    </xs:annotation>");
            sb.AppendLine("    <xs:restriction base=\"xs:string\">");

            var allClasses = TailwindMap.ClassMap.Keys.OrderBy(k => k).ToList();

            foreach (var className in allClasses)
            {
                sb.AppendLine($"      <xs:enumeration value=\"{EscapeXml(className)}\">");
                sb.AppendLine($"        <xs:annotation>");
                sb.AppendLine($"          <xs:documentation>{GetClassDocumentation(className)}</xs:documentation>");
                sb.AppendLine($"        </xs:annotation>");
                sb.AppendLine($"      </xs:enumeration>");
            }

            sb.AppendLine("    </xs:restriction>");
            sb.AppendLine("  </xs:simpleType>");
            sb.AppendLine();

            sb.AppendLine("  <xs:attribute name=\"Class\">");
            sb.AppendLine("    <xs:annotation>");
            sb.AppendLine("      <xs:documentation>Classes Tailwind CSS séparées par des espaces</xs:documentation>");
            sb.AppendLine("    </xs:annotation>");
            sb.AppendLine("    <xs:simpleType>");
            sb.AppendLine("      <xs:list itemType=\"tw:TailwindClassType\"/>");
            sb.AppendLine("    </xs:simpleType>");
            sb.AppendLine("  </xs:attribute>");
            sb.AppendLine();

            sb.AppendLine("</xs:schema>");

            return sb.ToString();
        }

        private static string EscapeXml(string text)
        {
            return text
                .Replace("&", "&amp;")
                .Replace("<", "&lt;")
                .Replace(">", "&gt;")
                .Replace("\"", "&quot;")
                .Replace("'", "&apos;");
        }

        private static string GetClassDocumentation(string className)
        {
            // Documentation name based
            return className switch
            {
                var c when c.StartsWith("bg-") => $"Background color: {c}",
                var c when c.StartsWith("text-") && (c.Contains("xs") || c.Contains("sm") || c.Contains("lg") || c.Contains("xl") || c.Contains("2xl") || c.Contains("base")) => $"Font size: {c}",
                var c when c.StartsWith("text-") => $"Text color: {c}",
                var c when c.StartsWith("p-") => $"Padding: {c}",
                var c when c.StartsWith("m-") => $"Margin: {c}",
                var c when c.StartsWith("w-") => $"Width: {c}",
                var c when c.StartsWith("h-") => $"Height: {c}",
                var c when c.StartsWith("border-") => $"Border: {c}",
                var c when c.StartsWith("rounded") => $"Border radius: {c}",
                var c when c.StartsWith("shadow") => $"Box shadow: {c}",
                var c when c.StartsWith("opacity") => $"Opacity: {c}",
                var c when c.StartsWith("hover:") => $"Hover state: {c}",
                var c when c.StartsWith("focus:") => $"Focus state: {c}",
                var c when c.StartsWith("active:") => $"Active state: {c}",
                var c when c.StartsWith("disabled:") => $"Disabled state: {c}",
                var c when c.StartsWith("sm:") => $"Small screens (≥640px): {c}",
                var c when c.StartsWith("md:") => $"Medium screens (≥768px): {c}",
                var c when c.StartsWith("lg:") => $"Large screens (≥1024px): {c}",
                var c when c.StartsWith("xl:") => $"Extra large screens (≥1280px): {c}",
                var c when c.StartsWith("2xl:") => $"2X Extra large screens (≥1536px): {c}",
                var c when c.StartsWith("flex") => $"Flexbox: {c}",
                var c when c.StartsWith("grid") => $"Grid: {c}",
                _ => $"Tailwind class: {className}"
            };
        }

        /// <summary>
        /// Generate a report
        /// </summary>
        public static void GenerateClassReport(string outputPath = "TailwindClasses.txt")
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Date : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine($"Total : {TailwindMap.ClassMap.Count} classes");
            sb.AppendLine();

            var classesByCategory = TailwindMap.ClassMap.Keys
                .GroupBy(GetClassCategory)
                .OrderBy(g => g.Key);

            foreach (var category in classesByCategory)
            {
                sb.AppendLine($"=== {category.Key.ToUpper()} ({category.Count()} classes) ===");
                foreach (var className in category.OrderBy(c => c))
                {
                    sb.AppendLine($"  {className}");
                }
                sb.AppendLine();
            }

            File.WriteAllText(outputPath, sb.ToString(), Encoding.UTF8);
            Console.WriteLine($"report path : {Path.GetFullPath(outputPath)}");
        }

        private static string GetClassCategory(string className)
        {
            return className switch
            {
                var c when c.StartsWith("bg-") => "Background",
                var c when c.StartsWith("text-") && (c.Contains("xs") || c.Contains("sm") || c.Contains("lg") || c.Contains("xl") || c.Contains("2xl") || c.Contains("base")) => "Typography Size",
                var c when c.StartsWith("text-") => "Text Color",
                var c when c.StartsWith("font-") => "Typography Weight",
                var c when c.StartsWith("p-") || c.StartsWith("px-") || c.StartsWith("py-") || c.StartsWith("pt-") || c.StartsWith("pr-") || c.StartsWith("pb-") || c.StartsWith("pl-") => "Padding",
                var c when c.StartsWith("m-") || c.StartsWith("mx-") || c.StartsWith("my-") || c.StartsWith("mt-") || c.StartsWith("mr-") || c.StartsWith("mb-") || c.StartsWith("ml-") => "Margin",
                var c when c.StartsWith("w-") => "Width",
                var c when c.StartsWith("h-") => "Height",
                var c when c.StartsWith("border-") => "Border",
                var c when c.StartsWith("rounded") => "Border Radius",
                var c when c.StartsWith("shadow") || c.StartsWith("drop-shadow") => "Shadow",
                var c when c.StartsWith("opacity") => "Opacity",
                var c when c.StartsWith("blur") => "Blur",
                var c when c.StartsWith("scale") || c.StartsWith("rotate") || c.StartsWith("translate") || c.StartsWith("skew") => "Transform",
                var c when c.StartsWith("hover:") => "Hover States",
                var c when c.StartsWith("focus:") => "Focus States",
                var c when c.StartsWith("active:") => "Active States",
                var c when c.StartsWith("disabled:") => "Disabled States",
                var c when c.StartsWith("sm:") => "Responsive Small",
                var c when c.StartsWith("md:") => "Responsive Medium",
                var c when c.StartsWith("lg:") => "Responsive Large",
                var c when c.StartsWith("xl:") => "Responsive XL",
                var c when c.StartsWith("2xl:") => "Responsive 2XL",
                var c when c.StartsWith("flex") || c.StartsWith("justify") || c.StartsWith("items") || c.StartsWith("self") => "Flexbox",
                var c when c.StartsWith("grid") || c.StartsWith("col-") || c.StartsWith("row-") || c.StartsWith("gap") => "Grid",
                var c when c.StartsWith("absolute") || c.StartsWith("relative") || c.StartsWith("fixed") || c.StartsWith("top-") || c.StartsWith("bottom-") || c.StartsWith("left-") || c.StartsWith("right-") || c.StartsWith("z-") => "Position",
                var c when c.StartsWith("block") || c.StartsWith("inline") || c.StartsWith("hidden") || c.StartsWith("visible") => "Display",
                var c when c.StartsWith("cursor") => "Cursor",
                var c when c.StartsWith("transition") || c.StartsWith("duration") => "Transition",
                _ => "Other"
            };
        }
    }
}
