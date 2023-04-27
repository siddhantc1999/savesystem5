using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonid : MonoBehaviour
{
    public scenemanager.nextscreen mynextcanvas;
    public List<userdata> getuserlist;
    [SerializeField] GameObject loginidinputfield;
    [SerializeField] GameObject usernotpresenttext;
    public string loginid;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void nextcanvas()
    {

        foreach (var name in scenemanager.nextscreen.GetNames(mynextcanvas.GetType()))
        {
            if (name == mynextcanvas.ToString())
            {
             
                scenemanager.instance.changescreen(name);
            }
        }
    }
    public void logincheck()
    {
        Debug.Log("in login check");
        getuserlist = savesystem.loadplayer();

        if (getuserlist != null)
        {
            //Debug.Log(loginidinputfield.GetComponent<TMP_InputField>().text.ToString());
            loginid = loginidinputfield.GetComponent<TMP_InputField>().text.ToString();


            if (!string.IsNullOrEmpty(loginid))
            {
                foreach (userdata theuserdata in getuserlist)
                {
                    if (theuserdata.userid == loginid)
                    {
                        
                        nextcanvas();
                        FindObjectOfType<scenemanager>().currentuserdata = theuserdata;
                        FindObjectOfType<contactdisplay>().contactsdisplay(theuserdata);
                        if (usernotpresenttext != null)
                        {
                            usernotpresenttext.active = false;
                        }

                    }
                    else
                    {
                        if (usernotpresenttext != null)
                        {
                            usernotpresenttext.active = true;
                        }
                    }
                }
            }
            else
            {
                Debug.LogError("user id is empty type again");
            }
        }
        else
        {
            Debug.LogError("please register");
        }
    }
    public void viewdetailbutton()
    {

            currentcontactdetails mycurrentcontactdetails = FindObjectOfType<currentcontactdetails>();
            mycurrentcontactdetails.name = GetComponent<buttondetails>().name;
            mycurrentcontactdetails.mobilenum = GetComponent<buttondetails>().mobilenum;
            mycurrentcontactdetails.address = GetComponent<buttondetails>().address;
            mycurrentcontactdetails.mail = GetComponent<buttondetails>().mail;
            nextcanvas();


    }
    //public void viewdetailbutton()
    //{

    //    Button buttonid=GetComponentInChildren<TextMeshProUGUI>()


    //}


    //logintext = loginbutton.GetComponent<>();
    //foreach (userdata theuser in getuserlist)
    //{
    //    if (theuser.name==)
    //    {

    //        scenemanager.instance.changescreen(name);
    //    }
    //}
}

