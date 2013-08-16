// ReSharper disable TypeParameterCanBeVariant

namespace Alba.CsCss.Style
{
    using TUnit = CssUnit;

    // Here TInput is CssValue and TResult is float, but original code contains more combinations.
    internal interface ICalcOps<TInput, TResult>
        where TInput : ICalcOpsInput<TInput>
    {
        TUnit GetUnit (TInput aValue);
        TResult MergeAdditive (TUnit aCalcFunction, TResult aValue1, TResult aValue2);
        TResult MergeMultiplicativeL (TUnit aCalcFunction, TResult aValue1, TResult aValue2);
        TResult MergeMultiplicativeR (TUnit aCalcFunction, TResult aValue1, TResult aValue2);
        TResult ComputeLeafValue (TInput aValue);
        TResult ComputeNumber (TInput aValue);
    }
}