//
// Generated file. Do not edit manually.
//

namespace Alba.CsCss.Style
{
    internal class LookAndFeel
    {
        public enum ColorID {
        
            // WARNING : NO NEGATIVE VALUE IN THIS ENUMERATION
            // see patch in bug 57757 for more information
        
            WindowBackground,
            WindowForeground,
            WidgetBackground,
            WidgetForeground,
            WidgetSelectBackground,
            WidgetSelectForeground,
            Widget3DHighlight,
            Widget3DShadow,
            TextBackground,
            TextForeground,
            TextSelectBackground,
            TextSelectForeground,
            TextSelectBackgroundDisabled,
            TextSelectBackgroundAttention,
            TextHighlightBackground,
            TextHighlightForeground,
        
            IMERawInputBackground,
            IMERawInputForeground,
            IMERawInputUnderline,
            IMESelectedRawTextBackground,
            IMESelectedRawTextForeground,
            IMESelectedRawTextUnderline,
            IMEConvertedTextBackground,
            IMEConvertedTextForeground,
            IMEConvertedTextUnderline,
            IMESelectedConvertedTextBackground,
            IMESelectedConvertedTextForeground,
            IMESelectedConvertedTextUnderline,
        
            SpellCheckerUnderline,
        
            // New CSS 2 color definitions
            activeborder,
            activecaption,
            appworkspace,
            background,
            buttonface,
            buttonhighlight,
            buttonshadow,
            buttontext,
            captiontext,
            graytext,
            highlight,
            highlighttext,
            inactiveborder,
            inactivecaption,
            inactivecaptiontext,
            infobackground,
            infotext,
            menu,
            menutext,
            scrollbar,
            threeddarkshadow,
            threedface,
            threedhighlight,
            threedlightshadow,
            threedshadow,
            window,
            windowframe,
            windowtext,
        
            _moz_buttondefault,
            // Colors which will hopefully become CSS3
            _moz_field,
            _moz_fieldtext,
            _moz_dialog,
            _moz_dialogtext,
            // used to highlight valid regions to drop something onto
            _moz_dragtargetzone,
        
            // used to cell text background, selected but not focus
            _moz_cellhighlight,
            // used to cell text, selected but not focus
            _moz_cellhighlighttext,
            // used to html select cell text background, selected but not focus
            _moz_html_cellhighlight,
            // used to html select cell text, selected but not focus
            _moz_html_cellhighlighttext,
            // used to button text background, when mouse is over
            _moz_buttonhoverface,
            // used to button text, when mouse is over
            _moz_buttonhovertext,
            // used to menu item background, when mouse is over
            _moz_menuhover,
            // used to menu item text, when mouse is over
            _moz_menuhovertext,
            // used to menu bar item text
            _moz_menubartext,
            // used to menu bar item text, when mouse is over
            _moz_menubarhovertext,
            // On platforms where these colors are the same as
            // -moz-field, use -moz-fieldtext as foreground color
            _moz_eventreerow,
            _moz_oddtreerow,
        
            // colors needed by the Mac OS X theme
        
            // background color of chrome toolbars in active windows
            _moz_mac_chrome_active,
            // background color of chrome toolbars in inactive windows
            _moz_mac_chrome_inactive,
            //ring around text fields and lists
            _moz_mac_focusring,
            //colour used when mouse is over a menu item
            _moz_mac_menuselect,
            //colour used to do shadows on menu items
            _moz_mac_menushadow,
            // color used to display text for disabled menu items
            _moz_mac_menutextdisable,
            //colour used to display text while mouse is over a menu item
            _moz_mac_menutextselect,
            // text color of disabled text on toolbars
            _moz_mac_disabledtoolbartext,
        
            //new in 10.2
        
            //active list highlight
            _moz_mac_alternateprimaryhighlight,
            //inactive light hightlight
            _moz_mac_secondaryhighlight,
        
            // vista rebars
        
            // media rebar text
            _moz_win_mediatext,
            // communications rebar text
            _moz_win_communicationstext,
        
            // Hyperlink color extracted from the system, not affected by the
            // browser.anchor_color user pref.
            // There is no OS-specified safe background color for this text, 
            // but it is used regularly within Windows and the Gnome DE on Dialog and
            // Window colors.
            _moz_nativehyperlinktext,
        
            // Combo box widgets
            _moz_comboboxtext,
            _moz_combobox,
        
            // keep this one last, please
            LAST_COLOR
          };

        public enum IntID {
            // default, may be overriden by OS
            CaretBlinkTime,
            // pixel width of caret
            CaretWidth,
            // show the caret when text is selected?
            ShowCaretDuringSelection,
            // select textfields when focused via tab/accesskey?
            SelectTextfieldsOnKeyFocus,
            // delay before submenus open
            SubmenuDelay,
            // can popups overlap menu/task bar?
            MenusCanOverlapOSBar,
            // show/hide scrollbars based on activity
            ShowHideScrollbars,
            // skip navigating to disabled menu item?
            SkipNavigatingDisabledMenuItem,
            // begin a drag if the mouse is moved further than the threshold while the
            // button is down
            DragThresholdX,
            DragThresholdY,
            // Accessibility theme being used?
            UseAccessibilityTheme,
        
            // position of scroll arrows in a scrollbar
            ScrollArrowStyle,
            // is scroll thumb proportional or fixed?
            ScrollSliderStyle,
        
            // each button can take one of four values:
            ScrollButtonLeftMouseButtonAction,
            // 0 - scrolls one  line, 1 - scrolls one page
            ScrollButtonMiddleMouseButtonAction,
            // 2 - scrolls to end, 3 - button ignored
            ScrollButtonRightMouseButtonAction,
        
