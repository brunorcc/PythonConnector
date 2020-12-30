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
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Primavera.Hydrogen;
using Primavera.Hydrogen.IdentityModel;
using Primavera.Lithium.PythonConnector.WebApi.Models.Internal.ViewModels;

namespace Primavera.Lithium.PythonConnector.WebApi.Controllers
{
    /// <summary>
    /// Defines the base class for the home controller.
    /// </summary>
    [GeneratedCode("Lithium", "2.0")]
    public abstract partial class HomeControllerBase : Controller
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeControllerBase" /> class.
        /// </summary>
        protected HomeControllerBase()        
        {
        }

        #endregion

        #region Public Methods

        #region Index

        /// <summary>
        /// Executes the action that responds in the default (root) route.
        /// This actions shows a default home page.
        /// </summary>
        /// <returns>
        /// The action result.
        /// </returns>
        [HttpGet(Constants.Controllers.Home.Routes.Index)]
        [ActionName(Constants.Controllers.Home.Actions.Index)]
        public virtual Task<IActionResult> Index()
        {
            // Show the view

            return Task.FromResult<IActionResult>(
                this.View("~/GeneratedCode/HomeView.gen.cshtml"));
        }

        #endregion

        #region AccessDenied

        /// <summary>
        /// Executes the action that shows the access denied error.
        /// </summary>
        /// <returns>
        /// The action result.
        /// </returns>
        [HttpGet(Constants.Controllers.Home.Routes.AccessDenied)]
        [ActionName(Constants.Controllers.Home.Actions.AccessDenied)]
        public virtual Task<IActionResult> AccessDenied()
        {
            // Build the view model

            ErrorViewModel model = new ErrorViewModel(
                403,
                this.Request.Path,
                this.Request.QueryString != null ? this.Request.QueryString.Value : null,
                this.User?.Identity != null ? this.User.Identity.IsAuthenticated : false,
                this.User?.GetEmail());

            // Show the error

            return this.ShowError(model);
        }

        #endregion

        #region Error

        /// <summary>
        /// Executes the action that responds in the error route.
        /// This actions shows a default error page.
        /// </summary>
        /// <param name="statusCode">The error status code.</param>
        /// <returns>
        /// The action result.
        /// </returns>
        [HttpGet(Constants.Controllers.Home.Routes.Error)]
        [ActionName(Constants.Controllers.Home.Actions.Error)]
        public virtual Task<IActionResult> Error(int statusCode)
        {
            // If status code is 0, then use the status code in the response

            if (statusCode == 0 && this.HttpContext.Response != null)
            {
                statusCode = this.HttpContext.Response.StatusCode;
            }

            // Original path and query string

            string originalPath = null;
            string originalQueryString = null;

            // Exception feature

            IExceptionHandlerPathFeature exceptionHandlerFeature = this.HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            if (exceptionHandlerFeature != null)
            {
                originalPath = exceptionHandlerFeature.Path;
            }

            // Status code feature

            IStatusCodeReExecuteFeature statusCodeFeature = this.HttpContext.Features.Get<IStatusCodeReExecuteFeature>();
            if (statusCodeFeature != null)
            {
                originalPath = statusCodeFeature.OriginalPath;
                originalQueryString = statusCodeFeature.OriginalQueryString;
            }

            // Build the view model

            ErrorViewModel model = new ErrorViewModel(
                statusCode, 
                originalPath,
                originalQueryString,
                this.User?.Identity != null ? this.User.Identity.IsAuthenticated : false,
                this.User?.GetEmail());

            // Show the error

            return this.ShowError(model);
        }

        #endregion

        #region Sign-out

        /// <summary>
        /// Executes the action that signs-out the user.
        /// </summary>
        /// <param name="returnUrl">The return URL.</param>
        /// <returns>
        /// The action result.
        /// </returns>
        [Route(Constants.Controllers.Home.Routes.Signout)]
        [ActionName(Constants.Controllers.Home.Actions.Signout)]
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", Justification = "Must be string")]
        public async Task Signout(string returnUrl)
        {
            // Sign-out all authentication schemes

            await this.HttpContext.SignOutAsync(
                OidcConstants.AuthenticationSchemes.Cookies)
                .ConfigureAwait(false);

            await this.HttpContext.SignOutAsync(
                OidcConstants.AuthenticationSchemes.Oidc, 
                new AuthenticationProperties()
                {
                    RedirectUri = returnUrl
                })
                .ConfigureAwait(false);
        }

        #endregion

        #endregion

        #region Protected Methods

        /// <summary>
        /// Shows the default error page for the specified model.
        /// </summary>
        /// <param name="model">The error view model.</param>
        /// <returns>
        /// The action result.
        /// </returns>
        protected virtual Task<IActionResult> ShowError(ErrorViewModel model)
        {
            // Validation

            SmartGuard.NotNull(() => model, model);

            // Show the view

            return Task.FromResult<IActionResult>(
                this.View("~/GeneratedCode/ErrorView.gen.cshtml", model));
        }

        #endregion
    }

    /// <summary>
    /// Defines the controller for the service Web pages.
    /// </summary>
    [GeneratedCode("Lithium", "2.0")]
    [ControllerName(Constants.Controllers.Home.Name)]
    public partial class HomeController : HomeControllerBase
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController" /> class.
        /// </summary>
        public HomeController()
            : base()
        {
        }

        #endregion
    }
}
