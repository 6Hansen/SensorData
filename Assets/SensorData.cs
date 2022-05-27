using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorData : MonoBehaviour
{
    public int Value;
    public float Time;

    public KeyFrame(){}

    public KeyFrame (int value, float time)
    {
        Value = value;
        Time = time;
    }

    public string ToCSV()
{
    var sb = new StringBuilder("Time,Value");
    foreach(var frame in keyFrames)
    {
        sb.Append('\n').Append(frame.Time.ToString()).Append(',').Append(frame.Value.ToString());
    }

    return sb.ToString();
}
}
