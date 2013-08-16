//
// Generated file. Do not edit manually.
//

using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    internal partial class nsMediaFeatures
    {
        private static readonly List<CssMediaFeature> features = new List<CssMediaFeature> {
            new CssMediaFeature(nsGkAtoms.width, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Length),
            new CssMediaFeature(nsGkAtoms.height, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Length),
            new CssMediaFeature(nsGkAtoms.deviceWidth, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Length),
            new CssMediaFeature(nsGkAtoms.deviceHeight, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Length),
            new CssMediaFeature(nsGkAtoms.orientation, CssMediaFeature.RangeType.MinMaxNotAllowed, CssMediaFeature.ValueType.Enumerated, nsCSSProps.kOrientationKeywords),
            new CssMediaFeature(nsGkAtoms.aspectRatio, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.IntRatio),
            new CssMediaFeature(nsGkAtoms.deviceAspectRatio, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.IntRatio),
            new CssMediaFeature(nsGkAtoms.color, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Integer),
            new CssMediaFeature(nsGkAtoms.colorIndex, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Integer),
            new CssMediaFeature(nsGkAtoms.monochrome, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Integer),
            new CssMediaFeature(nsGkAtoms.resolution, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Resolution),
            new CssMediaFeature(nsGkAtoms.scan, CssMediaFeature.RangeType.MinMaxNotAllowed, CssMediaFeature.ValueType.Enumerated, nsCSSProps.kScanKeywords),
            new CssMediaFeature(nsGkAtoms.grid, CssMediaFeature.RangeType.MinMaxNotAllowed, CssMediaFeature.ValueType.BoolInteger),
              // Mozilla extensions
            new CssMediaFeature(nsGkAtoms._moz_device_pixel_ratio, CssMediaFeature.RangeType.MinMaxAllowed, CssMediaFeature.ValueType.Float),
            new CssMediaFeature(nsGkAtoms._moz_device_orientation, CssMediaFeature.RangeType.MinMaxNotAllowed, CssMediaFeature.ValueType.Enumerated, nsCSSProps.kOrientationKeywords),
            // nsGkAtoms._moz_is_resource_document,
            // nsGkAtoms._moz_scrollbar_start_backward,
            // nsGkAtoms._moz_scrollbar_start_forward,
            // nsGkAtoms._moz_scrollbar_end_backward,
            // nsGkAtoms._moz_scrollbar_end_forward,
            // nsGkAtoms._moz_scrollbar_thumb_proportional,
            // nsGkAtoms._moz_images_in_menus,
            // nsGkAtoms._moz_images_in_buttons,
            // nsGkAtoms._moz_windows_default_theme,
            // nsGkAtoms._moz_mac_graphite_theme,
            // nsGkAtoms._moz_mac_lion_theme,
            // nsGkAtoms._moz_windows_compositor,
            // nsGkAtoms._moz_windows_classic,
            // nsGkAtoms._moz_windows_glass,
            // nsGkAtoms._moz_touch_enabled,
            // nsGkAtoms._moz_maemo_classic,
            // nsGkAtoms._moz_menubar_drag,
            // nsGkAtoms._moz_windows_theme,
              // Internal -moz-is-glyph media feature: applies only inside SVG glyphs.
            // Internal because it is really only useful in the user agent anyway
            //  and therefore not worth standardizing.
            // nsGkAtoms._moz_is_glyph,
            // Null-mName terminator:
            // null,
            //new CssMediaFeature()
        };

        private static readonly CssMediaFeature EmptyFeature = new CssMediaFeature();
    }
}
