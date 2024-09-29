# Bookstore Management MVC Project

## Overview

This project is a **Bookstore Management System** built using ASP.NET Core MVC. The system allows users to manage books, track sales, and organize the bookstore's inventory efficiently. It supports full CRUD (Create, Read, Update, Delete) functionality for managing books in the store.

## Features

- Add new books to the inventory
- Edit existing book details
- Delete books from the store
- View a list of all books
- Search for books by title or author
- User-friendly interface for bookstore management

---

## Setup Instructions

### Prerequisites

Before you begin, make sure you have the following installed:

- [.NET Core SDK](https://dotnet.microsoft.com/download) (version 7.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- A compatible IDE, such as [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Steps to Set Up the Project

1. **Clone the Repository:**
   ```bash
   git clone https://github.com/Moayadhamdan/Bookstore-Management.git

2. **Open the Solution:**
   * Navigate to the cloned repository folder and open the `.sln` file using Visual Studio 2022.

3. **Update the Database:**
   * In Visual Studio, open the Package Manager Console by navigating to `Tools > NuGet Package Manager > Package Manager Console`.
   * Run the following command to apply migrations and update the database:
     ```bash
     Update-Database
     ```

4. **Run the Project:**
   * Press `F5` or click **Start** in Visual Studio to run the project.

5. **Test the Application:**
   * Once the project is running, navigate to the "Book Store" page to view, create, edit, and delete book entries, and explore the full CRUD functionality.

---

## Features

* **CRUD Functionality:** Manage books with Create, Read, Update, and Delete operations.
* **Responsive Design:** Fully responsive UI for both desktop and mobile devices.
* **Search and Filter:** Easily search books by title or author.

### How to Use the CRUD Functionality

#### Create a Book

1. Navigate to the Book Store section from the top navigation bar.
2. Click the **Create New** button to add a new book.
3. Fill in the book details (title, author, price, etc.) and click **Create** to save the book.

#### Read/View Books

- From the **Book Store** page, you can view the list of all books in the inventory.
- You can also search for books by title or author using the search bar.

#### Update/Edit a Book

1. In the list of books, find the book you wish to edit and click the **Edit** button next to it.
2. Update the necessary fields and click **Save** to update the book details.

#### Delete a Book

1. In the list of books, find the book you wish to delete and click the **Delete** button next to it.
2. Confirm the deletion to remove the book from the inventory.

---

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5 (for styling)
- jQuery (for frontend functionality)
