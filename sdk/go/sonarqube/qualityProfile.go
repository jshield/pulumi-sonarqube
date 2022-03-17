// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sonarqube

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type QualityProfile struct {
	pulumi.CustomResourceState

	// Is the default profile
	IsDefault pulumi.BoolPtrOutput `pulumi:"isDefault"`
	// Quality profile key
	Key pulumi.StringOutput `pulumi:"key"`
	// Quality profile language
	Language pulumi.StringOutput `pulumi:"language"`
	// Quality profile name
	Name   pulumi.StringOutput    `pulumi:"name"`
	Parent pulumi.StringPtrOutput `pulumi:"parent"`
}

// NewQualityProfile registers a new resource with the given unique name, arguments, and options.
func NewQualityProfile(ctx *pulumi.Context,
	name string, args *QualityProfileArgs, opts ...pulumi.ResourceOption) (*QualityProfile, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Language == nil {
		return nil, errors.New("invalid value for required argument 'Language'")
	}
	var resource QualityProfile
	err := ctx.RegisterResource("sonarqube:index/qualityProfile:QualityProfile", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetQualityProfile gets an existing QualityProfile resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetQualityProfile(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *QualityProfileState, opts ...pulumi.ResourceOption) (*QualityProfile, error) {
	var resource QualityProfile
	err := ctx.ReadResource("sonarqube:index/qualityProfile:QualityProfile", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering QualityProfile resources.
type qualityProfileState struct {
	// Is the default profile
	IsDefault *bool `pulumi:"isDefault"`
	// Quality profile key
	Key *string `pulumi:"key"`
	// Quality profile language
	Language *string `pulumi:"language"`
	// Quality profile name
	Name   *string `pulumi:"name"`
	Parent *string `pulumi:"parent"`
}

type QualityProfileState struct {
	// Is the default profile
	IsDefault pulumi.BoolPtrInput
	// Quality profile key
	Key pulumi.StringPtrInput
	// Quality profile language
	Language pulumi.StringPtrInput
	// Quality profile name
	Name   pulumi.StringPtrInput
	Parent pulumi.StringPtrInput
}

func (QualityProfileState) ElementType() reflect.Type {
	return reflect.TypeOf((*qualityProfileState)(nil)).Elem()
}

type qualityProfileArgs struct {
	// Is the default profile
	IsDefault *bool `pulumi:"isDefault"`
	// Quality profile language
	Language string `pulumi:"language"`
	// Quality profile name
	Name   *string `pulumi:"name"`
	Parent *string `pulumi:"parent"`
}

// The set of arguments for constructing a QualityProfile resource.
type QualityProfileArgs struct {
	// Is the default profile
	IsDefault pulumi.BoolPtrInput
	// Quality profile language
	Language pulumi.StringInput
	// Quality profile name
	Name   pulumi.StringPtrInput
	Parent pulumi.StringPtrInput
}

func (QualityProfileArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*qualityProfileArgs)(nil)).Elem()
}

type QualityProfileInput interface {
	pulumi.Input

	ToQualityProfileOutput() QualityProfileOutput
	ToQualityProfileOutputWithContext(ctx context.Context) QualityProfileOutput
}

func (*QualityProfile) ElementType() reflect.Type {
	return reflect.TypeOf((**QualityProfile)(nil)).Elem()
}

func (i *QualityProfile) ToQualityProfileOutput() QualityProfileOutput {
	return i.ToQualityProfileOutputWithContext(context.Background())
}

func (i *QualityProfile) ToQualityProfileOutputWithContext(ctx context.Context) QualityProfileOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QualityProfileOutput)
}

// QualityProfileArrayInput is an input type that accepts QualityProfileArray and QualityProfileArrayOutput values.
// You can construct a concrete instance of `QualityProfileArrayInput` via:
//
//          QualityProfileArray{ QualityProfileArgs{...} }
type QualityProfileArrayInput interface {
	pulumi.Input

	ToQualityProfileArrayOutput() QualityProfileArrayOutput
	ToQualityProfileArrayOutputWithContext(context.Context) QualityProfileArrayOutput
}

