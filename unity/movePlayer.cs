using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 150.0f;
    public float hspeed = 200.0f;
    public float trust = 500.0f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float v = Input.GetAxis("Vertical") * speed * Time.fixedDeltaTime;
        float h = Input.GetAxis("Horizontal") * hspeed * Time.fixedDeltaTime;

        rb.velocity = transform.TransformDirection(new Vector3(v, rb.velocity.y, -h));
    }

    private void OnCollisionEnter(Collision other) // один раз при соприкосновении
    {
        if (other.gameObject.name == "Cube")
            rb.AddForce(new Vector3(0, 1, 0) * trust);
    }

    private void OnCollisionStay(Collision other) // постоянно пока задевает другой объект
    {
        if (other.gameObject.name == "Cube")
            Debug.Log("Отойди от меня!!!");
    }

    private void OnCollisionExit(Collision other) // когда перестает задевать другой объект
    {
        if (other.gameObject.name == "Cube")
            Debug.Log("Наконец-то отвалил!!!");
    }
    private void OnTriggerEnter(Collider other) // один раз при соприкосновении
    {
        if (other.gameObject.name == "Trigger")
            rb.AddForce(new Vector3(0, 1, 0) * trust);
    }

    private void OnTriggerStay(Collider other) // постоянно пока задевает другой объект
    {
        if (other.gameObject.name == "Trigger")
            Debug.Log("Отойди от меня, я триггер!!!");
    }

    private void OnTriggerExit(Collider other) // когда перестает задевать другой объект
    {
        if (other.gameObject.name == "Trigger")
            Destroy(other.gameObject); // удаляем триггер
    }

}
