using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class me_move : MonoBehaviour
{
    public GameObject mine_me;
    public GameObject main_me;
    
    public GameObject mine_ipgu;
    public GameObject dun_ipgu;
          public GameObject shop_ipgu;
          public GameObject main_pop;
          public GameObject mine_pop;
          public GameObject dun_pop;
          public GameObject shop_pop;
          
          public GameObject stone_bar;
          public GameObject dia_bar;
          public GameObject gold_bar;
          public GameObject emerald_bar;
          public GameObject red_dia_bar;
          public GameObject angel_stone_bar;
          
          public float stone_bar_time=3f;
          public float dia_bar_time = 25f;
          public float gold_bar_time=7.0f;
          public float emerald_bar_time=40;
          public float red_dia_bar_time=60;
          public float angel_stone_bar_time;
          
          public bool stone_bar_bool=false;
          public bool dia_bar_bool=false;
          public bool gold_bar_bool=false;
          public bool emerald_bar_bool=false;
          public bool red_dia_bar_bool=false;
          public bool angel_stone_bar_bool=false;
          
          public Image stone_bar_s;
          public Image dia_bar_s;
          public Image gold_bar_s;
          public Image emerald_bar_s;
          public Image red_dia_bar_s;
          public Image angel_stone_bar_s;
         
          IEnumerator stone_time_coru()
          {
              if (stone_bar_bool)
              {
                  yield return new WaitForSeconds(stone_bar_time / 40f);
                  stone_bar.SetActive(true);
                  if ((stone_bar_time / 40f) <= 0)
                  {
                      stone_bar_s.fillAmount = 0;
                  }
                  else
                  {
                      stone_bar_s.fillAmount += stone_bar_time / 40f / 100f;

                  }

              }else{
                  stone_bar.SetActive(false);
              }
            
              

             

          }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("stone_time_coru", stone_bar_time / 40f);
    }

    void OnTriggerStay2D(Collider2D col)
    {
        if(col.gameObject.tag == "stone"){
            
            stone_bar.SetActive(true);
            stone_bar_bool = true;
        }
    }
    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "stone")
        {

            stone_bar_time = 0;
        }
        if(col.gameObject.tag == "exit"){
            main_me.SetActive(true);
            mine_me.SetActive(false);
            main_pop.SetActive(true);
           mine_pop.SetActive(false);
          
       /*    dun_pop.SetActive(false);
           shop_pop.SetActive(false);   */
           
          
          
        }
        
   if(col.gameObject.tag == "mine"){
    mine_ipgu.SetActive(true);
          
}

   if(col.gameObject.tag == "dun"){
    dun_ipgu.SetActive(true);
          
}
   if(col.gameObject.tag == "shop"){
    shop_ipgu.SetActive(true);
          
}

    }
    
void OnTriggerExit2D(Collider2D col) {
        //실행문
        if(col.gameObject.tag == "exit"){
            main_me.SetActive(true);
            mine_me.SetActive(false);
            main_pop.SetActive(true);
            mine_pop.SetActive(false);
       
            /*    dun_pop.SetActive(false);
              shop_pop.SetActive(false);   */
          
          
        }
        
        if(col.gameObject.tag == "stone"){
            
            stone_bar.SetActive(false);
            stone_bar_bool = false;
        }
        
        
   if(col.gameObject.tag == "mine"){
    mine_ipgu.SetActive(false);
          
}

   if(col.gameObject.tag == "shop"){
    shop_ipgu.SetActive(false);
          
}
   if(col.gameObject.tag == "dun"){
    dun_ipgu.SetActive(false);
          
}


    }

    // Update is called once per frame
      void Update()
    {

        // w ->앞
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0.0f, 161.0f, 0.0f)*Time.deltaTime;
        }
        // s->뒤
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0.0f, 161.0f, 0.0f)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(161.0f, 0.0f, 0.0f)*Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(161.0f, 0.0f, 0.0f)*Time.deltaTime;
        }
        
        


    }
}
