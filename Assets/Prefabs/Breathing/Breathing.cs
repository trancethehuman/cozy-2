using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breathing : MonoBehaviour
{
    [field: SerializeField] public float TimeLimit { get; private set; }
    [field: SerializeField] public int BreathsPerMinute { get; private set; }
    [field: SerializeField] public float TimeTillNextBreath { get; private set; }
    [field: SerializeField] public int CurrentBreath { get; private set; }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
