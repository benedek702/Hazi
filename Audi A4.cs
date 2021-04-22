using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudiA4 : MonoBehaviour
{
    private int speed;

    public int Speed
    {
        get { return speed; }
        set { speed = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Speed = 8;
        print("Sebbesség=8");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
