using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUnity.Game.UI;
using UnityEngine;
using LUnity.Game.Scene;

public enum ELSceneType
{
    /// <summary>
    /// 登录
    /// </summary>
    SceneLevel = 1,

}

/// <summary>
/// 游戏界面信息
/// </summary>
public class CLSceneInfo
{

    public static List<CLSceneEntity> GetSceneInfos()
    {
        return new List<CLSceneEntity>()
        {
            new CLSceneEntity()
            {
                SceneId = (int)ELSceneType.SceneLevel,
                SceneName = "SceneLevel1",
                ScenePath = "scene/scelevel1.data",
                PageId = (int)ELPageType.Login,
            }
        };
    }

}