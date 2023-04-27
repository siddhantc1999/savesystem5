using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class contactdisplay : MonoBehaviour
{
    [SerializeField] GameObject button;
    int userlistcount;
    Button thebutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void contactsdisplay(userdata currentuserdata)
    {
        if (currentuserdata.mycontactdetails.Count >0)
        {
            Debug.Log("the current contact details "+currentuserdata.mycontactdetails.Count); ;
            for (int i = 0; i < currentuserdata.mycontactdetails.Count; i++)
            {
                GameObject contactobject = Instantiate(button, transform.gameObject.transform);
                thebutton = contactobject.GetComponent<Button>();
                thebutton.GetComponentInChildren<TextMeshProUGUI>().text = currentuserdata.mycontactdetails[i].name;
                thebutton.gameObject.GetComponent<buttondetails>().name = currentuserdata.mycontactdetails[i].name;
                thebutton.gameObject.GetComponent<buttondetails>().mobilenum = currentuserdata.mycontactdetails[i].mobilenum;
                thebutton.gameObject.GetComponent<buttondetails>().address = currentuserdata.mycontactdetails[i].address;
                thebutton.gameObject.GetComponent<buttondetails>().mail = currentuserdata.mycontactdetails[i].mail;



            }
        }

    }
}
