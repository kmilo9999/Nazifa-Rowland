using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{



    public int centuryInRealTimeMinutes;
    private float centuryInRTSeconds;
    private float yearsInRTSeconds;
    private float monthsInRTSeconds;
    private float daysInRTSeconds;

    private float gameYears;
    private float gameMonths;
    private float gameDays;

    private float localTimer;
    private float localSeconds;
    private float localMinutes;

    public Text myTextLabel;

    public Text RTCentury;
    public Text myCenturyLabel;
    public Text myYearLabel;
    public Text myMonthLabel;

    // Start is called before the first frame update
    void Start()
    {
        //years
        this.centuryInRTSeconds = (centuryInRealTimeMinutes * 60.0f) ;
        this.yearsInRTSeconds = (centuryInRealTimeMinutes / 100.0f) * 60.0f;
        this.monthsInRTSeconds = this.yearsInRTSeconds / 12.0f;
        this.daysInRTSeconds = this.yearsInRTSeconds / 365.0f;



        this.gameYears = 0.0f;
        this.gameMonths = 0.0f;
        this.gameDays = 0.0f;

        RTCentury.text = "RT Century: " + centuryInRealTimeMinutes;
        myCenturyLabel.text = "Game Century: "+this.centuryInRTSeconds;
        myYearLabel.text = "Game Year: " + this.yearsInRTSeconds;
        myMonthLabel.text = "Game Month: " + this.monthsInRTSeconds;
    }

    // Update is called once per frame
    void Update()
    {
        this.localTimer += Time.deltaTime;

        if (this.localTimer > this.yearsInRTSeconds )
        {
            this.gameYears++;
            this.localTimer = 0;
        }

        myTextLabel.text = "Years: "+this.gameYears;

    }
}
