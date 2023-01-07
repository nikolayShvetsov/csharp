using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject obj;
    public Transform target;
    public Light _light;
    public GameObject[] objs = new GameObject[3];
    public Transform[] targets = new Transform[4];

    public float speed = 5.0f;

    void Start()
    {
        // obj.SetActive(false);
        // obj.GetComponent<Transform>().position = new Vector3(2, 0.5f, 2);
        // target.position = new Vector3(1, 0.6f, 1);
        // _light.intensity = 0.3f;

        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].position = new Vector3(-4.4f, 0.4f, i * 2);
        }
    }

    void Update()
    {
        for (int i = 0; i < targets.Length; i++)
        {
            targets[i].Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
    }
}
