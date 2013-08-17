//
// Generated file. Do not edit manually.
//

using System.Collections.Generic;

namespace Alba.CsCss.Style
{
    using nsMediaFeature = CssMediaFeature;

    internal partial class nsMediaFeatures
    {
        private static readonly List<CssMediaFeature> features = new List<CssMediaFeature> {
            new nsMediaFeature(nsGkAtoms.width, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Length),
            new nsMediaFeature(nsGkAtoms.height, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Length),
            new nsMediaFeature(nsGkAtoms.deviceWidth, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Length),
            new nsMediaFeature(nsGkAtoms.deviceHeight, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Length),
            new nsMediaFeature(nsGkAtoms.orientation, nsMediaFeature.RangeType.MinMaxNotAllowed, nsMediaFeature.ValueType.Enumerated, nsCSSProps.kOrientationKeywords),
            new nsMediaFeature(nsGkAtoms.aspectRatio, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.IntRatio),
            new nsMediaFeature(nsGkAtoms.deviceAspectRatio, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.IntRatio),
            new nsMediaFeature(nsGkAtoms.color, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Integer),
            new nsMediaFeature(nsGkAtoms.colorIndex, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Integer),
            new nsMediaFeature(nsGkAtoms.monochrome, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Integer),
            new nsMediaFeature(nsGkAtoms.resolution, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Resolution),
            new nsMediaFeature(nsGkAtoms.scan, nsMediaFeature.RangeType.MinMaxNotAllowed, nsMediaFeature.ValueType.Enumerated, nsCSSProps.kScanKeywords),
            new nsMediaFeature(nsGkAtoms.grid, nsMediaFeature.RangeType.MinMaxNotAllowed, nsMediaFeature.ValueType.BoolInteger),
              // Mozilla extensions
            new nsMediaFeature(nsGkAtoms._moz_device_pixel_ratio, nsMediaFeature.RangeType.MinMaxAllowed, nsMediaFeature.ValueType.Float),
            new nsMediaFeature(nsGkAtoms._moz_device_orientation, nsMediaFeature.RangeType.MinMaxNotAllowed, nsMediaFeature.ValueType.Enumerated, nsCSSProps.kOrientationKeywords),
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
