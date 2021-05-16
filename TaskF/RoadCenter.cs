using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
[DataContract]
public class RoadCenter : ITrackingCenter
{
    [DataMember]
    private List<Camera> cameras = new List<Camera>();
    public void AddCamera(int id, int maxSpeed)
    {
        cameras.Add(new Camera(id,maxSpeed));
    }

    public void CheckCarSpeed(int forCameraId, int carNumber, int carSpeed)
    {
        foreach (var camera in cameras)
        {
            if (camera.id == forCameraId)
            {
                if (camera.maxSpeed < carSpeed)
                {
                    camera.AddPenalty(carNumber,carSpeed);
                }
            }
        }
    }

    public void GetData(string inFilePath)
    {
        DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(RoadCenter));

        using (Stream fileData = new FileStream(inFilePath, FileMode.Create))
        {
            formatter.WriteObject(fileData,this);
        }
    }
}