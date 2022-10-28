# head_first_patterns_Examples

## Зміст   
1. [Strategy](#Strategy)
2. [Observer](#Observer)

## Strategy
```Означення :``` Паттерн Стратегія визначає сімейство алгоритмів, інкапсулює кожен із них та забезпечує їх взаємозамінність. \
Він дозволяє модифікувати алгоритми незалежно від їх використання на стороні клієнта. 

В данному коді він разом з DI використовуються для інкапсуляції поведінки(політ , кракання) різних "качок".
![alt text](https://github.com/pflofif/head_first_patterns_Examples/blob/master/Head%20First.%20Examples/architecture%20image/Type%20Dependencies%20Diagram%20for%20FlyNoWay%20and%20other%20elements.png)

[:arrow_up:Зміст](#Зміст)

## Observer
```Означення :``` визначає залежність типу «один до багатьох» між об'єктами таким чином, що при зміні стану одного об'єкта , всі, що залежать від нього сповіщаються про це та автоматично оновлюються. 

В данному коді він використовується для проєктування сервісу "прогнозу погоди". При отриманні нових данних клас "погоди" повідомляє клієнтів(класи , що відповідають за відображення данних на екран) про зміни данних, і вони оновлюють вивід.
![alt text](https://github.com/pflofif/head_first_patterns_Examples/blob/project_refactor/Images/Observer.png)

[:arrow_up:Зміст](#Зміст)
