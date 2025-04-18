using CommunityToolkit.Mvvm.ComponentModel;

namespace Tkmm.Core.TkOptimizer.Models.ValueTypes;

public sealed partial class TkOptimizerFloatingPointRangeValue(TkOptimizerContext context, double @default) : TkOptimizerValue<double>(context, @default)
{
    [ObservableProperty]
    private double _minValue;
    
    [ObservableProperty]
    private double _maxValue;
    
    [ObservableProperty]
    private double _incrementSize; 
}