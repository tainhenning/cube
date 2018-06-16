using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewayForce = 100f;

    void Start () {
    }
    void Update()
    {
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
