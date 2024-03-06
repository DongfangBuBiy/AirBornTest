using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VladimirMoveModelUIToVladimir : MonoBehaviour
{
    /// <summary>
    /// این کلاس یک متغییر استرینگ دارد که نشان دهند وضعیت حرکن کماندو می باشد 
    /// با تابع Get می تتوان آن را مقدار دهی کرد
    /// و برعکس
    /// این کلاس به اسکریپت کماندو متصل است
    /// </summary>
    private string MoveModel;

    public string GetMoveModel(string moveModel)
    {
        MoveModel = moveModel;
        return MoveModel;
    }

    public string SendMoveModel()
    {
        return MoveModel;
    }

}
