namespace Playground.Api.Models;

public class Game {
    public string Name { get; set; }
    public bool IsOld { get; set; }
}

public class Car {
    public int Speed { get; set; }

    public Car(int baseSpeed) {
        Speed = baseSpeed;
    }

    public void Accelerate(int accelerateByAmount) {
        Speed = Speed + accelerateByAmount;
    }

    public void DoSomething() {

        var speed = 10;
        var accelerateByAmount = 30;

        speed = speed + accelerateByAmount;

        // ToDo: if, loops, arrays, classes



        var myMazda = new Car(10);

        print(myMazda.Speed);


        string name;

        int x = 5;
        bool h = false;
        string j = "Some text";

        double k = 2378.23;
        uint m = 87623;


        var t = m + k;


    }
}