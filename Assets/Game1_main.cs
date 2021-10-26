using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class Game1_main : MonoBehaviour
{
    public Text readyText;
    public GameObject ReadyText;
    public float Timer = 10.0f;
    public Text TimeLabel;
    public bool TimerBool = false;
    public Text panel_1;
    public Text panel_2;
    public Text panel_3;
    public Text panel_4;
    public Text panel_5;
    public Text panel_6;
    public Text panel_7;
    public Text panel_8;
    public Text panel_9;
    private string _text_1;
    private string _text_2;
    private string _text_3;
    private string _text_4;
    private string _text_5;
    private string _text_6;
    private string _text_7;
    private string _text_8;
    private string _text_9;
    /*public GameObject Panel_1;
    public GameObject Panel_2;
    public GameObject Panel_3;
    public GameObject Panel_4;
    public GameObject Panel_5;
    public GameObject Panel_6;
    public GameObject Panel_7;
    public GameObject Panel_8;
    public GameObject Panel_9;*/
    private string[] _test_1 = { "アメリカ\r\nクロクマ", "アフリカ/r/nスイギュウ", "ジャイアント/r/nパンダ", "ワニ", "ニホンカ/r/nモシカ", "ユーラシア/r/nカワウソ", "アフリカ/r/nゾウ", "ハリネズミ",SelectScript.TODO1 };//8個の要素
    private string[] _test_2 = { "むらさき", "ももいろ", "はいいろ", "あおいろ", "きいろ", "みどりいろ", "くろいろ", "しろいろ", SelectScript.TODO2 };
    private int[] randomNum = new int[9];
    private string[] randomTodo;
    private bool trueFalse_1 = false;
    private bool trueFalse_2 = false;
    private bool trueFalse_3 = false;
    private bool trueFalse_4 = false;
    private bool trueFalse_5 = false;
    private bool trueFalse_6 = false;
    private bool trueFalse_7 = false;
    private bool trueFalse_8 = false;
    private bool trueFalse_9 = false;
    private int _testNum = 1;
    private int trueCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Ready", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimerBool == true)
        {
            Timer -= Time.deltaTime;
            TimeLabel.text = Timer.ToString("f1");

            if (Timer < 0)
            {
                SceneManager.LoadScene("Result");
            }
        }

        if (trueCount == 5)
        {
            SceneManager.LoadScene("Result");
        }


    }

    public void Ready()
    {
        readyText.text = "Go";
        Invoke("StartGame", 1.0f);
        CreateTest_1();
    }

    public void StartGame()
    {
        readyText.text = " ";
        //ReadyText.SetActive(false);
        /*Timer -= Time.deltaTime;
        TimeLabel.text = Timer.ToString();*/
        TimerBool = true;
    }

    public void CreateTest_1()
    {
        if (_testNum == 1)
        {
            _testNum = 2;
            System.Random rand = new System.Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = i;
            }
            for (int i = randomNum.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = randomNum[i];
                randomNum[i] = randomNum[j];
                randomNum[j] = tmp;
            }

            panel_1.text = _test_1[randomNum[0]];
            panel_2.text = _test_1[randomNum[1]];
            panel_3.text = _test_1[randomNum[2]];
            panel_4.text = _test_1[randomNum[3]];
            panel_5.text = _test_1[randomNum[4]];
            panel_6.text = _test_1[randomNum[5]];
            panel_7.text = _test_1[randomNum[6]];
            panel_8.text = _test_1[randomNum[7]];
            panel_9.text = _test_1[randomNum[8]];

            _text_1 = _test_1[randomNum[0]];
            _text_2 = _test_1[randomNum[1]];
            _text_3 = _test_1[randomNum[2]];
            _text_4 = _test_1[randomNum[3]];
            _text_5 = _test_1[randomNum[4]];
            _text_6 = _test_1[randomNum[5]];
            _text_7 = _test_1[randomNum[6]];
            _text_8 = _test_1[randomNum[7]];
            _text_9 = _test_1[randomNum[8]];

            if (_text_1 == _test_1[8])
            {
                trueFalse_1 = true;
                
            }
            if (_text_2 == _test_1[8])
            {
                trueFalse_2 = true;
                //Debug.Log("2ばん");
            }
            if (_text_3 == _test_1[8])
            {
                trueFalse_3 = true;
                // Debug.Log("3ばん");
            }
            if (_text_4 == _test_1[8])
            {
                trueFalse_4 = true;
                //Debug.Log("4ばん");
            }
            if (_text_5 == _test_1[8])
            {
                trueFalse_5 = true;

                //Debug.Log("5ばん");
            }
            if (_text_6 == _test_1[8])
            {
                trueFalse_6 = true;
                //Debug.Log("6ばん");
            }
            if (_text_7 == _test_1[8])
            {
                trueFalse_7 = true;
                // Debug.Log("7ばん");
            }
            if (_text_8 == _test_1[8])
            {
                trueFalse_8 = true;
                //Debug.Log("8ばん");
            }
            if (_text_9 == _test_1[8])
            {
                trueFalse_9 = true;
                Debug.Log("9ばん");
            }

        }

        else if(_testNum == 2)
        {
            _testNum = 3;
            System.Random rand = new System.Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = i;
            }
            for (int i = randomNum.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = randomNum[i];
                randomNum[i] = randomNum[j];
                randomNum[j] = tmp;
            }

            panel_1.text = _test_2[randomNum[0]];
            panel_2.text = _test_2[randomNum[1]];
            panel_3.text = _test_2[randomNum[2]];
            panel_4.text = _test_2[randomNum[3]];
            panel_5.text = _test_2[randomNum[4]];
            panel_6.text = _test_2[randomNum[5]];
            panel_7.text = _test_2[randomNum[6]];
            panel_8.text = _test_2[randomNum[7]];
            panel_9.text = _test_2[randomNum[8]];

            _text_1 = _test_2[randomNum[0]];
            _text_2 = _test_2[randomNum[1]];
            _text_3 = _test_2[randomNum[2]];
            _text_4 = _test_2[randomNum[3]];
            _text_5 = _test_2[randomNum[4]];
            _text_6 = _test_2[randomNum[5]];
            _text_7 = _test_2[randomNum[6]];
            _text_8 = _test_2[randomNum[7]];
            _text_9 = _test_2[randomNum[8]];

            if (_text_1 == _test_2[8])
            {
                trueFalse_1 = true;
            }
            if (_text_2 == _test_2[8])
            {
                trueFalse_2 = true;
                //Debug.Log("2ばん");
            }
            if (_text_3 == _test_2[8])
            {
                trueFalse_3 = true;
                // Debug.Log("3ばん");
            }
            if (_text_4 == _test_2[8])
            {
                trueFalse_4 = true;
                //Debug.Log("4ばん");
            }
            if (_text_5 == _test_2[8])
            {
                trueFalse_5 = true;

                //Debug.Log("5ばん");
            }
            if (_text_6 == _test_2[8])
            {
                trueFalse_6 = true;
                //Debug.Log("6ばん");
            }
            if (_text_7 == _test_2[8])
            {
                trueFalse_7 = true;
                // Debug.Log("7ばん");
            }
            if (_text_8 == _test_2[8])
            {
                trueFalse_8 = true;
                //Debug.Log("8ばん");
            }
            if (_text_9 == _test_2[8])
            {
                trueFalse_9 = true;
                //Debug.Log("9ばん");
            }
        }

        else if (_testNum == 3)
        {
            _testNum = 4;
            System.Random rand = new System.Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = i;
            }
            for (int i = randomNum.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = randomNum[i];
                randomNum[i] = randomNum[j];
                randomNum[j] = tmp;
            }

            panel_1.text = _test_2[randomNum[0]];
            panel_2.text = _test_2[randomNum[1]];
            panel_3.text = _test_2[randomNum[2]];
            panel_4.text = _test_2[randomNum[3]];
            panel_5.text = _test_2[randomNum[4]];
            panel_6.text = _test_2[randomNum[5]];
            panel_7.text = _test_2[randomNum[6]];
            panel_8.text = _test_2[randomNum[7]];
            panel_9.text = _test_2[randomNum[8]];

            _text_1 = _test_2[randomNum[0]];
            _text_2 = _test_2[randomNum[1]];
            _text_3 = _test_2[randomNum[2]];
            _text_4 = _test_2[randomNum[3]];
            _text_5 = _test_2[randomNum[4]];
            _text_6 = _test_2[randomNum[5]];
            _text_7 = _test_2[randomNum[6]];
            _text_8 = _test_2[randomNum[7]];
            _text_9 = _test_2[randomNum[8]];

            if (_text_1 == _test_2[8])
            {
                trueFalse_1 = true;
            }
            if (_text_2 == _test_2[8])
            {
                trueFalse_2 = true;
                //Debug.Log("2ばん");
            }
            if (_text_3 == _test_2[8])
            {
                trueFalse_3 = true;
                // Debug.Log("3ばん");
            }
            if (_text_4 == _test_2[8])
            {
                trueFalse_4 = true;
                //Debug.Log("4ばん");
            }
            if (_text_5 == _test_2[8])
            {
                trueFalse_5 = true;

                //Debug.Log("5ばん");
            }
            if (_text_6 == _test_2[8])
            {
                trueFalse_6 = true;
                //Debug.Log("6ばん");
            }
            if (_text_7 == _test_2[8])
            {
                trueFalse_7 = true;
                // Debug.Log("7ばん");
            }
            if (_text_8 == _test_2[8])
            {
                trueFalse_8 = true;
                //Debug.Log("8ばん");
            }
            if (_text_9 == _test_2[8])
            {
                trueFalse_9 = true;
                //Debug.Log("9ばん");
            }
        }

        else if (_testNum == 4)
        {
            _testNum = 5;
            System.Random rand = new System.Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = i;
            }
            for (int i = randomNum.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = randomNum[i];
                randomNum[i] = randomNum[j];
                randomNum[j] = tmp;
            }

            panel_1.text = _test_2[randomNum[0]];
            panel_2.text = _test_2[randomNum[1]];
            panel_3.text = _test_2[randomNum[2]];
            panel_4.text = _test_2[randomNum[3]];
            panel_5.text = _test_2[randomNum[4]];
            panel_6.text = _test_2[randomNum[5]];
            panel_7.text = _test_2[randomNum[6]];
            panel_8.text = _test_2[randomNum[7]];
            panel_9.text = _test_2[randomNum[8]];

            _text_1 = _test_2[randomNum[0]];
            _text_2 = _test_2[randomNum[1]];
            _text_3 = _test_2[randomNum[2]];
            _text_4 = _test_2[randomNum[3]];
            _text_5 = _test_2[randomNum[4]];
            _text_6 = _test_2[randomNum[5]];
            _text_7 = _test_2[randomNum[6]];
            _text_8 = _test_2[randomNum[7]];
            _text_9 = _test_2[randomNum[8]];

            if (_text_1 == _test_2[8])
            {
                trueFalse_1 = true;
            }
            if (_text_2 == _test_2[8])
            {
                trueFalse_2 = true;
                //Debug.Log("2ばん");
            }
            if (_text_3 == _test_2[8])
            {
                trueFalse_3 = true;
                // Debug.Log("3ばん");
            }
            if (_text_4 == _test_2[8])
            {
                trueFalse_4 = true;
                //Debug.Log("4ばん");
            }
            if (_text_5 == _test_2[8])
            {
                trueFalse_5 = true;

                //Debug.Log("5ばん");
            }
            if (_text_6 == _test_2[8])
            {
                trueFalse_6 = true;
                //Debug.Log("6ばん");
            }
            if (_text_7 == _test_2[8])
            {
                trueFalse_7 = true;
                // Debug.Log("7ばん");
            }
            if (_text_8 == _test_2[8])
            {
                trueFalse_8 = true;
                //Debug.Log("8ばん");
            }
            if (_text_9 == _test_2[8])
            {
                trueFalse_9 = true;
                //Debug.Log("9ばん");
            }
        }

        else if (_testNum == 5)
        {
            
            //_testNum = 3;
            System.Random rand = new System.Random();
            for (int i = 0; i < randomNum.Length; i++)
            {
                randomNum[i] = i;
            }
            for (int i = randomNum.Length - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                int tmp = randomNum[i];
                randomNum[i] = randomNum[j];
                randomNum[j] = tmp;
            }

            panel_1.text = _test_2[randomNum[0]];
            panel_2.text = _test_2[randomNum[1]];
            panel_3.text = _test_2[randomNum[2]];
            panel_4.text = _test_2[randomNum[3]];
            panel_5.text = _test_2[randomNum[4]];
            panel_6.text = _test_2[randomNum[5]];
            panel_7.text = _test_2[randomNum[6]];
            panel_8.text = _test_2[randomNum[7]];
            panel_9.text = _test_2[randomNum[8]];

            _text_1 = _test_2[randomNum[0]];
            _text_2 = _test_2[randomNum[1]];
            _text_3 = _test_2[randomNum[2]];
            _text_4 = _test_2[randomNum[3]];
            _text_5 = _test_2[randomNum[4]];
            _text_6 = _test_2[randomNum[5]];
            _text_7 = _test_2[randomNum[6]];
            _text_8 = _test_2[randomNum[7]];
            _text_9 = _test_2[randomNum[8]];

            if (_text_1 == _test_2[8])
            {
                trueFalse_1 = true;
            }
            if (_text_2 == _test_2[8])
            {
                trueFalse_2 = true;
                //Debug.Log("2ばん");
            }
            if (_text_3 == _test_2[8])
            {
                trueFalse_3 = true;
                // Debug.Log("3ばん");
            }
            if (_text_4 == _test_2[8])
            {
                trueFalse_4 = true;
                //Debug.Log("4ばん");
            }
            if (_text_5 == _test_2[8])
            {
                trueFalse_5 = true;

                //Debug.Log("5ばん");
            }
            if (_text_6 == _test_2[8])
            {
                trueFalse_6 = true;
                //Debug.Log("6ばん");
            }
            if (_text_7 == _test_2[8])
            {
                trueFalse_7 = true;
                // Debug.Log("7ばん");
            }
            if (_text_8 == _test_2[8])
            {
                trueFalse_8 = true;
                //Debug.Log("8ばん");
            }
            if (_text_9 == _test_2[8])
            {
                trueFalse_9 = true;
                //Debug.Log("9ばん");
            }
        }


    }

    /*public void CreateTest_2()
    {
        System.Random rand = new System.Random();
        for (int i = 0; i < randomNum.Length; i++)
        {
            randomNum[i] = i;
        }
        for (int i = randomNum.Length - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            int tmp = randomNum[i];
            randomNum[i] = randomNum[j];
            randomNum[j] = tmp;
        }

        panel_1.text = _test_2[randomNum[0]];
        panel_2.text = _test_2[randomNum[1]];
        panel_3.text = _test_2[randomNum[2]];
        panel_4.text = _test_2[randomNum[3]];
        panel_5.text = _test_2[randomNum[4]];
        panel_6.text = _test_2[randomNum[5]];
        panel_7.text = _test_2[randomNum[6]];
        panel_8.text = _test_2[randomNum[7]];
        panel_9.text = _test_2[randomNum[8]];

        _text_1 = _test_2[randomNum[0]];
        _text_2 = _test_2[randomNum[1]];
        _text_3 = _test_2[randomNum[2]];
        _text_4 = _test_2[randomNum[3]];
        _text_5 = _test_2[randomNum[4]];
        _text_6 = _test_2[randomNum[5]];
        _text_7 = _test_2[randomNum[6]];
        _text_8 = _test_2[randomNum[7]];
        _text_9 = _test_2[randomNum[8]];

        if (_text_1 == _test_2[8])
        {
            trueFalse_1 = true;
        }
        if (_text_2 == _test_2[8])
        {
            trueFalse_2 = true;
            //Debug.Log("2ばん");
        }
        if (_text_3 == _test_2[8])
        {
            trueFalse_3 = true;
            // Debug.Log("3ばん");
        }
        if (_text_4 == _test_2[8])
        {
            trueFalse_4 = true;
            //Debug.Log("4ばん");
        }
        if (_text_5 == _test_2[8])
        {
            trueFalse_5 = true;

            //Debug.Log("5ばん");
        }
        if (_text_6 == _test_2[8])
        {
            trueFalse_6 = true;
            //Debug.Log("6ばん");
        }
        if (_text_7 == _test_2[8])
        {
            trueFalse_7 = true;
            // Debug.Log("7ばん");
        }
        if (_text_8 == _test_2[8])
        {
            trueFalse_8 = true;
            //Debug.Log("8ばん");
        }
        if (_text_9 == _test_2[8])
        {
            trueFalse_9 = true;
            //Debug.Log("9ばん");
        }

    }*/

    public void On1Click()
    {
        if(trueFalse_1 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On2Click()
    {
        if (trueFalse_2 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On3Click()
    {
        if (trueFalse_3 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On4Click()
    {
        if (trueFalse_4 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On5Click()
    {
        if (trueFalse_5 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On6Click()
    {
        if (trueFalse_6 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On7Click()
    {
        if (trueFalse_7 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On8Click()
    {
        if (trueFalse_8 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }

    public void On9Click()
    {
        if (trueFalse_9 == true)
        {
            readyText.text = "正解";
            CreateTest_1();
            trueCount++;
        }
        else
        {
            readyText.text = "不正解";
        }
    }
}
