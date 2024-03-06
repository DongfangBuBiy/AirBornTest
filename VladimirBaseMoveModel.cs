using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(VladimirMoveModelUIToVladimir))]
public class VladimirBaseMoveModel : MonoBehaviour
{
    /// <summary>
    /// این کلاس برای آیکن های نشستن ایستادن و سینه خیز است و به کلید های آن متصل است
    /// </summary>
    [SerializeField] private VladimirMoveModelUIToVladimir moveModel;

    private void Start()
    {
        moveModel = GetComponent<VladimirMoveModelUIToVladimir>();
    }

    public void Simpel()
    {
        moveModel.GetMoveModel("Simpel");
    }

    public void Crouch()
    {
        moveModel.GetMoveModel("Crouch");
    }

    public void Chesty()
    {
        moveModel.GetMoveModel("Chesty");
    }
}
