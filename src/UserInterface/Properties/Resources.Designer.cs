﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieMaker64.UserInterface.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MovieMaker64.UserInterface.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap AboutBoxImage {
            get {
                object obj = ResourceManager.GetObject("AboutBoxImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Base Address: {0}.
        /// </summary>
        internal static string CurrentBaseAddressStatusLabel {
            get {
                return ResourceManager.GetString("CurrentBaseAddressStatusLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Internal Course ID: {0}.
        /// </summary>
        internal static string CurrentCourseStatusLabel {
            get {
                return ResourceManager.GetString("CurrentCourseStatusLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Freeze Camera.
        /// </summary>
        internal static string FreezeCameraButtonLabel {
            get {
                return ResourceManager.GetString("FreezeCameraButtonLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon PrimaryIcon {
            get {
                object obj = ResourceManager.GetObject("PrimaryIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Attach Process.
        /// </summary>
        internal static string ProcessNotSelectedMessageCaption {
            get {
                return ResourceManager.GetString("ProcessNotSelectedMessageCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have not selected a process to attach into for this session.
        ///
        ///If the list does not appear to have any processes on the list, make sure any of the declared processes is running before choosing to refresh.
        ///
        ///If the process still does not appear in the list, this might mean that Movie Maker 64 is currently not set up to recognize the desired process..
        /// </summary>
        internal static string ProcessNotSelectedMessageText {
            get {
                return ResourceManager.GetString("ProcessNotSelectedMessageText", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Soft-freeze Camera.
        /// </summary>
        internal static string SoftfreezeCameraButtonLabel {
            get {
                return ResourceManager.GetString("SoftfreezeCameraButtonLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &amp;Soft-unfreeze Camera.
        /// </summary>
        internal static string SoftunfreezeCameraButtonLabel {
            get {
                return ResourceManager.GetString("SoftunfreezeCameraButtonLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unassigned.
        /// </summary>
        internal static string UnassignedLabel {
            get {
                return ResourceManager.GetString("UnassignedLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Un&amp;freeze Camera.
        /// </summary>
        internal static string UnfreezeCameraButtonLabel {
            get {
                return ResourceManager.GetString("UnfreezeCameraButtonLabel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown.
        /// </summary>
        internal static string UnknownLabel {
            get {
                return ResourceManager.GetString("UnknownLabel", resourceCulture);
            }
        }
    }
}
