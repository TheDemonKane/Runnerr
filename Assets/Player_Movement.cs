using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Movement : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;
    bool alive = true;

    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;
    private void FixedUpdate ()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
        
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if(transform.position.y<-5)
        {
            die();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            speed = speed + 5;
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            speed = speed - 5;
        }
    }

    public void die()
    {
        alive = false;
        Invoke("restart",2);
    }

    public float SpeedOutput()
    {
        return speed;
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void Jump()
    {
        
        float height = GetComponent<Collider>().bounds.size.y;
        bool Grounded = Physics.Raycast(transform.position, Vector3.down, (height/2) + 0.4f, groundMask);

        if (Grounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }

    }

}
