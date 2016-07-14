using System;
using System.Runtime.InteropServices;

namespace MinimizeCapture
{
    internal static class XPAppearance
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SystemParametersInfo(XPAppearance.SPI uiAction, uint uiParam, ref XPAppearance.ANIMATIONINFO pvParam, XPAppearance.SPIF fWinIni);

        public static bool MinAnimate
        {
            get
            {
                XPAppearance.ANIMATIONINFO aNIMATIONINFO = new XPAppearance.ANIMATIONINFO(false);
                XPAppearance.SystemParametersInfo(XPAppearance.SPI.SPI_GETANIMATION, XPAppearance.ANIMATIONINFO.GetSize(), ref aNIMATIONINFO, XPAppearance.SPIF.None);
                return aNIMATIONINFO.IMinAnimate;
            }

            set
            {
                XPAppearance.ANIMATIONINFO aNIMATIONINFO = new XPAppearance.ANIMATIONINFO(value);
                XPAppearance.SystemParametersInfo(XPAppearance.SPI.SPI_SETANIMATION, XPAppearance.ANIMATIONINFO.GetSize(), ref aNIMATIONINFO, XPAppearance.SPIF.SPIF_SENDCHANGE);
            }
        }

        private const uint SPI_GETACCESSTIMEOUT = 60u;

        private const uint SPI_GETACTIVEWINDOWTRACKING = 4096u;

        private const uint SPI_GETACTIVEWNDTRKTIMEOUT = 8194u;

        private const uint SPI_GETACTIVEWNDTRKZORDER = 4108u;

        private const uint SPI_GETANIMATION = 72u;

        private const uint SPI_GETBEEP = 1u;

        private const uint SPI_GETBLOCKSENDINPUTRESETS = 4134u;

        private const uint SPI_GETBORDER = 5u;

        private const uint SPI_GETCARETWIDTH = 8198u;

        private const uint SPI_GETCOMBOBOXANIMATION = 4100u;

        private const uint SPI_GETCURSORSHADOW = 4122u;

        private const uint SPI_GETDEFAULTINPUTLANG = 89u;

        private const uint SPI_GETDESKWALLPAPER = 115u;

        private const uint SPI_GETDRAGFULLWINDOWS = 38u;

        private const uint SPI_GETDROPSHADOW = 4132u;

        private const uint SPI_GETFASTTASKSWITCH = 35u;

        private const uint SPI_GETFILTERKEYS = 50u;

        private const uint SPI_GETFLATMENU = 4130u;

        private const uint SPI_GETFOCUSBORDERHEIGHT = 8208u;

        private const uint SPI_GETFOCUSBORDERWIDTH = 8206u;

        private const uint SPI_GETFONTSMOOTHING = 74u;

        private const uint SPI_GETFONTSMOOTHINGCONTRAST = 8204u;

        private const uint SPI_GETFONTSMOOTHINGORIENTATION = 8210u;

        private const uint SPI_GETFONTSMOOTHINGTYPE = 8202u;

        private const uint SPI_GETFOREGROUNDFLASHCOUNT = 8196u;

        private const uint SPI_GETFOREGROUNDLOCKTIMEOUT = 8192u;

        private const uint SPI_GETGRADIENTCAPTIONS = 4104u;

        private const uint SPI_GETGRIDGRANULARITY = 18u;

        private const uint SPI_GETHIGHCONTRAST = 66u;

        private const uint SPI_GETHOTTRACKING = 4110u;

        private const uint SPI_GETICONMETRICS = 45u;

        private const uint SPI_GETICONTITLELOGFONT = 31u;

        private const uint SPI_GETICONTITLEWRAP = 25u;

        private const uint SPI_GETKEYBOARDCUES = 4106u;

        private const uint SPI_GETKEYBOARDDELAY = 22u;

        private const uint SPI_GETKEYBOARDPREF = 68u;

        private const uint SPI_GETKEYBOARDSPEED = 10u;

        private const uint SPI_GETLISTBOXSMOOTHSCROLLING = 4102u;

        private const uint SPI_GETLOWPOWERACTIVE = 83u;

        private const uint SPI_GETLOWPOWERTIMEOUT = 79u;

        private const uint SPI_GETMENUANIMATION = 4098u;

        private const uint SPI_GETMENUDROPALIGNMENT = 27u;

        private const uint SPI_GETMENUFADE = 4114u;

        private const uint SPI_GETMENUSHOWDELAY = 106u;

        private const uint SPI_GETMENUUNDERLINES = 4106u;

        private const uint SPI_GETMINIMIZEDMETRICS = 43u;

        private const uint SPI_GETMOUSE = 3u;

