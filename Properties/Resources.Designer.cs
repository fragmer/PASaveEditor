﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PASaveEditor.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("PASaveEditor.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to When enabled you will always receive a random number of Prisoners every day,
        ///which you may not temporarily stop..
        /// </summary>
        internal static string TipContinuousIntake {
            get {
                return ResourceManager.GetString("TipContinuousIntake", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [CHEAT] If disabled, everything would presumably stop getting dirty.
        ///Dirty things will stay clean once cleaned. Removes the need for janitors!.
        /// </summary>
        internal static string TipDecay {
            get {
                return ResourceManager.GetString("TipDecay", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable or disable failure conditions (ways to lose):
        ///too many deaths, too many escapes, uncontrolled riot, and bankruptcy..
        /// </summary>
        internal static string TipFailureConditions {
            get {
                return ResourceManager.GetString("TipFailureConditions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enable or disable Fog of War
        ///(limited indoor visibility, based on where CCTV and guards are)..
        /// </summary>
        internal static string TipFogOfWar {
            get {
                return ResourceManager.GetString("TipFogOfWar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [CHEAT] If misconduct is disabled, prisoners will not break any rules. No fun!.
        /// </summary>
        internal static string TipMisconduct {
            get {
                return ResourceManager.GetString("TipMisconduct", resourceCulture);
            }
        }
    }
}
