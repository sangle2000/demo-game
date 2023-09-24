using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeCount : MonoBehaviour
{
    [SerializeField] private Text _display_time;
    [SerializeField] private Text _count_down;
    public GameObject _panel_count_down;

    public float timer = 0f;
    public bool _already;

    private float _begin_game;
    private int temp = 0;
    string[] _ready_text = new string[] { "3", "2", "1", "Ready", "Go!!!" };
    // Start is called before the first frame update
    void Start()
    {
        _display_time.text = "0:00.00";
        _count_down.text = "3";
        temp = 0;
        _begin_game = 0;
        _already = true;
    }

    private void Update()
    {
        if (!_already)
        {
            timer += Time.deltaTime;
            _display_time.text = ShowTime();
        } else
        {
            _begin_game += Time.deltaTime;
            if (_begin_game > temp)
            {
                try
                {
                   _count_down.text = _ready_text[temp];
                    temp += 1;
                }
                catch
                {
                    _panel_count_down.SetActive(false);
                    _already = false;
                }
            }
        }
    }

    // Update is called once per frame
    public string ShowTime()
    {
        // Calculate minutes, seconds, and milliseconds.
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        int milliseconds = Mathf.FloorToInt((timer * 1000f) % 1000f);

        return string.Format("{0:D2}:{1:D2}.{2:D2}", minutes, seconds, milliseconds);
    }
}