            // delay for opening spring loaded folders
            TreeOpenDelay,
            // delay for closing spring loaded folders
            TreeCloseDelay,
            // delay for triggering the tree scrolling
            TreeLazyScrollDelay,
            // delay for scrolling the tree
            TreeScrollDelay,
            // the maximum number of lines to be scrolled at ones
            TreeScrollLinesMax,
            // What type of tab-order to use
            TabFocusModel,
            // Should menu items blink when they're chosen?
            ChosenMenuItemsShouldBlink,
        
            /*
             * A Boolean value to determine whether the Windows default theme is
             * being used.
             *
             * The value of this metric is not used on other platforms. These platforms
             * should return NS_ERROR_NOT_IMPLEMENTED when queried for this metric.
             */
            WindowsDefaultTheme,
        
            /*
             * A Boolean value to determine whether the DWM compositor is being used
             *
             * This metric is not used on non-Windows platforms. These platforms
             * should return NS_ERROR_NOT_IMPLEMENTED when queried for this metric.
             */
            DWMCompositor,
        
            /*
             * A Boolean value to determine whether Windows is themed (Classic vs.
             * uxtheme)
             *
             * This is Windows-specific and is not implemented on other platforms
             * (will return the default of NS_ERROR_FAILURE).
             */
            WindowsClassic,
        
            /*
             * A Boolean value to determine whether the current Windows desktop theme
             * supports Aero Glass.
             *
             * This is Windows-specific and is not implemented on other platforms
             * (will return the default of NS_ERROR_FAILURE).
             */
            WindowsGlass,
        
            /*
             * A Boolean value to determine whether the device is a touch enabled
             * device. Currently this is only supported by the Windows 7 Touch API.
             *
             * Platforms that do not support this metric should return
             * NS_ERROR_NOT_IMPLEMENTED when queried for this metric.
             */
            TouchEnabled,
        
            /*
             * A Boolean value to determine whether the Mac graphite theme is
             * being used.
             *
             * The value of this metric is not used on other platforms. These platforms
             * should return NS_ERROR_NOT_IMPLEMENTED when queried for this metric.
             */
            MacGraphiteTheme,
        
            /*
             * A Boolean value to determine whether the Mac OS X Lion-specific theming
             * should be used.
             *
             * The value of this metric is not used on non-Mac platforms. These
             * platforms should return NS_ERROR_NOT_IMPLEMENTED when queried for this
             * metric.
             */
            MacLionTheme,
        
            /*
             * A Boolean value to determine whether Mameo is using the new Fremantle
             * theme.
             *
             * The value of this metric is not used on other platforms. These platforms
             * should return NS_ERROR_NOT_IMPLEMENTED when queried for this metric.
             */
            MaemoClassic,
        
            /*
             * AlertNotificationOrigin indicates from which corner of the
             * screen alerts slide in, and from which direction (horizontal/vertical).
             * 0, the default, represents bottom right, sliding vertically.
             * Use any bitwise combination of the following constants:
             * NS_ALERT_HORIZONTAL (1), NS_ALERT_LEFT (2), NS_ALERT_TOP (4).
             *
             *       6       4
             *     +-----------+
             *    7|           |5
             *     |           |
             *    3|           |1
             *     +-----------+
             *       2       0
             */
            AlertNotificationOrigin,
        
            /**
             * If true, clicking on a scrollbar (not as in dragging the thumb) defaults
             * to scrolling the view corresponding to the clicked point. Otherwise, we
             * only do so if the scrollbar is clicked using the middle mouse button or
             * if shift is pressed when the scrollbar is clicked.
             */
            ScrollToClick,
        
            /**
             * IME and spell checker underline styles, the values should be
             * NS_DECORATION_LINE_STYLE_*.  They are defined below.
             */
            IMERawInputUnderlineStyle,
            IMESelectedRawTextUnderlineStyle,
            IMEConvertedTextUnderlineStyle,
            IMESelectedConvertedTextUnderline,
            SpellCheckerUnderlineStyle,
        
            /**
             * If this metric != 0, show icons in menus.
             */
            ImagesInMenus,
            /**
             * If this metric != 0, show icons in buttons.
             */
            ImagesInButtons,
            /**
             * If this metric != 0, support window dragging on the menubar.
             */
            MenuBarDrag,
            /**
             * Return the appropriate WindowsThemeIdentifier for the current theme.
             */
            WindowsThemeIdentifier,
            /**
             * 0: scrollbar button repeats to scroll only when cursor is on the button.
             * 1: scrollbar button repeats to scroll even if cursor is outside of it.
             */
            ScrollbarButtonAutoRepeatBehavior,
            /**
             * Dealy before showing a tooltip.
             */
            TooltipDelay
          };

        public enum WindowsTheme {
            Generic = 0, // unrecognized theme
            Classic,
            Aero,
            LunaBlue,
            LunaOlive,
            LunaSilver,
            Royale,
            Zune
          };

        public enum FloatID {
            IMEUnderlineRelativeSize,
            SpellCheckerUnderlineRelativeSize,
        
            // The width/height ratio of the cursor. If used, the CaretWidth int metric
            // should be added to the calculated caret width.
            CaretAspectRatio
          };

        public enum FontID {
            Caption = 1,     // css2
            Icon,
            Menu,
            MessageBox,
            SmallCaption,
            StatusBar,
        
            Window,          // css3
            Document,
            Workspace,
            Desktop,
            Info,
            Dialog,
            Button,
            PullDownMenu,
            List,
            Field,
        
            Tooltips,        // moz
            Widget
          };

    }
}