        private const uint SPI_GETMOUSECLICKLOCK = 4126u;

        private const uint SPI_GETMOUSECLICKLOCKTIME = 8200u;

        private const uint SPI_GETMOUSEHOVERHEIGHT = 100u;

        private const uint SPI_GETMOUSEHOVERTIME = 102u;

        private const uint SPI_GETMOUSEHOVERWIDTH = 98u;

        private const uint SPI_GETMOUSEKEYS = 54u;

        private const uint SPI_GETMOUSESONAR = 4124u;

        private const uint SPI_GETMOUSESPEED = 112u;

        private const uint SPI_GETMOUSETRAILS = 94u;

        private const uint SPI_GETMOUSEVANISH = 4128u;

        private const uint SPI_GETNONCLIENTMETRICS = 41u;

        private const uint SPI_GETPOWEROFFACTIVE = 84u;

        private const uint SPI_GETPOWEROFFTIMEOUT = 80u;

        private const uint SPI_GETSCREENREADER = 70u;

        private const uint SPI_GETSCREENSAVEACTIVE = 16u;

        private const uint SPI_GETSCREENSAVERRUNNING = 114u;

        private const uint SPI_GETSCREENSAVETIMEOUT = 14u;

        private const uint SPI_GETSELECTIONFADE = 4116u;

        private const uint SPI_GETSERIALKEYS = 62u;

        private const uint SPI_GETSHOWIMEUI = 110u;

        private const uint SPI_GETSHOWSOUNDS = 56u;

        private const uint SPI_GETSNAPTODEFBUTTON = 95u;

        private const uint SPI_GETSOUNDSENTRY = 64u;

        private const uint SPI_GETSTICKYKEYS = 58u;

        private const uint SPI_GETTOGGLEKEYS = 52u;

        private const uint SPI_GETTOOLTIPANIMATION = 4118u;

        private const uint SPI_GETTOOLTIPFADE = 4120u;

        private const uint SPI_GETUIEFFECTS = 4158u;

        private const uint SPI_GETWHEELSCROLLLINES = 104u;

        private const uint SPI_GETWINDOWSEXTENSION = 92u;

        private const uint SPI_GETWORKAREA = 48u;

        private const uint SPI_ICONHORIZONTALSPACING = 13u;

        private const uint SPI_ICONVERTICALSPACING = 24u;

        private const uint SPI_LANGDRIVER = 12u;

        private const uint SPI_SCREENSAVERRUNNING = 97u;

        private const uint SPI_SETACCESSTIMEOUT = 61u;

        private const uint SPI_SETACTIVEWINDOWTRACKING = 4097u;

        private const uint SPI_SETACTIVEWNDTRKTIMEOUT = 8195u;

        private const uint SPI_SETACTIVEWNDTRKZORDER = 4109u;

        private const uint SPI_SETANIMATION = 73u;

        private const uint SPI_SETBEEP = 2u;

        private const uint SPI_SETBLOCKSENDINPUTRESETS = 4135u;

        private const uint SPI_SETBORDER = 6u;

        private const uint SPI_SETCARETWIDTH = 8199u;

        private const uint SPI_SETCOMBOBOXANIMATION = 4101u;

        private const uint SPI_SETCURSORSHADOW = 4123u;

        private const uint SPI_SETDEFAULTINPUTLANG = 90u;

        private const uint SPI_SETDESKPATTERN = 21u;

        private const uint SPI_SETDESKWALLPAPER = 20u;

        private const uint SPI_SETDOUBLECLICKTIME = 32u;

        private const uint SPI_SETDOUBLECLKHEIGHT = 30u;

        private const uint SPI_SETDOUBLECLKWIDTH = 29u;

        private const uint SPI_SETDRAGFULLWINDOWS = 37u;

        private const uint SPI_SETDRAGHEIGHT = 77u;

        private const uint SPI_SETDRAGWIDTH = 76u;

        private const uint SPI_SETDROPSHADOW = 4133u;

        private const uint SPI_SETFASTTASKSWITCH = 36u;

        private const uint SPI_SETFILTERKEYS = 51u;

        private const uint SPI_SETFLATMENU = 4131u;

        private const uint SPI_SETFOCUSBORDERHEIGHT = 8209u;

        private const uint SPI_SETFOCUSBORDERWIDTH = 8207u;

        private const uint SPI_SETFONTSMOOTHING = 75u;

        private const uint SPI_SETFONTSMOOTHINGCONTRAST = 8205u;

        private const uint SPI_SETFONTSMOOTHINGORIENTATION = 8211u;

        private const uint SPI_SETFONTSMOOTHINGTYPE = 8203u;

