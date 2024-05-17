using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;
using UnityEngine.UI;
public class OnClickButton0Lvl : MonoBehaviour {
    public bool PlayerTimer = false;
    public bool PlayerTimerWork = true;
    public float timeStartWork = 0f;
    public int timeintwork = 0;
    public int timeint = 0;
    public GameObject buttonexit;
    public GameObject text2;
    //public GameObject TextNoRecords;
    public GameObject timer;
    public GameObject timertext;
    public GameObject timer1;
    public GameObject timertext1;
    bool isWin = false;
    bool isLose = false;
    public float timeStart = 0f;
    public Text Timer;
    public Text Timer1;
    public GameObject CanvasTimer;
    // public GameManager script;
    public MaxScore script1;
    public GameObject play;
    public int d = 0;//для массива ввода
    public int a = 0;
    public int b = 0; //переменная для массива рандомных значений
    public int c = 0;
    public GameManager gameManager;
    public GameObject text;
    public GameObject textWin;
    public GameObject[] myButton = new GameObject[5];
    public int[] NewMasiveRandom;
    public int[] NewMasiveInput;
    public int k;
    public int j;
    public int i;
    public int w;
    public int e;
    public int r;
    public int t;
    public GameObject[] allExamples = new GameObject[5];
    // Use this for initialization
    void Start()
    {

        Timer.text = timeStart.ToString();
        Timer1.text = timeStart.ToString();
       // Camera.main.aspect = 1080f / 1920f;
        k = Random.Range(0, 6);
        NewMasiveRandom[b] = k;
        b += 1;
        allExamples[k].SetActive(true);

        j = Random.Range(0, 7);
        while (k == j)
        {
            j = Random.Range(0, 6);

        }
        StartCoroutine(WaitAndPrint(1f));
        //allExamples[j].SetActive(true);
        NewMasiveRandom[b] = j;
        b += 1;
        i = Random.Range(0, 6);
        while (i == k || i == j)
        {
            i = Random.Range(0, 6);
            //allExamples[i].SetActive(true);
        }
        NewMasiveRandom[b] = i;
        b += 1;
        StartCoroutine(WaitAndPrint1(2f));
        w = Random.Range(0, 6);
        while (w == i || w == k || w == j)
        {
            w = Random.Range(0, 6);
            //allExamples[w].SetActive(true);
        }
        StartCoroutine(WaitAndPrint2(3f));
        NewMasiveRandom[b] = w;
        b += 1;
        e = Random.Range(0, 6);
        while (e == w || e == i || e == k || e == j)
        {
            e = Random.Range(0, 6);
            //allExamples[e].SetActive(true);

        }
        StartCoroutine(WaitAndPrint3(4f));
        NewMasiveRandom[b] = e;
        b += 1;
        r = Random.Range(0, 6);
        while (r == e || r == w || r == i || r == k || r == j)
        {
            r = Random.Range(0, 6);
            // allExamples[r].SetActive(true);
        }
        StartCoroutine(WaitAndPrint4(5f));
        NewMasiveRandom[b] = r;
        b += 1;
       
       
        
        //NewMasiveRandom = [k, j, i, w, e, r, t];

        StartCoroutine(WaitAndPrint6(8f));
        /*if (k == 0)
        {
            j = 1;
        }
        else
        {
            j = 0;
        }
        myButton[k].SetActive(true);
        myButton[j].SetActive(true);
        */
    }
    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[j].SetActive(true);
    }
    IEnumerator WaitAndPrint1(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[i].SetActive(true);
    }
    IEnumerator WaitAndPrint2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[w].SetActive(true);
    }
    IEnumerator WaitAndPrint3(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[e].SetActive(true);
    }
    IEnumerator WaitAndPrint4(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[r].SetActive(true);
    }
    
    IEnumerator WaitAndPrint6(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[k].SetActive(false);
        allExamples[j].SetActive(false);
        allExamples[i].SetActive(false);
        allExamples[w].SetActive(false);
        allExamples[r].SetActive(false);
        allExamples[e].SetActive(false);

      
        text.SetActive(false);
        myButton[0].SetActive(true);
        myButton[1].SetActive(true);
        myButton[2].SetActive(true);
        myButton[3].SetActive(true);
        myButton[4].SetActive(true);
        myButton[5].SetActive(true);
       

        /*
        buttonred.SetActive(true);
        buttongreen.SetActive(true);
        buttonblue.SetActive(true);
        buttonorange.SetActive(true);
        buttonpurple.SetActive(true);
        buttonwhite.SetActive(true);
        buttonyellow.SetActive(true);
        */
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerTimerWork == true)
        {

            timeStartWork += Time.deltaTime;
            timeintwork = (int)timeStartWork;
            //Timer.text = timeStart.ToString("F0");
            // Timer1.text = timeStart.ToString("F0");
            //timerwork.text = timeint.ToString("F0");
            PlayerTimer = true;
            //timeint = (int)timeStart;
        }
        if (PlayerTimer == true && timeintwork >= 8f)
        {
            timer.SetActive(true);
            timertext.SetActive(true);
            PlayerTimerWork = false;
            timeStart += Time.deltaTime;
            timeint = (int)timeStart;
            //Timer.text = timeStart.ToString("F0");
            // Timer1.text = timeStart.ToString("F0");
            Timer.text = timeint.ToString("F0");
            Timer1.text = timeint.ToString("F0");
            //timeint = (int)timeStart;
        }
        if (timeint > 99f)
        {
            Application.LoadLevel(Application.loadedLevel);
        }
        if ((NewMasiveRandom[0] == NewMasiveInput[0]) && (NewMasiveRandom[1] == NewMasiveInput[1]) && (NewMasiveRandom[2] == NewMasiveInput[2]) && (NewMasiveRandom[3] == NewMasiveInput[3]) && (NewMasiveRandom[4] == NewMasiveInput[4] && (NewMasiveRandom[5] == NewMasiveInput[5] )))
        {
            // timeStart = 1000f;
            Debug.Log("ВЫ ПОБЕДИЛИ!");
            textWin.SetActive(true);
            play.SetActive(true);
            timer.SetActive(false);
            timertext.SetActive(false);
            timer1.SetActive(true);
            timertext1.SetActive(true);
            PlayerTimer = false;
            buttonexit.SetActive(true);
            if (PlayerPrefs.GetInt("Score0") > timeint && PlayerPrefs.HasKey("Score0") == true)
            {
                timeint = (int)timeStart;
                PlayerPrefs.SetInt("Score0", timeint);

                Debug.Log("Сохраняем лучший результат");
            }

            // else
            // {
            //  if (PlayerPrefs.HasKey("Score") == false)
            //  {
            //float timeStart = 1000f;
            //     Debug.Log("Первый раз и проигрыш!");

            //      //PlayerPrefs.SetInt("Score", timeint);
            //      TextNoRecords.SetActive(true);
            //       timertext1.SetActive(true);
            //   }
            else
            {
                if (PlayerPrefs.GetInt("Score0") == 0 && PlayerPrefs.HasKey("Score0") == false)//если игрок с первой попытки нажал все правильно
                {
                    Debug.Log("Первый запуск!");
                    PlayerPrefs.SetInt("Score0", timeint);

                }
            }
        }







        else

        {
            if ((a == 6) && (PlayerPrefs.HasKey("Score0") == false))
            {
                //timeStart = 0f;
                Debug.Log("Нажал неправильно и нет правильного ответа");
                PlayerTimer = false;
                gameManager.GameOver();
                timer.SetActive(false);
                timertext.SetActive(false);
                //timer1.SetActive(true);
                text2.SetActive(true);

                timertext1.SetActive(true);
                buttonexit.SetActive(true);

            }
            else
            {
                if (a == 6)
                {
                    Debug.Log("Сохраненный результат есть и игрок проиграл");
                    timer.SetActive(false);
                    timertext.SetActive(false);
                    gameManager.GameOver();
                    PlayerTimer = false;
                    timer1.SetActive(true);
                    timertext1.SetActive(true);
                    buttonexit.SetActive(true);
                }
            }
        }
    }

    public void OnClickEnterRed()
    {

        if (myButton[0].name == "ButtonRed")
        {
            a++;
            NewMasiveInput[d] = 0;
            d++;
            Destroy(myButton[0]);
            GetComponent<AudioSource>().Play();
        }


    }
    public void OnClickEnterGreen()
    {

        if (myButton[1].name == "ButtonGreen")
        {
            a++;
            NewMasiveInput[d] = 1;
            d++;
            Destroy(myButton[1]);
            GetComponent<AudioSource>().Play();
        }


    }
    public void OnClickEnterBlue()
    {

        if (myButton[2].name == "ButtonBlue")
        {
            a++;
            NewMasiveInput[d] = 2;
            d++;
            Destroy(myButton[2]);
            GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickEnterOrange()
    {

        /// if (myButton[3].name == "ButtonOrange"&&(a==w))
        if (myButton[3].name == "ButtonOrange")
        {
            a++;
            NewMasiveInput[d] = 3;
            d++;
            Destroy(myButton[3]);
            GetComponent<AudioSource>().Play();
        }
    }

    public void OnClickEnterPurple()
    {

        if (myButton[4].name == "ButtonPurple")
        {
            a++;
            NewMasiveInput[d] = 4;
            d++;
            Destroy(myButton[4]);
            GetComponent<AudioSource>().Play();
        }


    }
    public void OnClickEnterYellow()
    {

        if (myButton[5].name == "ButtonYellow")
        {
            a++;
            NewMasiveInput[d] = 5;
            d++;
            Destroy(myButton[5]);
            GetComponent<AudioSource>().Play();
        }
    }
    //public void OnClickEnterYellow()
   // {

       // if (myButton[6].name == "ButtonYellow")
     //   {
        //    a++;
        //    NewMasiveInput[d] = 6;
        //    d++;
        //    Destroy(myButton[6]);
         //   GetComponent<AudioSource>().Play();
       // }
   // }

}

