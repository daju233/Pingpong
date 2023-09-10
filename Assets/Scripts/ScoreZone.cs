using System.Collections;
using System.Collections.Generic;
//using UnityEditor.AnimatedValues;
using UnityEngine;
using UnityEngine.EventSystems;

public class ScoreZone : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;
    gamemanager score;
    private void OnCollisionEnter2D(Collision2D collision)
    {
    ball ball = collision.gameObject.GetComponent<ball>();// ≤√¥“‚Àº

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
     }
    }
