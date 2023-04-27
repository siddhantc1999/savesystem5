using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class currentcontactdetails : MonoBehaviour
{

    public string name;
    public string mobilenum;
    public string address;
    public string mail;
    [SerializeField] GameObject nameinput;
    [SerializeField] GameObject mobileinput;
    [SerializeField] GameObject addressinput;
    [SerializeField] GameObject mailinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if()
        nameinput.GetComponent<TMP_InputField>().text = name;
        mobileinput.GetComponent<TMP_InputField>().text = mobilenum;
        addressinput.GetComponent<TMP_InputField>().text = address;
        mailinput.GetComponent<TMP_InputField>().text = mail;
    }
}
