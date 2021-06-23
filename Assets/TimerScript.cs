using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    //[SerializeField]
    public Text timerLabel;
    private int minute;
    private int hour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (SelectScript.time > 0)
        {
            timerLabel.text = string.Format("{0:00.00}", SelectScript.time);
            SelectScript.time -= Time.deltaTime;
        }
        else if (SelectScript.time <= 0)
        {
            //ぴったり0になることはないので表示を調整する
            timerLabel.text = string.Format("00.00");
        }*/
        SelectScript.time -= Time.deltaTime;
        timerLabel.text = SelectScript.time.ToString("f1");

        /*if (minute < 60)
        {
            hour--;
            minute = 0;
        }
        if (SelectScript.time <= 60f)
        {
            minute -= 1;
            SelectScript.time = 0;
        }
        timerLabel.text = hour.ToString() + ":" + minute.ToString("00") + ":" + SelectScript.time.ToString("f2");*/
    }
}
