using ClassDemo;

Lamp lamp = new Lamp();
lamp.TurnOn();
lamp.TurnOff();
lamp.SetBrightness(100);


Thermostat thermostat = new Thermostat();
thermostat.TurnOn();
thermostat.TurnOff();
thermostat.SetTemperature(25);


ClassDemo.Lock doorlock = new ClassDemo.Lock(); //pochemu me tak napisali potomu chto v sistema nawyol vstroeniy class is biblioteki same nama[Lock]
doorlock.TurnOn();
doorlock.TurnOff();
doorlock.LockDoor();
doorlock.UnLockDoor();