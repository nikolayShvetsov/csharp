using System.Collections;
using System;
using UnityEngine;

public class CreateObjectsWithCourutine : MonoBehaviour
{
    public GameObject[] objs;

    private void Update()
    {
        // invoke("CreateObject", 2f);
        if(Input.GetKeyUp(KeyCode.U))
            StartCoroutine(Create3DObjects(2f));
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

    private IEnumerator Create3DObjects(float wait)
    {
        yield return new WaitForSeconds(wait);
        CreateObject();
    }
}