        private const uint SPI_SETFOREGROUNDFLASHCOUNT = 8197u;

        private const uint SPI_SETFOREGROUNDLOCKTIMEOUT = 8193u;

        private const uint SPI_SETGRADIENTCAPTIONS = 4105u;

        private const uint SPI_SETGRIDGRANULARITY = 19u;

        private const uint SPI_SETHANDHELD = 78u;

        private const uint SPI_SETHIGHCONTRAST = 67u;

        private const uint SPI_SETHOTTRACKING = 4111u;

        private const uint SPI_SETICONMETRICS = 46u;

        private const uint SPI_SETICONS = 88u;

        private const uint SPI_SETICONTITLELOGFONT = 34u;

        private const uint SPI_SETICONTITLEWRAP = 26u;

        private const uint SPI_SETKEYBOARDCUES = 4107u;

        private const uint SPI_SETKEYBOARDDELAY = 23u;

        private const uint SPI_SETKEYBOARDPREF = 69u;

        private const uint SPI_SETKEYBOARDSPEED = 11u;

        private const uint SPI_SETLANGTOGGLE = 91u;

        private const uint SPI_SETLISTBOXSMOOTHSCROLLING = 4103u;

        private const uint SPI_SETLOWPOWERACTIVE = 85u;

        private const uint SPI_SETLOWPOWERTIMEOUT = 81u;

        private const uint SPI_SETMENUANIMATION = 4099u;

        private const uint SPI_SETMENUDROPALIGNMENT = 28u;

        private const uint SPI_SETMENUFADE = 4115u;

        private const uint SPI_SETMENUSHOWDELAY = 107u;

        private const uint SPI_SETMENUUNDERLINES = 4107u;

        private const uint SPI_SETMINIMIZEDMETRICS = 44u;

        private const uint SPI_SETMOUSE = 4u;

        private const uint SPI_SETMOUSEBUTTONSWAP = 33u;

        private const uint SPI_SETMOUSECLICKLOCK = 4127u;

        private const uint SPI_SETMOUSECLICKLOCKTIME = 8201u;

        private const uint SPI_SETMOUSEHOVERHEIGHT = 101u;

        private const uint SPI_SETMOUSEHOVERTIME = 103u;

        private const uint SPI_SETMOUSEHOVERWIDTH = 99u;

        private const uint SPI_SETMOUSEKEYS = 55u;

        private const uint SPI_SETMOUSESONAR = 4125u;

        private const uint SPI_SETMOUSESPEED = 113u;

        private const uint SPI_SETMOUSETRAILS = 93u;

        private const uint SPI_SETMOUSEVANISH = 4129u;

        private const uint SPI_SETNONCLIENTMETRICS = 42u;

        private const uint SPI_SETPENWINDOWS = 49u;

        private const uint SPI_SETPOWEROFFACTIVE = 86u;

        private const uint SPI_SETPOWEROFFTIMEOUT = 82u;

        private const uint SPI_SETSCREENREADER = 71u;

        private const uint SPI_SETSCREENSAVEACTIVE = 17u;

        private const uint SPI_SETSCREENSAVETIMEOUT = 15u;

        private const uint SPI_SETSELECTIONFADE = 4117u;

        private const uint SPI_SETSERIALKEYS = 63u;

        private const uint SPI_SETSHOWIMEUI = 111u;

        private const uint SPI_SETSHOWSOUNDS = 57u;

        private const uint SPI_SETSNAPTODEFBUTTON = 96u;

        private const uint SPI_SETSOUNDSENTRY = 65u;

        private const uint SPI_SETSTICKYKEYS = 59u;

        private const uint SPI_SETTOGGLEKEYS = 53u;

        private const uint SPI_SETTOOLTIPANIMATION = 4119u;

        private const uint SPI_SETTOOLTIPFADE = 4121u;

        private const uint SPI_SETUIEFFECTS = 4159u;

        private const uint SPI_SETWHEELSCROLLLINES = 105u;

        private const uint SPI_SETWORKAREA = 47u;

        private struct ANIMATIONINFO
        {
            public ANIMATIONINFO(bool iMinAnimate)
            {
                this.cbSize = XPAppearance.ANIMATIONINFO.GetSize();
                if (iMinAnimate)
                {
                    this.iMinAnimate = 1;
                    return;
                }
                this.iMinAnimate = 0;
            }

            public static uint GetSize()
            {
                return (uint)Marshal.SizeOf(typeof(XPAppearance.ANIMATIONINFO));
            }

