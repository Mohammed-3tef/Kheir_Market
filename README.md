# Super Market Database Management System

## Overview

This project presents the design and implementation of a relational database system for an online supermarket platform, modeled after real-world systems such as [Carrefour Egypt](https://www.carrefouregypt.com). The system is intended to manage product inventories, handle customer data, and support online purchasing processes.

## Objectives

The primary objectives of this project are to:

- Design a comprehensive Entity Relationship Diagram (ERD) that captures all necessary entities and their relationships.
- Convert the ERD into a physical database schema using Data Definition Language (DDL) scripts.
- Provide structured queries that address typical business inquiries relevant to supermarket operations.

## System Features

### Customer Management
- Register new customers (by administrator or customer)
- Update customer information (by administrator or customer)
- Remove customer accounts (by administrator or customer)

### Product Management (Administrator Only)
- Add new products
- Update product details
- Remove products from the inventory

### Product Interaction
- Browse available products (by administrator or customers)
- Display a list of all available products
- Identify products requiring restocking (based on quantity threshold)

### Promotions
- Generate a list of frequent customers eligible for discount vouchers

## Deliverables

### 1. Entity Relationship Diagram (ERD)
A detailed ERD is included to model the necessary entities such as `Customers`, `Products`, `Orders`, and their relationships.

### 2. Physical Data Model (DDL Scripts)
The database schema is created using SQL DDL statements, defining tables, constraints, and data types.

### 3. Sample Business Inquiries (with SQL Queries)
1. **Most frequently purchased product**
2. **Products not purchased during a specific month**
3. **Customers with no purchases in the past year**
4. **Customer with the highest purchase volume this month**
5. **Sales comparison between electric appliances and food products**
6. **Product information along with number of unique buyers**

## Technologies Used

- **Database Management System**: MS SQL Server
- **Design Tools**: dbdiagram.io, MySQL Workbench, or pgAdmin (for ERD and schema visualization)
- **Languages**: SQL (DDL and DML)

## Contributing

Contributions are welcome! Feel free to fork the repo and submit a pull request.

## Authors

- Mariam Badr Yehia: [GitHub](https://github.com/Mariam-Badr-MB) - [LinkedIn](https://www.linkedin.com/in/mariambadr13/)
- George Malak Magdy: [GitHub](https://github.com/GeorgeMalakM) - [LinkedIn](https://www.linkedin.com/in/george-malak204/)
- John Ayman Demian: [GitHub](https://github.com/Johnayman1) - [LinkedIn](https://www.linkedin.com/in/john-ayman-aa30842b7/)
- Mohammed Atef Abd El-Kader: [GitHub](https://github.com/Mohammed-3tef) - [LinkedIn](https://www.linkedin.com/in/mohammed-atef-b0a408299/)
- Marawan Mohammed Badr: [GitHub](https://github.com/M-Marawan) - [LinkedIn](https://www.linkedin.com/in/marawan-mohamed-7244692a4/)

## License

This project is licensed under the MPL License.
