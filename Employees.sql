-- Create the database
CREATE DATABASE Employees;

-- Use the newly created database
USE Employees;

-- Create the Education table
CREATE TABLE Education (
    id INT AUTO_INCREMENT PRIMARY KEY,
    education_level ENUM('UnderGraduate', 'PostGraduate') NOT NULL
);

-- Create the Department table
CREATE TABLE Department (
    id INT AUTO_INCREMENT PRIMARY KEY,
    department_name ENUM('Human Resource', 'Marketing', 'R&D') NOT NULL
);

-- Create the Employee table
CREATE TABLE Employee (
    id INT AUTO_INCREMENT PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    address VARCHAR(255) NOT NULL,
    start_date DATE NOT NULL,
    education_id INT NOT NULL,
    department_id INT NOT NULL,
    FOREIGN KEY (education_id) REFERENCES Education(id),
    FOREIGN KEY (department_id) REFERENCES Department(id)
);

-- Insert sample data into Education table
INSERT INTO Education (education_level) VALUES
('UnderGraduate'),
('PostGraduate');

-- Insert sample data into Department table
INSERT INTO Department (department_name) VALUES
('Human Resource'),
('Marketing'),
('R&D');

-- Insert sample employee data
INSERT INTO Employee (name, address, start_date, education_id, department_id) VALUES
('Nguyen Van A', '123 Nguyen Trai, Ho Chi Minh City', '2020-01-15', 1, 1), -- UnderGraduate, Human Resource
('Tran Thi B', '456 Le Lai, Hanoi', '2019-05-23', 2, 2), -- PostGraduate, Marketing
('Le Van C', '789 Hung Vuong, Da Nang', '2021-08-30', 1, 3), -- UnderGraduate, R&D
('Pham Minh D', '321 Nguyen Hue, Can Tho', '2018-12-01', 2, 1);