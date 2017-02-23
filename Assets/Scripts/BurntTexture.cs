﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public class BurntTexture : MonoBehaviour {
    
    public float timer;
    public float lifetime;
    public int AmtOfBurntTexture;

    bool allOccupied;
     public  BurntGameObject burntGo;
    List<BurntGameObject> burnt_GoList = new List<BurntGameObject>();
    // Use this for initialization
    void Start()
    {
        allOccupied = false;
        for (int a = 0; a < AmtOfBurntTexture; a++)
        {       
            burntGo =(BurntGameObject)Instantiate(burntGo);
            burnt_GoList.Add(burntGo);
            Debug.Log(burntGo.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
      //  timer += Time.deltaTime;
        for (int a = 0; a < burnt_GoList.Count; a++)
        {
            if (burnt_GoList[a].gameObject.activeSelf)
            {
                burnt_GoList[a].lifeTime -= Time.deltaTime;
                if (burnt_GoList[a].lifeTime<=0)
                {
                    burnt_GoList[a].gameObject.SetActive(false);
                    allOccupied = false;
                }
                //else if (a == burnt_GoList.Count)
                //    allOccupied = true;
            }
        }
    }
    //BulletTexture, location, Quaternion.FromToRotation(Vector3.forward, hit.point));
    public GameObject InstantiateBurntTexture(Vector3 pos,Quaternion Rot)
    {
        if (!allOccupied)
        {
            Debug.Log("NOT OCCUPIED");
            for (int b = 0; b < burnt_GoList.Count; b++)
            {
                if (!burnt_GoList[b].gameObject.activeSelf)
                {
                   // Debug.Log(pos);
                    burnt_GoList[b].gameObject.transform.position = pos;
                 //   Debug.Log(burnt_GoList[b].gameObject.transform.position);
                    burnt_GoList[b].gameObject.transform.rotation = Rot;
                    burnt_GoList[b].lifeTime = this.lifetime;
                    burnt_GoList[b].gameObject.SetActive(true);
                    allOccupied = false;
                    Debug.Log(b);
                    if(b==burnt_GoList.Count-1)
                    {
                        allOccupied = true;
                    }
                    return burnt_GoList[b].gameObject;
                   // break;
                   
                }
                //else if (b == burnt_GoList.Count)
                    //allOccupied = true;
            }
        }
        else
        {
            Debug.Log("OCCUPIED");
            BurntGameObject temp = burnt_GoList[0];
            for (int b = 0; b < burnt_GoList.Count; b++) //Find Object that has lowest lifetime currently;
            {
               if(burnt_GoList[b].lifeTime <temp.lifeTime)
               {
                   temp = burnt_GoList[b];
               }
            }
            temp.gameObject.transform.position = pos;
            temp.gameObject.transform.rotation = Rot;
            temp.lifeTime = this.lifetime;
            return temp.gameObject;
        }
                return null;
    }
}