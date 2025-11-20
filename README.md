# Товарно-складская система / Kaupade-lao süsteem

## Описание / Kirjeldus

**Русский:** Система управления складом и магазином с поддержкой двух языков (русский/эстонский). Включает управление товарами, категориями и процессом покупки.

**Eesti:** Lao ja poe haldussüsteem kahe keele toega (vene/eesti). Sisaldab kaupade, kategooriate ja ostuprotsessi haldamist.

---

## Структура приложения / Rakenduse struktuur

### 1. MenuForm - Главное меню / Peamenüü

#### Функции / Funktsioonid:

**Русский:**
- **Переключение языка** - Кнопка EST/RUS для смены интерфейса
- **Переход в склад** - Открытие формы управления складом
- **Переход в магазин** - Открытие формы покупок
- **Завершение приложения** - Закрытие всей программы при закрытии меню

**Eesti:**
- **Keele vahetamine** - EST/RUS nupp liidese muutmiseks
- **Lattu minek** - Lao halduse vormi avamine
- **Poodi minek** - Ostuvormide avamine
- **Rakenduse sulgemine** - Kogu programmi sulgemine menüü sulgemisel

#### Основные методы / Peamised meetodid:

- `btnLanguage_Click()` - Переключение языка / Keele vahetamine
- `UpdateLanguage()` - Обновление текстов интерфейса / Liidese tekstide uuendamine
- `OpenForm<T>()` - Универсальный метод открытия форм / Universaalne vormide avamise meetod

---

### 2. Form1 - Склад товаров / Kaupade ladu

#### Основные функции / Peamised funktsioonid:

**Русский:**
- **Управление категориями** - Добавление и удаление категорий товаров
- **Управление товарами** - CRUD операции с товарами
- **Работа с изображениями** - Загрузка и отображение фото товаров
- **Автозаполнение полей** - При выборе товара в таблице
- **Валидация данных** - Проверка корректности введенных данных

**Eesti:**
- **Kategooriate haldamine** - Kaupade kategooriate lisamine ja kustutamine
- **Kaupade haldamine** - CRUD operatsioonid kaupadega
- **Piltidega töötamine** - Kaupade fotode üleslaadimine ja kuvamine
- **Väljade automaatne täitmine** - Kauba valimisel tabelist
- **Andmete valideerimine** - Sisestatud andmete õigsuse kontroll

#### Детальное описание сложных функций / Keerukate funktsioonide üksikasjalik kirjeldus:

##### `lisaBtn_Click_1()` - Добавление товара / Kauba lisamine

**Русский:**
1. **Валидация полей** - Проверяет заполненность всех обязательных полей
2. **Проверка категории** - Ищет ID категории в базе данных
3. **Валидация чисел** - Проверяет корректность количества и цены
4. **Работа с изображениями** - Сохраняет изображение как байтовый массив
5. **Транзакция БД** - Безопасное добавление в базу данных
6. **Очистка формы** - Автоматическая очистка полей после добавления

**Eesti:**
1. **Väljade valideerimine** - Kontrollib kõigi kohustuslike väljade täitmist
2. **Kategooria kontroll** - Otsib kategooria ID andmebaasist
3. **Numbrite valideerimine** - Kontrollib koguse ja hinna õigsust
4. **Piltidega töötamine** - Salvestab pildi baitide massiivina
5. **AB transaktsioon** - Turvaline lisamine andmebaasi
6. **Vormi puhastamine** - Automaatne väljade puhastamine pärast lisamist

##### `uuendaBtn_Click()` - Обновление товара / Kauba uuendamine

**Русский:**
1. **Получение данных из таблицы** - Берет данные из выбранной строки GridView
2. **Автоматическое заполнение** - Не требует ручного ввода данных
3. **Поиск категории** - Находит ID категории по названию
4. **Обновление БД** - Выполняет UPDATE запрос с параметрами
5. **Обновление интерфейса** - Перезагружает таблицу и очищает поля

