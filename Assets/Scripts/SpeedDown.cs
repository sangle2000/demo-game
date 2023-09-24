using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    private Rigidbody _rb;

    private void Start()
    {
        _rb = _player.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _rb.drag = 5;
        }
    }
}
