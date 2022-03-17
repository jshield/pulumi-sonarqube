# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ProviderArgs', 'Provider']

@pulumi.input_type
class ProviderArgs:
    def __init__(__self__, *,
                 host: pulumi.Input[str],
                 pass_: pulumi.Input[str],
                 user: pulumi.Input[str],
                 installed_version: Optional[pulumi.Input[str]] = None,
                 tls_insecure_skip_verify: Optional[pulumi.Input[bool]] = None):
        """
        The set of arguments for constructing a Provider resource.
        :param pulumi.Input[bool] tls_insecure_skip_verify: Allows ignoring insecure certificates when set to true. Defaults to false. Disabling TLS verification is dangerous and
               should only be done for local testing.
        """
        pulumi.set(__self__, "host", host)
        pulumi.set(__self__, "pass_", pass_)
        pulumi.set(__self__, "user", user)
        if installed_version is not None:
            pulumi.set(__self__, "installed_version", installed_version)
        if tls_insecure_skip_verify is not None:
            pulumi.set(__self__, "tls_insecure_skip_verify", tls_insecure_skip_verify)

    @property
    @pulumi.getter
    def host(self) -> pulumi.Input[str]:
        return pulumi.get(self, "host")

    @host.setter
    def host(self, value: pulumi.Input[str]):
        pulumi.set(self, "host", value)

    @property
    @pulumi.getter(name="pass")
    def pass_(self) -> pulumi.Input[str]:
        return pulumi.get(self, "pass_")

    @pass_.setter
    def pass_(self, value: pulumi.Input[str]):
        pulumi.set(self, "pass_", value)

    @property
    @pulumi.getter
    def user(self) -> pulumi.Input[str]:
        return pulumi.get(self, "user")

    @user.setter
    def user(self, value: pulumi.Input[str]):
        pulumi.set(self, "user", value)

    @property
    @pulumi.getter(name="installedVersion")
    def installed_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "installed_version")

    @installed_version.setter
    def installed_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "installed_version", value)

    @property
    @pulumi.getter(name="tlsInsecureSkipVerify")
    def tls_insecure_skip_verify(self) -> Optional[pulumi.Input[bool]]:
        """
        Allows ignoring insecure certificates when set to true. Defaults to false. Disabling TLS verification is dangerous and
        should only be done for local testing.
        """
        return pulumi.get(self, "tls_insecure_skip_verify")

    @tls_insecure_skip_verify.setter
    def tls_insecure_skip_verify(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "tls_insecure_skip_verify", value)


class Provider(pulumi.ProviderResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host: Optional[pulumi.Input[str]] = None,
                 installed_version: Optional[pulumi.Input[str]] = None,
                 pass_: Optional[pulumi.Input[str]] = None,
                 tls_insecure_skip_verify: Optional[pulumi.Input[bool]] = None,
                 user: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        The provider type for the sonarqube package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] tls_insecure_skip_verify: Allows ignoring insecure certificates when set to true. Defaults to false. Disabling TLS verification is dangerous and
               should only be done for local testing.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ProviderArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        The provider type for the sonarqube package. By default, resources use package-wide configuration
        settings, however an explicit `Provider` instance may be created and passed during resource
        construction to achieve fine-grained programmatic control over provider settings. See the
        [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.

        :param str resource_name: The name of the resource.
        :param ProviderArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ProviderArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 host: Optional[pulumi.Input[str]] = None,
                 installed_version: Optional[pulumi.Input[str]] = None,
                 pass_: Optional[pulumi.Input[str]] = None,
                 tls_insecure_skip_verify: Optional[pulumi.Input[bool]] = None,
                 user: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ProviderArgs.__new__(ProviderArgs)

            if host is None and not opts.urn:
                raise TypeError("Missing required property 'host'")
            __props__.__dict__["host"] = host
            __props__.__dict__["installed_version"] = installed_version
            if pass_ is None and not opts.urn:
                raise TypeError("Missing required property 'pass_'")
            __props__.__dict__["pass_"] = pass_
            __props__.__dict__["tls_insecure_skip_verify"] = pulumi.Output.from_input(tls_insecure_skip_verify).apply(pulumi.runtime.to_json) if tls_insecure_skip_verify is not None else None
            if user is None and not opts.urn:
                raise TypeError("Missing required property 'user'")
            __props__.__dict__["user"] = user
        super(Provider, __self__).__init__(
            'sonarqube',
            resource_name,
            __props__,
            opts)

    @property
    @pulumi.getter
    def host(self) -> pulumi.Output[str]:
        return pulumi.get(self, "host")

    @property
    @pulumi.getter(name="installedVersion")
    def installed_version(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "installed_version")

    @property
    @pulumi.getter(name="pass")
    def pass_(self) -> pulumi.Output[str]:
        return pulumi.get(self, "pass_")

    @property
    @pulumi.getter
    def user(self) -> pulumi.Output[str]:
        return pulumi.get(self, "user")
