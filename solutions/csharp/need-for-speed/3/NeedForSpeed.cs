class RemoteControlCar
{
    private int _speed;
    private int _battery = 100;
    private int _batteryDrain;
    private int _distanceDrive = 0;

    public RemoteControlCar(int speed, int batteryDrain) {
        this._speed = speed;
        this._batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        if (_battery < _batteryDrain) {
            return true;
        }
        return false;
    }

    public int DistanceDriven() => 
        _distanceDrive;

    public void Drive()
    {
        if (!BatteryDrained()) {
            _distanceDrive += _speed;
            _battery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() =>
        new RemoteControlCar(50, 4);

}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance) {
        this._distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        do{
            car.Drive();
        } while(!car.BatteryDrained());
            
        if (car.DistanceDriven() >= _distance) {
            return true;
        }
        else {
            return false;
        }
    }
}
