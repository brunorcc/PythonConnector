﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;

namespace Primavera.Lithium.PythonConnector.Client.Console.Configuration
{
    #region Code

    #region Public Classes

    /// <summary>
    /// Defines the base class for the configuration used by the application.
    /// </summary>
    [GeneratedCode("Lithium", "2.0")]
    public abstract partial class ApplicationConfigurationBase
    {
        #region Code

        #region Public Properties

        /// <summary>
        /// Gets or sets the service Web API base URI.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string ServiceBaseUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the environments configuration.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual EnvironmentsConfiguration Environments
        {
            get;
            set;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationConfigurationBase"/> class.
        /// </summary>
        protected ApplicationConfigurationBase()        
        {
            // Initialize properties

            this.Environments = new EnvironmentsConfiguration();

            // Set default values

            this.SetDefaultValues();
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Sets the default values.
        /// </summary>
        /// <remarks>
        /// This method should be overridden to set the default values of properties.
        /// </remarks>
        protected virtual void SetDefaultValues()
        {
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines the configuration used by the application.
    /// </summary>
    /// <seealso cref="ApplicationConfigurationBase" />
    [GeneratedCode("Lithium", "2.0")]
    public partial class ApplicationConfiguration : ApplicationConfigurationBase
    {
        #region Code

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationConfiguration"/> class.
        /// </summary>
        public ApplicationConfiguration()        
            : base()
        {
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines the base class for the configuration of an environment.
    /// </summary>
    [GeneratedCode("Lithium", "2.0")]
    public abstract partial class EnvironmentsConfigurationBase
    {
        #region Code

        #region Public Properties

        /// <summary>
        /// Gets or sets the service base URI on the local development environment.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string LocalServiceBaseUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service base URI on the development environment.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string DevelopmentServiceBaseUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service base URI on the stating environment.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string StagingServiceBaseUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service base URI on the preview environment.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string PreviewServiceBaseUri
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service base URI on the production environment.
        /// </summary>
        [SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings")]
        public virtual string ProductionServiceBaseUri
        {
            get;
            set;
        }

        #endregion

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsConfigurationBase"/> class.
        /// </summary>
        protected EnvironmentsConfigurationBase()        
        {
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Sets the default values.
        /// </summary>
        /// <remarks>
        /// This method should be overridden to set the default values of properties.
        /// </remarks>
        protected virtual void SetDefaultValues()
        {
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines the configuration of an environment.
    /// </summary>
    /// <seealso cref="EnvironmentsConfigurationBase" />
    [GeneratedCode("Lithium", "2.0")]
    public partial class EnvironmentsConfiguration : EnvironmentsConfigurationBase
    {
        #region Code

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsConfiguration"/> class.
        /// </summary>
        public EnvironmentsConfiguration()        
            : base()
        {
        }

        #endregion

        #endregion
    }

    #endregion

    #endregion
}
