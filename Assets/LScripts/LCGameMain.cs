using LUnity.Game.Util;
using LUnity.Game.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LUnity.Game.Scene;

public class LCGameMain : MonoBehaviour
{

    /// <summary>
    /// 当前ui画布
    /// </summary>
    public Canvas mCurrCanvas;

    /// <summary>
    /// 挂载游戏ui的节点
    /// </summary>
    public GameObject mGameUiRoot;

    void Awake()
    {
        SLUnityUtil.LaunchGame();

        DontDestroyOnLoad(this);
    }

    // Use this for initialization
    void Start()
    {

        // 找到挂载ui的父节点
        mCurrCanvas = GetComponentInChildren<Canvas>();
        mGameUiRoot = mCurrCanvas != null ? mCurrCanvas.gameObject : gameObject;

        // 预加载必须的资源
        // 加载游戏界面资源
        SLUIManager.InitPageInfo(CLPageInfo.GetPageInfos(), mGameUiRoot);
        // 加载游戏场景信息
        SLScenesManager.InitSceneInit(CLSceneInfo.GetSceneInfos());
        // 游戏更新

        // 显示登录界面
        SLUIManager.OpenPage((int)ELPageType.Login);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
