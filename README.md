Так и не получилось у меня придумать, как сделать одно задание на всех на первую лабу, поэтому:

# Лабораторная работа №0

В директории lab0 находятся файлы шаблонов lab0.fs и lab0.hs.
Вам нужно их отредактировать:
- не забыть вписать адрес своей почты и фамилию с инициалами
- написать функцию pascal

Задание взято из курса по скале, занимает 3-4 строчки.

> The following pattern of numbers is called Pascal’s triangle.
>
> 1
>
> 1 1
>
> 1 2 1
>
> 1 3 3 1
>
> 1 4 6 4 1
>
> The numbers at the edge of the triangle are all 1, and each number inside the triangle is the sum
> of the two numbers above it. Write a function that computes the elements of Pascal’s triangle by
> means of a recursive process.
> Do this exercise by implementing the pascal function, which takes a column c and a row r,
> counting from 0 and returns the number at that spot in the triangle. For example, pascal(0,2)=1,
> pascal(1,2)=2 and pascal(1,3)=3.

Посмотреть, что у вас получается можно с помощью функции `printIt` (int -> string), которая выводит n-строчек треугольника в списке.

После того как вы всё напишете и проверите, вызывайте функцию `main`, которая отправит постом результаты вычисления первых 20 строчек.
Отправлять можно неограниченное число раз, адрес почты является первичным ключом.

Ваши результаты можно посмотреть здесь: http://mipt.eu01.aws.af.cm/labs

Ввиду того, что чтение из БД идёт с крайне медленных реплик, результаты обновляются не сразу.
Из-за этого, а ещё из-за своих возможных ошибок в коде оставляю за собой право менять варианты задания по своему усмотрению.

Программистам на хаскелле нужно будет поставить библиотеку http-conduit:
`cabal install http-conduit`

### Если у вас появятся какие-либо вопросы, оформляйте их как issue.
