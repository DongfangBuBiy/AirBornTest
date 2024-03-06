using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(VladimirMoveModelUIToVladimir))]
public class VladimirUiEbility : MonoBehaviour
{
    /// <summary>
    /// این کلاس شامل توانایی های کماندو می شود مثل چقو . تفنگ و ..
    /// کلیک های این توانایی ها به این کلاس متصل است
    /// </summary>
    [SerializeField] private VladimirMoveModelUIToVladimir moveModel; // دسترشسی به کلاس تعیین نوع حرکت
    [SerializeField] private string PlayerBeseMoveModel;//دسترسی به وضعیت حرکتی کماندو
    void Start()
    {
        moveModel = GetComponent<VladimirMoveModelUIToVladimir>();
        PlayerBeseMoveModel = moveModel.SendMoveModel();
    }

    private void Knifel()
    {
        //طبق وضعیت حرکتی موجود کماندو 
        //وضعیت این توانایی هم متغییر است
        
        switch(PlayerBeseMoveModel)
        {
            case "Simpel":
                moveModel.GetMoveModel("StandKnifel");
                break;

            case "Crouch":
                moveModel.GetMoveModel("KnifelCrouch");
                break;

            case "Chesty":
                break;
        }
    }

    private void Belt()
    {
        switch (PlayerBeseMoveModel)
        {
            case "Simpel":
                break;

            case "Crouch":
                break;

            case "Chesty":
                break;
        }
    }
   
}
