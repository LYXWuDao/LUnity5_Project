using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LUnity.Game.Util;
using LUnity.Game.UI;
using LUnity.Game.Scene;

public class CLUiLogin : CLUIPage
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick()
    {
        SLUnityLog.Error("click ");

        SLUIManager.OnClosePage((int)ELPageType.Login);

        SLScenesManager.OpenScene((int)ELSceneType.SceneLevel);
    }
}
