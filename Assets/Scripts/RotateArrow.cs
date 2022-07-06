using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArrow : MonoBehaviour
{
    public int Speed;

    private int _rotateMultiplicator = 1;
    private float _angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _angle = transform.localEulerAngles.z;
        _angle = (_angle > 180) ? _angle - 360 : _angle;

        if(_angle > 45)
        {
            _rotateMultiplicator = -1;
        }
        else if(_angle < -45)
        {
            _rotateMultiplicator = 1;
        }
        transform.eulerAngles = transform.eulerAngles + new Vector3(0,0,1 * Speed * _rotateMultiplicator) * Time.deltaTime;
    }
}
