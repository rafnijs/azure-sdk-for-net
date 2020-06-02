// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.DigitalTwins.Core.Serialization;

namespace Azure.DigitalTwins.Core.Tests
{
    public static class TestAssetsHelper
    {
        private static readonly string NewLine = Environment.NewLine;

        // Remove all new line characters as they are differnt in differnt Operaing Systems.
        // This will ensure that the recorded files always match the request in playback mode of tests.
        private static string RemoveNewLine(string payload)
        {
            return payload.Replace(NewLine, "");
        }

        public static string GetFloorModelPayload(string floorModelId, string roomModelId, string hvacModelId)
        {
            return RemoveNewLine(TestAssets.FloorModelPayload
                .Replace("FLOOR_MODEL_ID", floorModelId)
                .Replace("ROOM_MODEL_ID", roomModelId)
                .Replace("HVAC_MODEL_ID", hvacModelId));
        }

        public static string GetRoomModelPayload(string roomModelId, string floorModelId)
        {
            return RemoveNewLine(TestAssets.RoomModelPayload
                .Replace("ROOM_MODEL_ID", roomModelId)
                .Replace("FLOOR_MODEL_ID", floorModelId));
        }

        public static string GetHvacModelPayload(string hvacModelId, string floorModelId)
        {
            return RemoveNewLine(TestAssets.HvacModelPayload
                .Replace("HVAC_MODEL_ID", hvacModelId)
                .Replace("FLOOR_MODEL_ID", floorModelId));
        }

        public static string GetBuildingModelPayload(string buildingModelId, string hvacModelId, string floorModelId)
        {
            return RemoveNewLine(TestAssets.BuildingModelPayload
                .Replace("BUILDING_MODEL_ID", buildingModelId)
                .Replace("HVAC_MODEL_ID", hvacModelId)
                .Replace("FLOOR_MODEL_ID", floorModelId));
        }

        public static string GetWardModelPayload(string wardModelId)
        {
            return RemoveNewLine(TestAssets.WardModelPayload.Replace("WARD_MODEL_ID", wardModelId));
        }

        public static string GetRoomTwinUpdatePayload()
        {
            var uou = new UpdateOperationsUtility();
            uou.AppendAddOp("/Humidity", 30);
            uou.AppendReplaceOp("/Temperature", 70);
            uou.AppendRemoveOp("/EmployeeId");
            return RemoveNewLine(uou.Serialize());
        }

        public static string GetWifiComponentUpdatePayload()
        {
            var uou = new UpdateOperationsUtility();
            uou.AppendReplaceOp("/Network", "New Network");
            return RemoveNewLine(uou.Serialize());
        }

        public static string GetFloorTwinPayload(string floorModelId)
        {
            return RemoveNewLine(TestAssets.FloorTwinPayload.Replace("FLOOR_MODEL_ID", floorModelId));
        }

        public static string GetRoomTwinPayload(string roomModelId)
        {
            return RemoveNewLine(TestAssets.RoomTwinPayload.Replace("ROOM_MODEL_ID", roomModelId));
        }

        public static string GetRelationshipPayload(string targetTwinId, string relationshipName)
        {
            return RemoveNewLine(TestAssets.RelationshipPayload
                .Replace("TARGET_TWIN_ID", targetTwinId)
                .Replace("RELATIONSHIP_NAME", relationshipName));
        }

        public static string GetRelationshipWithPropertyPayload(string targetTwinId, string relationshipName, string propertyName, bool propertyValue)
        {
            return RemoveNewLine(TestAssets.RelationshipWithPropertyPayload
                .Replace("TARGET_TWIN_ID", targetTwinId)
                .Replace("RELATIONSHIP_NAME", relationshipName)
                .Replace("PROPERTY_NAME", propertyName)
                .Replace("\"PROPERTY_VALUE\"", propertyValue.ToString().ToLower()));
        }

        public static string GetRelationshipUpdatePayload(string propertyName, bool propertyValue)
        {
            var uou = new UpdateOperationsUtility();
            uou.AppendReplaceOp(propertyName, propertyValue);
            return RemoveNewLine(uou.Serialize());
        }

        public static string GetWifiModelPayload(string wifiModelId)
        {
            return RemoveNewLine(TestAssets.WifiModelPayload.Replace("WIFI_MODEL_ID", wifiModelId));
        }

        public static string GetRoomWithWifiModelPayload(string roomWithWifiModelId, string wifiModelId, string wifiComponentName)
        {
            return RemoveNewLine(TestAssets.RoomWithWifiModelPayload
                .Replace("ROOM_WITH_WIFI_MODEL_ID", roomWithWifiModelId)
                .Replace("WIFI_MODEL_ID", wifiModelId)
                .Replace("WIFI_COMPONENT_NAME", wifiComponentName));
        }

        public static string GetRoomWithWifiTwinPayload(string roomWithWifiModelId, string wifiModelId, string wifiComponentName)
        {
            return RemoveNewLine(TestAssets.RoomWithWifiTwinPayload
                .Replace("ROOM_WITH_WIFI_MODEL_ID", roomWithWifiModelId)
                .Replace("WIFI_MODEL_ID", wifiModelId)
                .Replace("WIFI_COMPONENT_NAME", wifiComponentName));
        }

        public static string GetHvacTwinPayload(string hvacModelId)
        {
            return RemoveNewLine(TestAssets.HvacTwinPayload.Replace("HVAC_MODEL_ID", hvacModelId));
        }
    }
}
