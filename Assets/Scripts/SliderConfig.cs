using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/AudioConfig", order = 1)]

public class SliderConfig : ScriptableObject
{

    public float master;
    public float music;
    public float sfx;

}
