using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMoving : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody2D _rigidbody;
    public GameObject Projectile;
    public GameObject Arrow;
    private bool _isMovingDown = false;
    private bool _isMovingUp = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = Player.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (_isMovingDown)
        {
            _rigidbody.MovePosition(Player.transform.position - Vector3.up * 10 * Time.deltaTime);
        }
        if (_isMovingUp)
        {
            _rigidbody.MovePosition(Player.transform.position + Vector3.up * 10 * Time.deltaTime);

        }
    }
    public void ClickDown()
    {
        _isMovingDown = true;
    }
    public void CancelClickDown()
    {
        _isMovingDown = false;
    }
    public void ClickUp()
    {
        _isMovingUp = true;

    }

    public void CancelClickUp()
    {
        _isMovingUp = false;
    }

    public void Shoot()
    {

        GameObject bullet = Instantiate(Projectile, Arrow.transform.position + Arrow.transform.right, transform.rotation);
        Rigidbody2D rigidbody = bullet.GetComponent<Rigidbody2D>();
        rigidbody.AddForce(Arrow.transform.right * 100);

    }
}
