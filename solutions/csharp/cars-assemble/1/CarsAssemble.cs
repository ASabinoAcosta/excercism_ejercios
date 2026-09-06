static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if( speed == 0)
        {
            return 0;
        }
        else if(speed > 0 && speed <= 4)
        {
            return 1;
        }
        else if (speed >=5 && speed <=8)
        {
            return 0.90;
        }
        else if (speed==9)
        {
            return 0.80;
        }
        else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double successRate = SuccessRate(speed);
        int totalProd = speed*221;

        return totalProd * successRate;    
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        double totalMinutes = ProductionRatePerHour(speed)/60;
        int total =(int)totalMinutes;
        return total;
        
    }
}
