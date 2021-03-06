// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    [SonarqubeResourceType("sonarqube:index/permissionTemplate:PermissionTemplate")]
    public partial class PermissionTemplate : Pulumi.CustomResource
    {
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("projectKeyPattern")]
        public Output<string?> ProjectKeyPattern { get; private set; } = null!;


        /// <summary>
        /// Create a PermissionTemplate resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PermissionTemplate(string name, PermissionTemplateArgs? args = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/permissionTemplate:PermissionTemplate", name, args ?? new PermissionTemplateArgs(), MakeResourceOptions(options, ""))
        {
        }

        private PermissionTemplate(string name, Input<string> id, PermissionTemplateState? state = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/permissionTemplate:PermissionTemplate", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PermissionTemplate resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PermissionTemplate Get(string name, Input<string> id, PermissionTemplateState? state = null, CustomResourceOptions? options = null)
        {
            return new PermissionTemplate(name, id, state, options);
        }
    }

    public sealed class PermissionTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("projectKeyPattern")]
        public Input<string>? ProjectKeyPattern { get; set; }

        public PermissionTemplateArgs()
        {
        }
    }

    public sealed class PermissionTemplateState : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("projectKeyPattern")]
        public Input<string>? ProjectKeyPattern { get; set; }

        public PermissionTemplateState()
        {
        }
    }
}
