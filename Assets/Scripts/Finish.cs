using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject _notify;
    [SerializeField] private Text _finish_time;
    [SerializeField] private Text _best_time_display;
    [SerializeField] private TimeCount _time_count;

    private float _best_time = 0;
    private string _best_time_string;

    private void Start()
    {
        _notify.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            Time.timeScale = 0;
            _notify.SetActive(true);
            _finish_time.text = "Total Time: " + _time_count.ShowTime();
            if(_best_time == 0)
            {
                _best_time = _time_count.timer;
                _best_time_string = _time_count.ShowTime();
            } else
            {
                if(_best_time > _time_count.timer)
                {
                    _best_time = _time_count.timer;
                    _best_time_string = _time_count.ShowTime();
                }
            }
            _best_time_display.text = "Best Time: " + _best_time_string;
        }
    }
}
