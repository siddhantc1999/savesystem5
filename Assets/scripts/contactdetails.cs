using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class contactdetails
{
    public string name;
    public string mobilenum;
    public string address;
    public string mail;
    //public string id;
    public contactdetails(getcontact usercontact)//string id, getcontact mygetcontact)
    {
        name = usercontact.name;
        mobilenum = usercontact.mobilenum;
        address = usercontact.address;
        mail = usercontact.mail;
        //this.id = id;
    }

}
