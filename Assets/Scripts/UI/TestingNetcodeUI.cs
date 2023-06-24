using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;
using UnityEngine.UI;
using TMPro;

public class TestingNetcodeUI : MonoBehaviour
{
    [SerializeField] Button startServerButton;
    [SerializeField] Button startHostButton;
    [SerializeField] Button startClientButton;


    private void Awake()
    {
        startHostButton.onClick.AddListener(() =>
        {
            Debug.Log("HOST");
            NetworkManager.Singleton.StartHost();
            Hide();
        });
        startClientButton.onClick.AddListener(() =>
        {
            Debug.Log("CLIENT");
            NetworkManager.Singleton.StartHost();
            Hide();
        });
        startServerButton.onClick.AddListener(() =>
        {
            Debug.Log("SERVER");
            NetworkManager.Singleton.StartHost();
            Hide();
        });
    }


    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
