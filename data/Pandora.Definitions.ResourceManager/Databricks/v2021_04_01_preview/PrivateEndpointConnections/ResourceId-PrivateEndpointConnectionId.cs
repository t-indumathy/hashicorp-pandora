using System.Collections.Generic;
using Pandora.Definitions.Interfaces;


// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See NOTICE.txt in the project root for license information.


namespace Pandora.Definitions.ResourceManager.Databricks.v2021_04_01_preview.PrivateEndpointConnections;

internal class PrivateEndpointConnectionId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Databricks/workspaces/{workspaceName}/privateEndpointConnections/{privateEndpointConnectionName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
        ResourceIDSegment.Static("staticSubscriptions", "subscriptions"),
        ResourceIDSegment.SubscriptionId("subscriptionId"),
        ResourceIDSegment.Static("staticResourceGroups", "resourceGroups"),
        ResourceIDSegment.ResourceGroup("resourceGroupName"),
        ResourceIDSegment.Static("staticProviders", "providers"),
        ResourceIDSegment.ResourceProvider("staticMicrosoftDatabricks", "Microsoft.Databricks"),
        ResourceIDSegment.Static("staticWorkspaces", "workspaces"),
        ResourceIDSegment.UserSpecified("workspaceName"),
        ResourceIDSegment.Static("staticPrivateEndpointConnections", "privateEndpointConnections"),
        ResourceIDSegment.UserSpecified("privateEndpointConnectionName"),
    };
}