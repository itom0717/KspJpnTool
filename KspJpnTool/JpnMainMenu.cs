using UnityEngine;

namespace KspJpnTool
{

    /// <summary>
    /// MainMenu
    /// </summary>
    /// <remarks>
    /// MainMenuの時
    /// </remarks>
    [KSPAddon(KSPAddon.Startup.MainMenu, false)]
    public class JpnMainMenu : MonoBehaviour
    {
        /// <summary>
        /// 処理済み？
        /// </summary>
        bool isOverwrite = false;

        /// <summary>
        /// Update
        /// </summary>
        void Update()
        {
            if (isOverwrite)
            {
                //すでに処理済みのため、何もしない
                return;
            }

            //MainMenuオブジェクト
            var tgtObject = GameObject.Find("MainMenu");
            if (tgtObject == null)
            {
                //MainMenuオブジェクトが見つからない
                return;
            }
            var mainMenu = tgtObject.GetComponent<MainMenu>();

            //Text変更
            this.ReplaceText(mainMenu.startBtn, "スタート");
            this.ReplaceText(mainMenu.settingBtn, "設定");
            this.ReplaceText(mainMenu.commBtn, "ＫＳＰコミュニティ");
            this.ReplaceText(mainMenu.spaceportBtn , "アドオン＆ＭＯＤ");
            this.ReplaceText(mainMenu.creditsBtn, "クレジット");
            this.ReplaceText(mainMenu.quitBtn, "終了");

            this.ReplaceText(mainMenu.continueBtn, "続きから");
            this.ReplaceText(mainMenu.newGameBtn, "ニューゲーム");
            this.ReplaceText(mainMenu.trainingBtn, "トレーニング");
            this.ReplaceText(mainMenu.scenariosBtn, "シナリオ");
            this.ReplaceText(mainMenu.backBtn, "戻る");
 
            isOverwrite = true;
        }

        /// <summary>
        /// テキスト置き換え
        /// </summary>
        /// <param name="tb3D">TextButton3D</param>
        /// <param name="text">テキスト</param>
        private void ReplaceText(TextButton3D tb3D, string text)
        {
            TextMesh tm = tb3D.transform.GetComponent<TextMesh>();

#if DEBUG
            Debug.Log("[MainMenu] : " + tm.text + " → " + text);
            //Debug.Log( "[FontName] : " + tm.font.name );
            Debug.Log( "[FontSize] : " + tm.font.fontSize );
#endif
            tm.text = text;
            tm.fontSize = 52;
        }

        /// <summary>
        /// OnGUI
        /// </summary>
        void OnGUI()
        {
        }
    }
}

