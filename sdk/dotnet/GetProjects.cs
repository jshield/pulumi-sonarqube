// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Sonarqube
{
    public static class GetProjects
    {
        public static Task<GetProjectsResult> InvokeAsync(GetProjectsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetProjectsResult>("sonarqube:index/getProjects:getProjects", args ?? new GetProjectsArgs(), options.WithDefaults());

        public static Output<GetProjectsResult> Invoke(GetProjectsInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetProjectsResult>("sonarqube:index/getProjects:getProjects", args ?? new GetProjectsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProjectsArgs : Pulumi.InvokeArgs
    {
        [Input("project", required: true)]
        public string Project { get; set; } = null!;

        public GetProjectsArgs()
        {
        }
    }

    public sealed class GetProjectsInvokeArgs : Pulumi.InvokeArgs
    {
        [Input("project", required: true)]
        public Input<string> Project { get; set; } = null!;

        public GetProjectsInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetProjectsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        public readonly string Project;
        public readonly string Visibility;

        [OutputConstructor]
        private GetProjectsResult(
            string id,

            string name,

            string project,

            string visibility)
        {
            Id = id;
            Name = name;
            Project = project;
            Visibility = visibility;
        }
    }
}
