﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lapis.Script.Parser {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class ExceptionResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ExceptionResource() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Lapis.Script.Parser.ExceptionResource", typeof(ExceptionResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 Content has already been set. 的本地化字符串。
        /// </summary>
        internal static string ContentHasAlreadySet {
            get {
                return ResourceManager.GetString("ContentHasAlreadySet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Content is unset. 的本地化字符串。
        /// </summary>
        internal static string ContentNull {
            get {
                return ResourceManager.GetString("ContentNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Branches have different roots. 的本地化字符串。
        /// </summary>
        internal static string DifferentRoot {
            get {
                return ResourceManager.GetString("DifferentRoot", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid char range. 的本地化字符串。
        /// </summary>
        internal static string InvalidCharRange {
            get {
                return ResourceManager.GetString("InvalidCharRange", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Unable to find a matching token. 的本地化字符串。
        /// </summary>
        internal static string MatchFailed {
            get {
                return ResourceManager.GetString("MatchFailed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Syntax error. 的本地化字符串。
        /// </summary>
        internal static string SyntaxError {
            get {
                return ResourceManager.GetString("SyntaxError", resourceCulture);
            }
        }
    }
}
