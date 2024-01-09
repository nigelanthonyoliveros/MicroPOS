using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Services
{
    public static class SkinManager
    {
        public static void ActivateSkin(this MaterialForm form, MaterialSkinManager.Themes theme = MaterialSkinManager.Themes.LIGHT)
        {
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(form);
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.Theme =theme ;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800, //primary
                Primary.BlueGrey900, //dark primary
                Primary.BlueGrey500, //light primary
                Accent.LightBlue200, //dark primary
                TextShade.WHITE      // text shade
                );

            //materialSkinManager.ColorScheme = new ColorScheme();

            //! you can create your own scheme by providing Color on ColorScheme constructor
            // like Color.Blue 

        }
      
    }
}
