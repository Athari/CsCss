// ReSharper disable TypeParameterCanBeVariant

namespace Alba.CsCss.Style
{
    internal interface ICalcOpsInput<TInput>
    {
        TInput[] GetArrayValue ();
    }
}