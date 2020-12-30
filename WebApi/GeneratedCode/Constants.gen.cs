﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Globalization;

namespace Primavera.Lithium.PythonConnector.WebApi
{
    #region Code

    #region Public Classes

    /// <summary>
    /// Defines constants used by various types.
    /// </summary>
    [GeneratedCode("Lithium", "2.0")]
    public static partial class Constants
    {
        #region Code

        #region Public Classes

        /// <summary>
        /// Defines constants used by MVC controllers.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        public static partial class Controllers
        {
            #region Code

            #region Public Classes

            /// <summary>
            /// Defines constants that specified by the Home MVC controller.
            /// </summary>
            [GeneratedCode("Lithium", "2.0")]
            public static partial class Home
            {
                #region Code

                #region Public Classes

                /// <summary>
                /// Defines constants that specified the routes used in the Home MVC controller.
                /// </summary>
                [GeneratedCode("Lithium", "2.0")]
                public static partial class Routes
                {
                    #region Code

                    #region Public Constants

                    /// <summary>
                    /// Defines the route of the index action.
                    /// </summary>
                    public const string Index = "";

                    /// <summary>
                    /// Defines the route of the access denied action.
                    /// </summary>
                    public const string AccessDenied = "/accessdenied";

                    /// <summary>
                    /// Defines the route of the error action.
                    /// </summary>
                    public const string Error = "/error";

                    /// <summary>
                    /// Defines the route of the signout action.
                    /// </summary>
                    public const string Signout = "/signout";

                    #endregion

                    #endregion
                }

                /// <summary>
                /// Defines constants that specify the action names used the Home MVC controller.
                /// </summary>
                [GeneratedCode("Lithium", "2.0")]
                public static partial class Actions
                {
                    #region Code

                    #region Public Constants

                    /// <summary>
                    /// Defines the name of the index action.
                    /// </summary>
                    public const string Index = "Home.Index";

                    /// <summary>
                    /// Defines the route of the access denied action.
                    /// </summary>
                    public const string AccessDenied = "Home.AccessDenied";

                    /// <summary>
                    /// Defines the route of the error action.
                    /// </summary>
                    public const string Error = "Home.Error";

                    /// <summary>
                    /// Defines the route of the signout action.
                    /// </summary>
                    public const string Signout = "Home.Signout";

                    #endregion

                    #endregion
                }

                #endregion

                #region Public Constants

                /// <summary>
                /// Defines the name of the controller.
                /// </summary>
                public const string Name = "Home";

                #endregion

                #endregion
            }

            #endregion

            #endregion
        }

        /// <summary>
        /// Defines constants used in the documentation.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        public static partial class Documentation
        {
            #region Code

            #region Public Constants

            /// <summary>
            /// Defines the base route of the Web API documentation.
            /// </summary>
            public const string WebApiBaseRoute = "/.doc/webapi";

            /// <summary>
            /// Defines the route of the Web API documentation documents.
            /// </summary>
            public const string WebApiDocumentsRoute = "/.doc/webapi/{documentName}/openapi.json";

            /// <summary>
            /// Defines the path of the custom script used to customize the UI.
            /// </summary>
            public const string WebApiJavaScriptPath = "OpenApiCustomScript.gen.js";

            /// <summary>
            /// Defines the path of the custom style sheet used to customize the UI.
            /// </summary>
            public const string WebApiStyleSheetPath = "OpenApiCustomStyleSheet.gen.css";

            /// <summary>
            /// Defines the base route of the Client Library documentation.
            /// </summary>
            public const string ClientLibBaseRoute = "/.doc/clientlib";

            /// <summary>
            /// Defines the action name of the Client Library documentation.
            /// </summary>
            public const string ClientLibActionName = "ClientLibDocumentation.Documentation";

            #endregion

            #endregion
        }

        #endregion

        #region Internal Classes

        /// <summary>
        /// Defines constants used to identity authentication policies.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        internal static partial class Policies
        {
            #region Code

            #region Internal Constants

            /// <summary>
            /// Defines the name of the policy that applies the default scope.
            /// </summary>
            internal const string DefaultScope = "pythonconnector";

            #endregion

            #endregion
        }

