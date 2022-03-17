// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sonarqube

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type UserToken struct {
	pulumi.CustomResourceState

	LoginName pulumi.StringOutput `pulumi:"loginName"`
	Name      pulumi.StringOutput `pulumi:"name"`
	Token     pulumi.StringOutput `pulumi:"token"`
}

// NewUserToken registers a new resource with the given unique name, arguments, and options.
func NewUserToken(ctx *pulumi.Context,
	name string, args *UserTokenArgs, opts ...pulumi.ResourceOption) (*UserToken, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.LoginName == nil {
		return nil, errors.New("invalid value for required argument 'LoginName'")
	}
	var resource UserToken
	err := ctx.RegisterResource("sonarqube:index/userToken:UserToken", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetUserToken gets an existing UserToken resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetUserToken(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *UserTokenState, opts ...pulumi.ResourceOption) (*UserToken, error) {
	var resource UserToken
	err := ctx.ReadResource("sonarqube:index/userToken:UserToken", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering UserToken resources.
type userTokenState struct {
	LoginName *string `pulumi:"loginName"`
	Name      *string `pulumi:"name"`
	Token     *string `pulumi:"token"`
}

type UserTokenState struct {
	LoginName pulumi.StringPtrInput
	Name      pulumi.StringPtrInput
	Token     pulumi.StringPtrInput
}

func (UserTokenState) ElementType() reflect.Type {
	return reflect.TypeOf((*userTokenState)(nil)).Elem()
}

type userTokenArgs struct {
	LoginName string  `pulumi:"loginName"`
	Name      *string `pulumi:"name"`
}

// The set of arguments for constructing a UserToken resource.
type UserTokenArgs struct {
	LoginName pulumi.StringInput
	Name      pulumi.StringPtrInput
}

func (UserTokenArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*userTokenArgs)(nil)).Elem()
}

type UserTokenInput interface {
	pulumi.Input

	ToUserTokenOutput() UserTokenOutput
	ToUserTokenOutputWithContext(ctx context.Context) UserTokenOutput
}

func (*UserToken) ElementType() reflect.Type {
	return reflect.TypeOf((**UserToken)(nil)).Elem()
}

func (i *UserToken) ToUserTokenOutput() UserTokenOutput {
	return i.ToUserTokenOutputWithContext(context.Background())
}

func (i *UserToken) ToUserTokenOutputWithContext(ctx context.Context) UserTokenOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserTokenOutput)
}

// UserTokenArrayInput is an input type that accepts UserTokenArray and UserTokenArrayOutput values.
// You can construct a concrete instance of `UserTokenArrayInput` via:
//
//          UserTokenArray{ UserTokenArgs{...} }
type UserTokenArrayInput interface {
	pulumi.Input

	ToUserTokenArrayOutput() UserTokenArrayOutput
	ToUserTokenArrayOutputWithContext(context.Context) UserTokenArrayOutput
}

type UserTokenArray []UserTokenInput

func (UserTokenArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*UserToken)(nil)).Elem()
}

func (i UserTokenArray) ToUserTokenArrayOutput() UserTokenArrayOutput {
	return i.ToUserTokenArrayOutputWithContext(context.Background())
}

func (i UserTokenArray) ToUserTokenArrayOutputWithContext(ctx context.Context) UserTokenArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserTokenArrayOutput)
}

// UserTokenMapInput is an input type that accepts UserTokenMap and UserTokenMapOutput values.
// You can construct a concrete instance of `UserTokenMapInput` via:
//
//          UserTokenMap{ "key": UserTokenArgs{...} }
type UserTokenMapInput interface {
	pulumi.Input

	ToUserTokenMapOutput() UserTokenMapOutput
	ToUserTokenMapOutputWithContext(context.Context) UserTokenMapOutput
}

type UserTokenMap map[string]UserTokenInput

func (UserTokenMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*UserToken)(nil)).Elem()
}

func (i UserTokenMap) ToUserTokenMapOutput() UserTokenMapOutput {
	return i.ToUserTokenMapOutputWithContext(context.Background())
}

func (i UserTokenMap) ToUserTokenMapOutputWithContext(ctx context.Context) UserTokenMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(UserTokenMapOutput)
}

type UserTokenOutput struct{ *pulumi.OutputState }

func (UserTokenOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**UserToken)(nil)).Elem()
}

func (o UserTokenOutput) ToUserTokenOutput() UserTokenOutput {
	return o
}

func (o UserTokenOutput) ToUserTokenOutputWithContext(ctx context.Context) UserTokenOutput {
	return o
}

type UserTokenArrayOutput struct{ *pulumi.OutputState }

func (UserTokenArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*UserToken)(nil)).Elem()
}

func (o UserTokenArrayOutput) ToUserTokenArrayOutput() UserTokenArrayOutput {
	return o
}

func (o UserTokenArrayOutput) ToUserTokenArrayOutputWithContext(ctx context.Context) UserTokenArrayOutput {
	return o
}

func (o UserTokenArrayOutput) Index(i pulumi.IntInput) UserTokenOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *UserToken {
		return vs[0].([]*UserToken)[vs[1].(int)]
	}).(UserTokenOutput)
}

type UserTokenMapOutput struct{ *pulumi.OutputState }

func (UserTokenMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*UserToken)(nil)).Elem()
}

func (o UserTokenMapOutput) ToUserTokenMapOutput() UserTokenMapOutput {
	return o
}

func (o UserTokenMapOutput) ToUserTokenMapOutputWithContext(ctx context.Context) UserTokenMapOutput {
	return o
}

func (o UserTokenMapOutput) MapIndex(k pulumi.StringInput) UserTokenOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *UserToken {
		return vs[0].(map[string]*UserToken)[vs[1].(string)]
	}).(UserTokenOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*UserTokenInput)(nil)).Elem(), &UserToken{})
	pulumi.RegisterInputType(reflect.TypeOf((*UserTokenArrayInput)(nil)).Elem(), UserTokenArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*UserTokenMapInput)(nil)).Elem(), UserTokenMap{})
	pulumi.RegisterOutputType(UserTokenOutput{})
	pulumi.RegisterOutputType(UserTokenArrayOutput{})
	pulumi.RegisterOutputType(UserTokenMapOutput{})
}