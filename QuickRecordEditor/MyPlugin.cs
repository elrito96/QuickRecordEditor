using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace QuickRecordEditor
{
    // using xrmtb.XrmToolBox.Controls for CRM controls in the window


    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Quick Record Editor"),
        ExportMetadata("Description", "This tool lets you easily and quickly modify a record's fields"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", null),
        // Please specify the base64 content of a 80x80 pixels image
        // This image is shown in the tool list, have to load it here statically as this value is taken in compilation time, not execution time
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}