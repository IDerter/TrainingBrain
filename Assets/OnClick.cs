using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class OnClick : MonoBehaviour {
    bool isWin = false;
    bool isLose = false;
    public float timeStart = 0f;
    public Text Timer;
    public Text Timer1;
    public GameObject CanvasTimer;
    public GameManager script;
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
    /* public GameObject buttonred;
     public GameObject buttongreen;
     public GameObject buttonblue;
     public GameObject buttonorange;
     public GameObject buttonpurple;
     public GameObject buttonwhite;
     public GameObject buttonyellow;*/
    public GameObject[] allExamples = new GameObject[6];
    // Use this for initialization
    void Start() {
        Timer.text = timeStart.ToString();
        Timer1.text = timeStart.ToString();
        Camera.main.aspect = 1080f / 1920f;
        k = Random.Range(0, 7);
        NewMasiveRandom[b] = k;
        b += 1;
        allExamples[k].SetActive(true);

        //j = Random.Range(0, 7);
        while (k == j)
        {
            j = Random.Range(0, 7);

        }
        StartCoroutine(WaitAndPrint(1f));
        //allExamples[j].SetActive(true);
        NewMasiveRandom[b] = j;
        b += 1;
        i = Random.Range(0, 7);
        while (i == k || i == j)
        {
            i = Random.Range(0, 7);
            //allExamples[i].SetActive(true);
        }
        NewMasiveRandom[b] = i;
        b += 1;
        StartCoroutine(WaitAndPrint1(2f));
        w = Random.Range(0, 7);
        while (w == i || w == k || w == j)
        {
            w = Random.Range(0, 7);
            //allExamples[w].SetActive(true);
        }
        StartCoroutine(WaitAndPrint2(3f));
        NewMasiveRandom[b] = w;
        b += 1;
        e = Random.Range(0, 7);
        while (e == w || e == i || e == k || e == j)
        {
            e = Random.Range(0, 7);
            //allExamples[e].SetActive(true);

        }
        StartCoroutine(WaitAndPrint3(4f));
        NewMasiveRandom[b] = e;
        b += 1;
        r = Random.Range(0, 7);
        while (r == e || r == w || r == i || r == k || r == j)
        {
            r = Random.Range(0, 7);
            // allExamples[r].SetActive(true);
        }
        StartCoroutine(WaitAndPrint4(5f));
        NewMasiveRandom[b] = r;
        b += 1;
        t = Random.Range(0, 7);
        while (t == r || t == e || t == w || t == k || t == j || t == i)
        {
            t = Random.Range(0, 7);
            // allExamples[t].SetActive(true);
        }
        NewMasiveRandom[b] = t;
        b += 1;
        //NewMasiveRandom = [k, j, i, w, e, r, t];
        StartCoroutine(WaitAndPrint5(6f));

        StartCoroutine(WaitAndPrint6(10f));
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
        allExamples[k].SetActive(false);
        allExamples[j].SetActive(false);
        allExamples[i].SetActive(false);
        allExamples[w].SetActive(false);
        allExamples[r].SetActive(false);
        allExamples[e].SetActive(false);

        allExamples[t].SetActive(false);
        text.SetActive(false);
        myButton[0].SetActive(true);
        myButton[1].SetActive(true);
        myButton[2].SetActive(true);
        myButton[3].SetActive(true);
        myButton[4].SetActive(true);
        myButton[5].SetActive(true);
        myButton[6].SetActive(true);

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
    void Update() {

        if(!isLose&&!isWin)
        {
            timeStart += Time.deltaTime;
            Timer.text = timeStart.ToString("F2");
            Timer1.text = timeStart.ToString("F2");
        }
       if ((NewMasiveRandom[0]==NewMasiveInput[0])&& (NewMasiveRandom[1] == NewMasiveInput[1]) && (NewMasiveRandom[2] == NewMasiveInput[2]) && (NewMasiveRandom[3] == NewMasiveInput[3]) && (NewMasiveRandom[4] == NewMasiveInput[4] && (NewMasiveRandom[5] == NewMasiveInput[5] && (NewMasiveRandom[6] == NewMasiveInput[6]))))
        {
            Debug.Log("ВЫ ПОБЕДИЛИ!");
            textWin.SetActive(true);
            play.SetActive(true);
            CanvasTimer.SetActive(true);
            if (PlayerPrefs.GetFloat("Score")<timeStart)
                {
                PlayerPrefs.SetFloat("Score", timeStart);
            }
        }
        else
        
        {
            if (a == 7)
            {
                gameManager.GameOver();
                CanvasTimer.SetActive(true);

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
        }


    }
    public void OnClickEnterWhite()
    {

        if (myButton[5].name == "ButtonWhite")
        {
            a++;
            NewMasiveInput[d] = 5;
            d++;
            Destroy(myButton[5]);
        }
    }
    public void OnClickEnterYellow()
    {

        if (myButton[6].name == "ButtonYellow")
        {
            a++;
            NewMasiveInput[d] = 6;
            d++;
            Destroy(myButton[6]);
        }
    }
   
}
