using UnityEngine;

public class CreatObjects : MonoBehaviour
{
    public GameObject[] objs;

    private void Start() {
        // GameObject createObject = Instantiate(obj, new Vector3(-4.4f, 0.4f, 2), Quaternion.Euler(5f, 5f, 5f)) as GameObject;

        for (int i = 0; i < 5; i++)
        {
            Instantiate(objs[Random.Range(0, objs.Length)], new Vector3(RandomNumber(), RandomNumber(), RandomNumber()), Quaternion.Euler(5f, 5f, 5f));
        }
    }

    private int RandomNumber() {
        return Random.Range(0, 10);
    }
}
