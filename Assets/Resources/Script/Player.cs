using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 10;
    Rigidbody rb;
    Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ani = GetComponent<Animator>();
    }
    void Update()
    {
        Move();
        Jump();
        Attack();
    }
    [HeaderAttribute("¸I¼²§P©w")]
    public GameObject DestoryFire;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Mortal")
        {
            if (collision.gameObject.tag == "Enemy")
            {
                GameManager.AddHp(1);
            }
            if (collision.gameObject.tag == "Mortal")
            {
                GameManager.AddMp(2);
            }
            Destroy(collision.gameObject);
            var fire = Instantiate(DestoryFire, collision.transform.position, transform.rotation);
            Destroy(fire, 0.5f);
        }
    }
    private void Move()
    {
        float ad = Input.GetAxis("Horizontal"); //-1~0~1
        float sw = Input.GetAxis("Vertical"); //-1~0~1
        if (sw != 0)
        {
            ani.SetBool("Walk", true);
        }
        else
        {
            ani.SetBool("Walk", false);
        }
        transform.Translate(new Vector3(0, 0, sw * MoveSpeed * Time.deltaTime));
        transform.Rotate(new Vector3(0, ad * 100 * Time.deltaTime, 0));
    }
    private void Jump()
    {
        if (Input.GetKey(KeyCode.J))
        {
            ani.SetBool("Walk", false);
            ani.SetBool("Jump", true);
            rb.velocity = transform.TransformDirection(0, 8, 3);
        }
        else
        {
            ani.SetBool("Jump", false);
        }
    }
    private void Attack()
    {
        if (Input.GetKey(KeyCode.F))
        {
            ani.SetBool("Attack", true);
        }
        else
        {
            ani.SetBool("Attack", false);
        }
    }

}
