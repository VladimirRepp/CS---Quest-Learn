# ⚓ Simple Sea Battle (WinForms MVP)

> **Учебный проект.** Финальная итерация — «Морской бой» с архитектурным паттерном Model-View-Presenter.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📖 О проекте

Данный проект — **третья, архитектурно зрелая итерация** разработки игры «Морской бой».  
После создания [ядра игры](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/GameCoreSimpleSeaBattle) и [быстрого переноса на WinForms](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20V0), на этом этапе внедрён паттерн **MVP (Model-View-Presenter)**.

Проект создан в обучающих целях и наглядно демонстрирует, **как правильная архитектура разделяет зоны ответственности** и делает код поддерживаемым, тестируемым и готовым к расширению.

---

## 🎯 Цели и задачи

- ✅ Применить паттерн **Model-View-Presenter** к игре «Морской бой»
- ✅ Полностью разделить бизнес-логику, представление и управление
- ✅ Сохранить ядро игры **неизменным** при переходе от консоли к WinForms
- ✅ Сделать код тестируемым и готовым к переносу на другие платформы
- ✅ Показать эволюционный путь: **Консоль → WinForms (без архитектуры) → WinForms (MVP)**

---

## 🧱 Архитектура MVP

Проект построен на трёх независимых слоях, каждый из которых решает строго свою задачу:

| Слой | Назначение | Знает о других слоях? |
|------|------------|----------------------|
| **Model** | Ядро игры: `GameMap`, `GameLogic` — поле, расстановка корабля, выстрелы, победа | Не знает ни о ком |
| **View** | Интерфейс Windows Forms: отрисовка поля, кликабельные клетки, отображение результата | Не знает о Model |
| **Presenter** | Посредник: получает действия от View, обращается к Model, обновляет View | Знает о Model и View (через интерфейс) |

### Преимущества MVP

- 🧪 **Тестируемость** — Presenter можно протестировать без запуска WinForms
- 🔄 **Заменяемость** — можно сменить View (WPF, Unity, консоль) без правок в Model и Presenter
- 🧹 **Чистота кода** — каждый слой отвечает только за свою задачу
- ♻️ **Переиспользуемость** — ядро игры остаётся тем же, что и в консольной версии

---

## 🔄 Эволюция проекта

| Итерация | Проект | Архитектура |
|----------|--------|-------------|
| 1 | [Console App](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/GameCoreSimpleSeaBattle) | Ядро игры, разделение логики и интерфейса |
| 2 | [WinForm V_0](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20V0) | Быстрый перенос без паттернов |
| **3** | **WinForms MVP** *(текущий)* | Model-View-Presenter ✅ |

---

## 🎮 Правила игры

| Параметр | Описание |
|----------|----------|
| Размер поля | 5×5 клеток |
| Корабли | Один однопалубный корабль |
| Генерация | Случайная расстановка |
| Управление | Клик мышью по клетке |
| Победа | При первом попадании в корабль |

---

## 📸 Интерфейс

В папке [`Img`](./Img) находятся скриншоты интерфейса приложения с архитектурой MVP:

- 🎬 Игровое поле 5×5
- 🎯 Процесс выстрелов и визуальная обратная связь
- 🏆 Экран победы

---

## 🚀 Быстрый старт

```bash
git clone https://github.com/VladimirRepp/CS---Quest-Learn.git
cd CS---Quest-Learn/Samples/SimpleSeaBatlle/SimpleSeaBattle\ -\ WinForm\ MVP
# Открыть решение SimpleSeaBattle.sln в Visual Studio и запустить проект
```

---

## 🔗 Ссылки

- **Репозиторий:** [CS---Quest-Learn / SimpleSeaBattle - WinForm MVP](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20MVP)
- **Ядро игры:** [Консольная версия](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/GameCoreSimpleSeaBattle)
- **Предыдущая итерация:** [WinForm V_0 (без архитектуры)](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/SimpleSeaBatlle/SimpleSeaBattle%20-%20WinForm%20V0)

---

## 📝 Лицензия

Проект распространяется под лицензией MIT. Подробнее в файле [LICENSE](LICENSE).

---

> *«Хорошая архитектура — это когда смена интерфейса не требует переписывания логики. Просто подключил — и работает.»*
