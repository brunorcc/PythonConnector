﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Primavera.Lithium.PythonConnector.WebApi.Controllers
{
    #region Code

    #region Public Classes

    /// <summary>
    /// Defines the base class for the controller that provides the client library documentation.
    /// </summary>
    /// <remarks>
    /// This is the base class of the MVC controller.
    /// </remarks>
    [GeneratedCode("Lithium", "2.0")]
    [SuppressMessage("Maintainability Rules", "SA1402:FileMayOnlyContainASingleType", Justification = "Because of code generation design.")]
    public abstract partial class ClientLibDocumentationControllerBase : Controller
    {
        #region Code

        #region Protected Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLibDocumentationControllerBase" /> class.
        /// </summary>
        protected ClientLibDocumentationControllerBase()        
            : base()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Executes the action that shows the client library documentation.
        /// </summary>
        /// <returns>
        /// The action result.
        /// </returns>
        [ActionName(Constants.Documentation.ClientLibActionName)]
        [HttpGet(Constants.Documentation.ClientLibBaseRoute)]
        public virtual Task<IActionResult> Documentation()
        {
            // Show the view

            return Task.FromResult<IActionResult>(
                this.View("~/GeneratedCode/ClientLibDocView.gen.cshtml"));
        }

        #endregion

        #endregion
    }

    /// <summary>
    /// Defines the controller that provides the client library documentation.
    /// </summary>
    /// <remarks>
    /// This is the MVC controller.
    /// </remarks>
    [GeneratedCode("Lithium", "2.0")]
    [SuppressMessage("Maintainability Rules", "SA1402:FileMayOnlyContainASingleType", Justification = "Because of code generation design.")]
    public partial class ClientLibDocumentationController : ClientLibDocumentationControllerBase
    {
        #region Code

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientLibDocumentationController" /> class.
        /// </summary>
        public ClientLibDocumentationController()        
        {
        }

        #endregion

        #endregion
    }

    #endregion

    #endregion
}