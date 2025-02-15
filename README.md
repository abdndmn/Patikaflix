# Patikaflix

## 📌 Description
Patikaflix is a simple **C# console application** designed for managing a list of TV series. Users can enter series details, store them in a list, and filter out comedy series. The program allows dynamic input, sorting, and filtering based on user-defined criteria.

---

## 🚀 Features

### 1️⃣ **Adding TV Series**
- Users can enter the **name**, **production year**, **genre**, **release year**, **director**, and **first platform** of a TV series.
- The entered series are stored in a `List<Series>`.

### 2️⃣ **Displaying All Series**
- After input, all stored series are displayed in a formatted manner.

### 3️⃣ **Filtering Comedy Series**
- Extracts series with the **"komedi"** (comedy) genre into a new list.
- Creates a `List<NewSeries>` that only contains **Name, Genre, and Director**.
- The list is **sorted alphabetically** by **series name** and then by **director name**.

### 4️⃣ **Looped Input Until User Exits**
- The program **keeps asking** the user if they want to add a new series.
- Exits the input process when the user types **'H'** (Hayır / No).

---

## 🔧 Technologies Used
- **C#** (Console Application)
- **.NET Core**
- **LINQ for filtering and sorting**

---

## 📂 Code Structure
### **Classes:**
#### **1️⃣ Series.cs** (Full Series Information)
```csharp
public class Series
{
    public string Name { get; set; }
    public int ProductionYear { get; set; }
    public string Genre { get; set; }
    public int ReleaseYear { get; set; }
    public string Director { get; set; }
    public string FirstPlatform { get; set; }
}
```
#### **2️⃣ NewSeries.cs** (Filtered Comedy Series)
```csharp
public class NewSeries
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Director { get; set; }
}
```
#### **3️⃣ Program.cs** (Main Application Logic)
- Takes user input for series details.
- Stores series in `List<Series>`.
- Filters comedy series into `List<NewSeries>`.
- Sorts and displays the results.

---

## 📌 Example Output
```
Dizinin Adını Giriniz: Friends
Dizinin Yapım Yılını Giriniz: 1994
Dizinin Türünü Giriniz: Komedi
Dizinin Yayınlanmaya Başladığı Yılı Giriniz: 1994
Dizinin Yönetmenini Giriniz: David Crane
Dizinin İlk Yayınlandığı Platformu Giriniz: NBC
Yeni Bir Dizi Eklemek İster misiniz? (E/H): H

Oluşturduğunuz Dizi:
Ad: Friends, Yapım Yılı: 1994, Tür: Komedi, Yayın Yılı: 1994, Yönetmen: David Crane, Platform: NBC

Komedi Dizileri Listesi:
Dizi Adı: Friends, Tür: Komedi, Yönetmen: David Crane
```
---

## 🚀 How to Run the Program
1. Clone the repository:
   ```sh
   git clone https://github.com/abdndmn/Patikaflix.git
   ```
2. Open the project in **Visual Studio** or **VS Code**.
3. Build and run the **C# console application**.
4. Follow the on-screen instructions to add TV series and filter comedy series.

---

## 🌟 Future Improvements
- Add **database storage** (e.g., SQLite or SQL Server).
- Implement a **GUI version**.
- Allow **search and update features** for stored series.
- Improve input validation for error handling.

---

📌 **Author:** [abdndmn](https://github.com/abdndmn)  
🚀 **Project:** Patikaflix  
🎬 **Manage your TV series efficiently!**

