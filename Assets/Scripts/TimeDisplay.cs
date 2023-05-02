using System;
using System.Collections.Generic;
using UnityEngine;

    public class TimeDisplay : MonoBehaviour
    {
        /*
        [Tooltip("Pool object for the time display UI item.")]
        public ObjectDef timeDisplayItem;


        void Awake()
        {
            currentTime = 0;
        }

        void OnEnable()
        {

        }

        TimeDisplayItem GetItem(int i)
        {

            if (i >= lapTimesText.Count)
            {
                TimeDisplayItem newItem = timeDisplayItem.getObject(false, finishedLevelParent.transform).GetComponent<TimeDisplayItem>();
                finishedLevelParent.UpdateTable(newItem.gameObject);
                timesText.Add(newItem);
                return newItem;
            }

            return timeText[i];
        }


        void Update()
        {
            if (currentTime == 0) return;
            if (levelClear) return;
            currentText.SetText(DisplayCurrentTime());
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
        }
        */
    }
