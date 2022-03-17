// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class QualityProfile extends pulumi.CustomResource {
    /**
     * Get an existing QualityProfile resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: QualityProfileState, opts?: pulumi.CustomResourceOptions): QualityProfile {
        return new QualityProfile(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sonarqube:index/qualityProfile:QualityProfile';

    /**
     * Returns true if the given object is an instance of QualityProfile.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is QualityProfile {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === QualityProfile.__pulumiType;
    }

    /**
     * Is the default profile
     */
    public readonly isDefault!: pulumi.Output<boolean | undefined>;
    /**
     * Quality profile key
     */
    public /*out*/ readonly key!: pulumi.Output<string>;
    /**
     * Quality profile language
     */
    public readonly language!: pulumi.Output<string>;
    /**
     * Quality profile name
     */
    public readonly name!: pulumi.Output<string>;
    public readonly parent!: pulumi.Output<string | undefined>;

    /**
     * Create a QualityProfile resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: QualityProfileArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: QualityProfileArgs | QualityProfileState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as QualityProfileState | undefined;
            resourceInputs["isDefault"] = state ? state.isDefault : undefined;
            resourceInputs["key"] = state ? state.key : undefined;
            resourceInputs["language"] = state ? state.language : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["parent"] = state ? state.parent : undefined;
        } else {
            const args = argsOrState as QualityProfileArgs | undefined;
            if ((!args || args.language === undefined) && !opts.urn) {
                throw new Error("Missing required property 'language'");
            }
            resourceInputs["isDefault"] = args ? args.isDefault : undefined;
            resourceInputs["language"] = args ? args.language : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["parent"] = args ? args.parent : undefined;
            resourceInputs["key"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(QualityProfile.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering QualityProfile resources.
 */
export interface QualityProfileState {
    /**
     * Is the default profile
     */
    isDefault?: pulumi.Input<boolean>;
    /**
     * Quality profile key
     */
    key?: pulumi.Input<string>;
    /**
     * Quality profile language
     */
    language?: pulumi.Input<string>;
    /**
     * Quality profile name
     */
    name?: pulumi.Input<string>;
    parent?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a QualityProfile resource.
 */
export interface QualityProfileArgs {
    /**
     * Is the default profile
     */
    isDefault?: pulumi.Input<boolean>;
    /**
     * Quality profile language
     */
    language: pulumi.Input<string>;
    /**
     * Quality profile name
     */
    name?: pulumi.Input<string>;
    parent?: pulumi.Input<string>;
}