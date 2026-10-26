using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x6f33ba4a : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x4528a087 != null)
            return;
        GameObject _0xdc05ed25 = new GameObject(_0x65337d39._0xcd9e9199(new byte[16] { 185, 128, 157, 174, 130, 131, 153, 159, 140, 158, 153, 170, 152, 140, 159, 137 }, 237));
        _0xdc05ed25.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xdc05ed25);
        _0x4528a087 = _0xdc05ed25.AddComponent<_0x6f33ba4a>();
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x521a1857)
    {
        return 0.2126f * Linear(_0x521a1857.r) + 0.7152f * Linear(_0x521a1857.g) + 0.0722f * Linear(_0x521a1857.b);
    }

    private readonly HashSet<TMP_Text> _0x02424de4 = new HashSet<TMP_Text>();
    private static _0x6f33ba4a _0x4528a087;
    private const float TargetRatio = 7f;
    private const float MinOutlineWidth = 0.01f;
    private void OnEnable()
    {
        if (this._0xb7ec5e6a == null)
            this._0xb7ec5e6a = _0x241e81cd => this._0xef997504(_0x241e81cd);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0xb7ec5e6a);
    }

    private readonly List<TMP_Text> _0x7d619fb4 = new List<TMP_Text>();
    private static void Fix(TMP_Text _0xef06b5c2)
    {
        if (_0xef06b5c2 == null || !_0xef06b5c2.isActiveAndEnabled)
            return;
        Material _0x5522f349 = _0xef06b5c2.fontSharedMaterial;
        if (_0x5522f349 == null || !_0x5522f349.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x5522f349.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x5522f349.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xbef8d35d = _0xef06b5c2.color;
        if (_0xbef8d35d.a <= 0f)
            return;
        Color _0x64178046 = _0x5522f349.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xbef8d35d, _0x64178046) >= MinRatio)
            return;
        Color _0xf465e6ce = Luminance(_0x64178046) < 0.5f ? Color.white : Color.black;
        Color _0x7476fa98;
        if (Ratio(_0xf465e6ce, _0x64178046) < TargetRatio)
        {
            _0x7476fa98 = _0xf465e6ce;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0xf886b1a3 = 0f;
            float _0x3b90ef4f = 1f;
            for (int _0xa5c4685f = 0; _0xa5c4685f < 20; _0xa5c4685f++)
            {
                float _0xbba35996 = (_0xf886b1a3 + _0x3b90ef4f) * 0.5f;
                if (Ratio(Color.Lerp(_0xbef8d35d, _0xf465e6ce, _0xbba35996), _0x64178046) >= TargetRatio)
                    _0x3b90ef4f = _0xbba35996;
                else
                    _0xf886b1a3 = _0xbba35996;
            }

            _0x7476fa98 = Color.Lerp(_0xbef8d35d, _0xf465e6ce, _0x3b90ef4f);
        }

        _0x7476fa98.a = _0xbef8d35d.a;
        _0xef06b5c2.color = _0x7476fa98;
    }

    private const float MinRatio = 4.5f;
    private void LateUpdate()
    {
        if (this._0x02424de4.Count == 0)
            return;
        this._0x7d619fb4.Clear();
        this._0x7d619fb4.AddRange(this._0x02424de4);
        this._0x02424de4.Clear();
        for (int _0x2a7a900d = 0; _0x2a7a900d < this._0x7d619fb4.Count; _0x2a7a900d++)
            Fix(this._0x7d619fb4[_0x2a7a900d]);
    }

    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0xb7ec5e6a;
    private void OnDisable()
    {
        if (this._0xb7ec5e6a != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0xb7ec5e6a);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xef997504(Object _0xc599a32e)
    {
        TMP_Text _0x8ae3282d = _0xc599a32e as TMP_Text;
        if (_0x8ae3282d != null)
            this._0x02424de4.Add(_0x8ae3282d);
    }

    private static float Ratio(Color _0x92537fc1, Color _0xc3591083)
    {
        float _0xcc44747c = Luminance(_0x92537fc1);
        float _0xada3532d = Luminance(_0xc3591083);
        return (Mathf.Max(_0xcc44747c, _0xada3532d) + 0.05f) / (Mathf.Min(_0xcc44747c, _0xada3532d) + 0.05f);
    }

    private static float Linear(float _0x4ccc7692)
    {
        _0x4ccc7692 = Mathf.Clamp01(_0x4ccc7692);
        return _0x4ccc7692 <= 0.03928f ? _0x4ccc7692 / 12.92f : Mathf.Pow((_0x4ccc7692 + 0.055f) / 1.055f, 2.4f);
    }
}

internal static class _0x65337d39
{
    internal static string _0xcd9e9199(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}