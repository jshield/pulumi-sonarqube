// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    [SonarqubeResourceType("sonarqube:index/sonarProject:SonarProject")]
    public partial class SonarProject : Pulumi.CustomResource
    {
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        [Output("visibility")]
        public Output<string?> Visibility { get; private set; } = null!;


        /// <summary>
        /// Create a SonarProject resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SonarProject(string name, SonarProjectArgs args, CustomResourceOptions? options = null)
            : base("sonarqube:index/sonarProject:SonarProject", name, args ?? new SonarProjectArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SonarProject(string name, Input<string> id, SonarProjectState? state = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/sonarProject:SonarProject", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SonarProject resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SonarProject Get(string name, Input<string> id, SonarProjectState? state = null, CustomResourceOptions? options = null)
        {
            return new SonarProject(name, id, state, options);
        }
    }

    public sealed class SonarProjectArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        [Input("visibility")]
        public Input<string>? Visibility { get; set; }

        public SonarProjectArgs()
        {
        }
    }

    public sealed class SonarProjectState : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("visibility")]
        public Input<string>? Visibility { get; set; }

        public SonarProjectState()
        {
        }
    }
}
