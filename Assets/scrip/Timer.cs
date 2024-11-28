using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Timer : MonoBehaviour
{
    private float elapsedTime = 0; // เวลาแบบสะสม (วินาที)
    private int displayedMinutes = 0; // นาทีปัจจุบันที่แสดงผล
    public bool isRunning = true;
    [SerializeField]public TMP_Text timeText;
    [SerializeField] public Camera Player1;
    [SerializeField] public Camera Next;
    [SerializeField] public Camera Win;
    [SerializeField] public Transform PlayerPo;
     public float count = 0;
    public float NightCount = 0;
    // Update is called once per frame
    void Update()
    {
         if (isRunning)
        {
            elapsedTime += Time.deltaTime;

            // เมื่อเวลาผ่านไปครบ 60 วินาที จะอัปเดตนาที
            if (Mathf.FloorToInt(elapsedTime / 60) > displayedMinutes)
            {
                count++;
                displayedMinutes++;
                UpdateDisplay();
            }if (count >= 5)
            {
                elapsedTime = 0;
                count = 0;
                displayedMinutes = 0;
                NightCount++;
                if (NightCount >= 5) 
                {
                    Player1.gameObject.SetActive(false);  // เปิด Camera2
                     Win.gameObject.SetActive(true); // ปิด Camera1
                    timeText.text = string.Format("{00:00}:00", displayedMinutes);

                }
                if (NightCount < 5)
                {
                    Next.gameObject.SetActive(true); // ปิด Camera1
                    Player1.gameObject.SetActive(false);  // เปิด Camera2
                    Win.gameObject.SetActive(false); // ปิด Camera1
                    timeText.text = string.Format("{00:00}:00", displayedMinutes);

                }
                
            }
            NightCount = IsWin();
        }
    }
    void UpdateDisplay()
    {
        timeText.text = string.Format("{00:00}:00", displayedMinutes);
    }
    float IsWin()
    {
        if (Player1.transform.position == PlayerPo.transform.position)
        {
            NightCount = 0;
        }
        return NightCount;
    }
    
}
