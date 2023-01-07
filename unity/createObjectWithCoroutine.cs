using System.Collections;
using System;
using UnityEngine;

public class CreateObjectsWithCourutine : MonoBehaviour
{
    public GameObject[] objs;

    private void Start()
    {
        // invoke("CreateObject", 2f);
        StartCoroutine(Create3DObjects());
    }

    private void CreateObject()
    {
        // GameObject createObject = Instantiate(obj, new Vector3(-4.4f, 0.4f, 2), Quaternion.Euler(5f, 5f, 5f)) as GameObject;

        for (int i = 0; i < 5; i++)
        {
            Instantiate(objs[UnityEngine.Random.Range(0, objs.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(5f, 5f, 5f));
        }
    }

    private int RandomNumber()
    {
        return UnityEngine.Random.Range(0, 10);
    }

    private IEnumerator Create3DObjects()
    {
        yield return new WaitForSeconds(3f);
        CreateObject();
    }
}
