using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolphinScript : MonoBehaviour
{
    public GameObject dolphin;
    public float value;
    public float value1;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value - 0.1f;
        dolphin.transform.position = new Vector3(value, value1, -6.33f);
    }

     public void MoveRight()
    {
        value = value + 0.1f;
        dolphin.transform.position = new Vector3(value, value1, -6.33f);
    }

    public void MoveUp()
    {
        value1 = value1 + 0.1f;
        dolphin.transform.position = new Vector3(value, value1, -6.33f);
    }

    public void MoveDown()
    {
        value1 = value1 - 0.1f;
        dolphin.transform.position = new Vector3(value, value1, -6.33f);
    }

    public void RotateLeft()
    {
        dolphin.transform.Rotate(20f, 0f, 0f);
    }


    public void Grow()
    {
        dolphin.transform.localScale = dolphin.transform.localScale + sizeChange;
    }

    public void ResetDolphin()
    {
        value = 1.64f;
        value1 = 0.55f;
        dolphin.transform.position = new Vector3(value, value1, -6.33f);
        dolphin.transform.rotation = Quaternion.Euler(new Vector3(114.71f, 2.76f, -6.07f));
        dolphin.transform.localScale = new Vector3(0.25f, -0.24f, 0.23f);
    }
}

