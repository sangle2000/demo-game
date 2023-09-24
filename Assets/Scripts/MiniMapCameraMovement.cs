using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapCameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _player_transform;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, _player_transform.position.z);
    }
}
