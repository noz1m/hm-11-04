#### О чём задание:  
У нас есть файл *add.txt* с данными о продуктах (название, описание, цена, количество, категория, дата). Нужно загрузить их в список, посчитать пару показателей и записать всё в файлы. Представьте, что это список товаров для магазина, и мы его приводим в порядок.

---

#### Задание: Работа с продуктами  

##### 1. Загрузка данных (*File, парсинг в List*)  
**Что нужно сделать:**  
- Откройте файл *add.txt* (в нём данные в формате `Name,Description,Price,StockQuantity,CategoryName,CreatedDate`).  
- Преобразуйте строки в список `List<Product>`. Вот как выглядит класс `Product`:  
```csharp
class Product
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
    public string CategoryName { get; set; }
    public DateTime CreatedDate { get; set; }
}
```  
- Выведите все продукты в консоль в удобном виде.  
- Если файла нет или данные некорректны (например, цена — не число), напишите: "Ошибка: файл не найден или данные неправильные."  
**Пример вывода:**  
```
Продукты из add.txt:  
1. Desk Organizer, 25$, 30 шт., категория: Office Supplies  
2. Travel Mug, 15$, 100 шт., категория: Accessories  
...
```

---

##### 2. Подсчёт статистики (*List<T>*)  
**Что нужно сделать:**  
- Посчитайте по списку продуктов:  
  - Общее количество продуктов.  
  - Среднюю цену (округлите до 2 знаков после запятой).  
  - Общее количество товаров на складе (`StockQuantity`).  
- Запишите результаты в файл `static.txt` в таком формате:  
```
Total Products: [число]
Average Price: [число]
Total Stock Quantity: [число]
```  
- Выведите в консоль: "Статистика сохранена в static.txt."  
**Пример файла `static.txt`:**  
```
Total Products: 20
Average Price: 75.50
Total Stock Quantity: 500
```

---

##### 3. Сохранение данных (*File*)  
**Что нужно сделать:**  
- Сохраните весь список продуктов в файл `products.txt` в том же формате, что *add.txt*:  
  - Одна строка — один продукт, поля разделены запятыми (`Name,Description,Price,StockQuantity,CategoryName,CreatedDate`).  
- После сохранения напишите: "Данные сохранены в products.txt."  
**Пример файла `products.txt`:**  
```
Desk Organizer,Compact desk organizer with multiple compartments,25.00,30,Office Supplies,2024-02-01
Travel Mug,Insulated travel mug for hot and cold beverages,15.00,100,Accessories,2024-02-02
...
```

---
