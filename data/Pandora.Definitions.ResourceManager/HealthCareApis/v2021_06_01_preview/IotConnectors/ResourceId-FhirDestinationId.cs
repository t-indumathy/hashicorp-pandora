using System.Collections.Generic;
using Pandora.Definitions.Interfaces;

namespace Pandora.Definitions.ResourceManager.HealthCareApis.v2021_06_01_preview.IotConnectors;

internal class FhirDestinationId : ResourceID
{
    public string? CommonAlias => null;

    public string ID => "/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HealthcareApis/workspaces/{workspaceName}/iotConnectors/{iotConnectorName}/fhirDestinations/{fhirDestinationName}";

    public List<ResourceIDSegment> Segments => new List<ResourceIDSegment>
    {
                new()
                {
                    Name = "staticSubscriptions",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "subscriptions"
                },

                new()
                {
                    Name = "subscriptionId",
                    Type = ResourceIDSegmentType.SubscriptionId
                },

                new()
                {
                    Name = "staticResourceGroups",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "resourceGroups"
                },

                new()
                {
                    Name = "resourceGroupName",
                    Type = ResourceIDSegmentType.ResourceGroup
                },

                new()
                {
                    Name = "staticProviders",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "providers"
                },

                new()
                {
                    Name = "staticMicrosoftHealthcareApis",
                    Type = ResourceIDSegmentType.ResourceProvider,
                    FixedValue = "Microsoft.HealthcareApis"
                },

                new()
                {
                    Name = "staticWorkspaces",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "workspaces"
                },

                new()
                {
                    Name = "workspaceName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

                new()
                {
                    Name = "staticIotConnectors",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "iotConnectors"
                },

                new()
                {
                    Name = "iotConnectorName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

                new()
                {
                    Name = "staticFhirDestinations",
                    Type = ResourceIDSegmentType.Static,
                    FixedValue = "fhirDestinations"
                },

                new()
                {
                    Name = "fhirDestinationName",
                    Type = ResourceIDSegmentType.UserSpecified
                },

    };
}