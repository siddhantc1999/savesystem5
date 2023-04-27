//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using System.Runtime.Serialization.Formatters.Binary;
//using System.IO;

//public static class contactsavedetails
//{
//    //public static List<userdata> userlist = new List<userdata>();
//    public static Dictionary<string, contactdetails> contactdetails;
//    public static void saveplayer(string id,getcontact usercontactinfo)
//    {

//        string path = Application.persistentDataPath + "/contactrecords5.fun";
//        if (File.Exists(path))
//        {
//            contactdetails = fileopen(path);
//            /*if (userlist == null)
//            {
//                userlist = new List<userdata>();
//            }*/

//            //userlist.Add(userlist);
//            Debug.Log("in file append");
//            if (checkuser(usergetinfo))
//            {
//                path = fileappend(path,id, usercontactinfo);
//            }

//        }
//        else
//        {
//            Debug.Log("in file create");
//            path = filecreate(path,id, usercontactinfo);
//        }
//    }



//    public static Dictionary<string, contactdetails> loadplayer()
//    {
//        string path = Application.persistentDataPath + "/phonerecords5.fun";
//        if (File.Exists(path))
//        {
//            return fileopen(path);
//        }
//        else
//        {
//            Debug.LogError("save file not found in " + path);
//            return null;
//        }
//    }

//    private static Dictionary<string, contactdetails> fileopen(string path)
//    {
//        BinaryFormatter formatter = new BinaryFormatter();

//        FileStream stream = new FileStream(path, FileMode.Open);
//        /*Debug.Log("stream length "+stream.Length);*/
//        /*stream.Position = 0;*/
//        if (stream.Length > 0)
//        {

//            Dictionary<string, contactdetails> data1 = formatter.Deserialize(stream) as Dictionary<string,contactdetails>;


//            stream.Close();
//            if (data1 == null)
//            {
//                return null;
//            }
//            else
//            {

//                return data1;
//            }
//        }
//        else
//        {

//            stream.Close();
//        }
//        return null;
//    }

//    private static string filecreate(string path, string id, getcontact usercontactinfo)
//    {


//        BinaryFormatter formatter = new BinaryFormatter();

//        FileStream stream = new FileStream(path, FileMode.Create);
//        contactdetails usercontactdetails = new contactdetails(id, usercontactinfo);
       
//        contactdetails.Add(usercontactdetails.id, usercontactdetails);

//        formatter.Serialize(stream, usercontactdetails);
//        stream.Close();
//        ///no need for below
//        return path;
//    }

//    private static string fileappend(string path,string id, getcontact usercontactinfo)
//    {

//        /*  Debug.Log("here in file creatae "+usergetinfo.name);*/
//        BinaryFormatter formatter = new BinaryFormatter();

//        FileStream stream = new FileStream(path, FileMode.Create);

//        userdata newuserdata = new userdata(usergetinfo);

//        userlist.Add(newuserdata);

//        formatter.Serialize(stream, userlist);
//        stream.Close();
//        /*Debug.Log(userlist[0].name);*/
//        ///no need for below
//        return path;
//    }

//    public static bool checkuser(getcontact usercontactinfo)
//    {
//        foreach (userdata theuserdata in userlist)
//        {
//            if (usergetinfo.userid == usergetinfo.userid)
//            {
//                Debug.LogError("user already present");
//                return false;
//            }
//        }
//        return true;
//    }
//}

