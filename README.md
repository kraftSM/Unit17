# Unit17 проект  Д/З по теме Design Patterns

- В исходном классе смасловая ошибка/опечатка  проценты то положительные то отрицательные, это не мненялось мной
- - Поскольку расчет процентов может быть актуален не толкь для счета (Account) но и для кредита,  в обявлен интерфейс, требующий реализвать эту опцию
- - в абстрактоном классе этот интерфейс реализован с константой (по умолчанию)
- - в нем же реализована перегрузка AsString() - в самом простом варианте, для просмотра свойств счета через коонсоль 
- - в наследниках этого абстрактоного класса делаем переопределениееё реализации для разных типов счетов. Пока их 2, но при необходимости список можно и расширить, точка для расширение уже заложена
- - Перечисление типов счетов не делалось, не ясно какие еще нужны -т.е задача пока не определена (ИзбыточногНеДелаем)
