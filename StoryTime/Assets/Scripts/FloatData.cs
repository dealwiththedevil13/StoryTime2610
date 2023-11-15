using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public float data;

    public void SetValue(float num)
    {
        value = num;
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
}