using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 5f;
    public float x ;
    public float y ;
    public float z ;

    private Rigidbody rb;

    void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        y = Input.GetAxisRaw("Vertical");
         Vector3 move = new Vector3(x, 0, y);
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}
