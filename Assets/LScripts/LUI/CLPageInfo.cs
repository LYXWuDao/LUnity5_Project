using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LUnity.Game.UI;
using UnityEngine;

public enum ELPageType
{
    /// <summary>
    /// 登录
    /// </summary>
    Login = 1,

}

/// <summary>
/// 游戏界面信息
/// </summary>
public class CLPageInfo
{

    public static List<CLPageEntity> GetPageInfos()
    {
        return new List<CLPageEntity>()
        {
            new CLPageEntity()
            {
                PageId = (int)ELPageType.Login,
                PageName = "uiLogin",
                PagePath = "ui/uilogin.data",
            }
        };
    }

}