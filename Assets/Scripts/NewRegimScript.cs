using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using TMPro;
public class NewRegimScript : MonoBehaviour
{
    public GameObject timer;
    public GameObject timertext;
    public bool PlayerTimer = false;
    public bool PlayerTimerWork = true;
    public float timeStart = 0f;
    public int timeintwork = 0;
    public int timeint = 0;
    public Text Timer;
    public Text Score;
    public float timeStartWork = 0f;
    public GameObject canvas1;
    public GameObject canvas2;
    public int k = 0;
    public int j = 0;
    public int i = 0;
    public int d = 0;
    public int newscore = 0;
    public GameObject[] MassiveColors1;
    public GameObject[] MassiveColors2;
    public GameObject[] MassiveColors3;
    public TextMeshProUGUI[] MassiveTexts;
    public TextMeshProUGUI[] MassiveColorsTextsRed;
    public TextMeshProUGUI[] MassiveColorsTextsGreen;
    public TextMeshProUGUI[] MassiveColorsTextsBlue;
    public TextMeshProUGUI[] MassiveColorsTextsPurple;
    public TextMeshProUGUI[] MassiveColorsTextsOrange;
    public TextMeshProUGUI[] MassiveColorsTextsYellow;
    public TextMeshProUGUI[] MassiveColorsTextsBrown;
    public TextMeshProUGUI[] MassiveColorsTextsPing;
    public TextMeshProUGUI[] MassiveColorsTextsBlack;
    public TextMeshProUGUI textlearn;
    public int y = 0;
    public int IsFirst = 1;
    private const string leaderboard = "CgkIr66frqwfEAIQAA";
    // Start is called before the first frame update
    void Start()
    {
        Timer.text = timeStart.ToString();
        PlayerPrefs.GetInt("isfirst", IsFirst);
        if (PlayerPrefs.GetInt("isfirst",IsFirst) ==1 )
        {
            textlearn.enabled = true;
            Invoke("StartGame", 5f);
            
        }
        else
        {
            AppereanseColors();
            
        }
    }
    public void StartGame()
    {
        AppereanseColors();
       // Timer.text = timeStart.ToString();
        //Score.text = timeStart.ToString();
        PlayerTimerWork = true;
    }
    void AppereanseColors()
    {
        IsFirst = 0;
        PlayerPrefs.SetInt("isfirst", IsFirst);
        PlayerTimerWork = true;
        textlearn.enabled = false;
        MassiveColorsTextsRed[y].enabled = false;
        MassiveColorsTextsGreen[y].enabled = false;
        MassiveColorsTextsBlue[y].enabled = false;
        MassiveColorsTextsPurple[y].enabled = false;
        MassiveColorsTextsOrange[y].enabled = false;
        MassiveColorsTextsYellow[y].enabled = false;
        MassiveColorsTextsBrown[y].enabled = false;
        MassiveColorsTextsPing[y].enabled = false;
        MassiveColorsTextsBlack[y].enabled = false;
        if (newscore >= 30 && newscore<90)
        {
            timeStart = 3;
            timeStartWork = 3;
            PlayerTimerWork = true;
        }
        if (newscore >= 90)
        {
            timeStart = 2;
            timeStartWork = 2;
            PlayerTimerWork = true;
        }
        if (newscore < 30)
        {
            timeStart = 4;
        }
        Timer.text = timeStart.ToString();
        y = Random.Range(0, 6);
        k = Random.Range(0, 9);
        MassiveColors1[k].SetActive(true);
        j = Random.Range(0, 9);
        while (k == j)
        {
            j = Random.Range(0, 9);

        }
        i = Random.Range(0, 9);
        MassiveColors2[j].SetActive(true);
        while (i == k || i == j)
        {
            i = Random.Range(0, 9);

        }
        MassiveColors3[i].SetActive(true);
        d = Random.Range(0, 9);
        while (d != k && d != j && d != i)
        {
            d = Random.Range(0, 9);
        }
        //MassiveTexts[d].enabled = true;
        Debug.Log("новыйтекст");
        timeStart -= 0.01f;
        if (d==k && k== 0)
        {
            MassiveColorsTextsRed[y].enabled = true;
        }
        if (d == k && k == 1)
        {
            MassiveColorsTextsGreen[y].enabled = true;
        }
        if (d == k && k == 2)
        {
            MassiveColorsTextsBlue[y].enabled = true;
        }
        if (d == k && k == 3)
        {
            MassiveColorsTextsPurple[y].enabled = true;
        }
        if (d == k && k == 4)
        {
            MassiveColorsTextsOrange[y].enabled = true;
        }
        if (d == k && k == 5)
        {
            MassiveColorsTextsYellow[y].enabled = true;
        }
        if (d == k && k == 6)
        {
            MassiveColorsTextsBrown[y].enabled = true;
        }
        if (d == k && k == 7)
        {
            MassiveColorsTextsPing[y].enabled = true;
        }
        if (d == k && k == 8)
        {
            MassiveColorsTextsBlack[y].enabled = true;
        }
        if (d == j && j == 0)
        {
            MassiveColorsTextsRed[y].enabled = true;
        }
        if (d == j && j == 1)
        {
            MassiveColorsTextsGreen[y].enabled = true;
        }
        if (d == j && j == 2)
        {
            MassiveColorsTextsBlue[y].enabled = true;
        }
        if (d == j && j == 3)
        {
            MassiveColorsTextsPurple[y].enabled = true;
        }
        if (d == j && j == 4)
        {
            MassiveColorsTextsOrange[y].enabled = true;
        }
        if (d == j && j == 5)
        {
            MassiveColorsTextsYellow[y].enabled = true;
        }
        if (d == j && j == 6)
        {
            MassiveColorsTextsBrown[y].enabled = true;
        }
        if (d == j && j == 7)
        {
            MassiveColorsTextsPing[y].enabled = true;
        }
        if (d == j && j == 8)
        {
            MassiveColorsTextsBlack[y].enabled = true;
        }
        if (d == i && i == 0)
        {
            MassiveColorsTextsRed[y].enabled = true;
        }
        if (d == i && i == 1)
        {
            MassiveColorsTextsGreen[y].enabled = true;
        }
        if (d == i && i == 2)
        {
            MassiveColorsTextsBlue[y].enabled = true;
        }
        if (d == i && i == 3)
        {
            MassiveColorsTextsPurple[y].enabled = true;
        }
        if (d == i && i == 4)
        {
            MassiveColorsTextsOrange[y].enabled = true;
        }
        if (d == i && i == 5)
        {
            MassiveColorsTextsYellow[y].enabled = true;
        }
        if (d == i && i == 6)
        {
            MassiveColorsTextsBrown[y].enabled = true;
        }
        if (d == i && i == 7)
        {
            MassiveColorsTextsPing[y].enabled = true;
        }
        if (d == i && i == 8)
        {
            MassiveColorsTextsBlack[y].enabled = true;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (PlayerTimerWork == true && timeStart > 0)
        {

            timer.SetActive(true);
            timertext.SetActive(true);

            timeStart -= Time.deltaTime;
            timeint = (int)timeStart;
            //Timer.text = timeStart.ToString("F0");
            // Timer1.text = timeStart.ToString("F0");
            Timer.text = timeint.ToString("F0");
            Score.text = newscore.ToString("F0");
            
            //timeint = (int)timeStart;
        }

        else
        if(timeStart <=0)
        {
            canvas1.SetActive(false);
            canvas2.SetActive(true);
            timeStart = 4;
            timeStartWork = 4;
            if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
            {
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                Social.ReportScore(newscore, leaderboard, (bool success) =>
                {
                    if (success) print("удачно добавлен в таблицу лидеров!");
                });
            }
           
        }
        
        //  else
        //   {
        //       timeStart = 4;
        //       timeStartWork = 4;
        //   }
    }
    public void OnClickEnterRed()
    {
        if (MassiveColors1[k].name == "ButtonRed1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
             //   MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();


            }

        }
    }
    public void OnClickEnterGreen()
    {
        if (MassiveColors1[k].name == "ButtonGreen1")
        {
            Debug.Log("!1");
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlue()
    {
        if (MassiveColors1[k].name == "ButtonBlue1")
        {
            Debug.Log("!1");
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
             //   MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPurple1()
    {
        if (MassiveColors1[k].name == "ButtonPurple1")
        {
            Debug.Log("!1");
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterOrange()
    {
        if (MassiveColors1[k].name == "ButtonOrange1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterYellow()
    {
        if (MassiveColors1[k].name == "ButtonYellow1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBrown()
    {
        if (MassiveColors1[k].name == "ButtonBrown1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPing()
    {
        if (MassiveColors1[k].name == "ButtonPing1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlack()
    {
        if (MassiveColors1[k].name == "ButtonBlack1")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors1[k].SetActive(false);
            if (d != k)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }


    public void OnClickEnterRed2()
    {
        if (MassiveColors2[j].name == "ButtonRed2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
                MassiveTexts[d].enabled = false;
               // MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterGreen2()
    {
        if (MassiveColors2[j].name == "ButtonGreen2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlue2()
    {
        if (MassiveColors2[j].name == "ButtonBlue2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPurple2()
    {
        if (MassiveColors2[j].name == "ButtonPurple2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
             //   MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterOrange2()
    {
        if (MassiveColors2[j].name == "ButtonOrange2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
            //    MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterYellow2()
    {
        if (MassiveColors2[j].name == "ButtonYellow2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
             //   MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBrown2()
    {
        if (MassiveColors2[j].name == "ButtonBrown2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPing2()
    {
        if (MassiveColors2[j].name == "ButtonPing2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
             //   MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlack2()
    {
        if (MassiveColors2[j].name == "ButtonBlack2")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors2[j].SetActive(false);
            if (d != j)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
            //    MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }


    public void OnClickEnterRed3()
    {
        if (MassiveColors3[i].name == "ButtonRed3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterGreen3()
    {
        if (MassiveColors3[i].name == "ButtonGreen3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlue3()
    {
        if (MassiveColors3[i].name == "ButtonBlue3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPurple3()
    {
        if (MassiveColors3[i].name == "ButtonPurple3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterOrange3()
    {
        if (MassiveColors3[i].name == "ButtonOrange3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
              //  MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterYellow3()
    {
        if (MassiveColors3[i].name == "ButtonYellow3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBrown3()
    {
        if (MassiveColors3[i].name == "ButtonBrown3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
                //MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterPing3()
    {
        if (MassiveColors3[i].name == "ButtonPing3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
    public void OnClickEnterBlack3()
    {
        if (MassiveColors3[i].name == "ButtonBlack3")
        {
            GetComponent<AudioSource>().Play();
            MassiveColors3[i].SetActive(false);
            if (d != i)
            {
                canvas1.SetActive(false);
                canvas2.SetActive(true);
                if (newscore >= PlayerPrefs.GetInt("Scorenewregim"))
                {
                    PlayerPrefs.SetInt("Scorenewregim", newscore);
                    Social.ReportScore(newscore, leaderboard, (bool success) =>
                    {
                        if (success) print("удачно добавлен в таблицу лидеров!");
                    });
                }
            }
            else
            {
                MassiveColors1[k].SetActive(false);
                MassiveColors2[j].SetActive(false);
                MassiveColors3[i].SetActive(false);
               // MassiveTexts[d].enabled = false;
                MassiveColorsTextsRed[y].enabled = false;
                MassiveColorsTextsGreen[y].enabled = false;
                MassiveColorsTextsBlue[y].enabled = false;
                MassiveColorsTextsPurple[y].enabled = false;
                MassiveColorsTextsOrange[y].enabled = false;
                MassiveColorsTextsYellow[y].enabled = false;
                MassiveColorsTextsBrown[y].enabled = false;
                MassiveColorsTextsPing[y].enabled = false;
                MassiveColorsTextsBlack[y].enabled = false;
                newscore += 1;
                PlayerPrefs.SetInt("Scorenewregim", newscore);
                AppereanseColors();
            }
        }
    }
}
