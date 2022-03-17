// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    [SonarqubeResourceType("sonarqube:index/user:User")]
    public partial class User : Pulumi.CustomResource
    {
        [Output("email")]
        public Output<string?> Email { get; private set; } = null!;

        [Output("isLocal")]
        public Output<bool?> IsLocal { get; private set; } = null!;

        [Output("loginName")]
        public Output<string> LoginName { get; private set; } = null!;

        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;


        /// <summary>
        /// Create a User resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public User(string name, UserArgs args, CustomResourceOptions? options = null)
            : base("sonarqube:index/user:User", name, args ?? new UserArgs(), MakeResourceOptions(options, ""))
        {
        }

        private User(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
            : base("sonarqube:index/user:User", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing User resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static User Get(string name, Input<string> id, UserState? state = null, CustomResourceOptions? options = null)
        {
            return new User(name, id, state, options);
        }
    }

    public sealed class UserArgs : Pulumi.ResourceArgs
    {
        [Input("email")]
        public Input<string>? Email { get; set; }

        [Input("isLocal")]
        public Input<bool>? IsLocal { get; set; }

        [Input("loginName", required: true)]
        public Input<string> LoginName { get; set; } = null!;

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        public UserArgs()
        {
        }
    }

    public sealed class UserState : Pulumi.ResourceArgs
    {
        [Input("email")]
        public Input<string>? Email { get; set; }

        [Input("isLocal")]
        public Input<bool>? IsLocal { get; set; }

        [Input("loginName")]
        public Input<string>? LoginName { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        public UserState()
        {
        }
    }
}
