// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class SonarProject extends pulumi.CustomResource {
    /**
     * Get an existing SonarProject resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SonarProjectState, opts?: pulumi.CustomResourceOptions): SonarProject {
        return new SonarProject(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sonarqube:index/sonarProject:SonarProject';

    /**
     * Returns true if the given object is an instance of SonarProject.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SonarProject {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SonarProject.__pulumiType;
    }

    public readonly name!: pulumi.Output<string>;
    public readonly project!: pulumi.Output<string>;
    public readonly visibility!: pulumi.Output<string | undefined>;

    /**
     * Create a SonarProject resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SonarProjectArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SonarProjectArgs | SonarProjectState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SonarProjectState | undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["project"] = state ? state.project : undefined;
            resourceInputs["visibility"] = state ? state.visibility : undefined;
        } else {
            const args = argsOrState as SonarProjectArgs | undefined;
            if ((!args || args.project === undefined) && !opts.urn) {
                throw new Error("Missing required property 'project'");
            }
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["project"] = args ? args.project : undefined;
            resourceInputs["visibility"] = args ? args.visibility : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SonarProject.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SonarProject resources.
 */
export interface SonarProjectState {
    name?: pulumi.Input<string>;
    project?: pulumi.Input<string>;
    visibility?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a SonarProject resource.
 */
export interface SonarProjectArgs {
    name?: pulumi.Input<string>;
    project: pulumi.Input<string>;
    visibility?: pulumi.Input<string>;
}
