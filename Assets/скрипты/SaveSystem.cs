using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveSystem : MonoBehaviour
{
   public int veryImportantInt = 0;
   public string veryImprotantIntKey = "OurKey";

   public bool boolToSave = false;
   public string boolToSaveKey = "SaveKey";

   public Vector3 playerPos;
   public string playerPosKey;

   void Awake()
   {
      veryImportantInt = LoadInt(veryImprotantIntKey);
      boolToSave = LoadBool(boolToSaveKey);
      playerPos = LoadPosition(playerPosKey);
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         SaveInt(veryImprotantIntKey, 333); 
      }

      if (Input.GetKeyDown(KeyCode.E))
      {
        SaveBool(boolToSaveKey, boolToSave); 
      }

      if (Input.GetKeyDown(KeyCode.W))
      {
         SavePosition(playerPosKey, playerPos); 
      }
      
   }

   public void SaveInt(string key,int intToSave)
   {
      PlayerPrefs.SetInt(key, intToSave); 
   }

   public int LoadInt(string key)
   {
      if (PlayerPrefs.HasKey(key))
      {
         return PlayerPrefs.GetInt(key);
      }

      return -1;
   }

   public void SaveBool(string key, bool saveBool)
   {
      //if false = 0
      //if true = 1

      if (saveBool == false)
      {
         PlayerPrefs.SetInt(key, 0);
      }

      if (saveBool == true)
      {
         PlayerPrefs.SetInt(key, 1);
      }
   }

   public bool LoadBool(string key)
   {
      var loadedBoolInt = PlayerPrefs.GetInt(key);

      if (loadedBoolInt == 0)
      {
         return false;
      }
      if (loadedBoolInt == 1)
      {
         return true;
      }
      
      return false;
   }
   
   public void SavePosition(string key, Vector3 position)
   {
      var posXKey = key + "X"; 
      var posYKey = key + "Y"; 
      var posZKey = key + "Z"; 
      
      PlayerPrefs.SetFloat(posXKey, position.x);
      PlayerPrefs.SetFloat(posYKey, position.y);
      PlayerPrefs.SetFloat(posZKey, position.z);
   }

   public Vector3 LoadPosition(string key)
   {
      var posXKey = key + "X"; 
      var posYKey = key + "Y"; 
      var posZKey = key + "Z";

      return new Vector3(
         PlayerPrefs.GetFloat(posXKey),
         PlayerPrefs.GetFloat(posYKey),
         PlayerPrefs.GetFloat(posZKey));
   }
}
