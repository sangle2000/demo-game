using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float _speed;
    [SerializeField] private TimeCount _isReady;
    [SerializeField] private GameObject _pause;


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!_isReady._already)
        {
            _rb.AddForce(0, 0, 1000 * Time.deltaTime * _speed);

            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a"))
            {
                _rb.AddForce(-100 * Time.deltaTime * _speed, 0, 0, ForceMode.VelocityChange);
            }
        
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d"))
            {
                _rb.AddForce(100 * Time.deltaTime * _speed, 0, 0, ForceMode.VelocityChange);
            }
        }
    }

    public void Pause()
    {
        if (!_isReady._already)
        {
            _pause.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void Continue()
    {
        if (!_isReady._already)
        {
            _pause.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
