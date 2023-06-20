using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginManager : MonoBehaviour
{
    public TextMeshProUGUI username;
    public TextMeshProUGUI password;

    // public TMP_Button loginBtn;

    public Button loginBtn;

    public GameObject errorPanelPrefab;
    
    private void DisplayErrorPanel(string errorMessage)
    {
        // Instantiate the error panel prefab
        GameObject errorPanel = Instantiate(errorPanelPrefab, transform);

        // Customize the error message text
        errorPanel.SetActive(true);
        TextMeshProUGUI errorText = errorPanel.GetComponentInChildren<TextMeshProUGUI>();
        errorText.text = errorMessage;
    }

    public void onLoginBtnClicked() {
        Debug.Log(username.text); 
        Debug.Log(password.text);      
        DisplayErrorPanel("Hello World");
    }

    private void Start()
    {
        // loginBtn = FindObjectOfType<TMP_Button>();
        loginBtn.onClick.AddListener(onLoginBtnClicked);
    }
}
