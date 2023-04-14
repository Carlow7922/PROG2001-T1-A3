using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public Text CountText;
    public GameObject WinText;
    public int Index;
    public int passIndex;
    public static GameManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }
    public void IndexC()
    {
        Index++;
        CountText.text = "Count:" + Index.ToString();
        if (Index >= passIndex)
            WinText.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
