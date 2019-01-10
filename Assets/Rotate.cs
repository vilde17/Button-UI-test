using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public void Spin(float degrees)
    {
        transform.Rotate(0, 0, degrees);
    }
}