type QualityProfileArray []QualityProfileInput

func (QualityProfileArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*QualityProfile)(nil)).Elem()
}

func (i QualityProfileArray) ToQualityProfileArrayOutput() QualityProfileArrayOutput {
	return i.ToQualityProfileArrayOutputWithContext(context.Background())
}

func (i QualityProfileArray) ToQualityProfileArrayOutputWithContext(ctx context.Context) QualityProfileArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QualityProfileArrayOutput)
}

// QualityProfileMapInput is an input type that accepts QualityProfileMap and QualityProfileMapOutput values.
// You can construct a concrete instance of `QualityProfileMapInput` via:
//
//          QualityProfileMap{ "key": QualityProfileArgs{...} }
type QualityProfileMapInput interface {
	pulumi.Input

	ToQualityProfileMapOutput() QualityProfileMapOutput
	ToQualityProfileMapOutputWithContext(context.Context) QualityProfileMapOutput
}

type QualityProfileMap map[string]QualityProfileInput

func (QualityProfileMap) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*QualityProfile)(nil)).Elem()
}

func (i QualityProfileMap) ToQualityProfileMapOutput() QualityProfileMapOutput {
	return i.ToQualityProfileMapOutputWithContext(context.Background())
}

func (i QualityProfileMap) ToQualityProfileMapOutputWithContext(ctx context.Context) QualityProfileMapOutput {
	return pulumi.ToOutputWithContext(ctx, i).(QualityProfileMapOutput)
}

type QualityProfileOutput struct{ *pulumi.OutputState }

func (QualityProfileOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**QualityProfile)(nil)).Elem()
}

func (o QualityProfileOutput) ToQualityProfileOutput() QualityProfileOutput {
	return o
}

func (o QualityProfileOutput) ToQualityProfileOutputWithContext(ctx context.Context) QualityProfileOutput {
	return o
}

type QualityProfileArrayOutput struct{ *pulumi.OutputState }

func (QualityProfileArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]*QualityProfile)(nil)).Elem()
}

func (o QualityProfileArrayOutput) ToQualityProfileArrayOutput() QualityProfileArrayOutput {
	return o
}

func (o QualityProfileArrayOutput) ToQualityProfileArrayOutputWithContext(ctx context.Context) QualityProfileArrayOutput {
	return o
}

func (o QualityProfileArrayOutput) Index(i pulumi.IntInput) QualityProfileOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) *QualityProfile {
		return vs[0].([]*QualityProfile)[vs[1].(int)]
	}).(QualityProfileOutput)
}

type QualityProfileMapOutput struct{ *pulumi.OutputState }

func (QualityProfileMapOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*map[string]*QualityProfile)(nil)).Elem()
}

func (o QualityProfileMapOutput) ToQualityProfileMapOutput() QualityProfileMapOutput {
	return o
}

func (o QualityProfileMapOutput) ToQualityProfileMapOutputWithContext(ctx context.Context) QualityProfileMapOutput {
	return o
}

func (o QualityProfileMapOutput) MapIndex(k pulumi.StringInput) QualityProfileOutput {
	return pulumi.All(o, k).ApplyT(func(vs []interface{}) *QualityProfile {
		return vs[0].(map[string]*QualityProfile)[vs[1].(string)]
	}).(QualityProfileOutput)
}

func init() {
	pulumi.RegisterInputType(reflect.TypeOf((*QualityProfileInput)(nil)).Elem(), &QualityProfile{})
	pulumi.RegisterInputType(reflect.TypeOf((*QualityProfileArrayInput)(nil)).Elem(), QualityProfileArray{})
	pulumi.RegisterInputType(reflect.TypeOf((*QualityProfileMapInput)(nil)).Elem(), QualityProfileMap{})
	pulumi.RegisterOutputType(QualityProfileOutput{})
	pulumi.RegisterOutputType(QualityProfileArrayOutput{})
	pulumi.RegisterOutputType(QualityProfileMapOutput{})
}