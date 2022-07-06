using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheBunnyDeleteME : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    public GameObject Projectile;
    public GameObject Arrow;
    public Camera MainCamera;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        this.transform.position = MainCamera.ScreenToWorldPoint(new Vector3(20, Screen.height / 2, 0));
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, 0);

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rigidbody.MovePosition(transform.position + Vector3.up * 10 * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rigidbody.MovePosition(transform.position - Vector3.up * 10 * Time.deltaTime);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(Projectile, Arrow.transform.position + Arrow.transform.right, transform.rotation);
            Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Arrow.transform.right * 100);




        }
    }
}
