using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Text;
using System.IO;
using System.Numerics;
using System.Globalization;
   using Random = UnityEngine.Random;

[System.Serializable]
public class data{
    public string G;
     public string xp;
 public string bosuk;
 public int mine_dogu_lv;
    public int dia;
        public int red_dia;
      public int emerald;
        public int gold;
          public int stone;
            public int angel_stone;

     

                                     
}

public class InGame : MonoBehaviour
{
        public BigInteger G;
     public BigInteger xp;
 public BigInteger bosuk;
    public int dia;
      public int emerald;
        public int gold;
          public int stone;
            public int angel_stone;
public int red_dia;
public int mine_dogu_lv;
       data datavar = new data();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void mine_visit()
    {
        SceneManager.LoadScene("mine");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnApplicationPause(bool pauseStatus){
    if(pauseStatus){
        Save();
    }
}
void OnApplicationQuit(){
      Save();
}


    public void Load(){
      
   string path = Application.persistentDataPath + "/data.Json";
if(File.Exists(path)){
    string json = File.ReadAllText(path);
 data datavar = JsonUtility.FromJson<data>(json);
     

      
    
            G = BigInteger.Parse(datavar.G); 
             xp = BigInteger.Parse(datavar.xp); 
              bosuk = BigInteger.Parse(datavar.bosuk); 
      dia=datavar.dia;
      
         red_dia=datavar.red_dia;
            gold=datavar.gold;
               stone=datavar.stone;
                  angel_stone=datavar.angel_stone;
                     emerald=datavar.emerald;
                     mine_dogu_lv=datavar.mine_dogu_lv;
}else{
      G=0;
      xp=0;
  bosuk=0;
  dia=0;
     emerald=0;
      gold=0;
          stone=0;
           angel_stone=0;
           red_dia=0;
 mine_dogu_lv=1;
    return;
}

}
       public void Save(){

        datavar.G = G.ToString();
  datavar.xp =xp.ToString();
    datavar.bosuk = bosuk.ToString();
      datavar.dia=dia;
         datavar.red_dia=red_dia;
            datavar.gold=gold;
               datavar.stone=stone;
                  datavar.angel_stone=angel_stone;
                     datavar.emerald=emerald;
                     datavar.mine_dogu_lv=mine_dogu_lv;
        string json = JsonUtility.ToJson(datavar);
        Debug.Log(json);
        string path = Application.persistentDataPath + "/data.Json";
        File.WriteAllText(path,json);
    }
}
