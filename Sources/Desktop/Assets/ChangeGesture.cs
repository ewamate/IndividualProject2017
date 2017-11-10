using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGesture : MonoBehaviour {

    // Use this for initialization
    private readonly string[] m_animations = { "Pickup","Wave" };
    int i = 0;
    private Animator[] m_animators;
    void Start ()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        Text vText = transform.Find("GetGesture").GetComponent<Text>();
        vText.text = m_animations[i%2];
        i++;
        vText.SetAllDirty();
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void TaskOnClick()
    {
        Text vText = transform.Find("GetGesture").GetComponent<Text>();
        vText.text = m_animations[i%2];
        i++;
        vText.SetAllDirty();


    }
}