            public bool IMinAnimate
            {
                get
                {
                    return this.iMinAnimate != 0;
                }

                set
                {
                    if (value)
                    {
                        this.iMinAnimate = 1;
                        return;
                    }
                    this.iMinAnimate = 0;
                }
            }

            public uint cbSize;

            private int iMinAnimate;
        }

        private enum SPI : uint
        {
            SPI_GETBEEP = 1u,

            SPI_SETBEEP,

            SPI_GETMOUSE,

            SPI_SETMOUSE,

            SPI_GETBORDER,

            SPI_SETBORDER,

            SPI_GETKEYBOARDSPEED = 10u,

            SPI_SETKEYBOARDSPEED,

            SPI_LANGDRIVER,

            SPI_ICONHORIZONTALSPACING,

            SPI_GETSCREENSAVETIMEOUT,

            SPI_SETSCREENSAVETIMEOUT,

            SPI_GETSCREENSAVEACTIVE,

            SPI_SETSCREENSAVEACTIVE,

            SPI_GETGRIDGRANULARITY,

            SPI_SETGRIDGRANULARITY,

            SPI_SETDESKWALLPAPER,

            SPI_SETDESKPATTERN,

            SPI_GETKEYBOARDDELAY,

            SPI_SETKEYBOARDDELAY,

            SPI_ICONVERTICALSPACING,

            SPI_GETICONTITLEWRAP,

            SPI_SETICONTITLEWRAP,

            SPI_GETMENUDROPALIGNMENT,

            SPI_SETMENUDROPALIGNMENT,

            SPI_SETDOUBLECLKWIDTH,

            SPI_SETDOUBLECLKHEIGHT,

            SPI_GETICONTITLELOGFONT,

            SPI_SETDOUBLECLICKTIME,

            SPI_SETMOUSEBUTTONSWAP,

            SPI_SETICONTITLELOGFONT,

            SPI_GETFASTTASKSWITCH,

            SPI_SETFASTTASKSWITCH,

            SPI_SETDRAGFULLWINDOWS,

            SPI_GETDRAGFULLWINDOWS,

            SPI_GETNONCLIENTMETRICS = 41u,

            SPI_SETNONCLIENTMETRICS,

            SPI_GETMINIMIZEDMETRICS,

            SPI_SETMINIMIZEDMETRICS,

            SPI_GETICONMETRICS,

            SPI_SETICONMETRICS,

            SPI_SETWORKAREA,

            SPI_GETWORKAREA,

            SPI_SETPENWINDOWS,

            SPI_GETHIGHCONTRAST = 66u,

            SPI_SETHIGHCONTRAST,

            SPI_GETKEYBOARDPREF,

            SPI_SETKEYBOARDPREF,

            SPI_GETSCREENREADER,

            SPI_SETSCREENREADER,

            SPI_GETANIMATION,

            SPI_SETANIMATION,

            SPI_GETFONTSMOOTHING,

            SPI_SETFONTSMOOTHING,

            SPI_SETDRAGWIDTH,

            SPI_SETDRAGHEIGHT,

            SPI_SETHANDHELD,

            SPI_GETLOWPOWERTIMEOUT,

            SPI_GETPOWEROFFTIMEOUT,

            SPI_SETLOWPOWERTIMEOUT,

            SPI_SETPOWEROFFTIMEOUT,

            SPI_GETLOWPOWERACTIVE,

            SPI_GETPOWEROFFACTIVE,

            SPI_SETLOWPOWERACTIVE,

            SPI_SETPOWEROFFACTIVE,

            SPI_SETCURSORS,

            SPI_SETICONS,

            SPI_GETDEFAULTINPUTLANG,

            SPI_SETDEFAULTINPUTLANG,

            SPI_SETLANGTOGGLE,

            SPI_GETWINDOWSEXTENSION,

            SPI_SETMOUSETRAILS,

            SPI_GETMOUSETRAILS,

            SPI_SETSCREENSAVERRUNNING = 97u,

            SPI_SCREENSAVERRUNNING = 97u,

            SPI_GETFILTERKEYS = 50u,

            SPI_SETFILTERKEYS,

            SPI_GETTOGGLEKEYS,

            SPI_SETTOGGLEKEYS,

            SPI_GETMOUSEKEYS,

            SPI_SETMOUSEKEYS,

            SPI_GETSHOWSOUNDS,

            SPI_SETSHOWSOUNDS,

            SPI_GETSTICKYKEYS,

            SPI_SETSTICKYKEYS,

            SPI_GETACCESSTIMEOUT,

            SPI_SETACCESSTIMEOUT,

            SPI_GETSERIALKEYS,

            SPI_SETSERIALKEYS,

            SPI_GETSOUNDSENTRY,

