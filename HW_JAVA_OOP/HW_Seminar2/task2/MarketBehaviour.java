package HW_Seminar2.task2;

import HW_Seminar2.task1.Human;


public interface MarketBehaviour {

    void acceptToMarket(Human actor);  // добавляем в человека в магазин
    void releaseFromMarket(Human actor);   // удаляем из магазина человека (ПРОСТИТЕ ЗА СВОЕВОЛИЕ ... мы должны как-то понять, какого человека удаляем)
    void update();

}
