using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.Monetization;
using UnityEngine.UI;
public class OnClickButton8Lvl : MonoBehaviour
{
    public GameObject bestscore;
    public GameObject bestscoretime;
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
    public MaxScore3Lvl script1;
    public GameObject play;
    public int d = 0;//для массива ввода
    public int a = 0;
    public int b = 0; //переменная для массива рандомных значений
    public int c = 0;
    public GameManager gameManager;
    public GameObject text;
    public GameObject textWin;
    public GameObject[] myButton = new GameObject[6];
    public int[] NewMasiveRandom;
    public int[] NewMasiveInput;
    public int k;
    public int j;
    public int i;
    public int w;
    public int e;
    public int r;
    public int t;
    public int v;
    public int x;
    public int y;
    public int n;
    public GameObject obshtime;
    public GameObject timeall;
    public GameObject[] allExamples = new GameObject[6];
    // Use this for initialization
    void Start()
    {

        Timer.text = timeStart.ToString();
        Timer1.text = timeStart.ToString();
       // Camera.main.aspect = 1080f / 1920f;
        k = Random.Range(0, 11);
        NewMasiveRandom[b] = k;
        b += 1;
        allExamples[k].SetActive(true);

        j = Random.Range(0, 11);
        while (k == j)
        {
            j = Random.Range(0, 11);

        }
        StartCoroutine(WaitAndPrint(1.5f));
        //allExamples[j].SetActive(true);
        NewMasiveRandom[b] = j;
        b += 1;
        i = Random.Range(0, 11);
        while (i == k || i == j)
        {
            i = Random.Range(0, 11);
            //allExamples[i].SetActive(true);
        }
        NewMasiveRandom[b] = i;
        b += 1;
        StartCoroutine(WaitAndPrint1(3f));
        w = Random.Range(0, 11);
        while (w == i || w == k || w == j)
        {
            w = Random.Range(0, 11);
            //allExamples[w].SetActive(true);
        }
        StartCoroutine(WaitAndPrint2(4.5f));
        NewMasiveRandom[b] = w;
        b += 1;
        e = Random.Range(0, 11);
        while (e == w || e == i || e == k || e == j)
        {
            e = Random.Range(0, 11);
            //allExamples[e].SetActive(true);

        }
        StartCoroutine(WaitAndPrint3(6f));
        NewMasiveRandom[b] = e;
        b += 1;
        r = Random.Range(0, 11);
        while (r == e || r == w || r == i || r == k || r == j)
        {
            r = Random.Range(0, 11);
            // allExamples[r].SetActive(true);
        }
        StartCoroutine(WaitAndPrint4(7.5f));
        NewMasiveRandom[b] = r;
        b += 1;
        t = Random.Range(0, 11);
        while (t == r || t == e || t == w || t == k || t == j || t == i)
        {
            t = Random.Range(0, 11);
            // allExamples[t].SetActive(true);
        }
        StartCoroutine(WaitAndPrint5(9f));
        NewMasiveRandom[b] = t;
        b += 1;
        v = Random.Range(0, 11);
        while (v == r || v == e || v == w || v == k || v == j || v == i || v == t)
        {
            v = Random.Range(0, 11);
        }
        StartCoroutine(WaitAndPrint6(10.5f));
        NewMasiveRandom[b] = v;
        b += 1;
        //NewMasiveRandom = [k, j, i, w, e, r, t];
        x = Random.Range(0, 11);
        while (x == r || x == e || x == w || x == k || x == j || x == i || x == t || x == v)
        {
            x = Random.Range(0, 11);
        }
        StartCoroutine(WaitAndPrint7(12f));
        NewMasiveRandom[b] = x;
        b += 1;
        y = Random.Range(0, 11);
        while (y == r || y == e || y == w || y == k || y == j || y == i || y == t || y == v || y == x)
        {
            y = Random.Range(0, 11);
        }

        StartCoroutine(WaitAndPrint8(13.5f));
        NewMasiveRandom[b] = y;
        b += 1;
        while (n == r || n == e || n == w || n == k || n == j || n == i || n == t || n == v || n == x||n== y)
        {
            n = Random.Range(0, 11);
        }
        StartCoroutine(WaitAndPrint9(16f));
        NewMasiveRandom[b] = n;
        b += 1;
        StartCoroutine(WaitAndPrint10(20f));
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
    IEnumerator WaitAndPrint5(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[t].SetActive(true);
    }
    IEnumerator WaitAndPrint6(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[v].SetActive(true);
    }
    IEnumerator WaitAndPrint7(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[x].SetActive(true);
    }
    IEnumerator WaitAndPrint8(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[y].SetActive(true);
    }
    IEnumerator WaitAndPrint9(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[n].SetActive(true);
    }
    IEnumerator WaitAndPrint10(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        allExamples[k].SetActive(false);
        allExamples[j].SetActive(false);
        allExamples[i].SetActive(false);
        allExamples[w].SetActive(false);
        allExamples[e].SetActive(false);
        allExamples[r].SetActive(false);
        allExamples[t].SetActive(false);
        allExamples[v].SetActive(false);
        allExamples[x].SetActive(false);
        allExamples[y].SetActive(false);
        allExamples[n].SetActive(false);
        text.SetActive(false);
        myButton[0].SetActive(true);
        myButton[1].SetActive(true);
        myButton[2].SetActive(true);
        myButton[3].SetActive(true);
        myButton[4].SetActive(true);
        myButton[5].SetActive(true);
        myButton[6].SetActive(true);
        myButton[7].SetActive(true);
        myButton[8].SetActive(true);
        myButton[9].SetActive(true);
        myButton[10].SetActive(true);

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
        if (PlayerTimer == true && timeintwork >= 20f)
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
        if ((NewMasiveRandom[0] == NewMasiveInput[0]) && (NewMasiveRandom[1] == NewMasiveInput[1]) && (NewMasiveRandom[2] == NewMasiveInput[2]) && (NewMasiveRandom[3] == NewMasiveInput[3]) && (NewMasiveRandom[4] == NewMasiveInput[4] && (NewMasiveRandom[5] == NewMasiveInput[5] && (NewMasiveRandom[6] == NewMasiveInput[6]) && (NewMasiveRandom[7] == NewMasiveInput[7]) && (NewMasiveRandom[8] == NewMasiveInput[8]) && (NewMasiveRandom[9] == NewMasiveInput[9]) && (NewMasiveRandom[10] == NewMasiveInput[10]))))
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
            timeall.SetActive(true);
            obshtime.SetActive(true);
            if (PlayerPrefs.GetInt("Score8") > timeint && PlayerPrefs.HasKey("Score8") == true)
            {
                timeint = (int)timeStart;
                PlayerPrefs.SetInt("Score8", timeint);
                bestscore.SetActive(true);
                bestscoretime.SetActive(true);
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
                if (PlayerPrefs.GetInt("Score8") == 0 && PlayerPrefs.HasKey("Score8") == false)//если игрок с первой попытки нажал все правильно
                {
                    Debug.Log("Первый запуск!");
                    PlayerPrefs.SetInt("Score8", timeint);
                    bestscore.SetActive(true);
                    bestscoretime.SetActive(true);
                    timeall.SetActive(true);
                    obshtime.SetActive(true);
                }
            }
        }







        else

        {
            if ((a == 11) && (PlayerPrefs.HasKey("Score8") == false))
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
                if (a == 11)
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


    public void OnClickEnterPurple()
    {

        if (myButton[3].name == "ButtonPurple")
        {
            a++;
            NewMasiveInput[d] = 3;
            d++;
            Destroy(myButton[3]);
            GetComponent<AudioSource>().Play();
        }


    }
    public void OnClickEnterOrange()
    {

        /// if (myButton[3].name == "ButtonOrange"&&(a==w))
        if (myButton[4].name == "ButtonOrange")
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
    public void OnClickEnterBrown()
    {

        if (myButton[6].name == "ButtonBrown")
        {
            a++;
            NewMasiveInput[d] = 6;
            d++;
            Destroy(myButton[6]);
            GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickEnterPing()
    {

        if (myButton[7].name == "ButtonPing")
        {
            a++;
            NewMasiveInput[d] = 7;
            d++;
            Destroy(myButton[7]);
            GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickEnterBlueShine()
    {

        if (myButton[8].name == "ButtonBlueShine")
        {
            a++;
            NewMasiveInput[d] = 8;
            d++;
            Destroy(myButton[8]);
            GetComponent<AudioSource>().Play();
        }
    }

    public void OnClickEnterBlack()
    {

        if (myButton[9].name == "ButtonBlack")
        {
            a++;
            NewMasiveInput[d] = 9;
            d++;
            Destroy(myButton[9]);
            GetComponent<AudioSource>().Play();
        }
    }
    public void OnClickEnterGray()
    {

        if (myButton[10].name == "ButtonGray")
        {
            a++;
            NewMasiveInput[d] = 10;
            d++;
            Destroy(myButton[10]);
            GetComponent<AudioSource>().Play();
        }
    }
}
