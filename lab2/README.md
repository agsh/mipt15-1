## Lab2
### Описание

В этой лабораторной вам предстоит работать со списками, полученными в результате разбора веб-страниц.
Для этих целей используются библиотеки [FSharp.Data](https://fsharp.github.io/FSharp.Data/library/HtmlParser.html) и [*-conduit](https://github.com/snoyberg/xml). Они позволяют изящно разбирать и запрашивать данные из таких иерархических структур как json, xml, html. В нашем случае мы будем работать с html-страницами, запрашивать содержимое тэгов с помощью селекторов и получать нужные нам данные в последовательностях и списках соответственно.

Примеры работы с библиотеками для каждого из языков находятся в соответствующих boilerplate-файлах: [Lab2.fs](./Lab2.fs) и [Lab2.hs](./Lab2.hs). И в интернете: [FSharp.Data](https://fsharp.github.io/FSharp.Data/library/HtmlParser.html), [html-conduit](https://www.fpcomplete.com/school/starting-with-haskell/libraries-and-frameworks/text-manipulation/tagsoup)

### Установка библиотек
#### FSharp
Через NuGet: `Install-Package FSharp.Data `. Или через nuget-плагин для monodevelop.
#### Haskell
С использованием cabal: `cabal install xml-conduit http-conduit html-conduit`

### Вопросы
Вполне вероятно, что некоторые страницы будут парситься некорректно, данные будет сложно извлечь, возникнут проблемы с кодировкой. Все эти и другие вопросы, как обычно, задавайте в issue.

### Задание
|Вариант|Задание|
|---|---|
|1|По [списку языков программирования](http://en.wikipedia.org/wiki/List_of_programming_languages) википедии составить список императивных, не функциональных ЯП.|
|2|По [списку языков программирования](http://en.wikipedia.org/wiki/List_of_programming_languages) википедии составить список кортежей: год  появления, названия. Языки без указания годов появления исключить.|
|3|По [списку телефонных номеров МФТИ](http://mipt.ru/about/general/contacts/phones.php) выяснить, кто делит один номер с коллегами. Телефонные номера нормализовать|
|4|Узнать, в каком году было больше и меньше всего [выпускников](http://mipt.ru/dafe/graduaters/) факультета аэромеханики и летательной техники|
|5|Составить список 50 самых умных и самых строгих [преподавателей](http://wikimipt.org/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9F%D1%80%D0%B5%D0%BF%D0%BE%D0%B4%D0%B0%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83)|
|6|Составить список из ФИО [преподавателей](http://wikimipt.org/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9F%D1%80%D0%B5%D0%BF%D0%BE%D0%B4%D0%B0%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83) и их страниц в соц.сетях (linkedin, facebook, vk)|
|7|Составить список [выпускников ФИВТ](https://vk.com/fivtmipt), которые [любят КВН](https://vk.com/ligakvnmfti)|
|8|Составить список 50 самых комментируемых [преподавателей](http://wikimipt.org/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9F%D1%80%D0%B5%D0%BF%D0%BE%D0%B4%D0%B0%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83)|
|9|Составить список 50 комментариев для [преподавателей](http://wikimipt.org/index.php?title=%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9F%D1%80%D0%B5%D0%BF%D0%BE%D0%B4%D0%B0%D0%B2%D0%B0%D1%82%D0%B5%D0%BB%D0%B8_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83) с самой высокой оценкой|
|10|Найти средний возраст участников [студсовета ФИВТ](http://vk.com/stfivt)|
|11|Отсортировать список [git-проектов Haskell](https://github.com/haskell), которые проходят тесты на Travis CI по количеству веток|
|12|Выяснить, какой процент из топ-500 проектов на языках Haskell и F# на github с наибольшим количеством звёзд составляют [проекты на F#](https://github.com/search?utf8=%E2%9C%93&q=language%3AF%23&type=Repositories&ref=advsearch&l=F%23)|
|13|Составить частоту обновлений [проектов на F#](https://github.com/search?utf8=%E2%9C%93&q=language%3AF%23&type=Repositories&ref=advsearch&l=F%23) на github (в течении последнего месяца, двух, и т.д.)|
|14|Узнать, от какой библиотеки зависит больше всего запрещённых [пакетов на hackage](http://hackage.haskell.org/packages/deprecated)|
|15|Найти пять самых скачиваемых пакетов за всё время на [hackage](http://hackage.haskell.org/packages/top)|
|16|Какой процент составляют issue с комментариями от общего количества issue для [NuGet](https://github.com/nuget/home/issues?page=1&q=is%3Aissue+is%3Aopen)?|
|17|Какое количество [разработчиков NuGet](https://nuget.codeplex.com/team/view) уже переехали на github, если судить по их никам?|
|18|Кто из [разработчиков Microsoft](https://github.com/Microsoft) на github ведёт блог на blogs.msdn.com и указал его в профиле?|
|19|Попытаться найти по [списку языков программирования](http://en.wikipedia.org/wiki/List_of_programming_languages) википедии человека, который разработал больше всего ЯП|
|20|Какое количество ссылок на [странице о LISP](https://www.linux.org.ru/wiki/en/%D0%A7%D0%B0%D1%81%D1%82%D1%8C_1._%D0%9E%D0%B1%D1%89%D0%B8%D0%B5_%D0%B2%D0%BE%D0%BF%D1%80%D0%BE%D1%81%D1%8B_%D0%BE_Lisp) ведут на англоязычные ресурсы, а какие - на русскоязычные?|
|21|Под какой лицензией выпущено большинство [проектов на F#](https://github.com/search?utf8=%E2%9C%93&q=language%3AF%23&type=Repositories&ref=advsearch&l=F%23) на github, если судить по файлу LICENSE?|
|22|Сколько пакетов в [Hackage](http://hackage.haskell.org/packages/) относятся к нескольким категориям?
|23|У какого факультета ФИВТ больше всего [кафедр](http://wikimipt.org/wiki/%D0%9A%D0%B0%D1%82%D0%B5%D0%B3%D0%BE%D1%80%D0%B8%D1%8F:%D0%9A%D0%B0%D1%84%D0%B5%D0%B4%D1%80%D1%8B_%D0%BF%D0%BE_%D0%B0%D0%BB%D1%84%D0%B0%D0%B2%D0%B8%D1%82%D1%83)?
|24|Сколько музыкальных групп всего с одним треком находится в [чарте last.fm](http://www.last.fm/charts/tracks/top/place/Russian+Federation?limit=100) top100 композиций по РФ?|
|25|Какие группы появлялись в чартах last.fm с [2008](http://www.last.fm/bestof/2008) по [2013](http://www.last.fm/bestof/2013) года (исключая 2012) больше всего раз?|
|26|Кто, кроме anonymous'а оставил больше всего комментариев в [этой теме](https://www.linux.org.ru/news/google/11404954)?|
|27|Какой тэг самый популярный среди ста самых популярных пакетов на [NuGet](https://www.nuget.org/stats/packages)?
|28|В каком месяце какого года было больше всего вопросов в [рассылке эрланга](http://erlang.org/pipermail/erlang-questions/)?|
