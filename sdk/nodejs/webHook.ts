// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class WebHook extends pulumi.CustomResource {
    /**
     * Get an existing WebHook resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WebHookState, opts?: pulumi.CustomResourceOptions): WebHook {
        return new WebHook(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sonarqube:index/webHook:WebHook';

    /**
     * Returns true if the given object is an instance of WebHook.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is WebHook {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === WebHook.__pulumiType;
    }

    public readonly name!: pulumi.Output<string>;
    public readonly secret!: pulumi.Output<string>;
    public readonly url!: pulumi.Output<string>;

    /**
     * Create a WebHook resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WebHookArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WebHookArgs | WebHookState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WebHookState | undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["secret"] = state ? state.secret : undefined;
            resourceInputs["url"] = state ? state.url : undefined;
        } else {
            const args = argsOrState as WebHookArgs | undefined;
            if ((!args || args.url === undefined) && !opts.urn) {
                throw new Error("Missing required property 'url'");
            }
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["secret"] = args ? args.secret : undefined;
            resourceInputs["url"] = args ? args.url : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(WebHook.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering WebHook resources.
 */
export interface WebHookState {
    name?: pulumi.Input<string>;
    secret?: pulumi.Input<string>;
    url?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a WebHook resource.
 */
export interface WebHookArgs {
    name?: pulumi.Input<string>;
    secret?: pulumi.Input<string>;
    url: pulumi.Input<string>;
}