**Eesti:**
1. **Andmete hankimine tabelist** - Võtab andmed valitud GridView reast
2. **Automaatne täitmine** - Ei nõua käsitsi andmete sisestamist
3. **Kategooria otsimine** - Leiab kategooria ID nime järgi
4. **AB uuendamine** - Teostab UPDATE päringu parameetritega
5. **Liidese uuendamine** - Laadib tabeli uuesti ja puhastab väljad

##### `ShowPopupImage()` - Всплывающее изображение / Hüpikpilt

**Русский:**
1. **Создание формы** - Создает временную форму без рамок
2. **Настройка отображения** - Устанавливает прозрачность и размер
3. **Позиционирование** - Размещает рядом с ячейкой таблицы
4. **Управление ресурсами** - Правильно освобождает память
5. **Обработка событий** - Закрывается при уходе мыши

**Eesti:**
1. **Vormi loomine** - Loob ajutise vormi ilma raamideta
2. **Kuvamise seadistamine** - Määrab läbipaistvuse ja suuruse
3. **Positsioonimine** - Paigutab tabeli lahtri kõrvale
4. **Ressursside haldamine** - Vabastab mälu õigesti
5. **Sündmuste töötlemine** - Sulgub hiire lahkumisel

---

### 3. ShopForm - Магазин / Pood

#### Основные функции / Peamised funktsioonid:

**Русский:**
- **Просмотр по категориям** - Навигация товаров через категории
- **Корзина покупок** - Добавление товаров и управление заказом
- **Обработка покупок** - Транзакционная обработка заказов
- **Контроль остатков** - Проверка наличия товаров на складе
- **Отображение изображений** - Просмотр фото выбранных товаров

**Eesti:**
- **Kategooriate järgi sirvimine** - Kaupade navigeerimine kategooriate kaudu
- **Ostukorv** - Kaupade lisamine ja tellimuse haldamine
- **Ostude töötlemine** - Tellimuste transaktsioonipõhine töötlemine
- **Jääkide kontroll** - Kaupade olemasolu kontroll laos
- **Piltide kuvamine** - Valitud kaupade fotode vaatamine

#### Детальное описание сложных функций / Keerukate funktsioonide üksikasjalik kirjeldus:

##### `LoadProductsByCategory()` - Загрузка товаров по категории / Kaupade laadimine kategooria järgi

**Русский:**
1. **Параметризованный запрос** - Использует безопасные SQL параметры
2. **Фильтрация остатков** - Показывает только товары с количеством > 0
3. **Создание объектов** - Преобразует DataRow в ProductItem объекты
4. **Обработка изображений** - Корректно работает с byte[] данными
5. **Обновление интерфейса** - Очищает и заполняет список товаров

**Eesti:**
1. **Parameetritega päring** - Kasutab turvaliseid SQL parameetreid
2. **Jääkide filtreerimine** - Näitab ainult kaupu kogusega > 0
3. **Objektide loomine** - Teisendab DataRow ProductItem objektideks
4. **Piltide töötlemine** - Töötab õigesti byte[] andmetega
5. **Liidese uuendamine** - Puhastab ja täidab kaupade nimekirja

##### `btnPurchase_Click()` - Обработка покупки / Ostu töötlemine

**Русский:**
1. **Валидация корзины** - Проверяет наличие товаров в корзине
2. **Создание транзакции** - Начинает SQL транзакцию для безопасности
3. **Проверка остатков** - Для каждого товара проверяет наличие на складе
4. **Атомарное обновление** - Все изменения или откат при ошибке
5. **Обновление интерфейса** - Очищает корзину и обновляет товары
6. **Обработка ошибок** - Rollback при недостатке товаров

**Eesti:**
1. **Ostukorvi valideerimine** - Kontrollib kaupade olemasolu ostukorvis
2. **Transaktsiooni loomine** - Alustab SQL transaktsiooni turvalisuse jaoks
3. **Jääkide kontroll** - Iga kauba puhul kontrollib olemasolu laos
4. **Aatomne uuendamine** - Kõik muudatused või tagasipööramine vea korral
5. **Liidese uuendamine** - Puhastab ostukorvi ja uuendab kaupu
6. **Vigade töötlemine** - Rollback kaupade puuduse korral

##### `UpdateCartDisplay()` - Обновление отображения корзины / Ostukorvi kuvamise uuendamine

