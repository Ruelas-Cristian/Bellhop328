using System;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.Track
{
    public class TimeDisplay : MonoBehaviour
    {
        /*
        [Tooltip("Pool object for the time display UI item.")]
        public ObjectDef timeDisplayItem;


        void Awake()
        {
            currentTime = 0;
            lapsOver = false;
        }

        void OnEnable()
        {

        }

        TimeDisplayItem GetItem(int i)
        {

            if (i >= lapTimesText.Count)
            {
                TimeDisplayItem newItem = timeDisplayItem.getObject(false, finishedLapsParent.transform).GetComponent<TimeDisplayItem>();
                finishedLapsParent.UpdateTable(newItem.gameObject);
                lapTimesText.Add(newItem);
                return newItem;
            }

            return lapTimesText[i];
        }


        void Update()
        {
            if (currentTime == 0) return;
            if (levelClear) return;
            currentLapText.SetText(DisplayCurrentTime());
        }

        string DisplayCurrentTime()
        {
            float currentTime = Time.time - newCurrentTime;
            if (currentTime < 0.01f) return "0:00";
            return getTimeString(currentTime);
        }
    
        string getTimeString(float time)
        {
            int timeInt = (int)(time);
            int minutes = timeInt / 60;
            int seconds = timeInt % 60;
            float fraction = (time * 100) % 100;
            if (fraction > 99) fraction = 99;
            return string.Format("{0}:{1:00}:{2:00}", minutes, seconds, fraction);
        }*/
    }
}
