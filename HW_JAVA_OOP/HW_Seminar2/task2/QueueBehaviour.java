package HW_Seminar2.task2;

import HW_Seminar2.task1.Actor;


public interface QueueBehaviour {        // признаюсь честно, так и не пришло доскональное понимание того, зачем нужен интерфейс в данной задаче ... и без него все делается замечательно. Или что-то путаю?

    void takeInQueue(Actor actor);  // очередь
    void takeOrders(Actor actor);
    void giveOrders(Actor actor);
    void releaseFromQueue(Actor actor);

}
