using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorPanelController : MonoBehaviour
{
    public Button okBtn;
    public GameObject errorPanel;
    // Start is called before the first frame update
    void Start()
    {
        okBtn.onClick.AddListener(hidePanel);        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hidePanel()
    {
        // errorPanel.SetActive(false);
        Destroy(errorPanel);
    }


}
