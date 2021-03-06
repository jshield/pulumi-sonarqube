// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    [SonarqubeResourceType("sonarqube:index/webHook:WebHook")]
    public partial class WebHook : Pulumi.CustomResource
    {
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("secret")]
        public Output<string> Secret { get; private set; } = null!;

        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a WebHook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public WebHook(string name, WebHookArgs args, CustomResourceOptions? options = null)
            : base("sonarqube:index/webHook:WebHook", name, args ?? new WebHookArgs(), MakeResourceOptions(options, ""))
        {
        }

        private WebHook(string name, Input<string> id, WebHookState? state = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/webHook:WebHook", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing WebHook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static WebHook Get(string name, Input<string> id, WebHookState? state = null, CustomResourceOptions? options = null)
        {
            return new WebHook(name, id, state, options);
        }
    }

    public sealed class WebHookArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secret")]
        public Input<string>? Secret { get; set; }

        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public WebHookArgs()
        {
        }
    }

    public sealed class WebHookState : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secret")]
        public Input<string>? Secret { get; set; }

        [Input("url")]
        public Input<string>? Url { get; set; }

        public WebHookState()
        {
        }
    }
}
