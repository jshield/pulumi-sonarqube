# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = [
    'GetRulesResult',
    'AwaitableGetRulesResult',
    'get_rules',
    'get_rules_output',
]

@pulumi.output_type
class GetRulesResult:
    """
    A collection of values returned by getRules.
    """
    def __init__(__self__, id=None, key=None, markdown_description=None, name=None, severity=None, status=None, template_key=None, type=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if key and not isinstance(key, str):
            raise TypeError("Expected argument 'key' to be a str")
        pulumi.set(__self__, "key", key)
        if markdown_description and not isinstance(markdown_description, str):
            raise TypeError("Expected argument 'markdown_description' to be a str")
        pulumi.set(__self__, "markdown_description", markdown_description)
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        pulumi.set(__self__, "name", name)
        if severity and not isinstance(severity, str):
            raise TypeError("Expected argument 'severity' to be a str")
        pulumi.set(__self__, "severity", severity)
        if status and not isinstance(status, str):
            raise TypeError("Expected argument 'status' to be a str")
        pulumi.set(__self__, "status", status)
        if template_key and not isinstance(template_key, str):
            raise TypeError("Expected argument 'template_key' to be a str")
        pulumi.set(__self__, "template_key", template_key)
        if type and not isinstance(type, str):
            raise TypeError("Expected argument 'type' to be a str")
        pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter(name="markdownDescription")
    def markdown_description(self) -> str:
        return pulumi.get(self, "markdown_description")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def severity(self) -> str:
        return pulumi.get(self, "severity")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter(name="templateKey")
    def template_key(self) -> str:
        return pulumi.get(self, "template_key")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")


class AwaitableGetRulesResult(GetRulesResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetRulesResult(
            id=self.id,
            key=self.key,
            markdown_description=self.markdown_description,
            name=self.name,
            severity=self.severity,
            status=self.status,
            template_key=self.template_key,
            type=self.type)


def get_rules(key: Optional[str] = None,
              opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetRulesResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['key'] = key
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = _utilities.get_version()
    __ret__ = pulumi.runtime.invoke('sonarqube:index/getRules:getRules', __args__, opts=opts, typ=GetRulesResult).value

    return AwaitableGetRulesResult(
        id=__ret__.id,
        key=__ret__.key,
        markdown_description=__ret__.markdown_description,
        name=__ret__.name,
        severity=__ret__.severity,
        status=__ret__.status,
        template_key=__ret__.template_key,
        type=__ret__.type)


@_utilities.lift_output_func(get_rules)
def get_rules_output(key: Optional[pulumi.Input[str]] = None,
                     opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetRulesResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...