            SPI_SETSOUNDSENTRY,

            SPI_GETSNAPTODEFBUTTON = 95u,

            SPI_SETSNAPTODEFBUTTON,

            SPI_GETMOUSEHOVERWIDTH = 98u,

            SPI_SETMOUSEHOVERWIDTH,

            SPI_GETMOUSEHOVERHEIGHT,

            SPI_SETMOUSEHOVERHEIGHT,

            SPI_GETMOUSEHOVERTIME,

            SPI_SETMOUSEHOVERTIME,

            SPI_GETWHEELSCROLLLINES,

            SPI_SETWHEELSCROLLLINES,

            SPI_GETMENUSHOWDELAY,

            SPI_SETMENUSHOWDELAY,

            SPI_GETSHOWIMEUI = 110u,

            SPI_SETSHOWIMEUI,

            SPI_GETMOUSESPEED,

            SPI_SETMOUSESPEED,

            SPI_GETSCREENSAVERRUNNING,

            SPI_GETDESKWALLPAPER,

            SPI_GETACTIVEWINDOWTRACKING = 4096u,

            SPI_SETACTIVEWINDOWTRACKING,

            SPI_GETMENUANIMATION,

            SPI_SETMENUANIMATION,

            SPI_GETCOMBOBOXANIMATION,

            SPI_SETCOMBOBOXANIMATION,

            SPI_GETLISTBOXSMOOTHSCROLLING,

            SPI_SETLISTBOXSMOOTHSCROLLING,

            SPI_GETGRADIENTCAPTIONS,

            SPI_SETGRADIENTCAPTIONS,

            SPI_GETKEYBOARDCUES,

            SPI_SETKEYBOARDCUES,

            SPI_GETMENUUNDERLINES = 4106u,

            SPI_SETMENUUNDERLINES,

            SPI_GETACTIVEWNDTRKZORDER,

            SPI_SETACTIVEWNDTRKZORDER,

            SPI_GETHOTTRACKING,

            SPI_SETHOTTRACKING,

            SPI_GETMENUFADE = 4114u,

            SPI_SETMENUFADE,

            SPI_GETSELECTIONFADE,

            SPI_SETSELECTIONFADE,

            SPI_GETTOOLTIPANIMATION,

            SPI_SETTOOLTIPANIMATION,

            SPI_GETTOOLTIPFADE,

            SPI_SETTOOLTIPFADE,

            SPI_GETCURSORSHADOW,

            SPI_SETCURSORSHADOW,

            SPI_GETMOUSESONAR,

            SPI_SETMOUSESONAR,

            SPI_GETMOUSECLICKLOCK,

            SPI_SETMOUSECLICKLOCK,

            SPI_GETMOUSEVANISH,

            SPI_SETMOUSEVANISH,

            SPI_GETFLATMENU,

            SPI_SETFLATMENU,

            SPI_GETDROPSHADOW,

            SPI_SETDROPSHADOW,

            SPI_GETBLOCKSENDINPUTRESETS,

            SPI_SETBLOCKSENDINPUTRESETS,

            SPI_GETUIEFFECTS = 4158u,

            SPI_SETUIEFFECTS,

            SPI_GETFOREGROUNDLOCKTIMEOUT = 8192u,

            SPI_SETFOREGROUNDLOCKTIMEOUT,

            SPI_GETACTIVEWNDTRKTIMEOUT,

            SPI_SETACTIVEWNDTRKTIMEOUT,

            SPI_GETFOREGROUNDFLASHCOUNT,

            SPI_SETFOREGROUNDFLASHCOUNT,

            SPI_GETCARETWIDTH,

            SPI_SETCARETWIDTH,

            SPI_GETMOUSECLICKLOCKTIME,

            SPI_SETMOUSECLICKLOCKTIME,

            SPI_GETFONTSMOOTHINGTYPE,

            SPI_SETFONTSMOOTHINGTYPE,

            SPI_GETFONTSMOOTHINGCONTRAST,

            SPI_SETFONTSMOOTHINGCONTRAST,

            SPI_GETFOCUSBORDERWIDTH,

            SPI_SETFOCUSBORDERWIDTH,

            SPI_GETFOCUSBORDERHEIGHT,

            SPI_SETFOCUSBORDERHEIGHT,

            SPI_GETFONTSMOOTHINGORIENTATION,

            SPI_SETFONTSMOOTHINGORIENTATION
        }

        [Flags]
        private enum SPIF
        {
            None = 0,

            SPIF_UPDATEINIFILE = 1,

            SPIF_SENDCHANGE = 2,

            SPIF_SENDWININICHANGE = 2
        }
    }
}