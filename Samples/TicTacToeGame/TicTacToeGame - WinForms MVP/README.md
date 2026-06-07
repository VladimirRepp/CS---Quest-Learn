# 🎮 Tic-Tac-Toe Game (WinForms MVP)

> **Учебный проект.** Третья итерация разработки — внедрение архитектурного паттерна Model-View-Presenter.

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📖 О проекте

Данный проект — **третья, зрелая итерация** разработки игры «Крестики-Нолики».  
После переноса логики из [консольного приложения](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/TicTacToeGame/GameLogicTicTacToeGame%20-%20CONSOLE) в WinForms, на этом этапе внедрён архитектурный паттерн **MVP (Model-View-Presenter)**.

Проект создан в обучающих целях и наглядно демонстрирует, как правильная архитектура упрощает поддержку, тестирование и развитие приложения.

---

## 🎯 Цели и задачи

- ✅ Применить паттерн **Model-View-Presenter** к игре «Крестики-Нолики»
- ✅ Полностью разделить бизнес-логику, представление и управление
- ✅ Сделать код тестируемым и готовым к дальнейшему расширению
- ✅ Показать эволюционный путь: **Консоль → WinForms (без архитектуры) → WinForms (MVP)**

---

## 🧱 Архитектура MVP

Проект построен на трёх ключевых слоях, каждый из которых решает свою задачу:

| Слой | Назначение | Знает о других слоях? |
|------|------------|----------------------|
| **Model** | Игровая логика, ядро игры, сущности (`Player`, `GameMap`, `GameLogic`) | Не знает ни о ком |
| **View** | Интерфейс Windows Forms, отображение поля, обработка действий пользователя | Не знает о Model |
| **Presenter** | Посредник: получает события от View, обращается к Model, обновляет View | Знает о Model и View (через интерфейс) |

### Почему MVP?

- 🧪 **Тестируемость** — Presenter можно протестировать без запуска WinForms
- 🔄 **Заменяемость** — можно сменить View (например, на WPF), не трогая Model и Presenter
- 🧹 **Чистота кода** — каждый слой отвечает только за свою задачу

---

## 🔄 Эволюция проекта

| Итерация | Проект | Архитектура |
|----------|--------|-------------|
| 1 | [Console App](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/GameLogicTicTacToeGame%20-%20CONSOLE) | Разделение логики и интерфейса |
| 2 | [WinForm V_0](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/TicTacToeGame/TicTacToeGame%20-%20WinForm%20V_0) | Без архитектурных паттернов |
| **3** | **WinForms MVP** *(текущий)* | Model-View-Presenter ✅ |

---

## 📸 Интерфейс

В папке [`Img`](./Img) находятся скриншоты интерфейса приложения на Windows Forms с архитектурой MVP.

---

## 🚀 Быстрый старт

```bash
git clone https://github.com/VladimirRepp/CS---Quest-Learn.git
cd CS---Quest-Learn/Samples/TicTacToeGame/TicTacToeGame\ -\ WinForms\ MVP
# Открыть решение TicTacToeGame.sln в Visual Studio и запустить проект
```

---

## 🔗 Ссылки

- **Репозиторий:** [CS---Quest-Learn / TicTacToeGame - WinForms MVP](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/TicTacToeGame/TicTacToeGame%20-%20WinForms%20MVP)
- **Предыдущая итерация:** [WinForm V_0 (без архитектуры)](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/TicTacToeGame/TicTacToeGame%20-%20WinForm%20V_0)
- **Ядро логики:** [Консольная версия](https://github.com/VladimirRepp/CS---Quest-Learn/tree/main/Samples/TicTacToeGame/GameLogicTicTacToeGame%20-%20CONSOLE)

---

## 📝 Лицензия

Проект распространяется под лицензией MIT. Подробнее в файле [LICENSE](LICENSE).

---

> *«Архитектура — это не про сложность. Это про умение разделять и властвовать.»*
