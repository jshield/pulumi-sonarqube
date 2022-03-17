# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['QualityProfileArgs', 'QualityProfile']

@pulumi.input_type
class QualityProfileArgs:
    def __init__(__self__, *,
                 language: pulumi.Input[str],
                 is_default: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a QualityProfile resource.
        :param pulumi.Input[str] language: Quality profile language
        :param pulumi.Input[bool] is_default: Is the default profile
        :param pulumi.Input[str] name: Quality profile name
        """
        pulumi.set(__self__, "language", language)
        if is_default is not None:
            pulumi.set(__self__, "is_default", is_default)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parent is not None:
            pulumi.set(__self__, "parent", parent)

    @property
    @pulumi.getter
    def language(self) -> pulumi.Input[str]:
        """
        Quality profile language
        """
        return pulumi.get(self, "language")

    @language.setter
    def language(self, value: pulumi.Input[str]):
        pulumi.set(self, "language", value)

    @property
    @pulumi.getter(name="isDefault")
    def is_default(self) -> Optional[pulumi.Input[bool]]:
        """
        Is the default profile
        """
        return pulumi.get(self, "is_default")

    @is_default.setter
    def is_default(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_default", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Quality profile name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parent(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "parent")

    @parent.setter
    def parent(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "parent", value)


@pulumi.input_type
class _QualityProfileState:
    def __init__(__self__, *,
                 is_default: Optional[pulumi.Input[bool]] = None,
                 key: Optional[pulumi.Input[str]] = None,
                 language: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering QualityProfile resources.
        :param pulumi.Input[bool] is_default: Is the default profile
        :param pulumi.Input[str] key: Quality profile key
        :param pulumi.Input[str] language: Quality profile language
        :param pulumi.Input[str] name: Quality profile name
        """
        if is_default is not None:
            pulumi.set(__self__, "is_default", is_default)
        if key is not None:
            pulumi.set(__self__, "key", key)
        if language is not None:
            pulumi.set(__self__, "language", language)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if parent is not None:
            pulumi.set(__self__, "parent", parent)

    @property
    @pulumi.getter(name="isDefault")
    def is_default(self) -> Optional[pulumi.Input[bool]]:
        """
        Is the default profile
        """
        return pulumi.get(self, "is_default")

    @is_default.setter
    def is_default(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "is_default", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        Quality profile key
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def language(self) -> Optional[pulumi.Input[str]]:
        """
        Quality profile language
        """
        return pulumi.get(self, "language")

    @language.setter
    def language(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "language", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        Quality profile name
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def parent(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "parent")

    @parent.setter
    def parent(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "parent", value)


class QualityProfile(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 is_default: Optional[pulumi.Input[bool]] = None,
                 language: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a QualityProfile resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_default: Is the default profile
        :param pulumi.Input[str] language: Quality profile language
        :param pulumi.Input[str] name: Quality profile name
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: QualityProfileArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a QualityProfile resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param QualityProfileArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(QualityProfileArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 is_default: Optional[pulumi.Input[bool]] = None,
                 language: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 parent: Optional[pulumi.Input[str]] = None,
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
            __props__ = QualityProfileArgs.__new__(QualityProfileArgs)

            __props__.__dict__["is_default"] = is_default
            if language is None and not opts.urn:
                raise TypeError("Missing required property 'language'")
            __props__.__dict__["language"] = language
            __props__.__dict__["name"] = name
            __props__.__dict__["parent"] = parent
            __props__.__dict__["key"] = None
        super(QualityProfile, __self__).__init__(
            'sonarqube:index/qualityProfile:QualityProfile',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            is_default: Optional[pulumi.Input[bool]] = None,
            key: Optional[pulumi.Input[str]] = None,
            language: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            parent: Optional[pulumi.Input[str]] = None) -> 'QualityProfile':
        """
        Get an existing QualityProfile resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] is_default: Is the default profile
        :param pulumi.Input[str] key: Quality profile key
        :param pulumi.Input[str] language: Quality profile language
        :param pulumi.Input[str] name: Quality profile name
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _QualityProfileState.__new__(_QualityProfileState)

        __props__.__dict__["is_default"] = is_default
        __props__.__dict__["key"] = key
        __props__.__dict__["language"] = language
        __props__.__dict__["name"] = name
        __props__.__dict__["parent"] = parent
        return QualityProfile(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="isDefault")
    def is_default(self) -> pulumi.Output[Optional[bool]]:
        """
        Is the default profile
        """
        return pulumi.get(self, "is_default")

    @property
    @pulumi.getter
    def key(self) -> pulumi.Output[str]:
        """
        Quality profile key
        """
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def language(self) -> pulumi.Output[str]:
        """
        Quality profile language
        """
        return pulumi.get(self, "language")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Quality profile name
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def parent(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "parent")

