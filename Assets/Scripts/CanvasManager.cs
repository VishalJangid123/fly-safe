using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CanvasManager : MonoBehaviour
{

    [SerializeField] private GameObject m_menuPanel;
    [SerializeField] private  Button m_startButton;

    void Start()
    {
        m_menuPanel.SetActive(false);
        ShowMenuPanel();
    }

    void ShowMenuPanel()
    {
        m_menuPanel.SetActive(true);
        m_startButton.onClick.RemoveAllListeners();

        m_startButton.onClick.AddListener(() => OnStartButtonClicked());
    }


    void OnStartButtonClicked()
    {
        m_menuPanel.SetActive(false);
        Player.startGame = true;
    }
    
}
