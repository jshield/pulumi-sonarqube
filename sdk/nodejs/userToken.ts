// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

export class UserToken extends pulumi.CustomResource {
    /**
     * Get an existing UserToken resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserTokenState, opts?: pulumi.CustomResourceOptions): UserToken {
        return new UserToken(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'sonarqube:index/userToken:UserToken';

    /**
     * Returns true if the given object is an instance of UserToken.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is UserToken {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === UserToken.__pulumiType;
    }

    public readonly loginName!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string>;
    public /*out*/ readonly token!: pulumi.Output<string>;

    /**
     * Create a UserToken resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserTokenArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserTokenArgs | UserTokenState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as UserTokenState | undefined;
            resourceInputs["loginName"] = state ? state.loginName : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["token"] = state ? state.token : undefined;
        } else {
            const args = argsOrState as UserTokenArgs | undefined;
            if ((!args || args.loginName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'loginName'");
            }
            resourceInputs["loginName"] = args ? args.loginName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["token"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(UserToken.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserToken resources.
 */
export interface UserTokenState {
    loginName?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    token?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a UserToken resource.
 */
export interface UserTokenArgs {
    loginName: pulumi.Input<string>;
    name?: pulumi.Input<string>;
}