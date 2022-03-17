// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    [SonarqubeResourceType("sonarqube:index/rule:Rule")]
    public partial class Rule : Pulumi.CustomResource
    {
        /// <summary>
        /// Key of the custom rule
        /// </summary>
        [Output("customKey")]
        public Output<string> CustomKey { get; private set; } = null!;

        /// <summary>
        /// Rule description
        /// </summary>
        [Output("markdownDescription")]
        public Output<string> MarkdownDescription { get; private set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
        /// </summary>
        [Output("params")]
        public Output<string?> Params { get; private set; } = null!;

        /// <summary>
        /// If set to true and if the rule has been deactivated (status 'REMOVED'), a status 409 will be returned
        /// </summary>
        [Output("preventReactivation")]
        public Output<string?> PreventReactivation { get; private set; } = null!;

        /// <summary>
        /// Rule severity
        /// </summary>
        [Output("severity")]
        public Output<string?> Severity { get; private set; } = null!;

        /// <summary>
        /// Rule status
        /// </summary>
        [Output("status")]
        public Output<string?> Status { get; private set; } = null!;

        /// <summary>
        /// Key of the template rule in order to create a custom rule (mandatory for custom rule)
        /// </summary>
        [Output("templateKey")]
        public Output<string> TemplateKey { get; private set; } = null!;

        /// <summary>
        /// Rule type
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Rule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Rule(string name, RuleArgs args, CustomResourceOptions? options = null)
            : base("sonarqube:index/rule:Rule", name, args ?? new RuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Rule(string name, Input<string> id, RuleState? state = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/rule:Rule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Rule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Rule Get(string name, Input<string> id, RuleState? state = null, CustomResourceOptions? options = null)
        {
            return new Rule(name, id, state, options);
        }
    }

    public sealed class RuleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key of the custom rule
        /// </summary>
        [Input("customKey", required: true)]
        public Input<string> CustomKey { get; set; } = null!;

        /// <summary>
        /// Rule description
        /// </summary>
        [Input("markdownDescription", required: true)]
        public Input<string> MarkdownDescription { get; set; } = null!;

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
        /// </summary>
        [Input("params")]
        public Input<string>? Params { get; set; }

        /// <summary>
        /// If set to true and if the rule has been deactivated (status 'REMOVED'), a status 409 will be returned
        /// </summary>
        [Input("preventReactivation")]
        public Input<string>? PreventReactivation { get; set; }

        /// <summary>
        /// Rule severity
        /// </summary>
        [Input("severity")]
        public Input<string>? Severity { get; set; }

        /// <summary>
        /// Rule status
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Key of the template rule in order to create a custom rule (mandatory for custom rule)
        /// </summary>
        [Input("templateKey", required: true)]
        public Input<string> TemplateKey { get; set; } = null!;

        /// <summary>
        /// Rule type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public RuleArgs()
        {
        }
    }

    public sealed class RuleState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Key of the custom rule
        /// </summary>
        [Input("customKey")]
        public Input<string>? CustomKey { get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [Input("markdownDescription")]
        public Input<string>? MarkdownDescription { get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
        /// </summary>
        [Input("params")]
        public Input<string>? Params { get; set; }

        /// <summary>
        /// If set to true and if the rule has been deactivated (status 'REMOVED'), a status 409 will be returned
        /// </summary>
        [Input("preventReactivation")]
        public Input<string>? PreventReactivation { get; set; }

        /// <summary>
        /// Rule severity
        /// </summary>
        [Input("severity")]
        public Input<string>? Severity { get; set; }

        /// <summary>
        /// Rule status
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// Key of the template rule in order to create a custom rule (mandatory for custom rule)
        /// </summary>
        [Input("templateKey")]
        public Input<string>? TemplateKey { get; set; }

        /// <summary>
        /// Rule type
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public RuleState()
        {
        }
    }
}
