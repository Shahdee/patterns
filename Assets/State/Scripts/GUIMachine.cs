using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIMachine : MonoBehaviour
{
   public Button m_Insert;

   public Button m_Eject;

   public Button m_Turn;
   public Button m_Fill;
   
   public void Awake(){
       m_Insert.onClick.AddListener(InsertClick);
       m_Eject.onClick.AddListener(EjectClick);
       m_Turn.onClick.AddListener(TurnClick);
       m_Fill.onClick.AddListener(FillClick);
   }

   void InsertClick(){
       GumballMachine.GetMachine().Insert();
   }

   void EjectClick(){
       GumballMachine.GetMachine().Eject();
   }
   
   void TurnClick(){
        GumballMachine.GetMachine().Turn();
   }

   void FillClick(){
        int count = 10;
        GumballMachine.GetMachine().Fill(count);
   }

}
