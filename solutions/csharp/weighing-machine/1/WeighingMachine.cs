using System;

class WeighingMachine
{
    private double _weight;
    private double _tareAdjustment = 5.0; 

    public int Precision { get; }

    public WeighingMachine(int precision)
    {
        Precision = precision;
    }

    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "Weight cannot be negative.");
            }
            _weight = value;
        }
    }

    public double TareAdjustment
    {
        get => _tareAdjustment;
        set => _tareAdjustment = value;
    }

    public string DisplayWeight
    {
        get
        {
            double displayValue = _weight - _tareAdjustment;
            return $"{displayValue.ToString($"F{Precision}")} kg";
        }
    }
}
