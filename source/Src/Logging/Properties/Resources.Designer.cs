﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnterpriseLibrary.ExceptionHandling.Logging.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EnterpriseLibrary.ExceptionHandling.Logging.Properties.Resour" +
                            "ces", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type specified for the formatter is not a formatter type..
        /// </summary>
        internal static string ExceptionFormatterTypeNotFormatter {
            get {
                return ResourceManager.GetString("ExceptionFormatterTypeNotFormatter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The formatter type is not set or does not represent a type..
        /// </summary>
        internal static string ExceptionFormatterTypeNotSetOrInvalid {
            get {
                return ResourceManager.GetString("ExceptionFormatterTypeNotSetOrInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Handler: &apos;{0}&apos;.
        /// </summary>
        internal static string HandlerPartNameTemplate {
            get {
                return ResourceManager.GetString("HandlerPartNameTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Category.
        /// </summary>
        internal static string LoggingHandlerCategoryPartName {
            get {
                return ResourceManager.GetString("LoggingHandlerCategoryPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event ID.
        /// </summary>
        internal static string LoggingHandlerEventIdPartName {
            get {
                return ResourceManager.GetString("LoggingHandlerEventIdPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Formatter.
        /// </summary>
        internal static string LoggingHandlerFormatterPartName {
            get {
                return ResourceManager.GetString("LoggingHandlerFormatterPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Priority.
        /// </summary>
        internal static string LoggingHandlerPriorityPartName {
            get {
                return ResourceManager.GetString("LoggingHandlerPriorityPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Severity.
        /// </summary>
        internal static string LoggingHandlerSeverityPartName {
            get {
                return ResourceManager.GetString("LoggingHandlerSeverityPartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Title.
        /// </summary>
        internal static string LoggingHandlerTitlePartName {
            get {
                return ResourceManager.GetString("LoggingHandlerTitlePartName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The configured exception formatter &apos;{0}&apos; must expose a public constructor that takes a TextWriter object, an Exception object and a GUID instance as parameters..
        /// </summary>
        internal static string MissingConstructor {
            get {
                return ResourceManager.GetString("MissingConstructor", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Logger.Writer property must be set before building a LoggingExceptionHandler..
        /// </summary>
        internal static string MustSetLoggerWriterException {
            get {
                return ResourceManager.GetString("MustSetLoggerWriterException", resourceCulture);
            }
        }
    }
}
