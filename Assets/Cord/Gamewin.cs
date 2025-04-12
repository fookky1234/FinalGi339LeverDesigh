using UnityEngine;
using System.Collections.Generic;

public class Gamewin : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>(); // เก็บรายชื่อ Object
    public GameObject panel; // Panel ที่จะแสดง

    void Start()
    {
        if (panel != null)
            panel.SetActive(false); // ซ่อน Panel ตอนเริ่มเกม
    }

    void Update()
    {
        // ลบ Object ที่ถูกทำลายออกจาก List
        objects.RemoveAll(item => item == null);

        // ถ้า List ว่าง ให้แสดง Panel
        /*if (objects.Count == 0 && panel != null)
        {
            panel.SetActive(true);
        }*/
        if (objects.Count == 0)
        {
            SceneSystem.instance.PlayGame();
        }
        
    }
    
   
}
