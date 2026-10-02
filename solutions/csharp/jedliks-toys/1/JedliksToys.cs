class RemoteControlCar
{
    private int _distance;
    private int _battery = 100;
    public static RemoteControlCar Buy()
    {
        var remoteCar = new RemoteControlCar();
        return remoteCar;
    }

    public string DistanceDisplay() =>
        $"Driven {_distance} meters";

    public string BatteryDisplay()
    {
        if (_battery == 0) {
            return "Battery empty";
        }
        return $"Battery at {_battery}%";
    }
        

    public void Drive()
    {
        if (_battery > 0) {
            _distance += 20;
            _battery -= 1; 
        }
    }
}