        /// <summary>
        /// Defines the base class for the localization instance.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        internal abstract partial class LocalizationInstanceBase
        {
            #region Code

            #region Internal Properties

            /// <summary>
            /// Gets the list of the extended supported cultures.
            /// </summary>
            internal virtual IList<CultureInfo> SupportedCulturesExtended
            {
                get
                {
                    return new List<CultureInfo>
                    {
                        new CultureInfo(Localization.EnglishDefaultCultureString),
                        new CultureInfo(Localization.EnglishFromIrelandCultureString),
                        new CultureInfo(Localization.EnglishFromGreatBritainCultureString),
                        new CultureInfo(Localization.EnglishFromUnitedStatesCultureString),
                        new CultureInfo(Localization.PortugueseDefaultCultureString),
                        new CultureInfo(Localization.PortugueseFromAngolaCultureString),
                        new CultureInfo(Localization.PortugueseFromCapeVerdeCultureString),
                        new CultureInfo(Localization.PortugueseFromMozambiqueCultureString),
                        new CultureInfo(Localization.PortugueseFromPortugalCultureString),
                        new CultureInfo(Localization.SpanishDefaultCultureString),
                        new CultureInfo(Localization.SpanishFromArgentinaCultureString),
                        new CultureInfo(Localization.SpanishFromChileCultureString),
                        new CultureInfo(Localization.SpanishFromMexicoCultureString),
                        new CultureInfo(Localization.SpanishFromSpainCultureString)
                    };
                }
            }

            /// <summary>
            /// Gets the default culture (as a string).
            /// </summary>
            internal virtual string DefaultCultureString
            {
                get
                {
                    return Localization.EnglishFromUnitedStatesCultureString;
                }
            }

            #endregion

            #endregion
        }

        /// <summary>
        /// Defines settings used in request localization.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        internal partial class LocalizationInstance : LocalizationInstanceBase
        {
            #region Code

            #endregion
        }

        /// <summary>
        /// Defines settings used to in request localization.
        /// </summary>
        [GeneratedCode("Lithium", "2.0")]
        internal static partial class Localization
        {
            #region Code

            #region Internal Constants

            /// <summary>
            /// The Portuguese culture (as a string).
            /// </summary>
            internal const string PortugueseDefaultCultureString = "pt";

            /// <summary>
            /// The Portuguese (Angola) culture (as a string).
            /// </summary>
            internal const string PortugueseFromAngolaCultureString = "pt-AO";

            /// <summary>
            /// The Portuguese (Cape Verde) culture (as a string).
            /// </summary>
            internal const string PortugueseFromCapeVerdeCultureString = "pt-CV";

            /// <summary>
            /// The Portuguese (Mozambique) culture (as a string).
            /// </summary>
            internal const string PortugueseFromMozambiqueCultureString = "pt-MZ";

            /// <summary>
            /// The Portuguese (Portugal) culture (as a string).
            /// </summary>
            internal const string PortugueseFromPortugalCultureString = "pt-PT";

            /// <summary>
            /// The English culture (as a string).
            /// </summary>
            internal const string EnglishDefaultCultureString = "en";

            /// <summary>
            /// The English (Ireland) culture (as a string).
            /// </summary>
            internal const string EnglishFromIrelandCultureString = "en-IE";

            /// <summary>
            /// The English (G.B.) culture (as a string).
            /// </summary>
            internal const string EnglishFromGreatBritainCultureString = "en-GB";

            /// <summary>
            /// The English (U.S.) culture (as a string).
            /// </summary>
            internal const string EnglishFromUnitedStatesCultureString = "en-US";

            /// <summary>
            /// The Spanish culture (as a string).
            /// </summary>
            internal const string SpanishDefaultCultureString = "es";

            /// <summary>
            /// The Spanish (Argentina) culture (as a string).
            /// </summary>
            internal const string SpanishFromArgentinaCultureString = "es-AR";

            /// <summary>
            /// The Spanish (Chile) culture (as a string).
            /// </summary>
            internal const string SpanishFromChileCultureString = "es-CL";

            /// <summary>
            /// The Spanish (Mexico) culture (as a string).
            /// </summary>
            internal const string SpanishFromMexicoCultureString = "es-MX";

            /// <summary>
            /// The Spanish (Spain) culture (as a string).
            /// </summary>
            internal const string SpanishFromSpainCultureString = "es-ES";

            #endregion

            #region Fields

            private static LocalizationInstance fieldInstance = new LocalizationInstance();

            #endregion

            #region Internal Properties

            /// <summary>
            /// Gets the default culture.
            /// </summary>
            internal static CultureInfo DefaultCulture
            {
                get
                {
                    return new CultureInfo(DefaultCultureString);
                }
            }

            /// <summary>
            /// Gets the default culture (as a string).
            /// </summary>
            internal static string DefaultCultureString
            {
                get
                {
                    return Instance.DefaultCultureString;
                }
            }

            /// <summary>
            /// Gets the list of extended supported cultures.
            /// </summary>
            internal static IList<CultureInfo> SupportedCulturesExtended
            {
                get
                {
                    return Instance.SupportedCulturesExtended;
                }
            }

            #endregion

            #region Private Properties

            /// <summary>
            /// Gets the instance
            /// </summary>
            private static LocalizationInstance Instance
            {
                get
                {
                    return fieldInstance;
                }
            }

            #endregion

            #endregion
        }

        #endregion

        #endregion
    }

    #endregion

    #endregion
}
