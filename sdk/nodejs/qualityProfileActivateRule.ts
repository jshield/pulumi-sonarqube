// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class QualityProfileActivateRule extends pulumi.CustomResource {
    /**
     * Get an existing QualityProfileActivateRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: QualityProfileActivateRuleState, opts?: pulumi.CustomResourceOptions): QualityProfileActivateRule {
        return new QualityProfileActivateRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sonarqube:index/qualityProfileActivateRule:QualityProfileActivateRule';

    /**
     * Returns true if the given object is an instance of QualityProfileActivateRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is QualityProfileActivateRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === QualityProfileActivateRule.__pulumiType;
    }

    /**
     * Quality Profile key. Can be obtained through api/qualityprofiles/search
     */
    public readonly key!: pulumi.Output<string>;
    /**
     * Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
     */
    public readonly params!: pulumi.Output<string | undefined>;
    /**
     * Reset severity and parameters of activated rule. Set the values defined on parent profile or from rule default values.
     */
    public readonly reset!: pulumi.Output<string | undefined>;
    /**
     * Rule key
     */
    public readonly rule!: pulumi.Output<string>;
    /**
     * Rule severity
     */
    public readonly severity!: pulumi.Output<string | undefined>;

    /**
     * Create a QualityProfileActivateRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: QualityProfileActivateRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: QualityProfileActivateRuleArgs | QualityProfileActivateRuleState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as QualityProfileActivateRuleState | undefined;
            resourceInputs["key"] = state ? state.key : undefined;
            resourceInputs["params"] = state ? state.params : undefined;
            resourceInputs["reset"] = state ? state.reset : undefined;
            resourceInputs["rule"] = state ? state.rule : undefined;
            resourceInputs["severity"] = state ? state.severity : undefined;
        } else {
            const args = argsOrState as QualityProfileActivateRuleArgs | undefined;
            if ((!args || args.key === undefined) && !opts.urn) {
                throw new Error("Missing required property 'key'");
            }
            if ((!args || args.rule === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rule'");
            }
            resourceInputs["key"] = args ? args.key : undefined;
            resourceInputs["params"] = args ? args.params : undefined;
            resourceInputs["reset"] = args ? args.reset : undefined;
            resourceInputs["rule"] = args ? args.rule : undefined;
            resourceInputs["severity"] = args ? args.severity : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(QualityProfileActivateRule.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering QualityProfileActivateRule resources.
 */
export interface QualityProfileActivateRuleState {
    /**
     * Quality Profile key. Can be obtained through api/qualityprofiles/search
     */
    key?: pulumi.Input<string>;
    /**
     * Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
     */
    params?: pulumi.Input<string>;
    /**
     * Reset severity and parameters of activated rule. Set the values defined on parent profile or from rule default values.
     */
    reset?: pulumi.Input<string>;
    /**
     * Rule key
     */
    rule?: pulumi.Input<string>;
    /**
     * Rule severity
     */
    severity?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a QualityProfileActivateRule resource.
 */
export interface QualityProfileActivateRuleArgs {
    /**
     * Quality Profile key. Can be obtained through api/qualityprofiles/search
     */
    key: pulumi.Input<string>;
    /**
     * Parameters as semi-colon list of =, for example 'params=key1=v1;key2=v2' (Only for custom rule)
     */
    params?: pulumi.Input<string>;
    /**
     * Reset severity and parameters of activated rule. Set the values defined on parent profile or from rule default values.
     */
    reset?: pulumi.Input<string>;
    /**
     * Rule key
     */
    rule: pulumi.Input<string>;
    /**
     * Rule severity
     */
    severity?: pulumi.Input<string>;
}
