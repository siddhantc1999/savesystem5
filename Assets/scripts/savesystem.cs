using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public static class savesystem
{
    public static List<userdata> userlist = new List<userdata>();
    public static void saveplayer(getinfo usergetinfo)
    {

        string path = Application.persistentDataPath + "/phonerecords9.fun";
        if (File.Exists(path))
        {
            userlist = fileopen(path);
            /*if (userlist == null)
            {
                userlist = new List<userdata>();
            }*/

            //userlist.Add(userlist);

            if (checkuser(usergetinfo))
            {
                userdata newuserdata = new userdata(usergetinfo);

                ///////////////////////////
                path = fileappend(path, newuserdata);
            }

        }
        else
        {
            userdata newuserdata = new userdata(usergetinfo);


            ///////////////////////////////
            path = filecreate(path, newuserdata);
        }
    }



    public static List<userdata> loadplayer()
    {
        string path = Application.persistentDataPath + "/phonerecords9.fun";
        if (File.Exists(path))
        {
            return fileopen(path);
        }
        else
        {
            //Debug.LogError("save file not found in " + path);
            return null;
        }
    }

    private static List<userdata> fileopen(string path)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Open);
        /*Debug.Log("stream length "+stream.Length);*/

        if (stream.Length > 0)
        {


            List<userdata> data1 = formatter.Deserialize(stream) as List<userdata>;


            stream.Close();
            if (data1 == null)
            {
                return null;
            }
            else
            {

                return data1;
            }
        }
        else
        {

            stream.Close();
        }
        return null;
    }

    private static string filecreate(string path, userdata newuserdata)
    {



        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);

        userlist.Add(newuserdata);
        Debug.Log("the userlist " + userlist[0].name);
        formatter.Serialize(stream, userlist);
        stream.Close();
        ///no need for below
        return path;
    }

    private static string fileappend(string path, userdata newuserdata)
    {

        /*  Debug.Log("here in file creatae "+usergetinfo.name);*/
        BinaryFormatter formatter = new BinaryFormatter();

        FileStream stream = new FileStream(path, FileMode.Create);

        //userdata newuserdata = new userdata(usergetinfo);

        userlist.Add(newuserdata);

        formatter.Serialize(stream, userlist);
        stream.Close();
        /*Debug.Log(userlist[0].name);*/
        ///no need for below
        return path;
    }

    public static bool checkuser(getinfo usergetinfo)
    {
        foreach (userdata theuserdata in userlist)
        {
            if (theuserdata.userid == usergetinfo.userid)
            {

                Debug.LogError("user already present");
                return false;
            }
        }
        return true;
    }
    public static void contactsave(string id, getcontact usercontact)
    {

        userlist = loadplayer();
        foreach (userdata theuserdata in userlist)
        {
           

            if (id == theuserdata.userid)
            {

                contactdetails usercontactdetails = new contactdetails(usercontact);
                /*     Debug.Log("the usercontact details "+usercontactdetails.name);*/
                /*    Debug.Log("the usredata output "+theuserdata.password);*/
                /*  if (theuserdata.mycontactdetails == null)
                  {
                      Debug.Log("its null");
                  }
  */
                theuserdata.mycontactdetails.Add(usercontactdetails);
                string path = Application.persistentDataPath + "/phonerecords9.fun";

                BinaryFormatter formatter = new BinaryFormatter();

                FileStream stream = new FileStream(path, FileMode.Create);
                formatter.Serialize(stream, userlist);
                stream.Close();

            }
        }

    }
}
    


//public class Playerdata
//{

//    public userdata myuserdata;
//}