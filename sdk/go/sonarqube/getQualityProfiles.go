// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package sonarqube

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

func GetQualityProfiles(ctx *pulumi.Context, args *GetQualityProfilesArgs, opts ...pulumi.InvokeOption) (*GetQualityProfilesResult, error) {
	var rv GetQualityProfilesResult
	err := ctx.Invoke("sonarqube:index/getQualityProfiles:getQualityProfiles", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getQualityProfiles.
type GetQualityProfilesArgs struct {
	Name string `pulumi:"name"`
}

// A collection of values returned by getQualityProfiles.
type GetQualityProfilesResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id        string `pulumi:"id"`
	IsDefault bool   `pulumi:"isDefault"`
	Key       string `pulumi:"key"`
	Language  string `pulumi:"language"`
	Name      string `pulumi:"name"`
}

func GetQualityProfilesOutput(ctx *pulumi.Context, args GetQualityProfilesOutputArgs, opts ...pulumi.InvokeOption) GetQualityProfilesResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetQualityProfilesResult, error) {
			args := v.(GetQualityProfilesArgs)
			r, err := GetQualityProfiles(ctx, &args, opts...)
			return *r, err
		}).(GetQualityProfilesResultOutput)
}

// A collection of arguments for invoking getQualityProfiles.
type GetQualityProfilesOutputArgs struct {
	Name pulumi.StringInput `pulumi:"name"`
}

func (GetQualityProfilesOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetQualityProfilesArgs)(nil)).Elem()
}

// A collection of values returned by getQualityProfiles.
type GetQualityProfilesResultOutput struct{ *pulumi.OutputState }

func (GetQualityProfilesResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetQualityProfilesResult)(nil)).Elem()
}

func (o GetQualityProfilesResultOutput) ToGetQualityProfilesResultOutput() GetQualityProfilesResultOutput {
	return o
}

func (o GetQualityProfilesResultOutput) ToGetQualityProfilesResultOutputWithContext(ctx context.Context) GetQualityProfilesResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetQualityProfilesResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetQualityProfilesResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetQualityProfilesResultOutput) IsDefault() pulumi.BoolOutput {
	return o.ApplyT(func(v GetQualityProfilesResult) bool { return v.IsDefault }).(pulumi.BoolOutput)
}

func (o GetQualityProfilesResultOutput) Key() pulumi.StringOutput {
	return o.ApplyT(func(v GetQualityProfilesResult) string { return v.Key }).(pulumi.StringOutput)
}

func (o GetQualityProfilesResultOutput) Language() pulumi.StringOutput {
	return o.ApplyT(func(v GetQualityProfilesResult) string { return v.Language }).(pulumi.StringOutput)
}

func (o GetQualityProfilesResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetQualityProfilesResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetQualityProfilesResultOutput{})
}
