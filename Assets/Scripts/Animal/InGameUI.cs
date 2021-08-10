using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InGameUI : MonoBehaviour
{
    public static InGameUI Instance;
    [SerializeField] private Text title;
    [SerializeField] private Text information;
    [SerializeField] private Text informationMethod;
    [SerializeField] private GameObject panel;

    // ABSTRACTION
    public Text Title { get => title; set => title = value; }
    public Text Information { get => information; set => information = value; }
    public Text InformationMethod { get => informationMethod; set => informationMethod = value; }
    public GameObject Panel { get => panel; set => panel = value; }

    private void Awake()
    {
        Instance = this;
    }
}