**Русский:**
1. **Очистка списка** - Удаляет все элементы из ListBox
2. **Расчет сумм** - Вычисляет стоимость каждой позиции
3. **Форматирование** - Отображает в удобном формате "Товар x Кол-во = Сумма"
4. **Общая сумма** - Подсчитывает итоговую стоимость заказа
5. **Обновление метки** - Показывает общую сумму в валютном формате

**Eesti:**
1. **Nimekirja puhastamine** - Eemaldab kõik elemendid ListBox-ist
2. **Summade arvutamine** - Arvutab iga positsiooni maksumuse
3. **Vormindamine** - Kuvab mugavas formaadis "Kaup x Kogus = Summa"
4. **Kogusumma** - Arvutab tellimuse lõpliku maksumuse
5. **Sildi uuendamine** - Näitab kogusummat valuuta formaadis

---

### 4. LanguageManager - Менеджер языков / Keelehaldur

#### Функции / Funktsioonid:

**Русский:**
- **Хранение переводов** - Словари с текстами на двух языках
- **Переключение языка** - Глобальное изменение языка интерфейса
- **Получение текстов** - Возврат переведенного текста по ключу
- **Состояние языка** - Отслеживание текущего выбранного языка

**Eesti:**
- **Tõlgete salvestamine** - Sõnaraamatud tekstidega kahes keeles
- **Keele vahetamine** - Liidese keele globaalne muutmine
- **Tekstide hankimine** - Tõlgitud teksti tagastamine võtme järgi
- **Keele olek** - Praegu valitud keele jälgimine

#### Основные методы / Peamised meetodid:

- `GetText(string key)` - Получение переведенного текста / Tõlgitud teksti hankimine
- `SwitchLanguage()` - Переключение между языками / Keelte vahel vahetamine

---

## Классы данных / Andmeklassid

### CartItem - Элемент корзины / Ostukorvi element
- `ProductId` - ID товара / Kauba ID
- `ProductName` - Название товара / Kauba nimetus
- `Price` - Цена / Hind
- `Quantity` - Количество / Kogus

### CategoryItem - Элемент категории / Kategooria element
- `Id` - ID категории / Kategooria ID
- `Name` - Название категории / Kategooria nimetus

### ProductItem - Элемент товара / Kauba element
- `Id` - ID товара / Kauba ID
- `Name` - Название / Nimetus
- `Quantity` - Количество на складе / Kogus laos
- `Price` - Цена / Hind
- `Image` - Изображение (byte[]) / Pilt (byte[])

---

## База данных / Andmebaas

### Таблицы / Tabelid:

**Kategooria** - Категории товаров / Kaupade kategooriad
- `Id` - Первичный ключ / Primaarvõti
- `Kategooria_nimetus` - Название категории / Kategooria nimetus

**Toodetabel** - Товары / Kaubad
- `Id` - Первичный ключ / Primaarvõti
- `Toodenimetus` - Название товара / Kauba nimetus
- `Kogus` - Количество / Kogus
- `Hind` - Цена / Hind
- `Pilt` - Имя файла изображения / Pildifaili nimi
- `Bpilt` - Изображение (byte[]) / Pilt (byte[])
- `Kategooriad` - Внешний ключ на категорию / Välisvõti kategooriale

---

## Особенности реализации / Rakendamise eripärad

### Безопасность / Turvalisus
- Параметризованные SQL запросы / Parameetritega SQL päringud
- Транзакции для критических операций / Transaktsioonid kriitiliste operatsioonide jaoks
- Валидация пользовательского ввода / Kasutaja sisendi valideerimine

### Производительность / Jõudlus
- Using statements для управления ресурсами / Using laused ressursside haldamiseks
- Правильное закрытие соединений / Ühenduste õige sulgemine
- Оптимизированные SQL запросы / Optimeeritud SQL päringud

### Пользовательский интерфейс / Kasutajaliides
- Современный плоский дизайн / Kaasaegne lame disain
- Отзывчивые элементы управления / Reageerivad juhtimiselemendid
- Интуитивная навигация / Intuitiivne navigeerimine
- Многоязычная поддержка / Mitmekeelne tugi