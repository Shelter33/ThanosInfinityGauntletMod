using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace ThanosInfinityGauntletMod.UI 
{
    internal class TimeStoneUItemporary : UIState
    {
        public DragableUIPanel mainPanel;

        public static bool Visible; 
        public override void OnInitialize() 
        {
            mainPanel = new DragableUIPanel();
            mainPanel.SetPadding(0); 
            mainPanel.Left.Set(75f, 0f);
            mainPanel.Top.Set(100f, 0f);

            mainPanel.Width.Set(296, 0f);
            mainPanel.Height.Set(275f, 0f);

            Texture2D buttonDeleteTexture = ModContent.GetTexture("Terraria/UI/ButtonDelete"); //this is a vanilla delete button. Of course you can change it to anything you want, like "ThanosInfinityGauntletMod/UI/gauntlet".
            UIHoverImageButton closeButton = new UIHoverImageButton(buttonDeleteTexture, Language.GetTextValue("LegacyInterface.52")); // Localized text for "Close"

            closeButton.Left.Set(10, 0f);
            closeButton.Top.Set(10, 0f);
            closeButton.Width.Set(30, 0f);
            closeButton.Height.Set(30, 0f);

            //closeButton.OnClick += new MouseEvent(CloseButtonClicked);

            mainPanel.Append(closeButton); 

            Append(mainPanel); 
        }
    }
}