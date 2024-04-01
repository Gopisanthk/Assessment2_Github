using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public GameObject Octopus;
    [SerializeField] float value;
    [SerializeField] Vector3 sizeChangeValue;
    private Vector3 startPosition;

    public void Start()
    {
        startPosition = new Vector3(Octopus.transform.position.x, Octopus.transform.position.y, Octopus.transform.position.z);
    }

    public void MoveRight()
    {
        value = 10.0f;
        Octopus.transform.position = new Vector3(Octopus.transform.position.x + value,
            Octopus.transform.position.y, Octopus.transform.position.z);
    }

    public void MoveLeft()
    {
        value = 10.0f;
        Octopus.transform.position = new Vector3(Octopus.transform.position.x - value,
            Octopus.transform.position.y, Octopus.transform.position.z);
    }

    public void MoveUp()
    {
        value = 10.0f;
        Octopus.transform.position = new Vector3(Octopus.transform.position.x ,
            Octopus.transform.position.y + value, Octopus.transform.position.z);
    }

    public void MoveDown()
    {
        value = 10.0f;
        Octopus.transform.position = new Vector3(Octopus.transform.position.x ,
            Octopus.transform.position.y - value, Octopus.transform.position.z);

    }

    public void RotateLeft()
    {
        Octopus.transform.Rotate(0, 0, 20f);
    }

        public void RotateRight()
    {
        Octopus.transform.Rotate(0, 0, -20f);
    }

    public void GrowObject()
    {       
        Octopus.transform.localScale = Octopus.transform.localScale + sizeChangeValue;
    }

    public void ShrinkObject()
    {
        Octopus.transform.localScale = Octopus.transform.localScale - sizeChangeValue;
    }

    public void ResetObject()
    {
        Octopus.transform.position = new Vector3(-40,44, 261);
        Octopus.transform.rotation = Quaternion.Euler(new Vector3(0, 0, 0));
        Octopus.transform.localScale = Vector3.one;
    }
}