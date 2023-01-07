using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {

        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(1, 0, 0) * speed * Time.deltaTime * v);
        transform.Translate(new Vector3(0, 0, -1) * speed * Time.deltaTime * h);

    }
}
