# Title
  quiz-application

# About
  
  This project is a Windows Forms application developed using Visual Studio Community Edition 2022. I designed this application in order to both practice foundational software development skills and to demonstrate those skills to others. Developing this project has given me the opportunity to grow in my knowledge of C#, Object-Oriented Programming, WinForms, application and database design and integration, writing sql queries, implementing stored procedures, and backing up my code using Git and GitHub.
  
# Usage 
  
  This application allows users to create multiple-choice quizzes. The title, length, and content of those quizzes is based upon user input. Once created, a quiz is stored in a database and displayed on the home page. From the home page, users can also choose to take previously created quizzes and are shown their results upon the quiz's completion. 

# How to Build

  <h3>Getting Started</h3>

  Ensure that Visual Studio 2022 or later (not to be confused with Visual Studio Code) is installed on your machine and that your GitHub account is connected. When installing the various workloads offered, be sure to include "Data storage and processing" as well as ".NET Desktop Development." If you only wish to view the source code/build the project, you can clone the repo and open it from Visual Studio using the "Code" drop down button. Doing this, however, will prevent you from pushing any changes back to the repository. If you wish to contribute, you will need to fork the repository, make your changes on a new  branch, and submit a pull request on the development branch.
  
  Once you have access to the files, open the solution file (.sln) in Visual Studio 2022. This should automatically open all of the relevant files for this project. Make sure to set up "MockQuiz" as the startup project. To do this, right click on the "MockQuiz" project in Solution Explorer and select "set as startup project."

  <h3>Create the Database</h3>

  This repository contains two ways of creating the database. You can publish it to your sql database management system of choice by right clicking on the "MockQuizDatabase" project and selecting publish. To the right of the "target database connection" option, select "edit." There will be a tab named "browse" which will allow you to publish the database to your database management system of choice. If you only wish to test the database, a quick and convenient option is to use the MSSQLocalDB built into Visual Studio. In the "browse" tab mentioned previously, select local>MSSQLocalDB and fill out the information as desired. Finally, name your database and click "publish." One important issue to note is that there is a bug that prevents publishing the database when the target platform is set to "SQL Server 2022 or Azure SQL Database Managed Instance." To fix this issue, right click on the "MockQuizDatabase" project and select properties. Under properties, change the target platform to "SQL Server 2019." The database should not publish without issues.
  
If the database was published to MSSQLocalDB, it can be accessed using the SQL Server Object Explorer built into Visual Studio. Select View>SQL Server Object Explorer. In the object explorer, select Server>(localdb)MSSQLocalDB>Databases, and the database should be there.  

Alternatively, you can find queries to create the database and its tables under the Queries Folder. To create the database using these queries, simply create a new query to run on your database management system of choice. If using MSSQLocalDB, simply right click it and select "new query." Copy and paste the contents of "Create Database" into the new query, and run it. Do the same thing for the "Create Tables" query. To create the stored procedures referenced in this application, follow the same steps described above using the queries in the "Stored Procedures" folder. Ensure that you are running them for the previously created database. 

  <h3>Connecting the Database to the Application</h3>

  To connect the database to the application, use the App.config.template file. Insert your database name as well as your unique connection string. If you are simply building the application to view it and used the MSSQLocalDB built into Visual Studio, then you can access the database connection string by right clicking the database, selecting properties, and copying the connection string property text. If using this connection string, be sure to remove the spaces between the "Trust Server Certificate", "Application Intent", and "Multi Subnet Failover" field names. When these steps are completed, rename the file by removing the .template portion of the file name. 

  Under the MockQuiz project file, right click on the Dashboard file and select "view code" to access the code-behind. There, change the content of the databaseName variable to match your database name from the app.config file. 

  <h3>Wire Up Dependancies</h3>

  If not automatically included, install the third-party packages into the "MockQuizLibrary" dependancies using NuGet Package manager. The third-party packages are detailed in the Credits section of this READMe.md as well as in the Credits.txt files contained in this repository.

  Right click on the "MockQuiz" project dependancies and add the "MockQuizLibrary" as a reference. 

  <h3>Conclusion</h3>

  After completing these steps, the application should build successfully. If the program does not run after following these steps, please reach out to me so that I can resolve the issue and amend this section of the READMe.md. 


# Contribution

  I created this project with the intent of practicing and showcasing my software skills and without the intention of collaboration. That being said, I appreciate and am thankful for any interest in this repository that contributors might have. If you are interested in contributing to this repository, please reach out to me directly or create a fork, make changes on the development branch, and create a pull request. I cannot guarantee that I will approve of every request, but I will certainly take them into consideration. If you do contribute directly to this repository, I will make every effort to list you as a contributor in the credits section of this README.md. 

  For those wishing to use this project for their own purposes, see the LICENSE.txt file for more information. You may use this source code as long as you abide by the terms of the license agreement. Please note that, while not committed directly to this repository, this application, when built, does depend on third-party packages which are under their own separate licensing terms and agreements. See the credits section of this README.md for more information on these third-party packages. 

# Plans for the Future

  This project is intended to be included in a software portfolio going forward. 
  
  Future potential improvements of this project include: UI enhancements, the addition of a delete quiz button, and additional user-input restrictions. 

# Credits

<h2>Third Party Software Package Attribution</h2>
---------------------------------------------------------------------------------------------------

This application makes use of software packages which are under their own separate license agreements and copyright information. The following packages are not committed to this repository but are necessary installations to properly build the application. In keeping with the terms of these license agreements, the packages are listed below along with their respective copyright information, license agreements, and repository links. To install these packages, use the links provided, or find them using the NuGet Package Manager built into Visual Studio. Please note that the packages listed below may contain their own dependancies, each with their own licensing terms and conditions. In no way do I intend to claim ownership over work that is not mine. If I have failed to give proper attribution and/or have not properly complied with a license agreement, please reach out to me through my contact information listed on GitHub.


Dapper 2.1.35 Copyright (c) Stack Exchange, Inc.

Licensed under Apache, Version 2.0 which can be found at https://www.apache.org/licenses/LICENSE-2.0

Link to NuGet Package: https://www.nuget.org/packages/Dapper/2.1.35

Link to the Dapper repository on Github: https://github.com/DapperLib/Dapper

-----------------------------------------------------------------------------------------------------

Microsoft.Data.SqlClient (5.2.2) Copyright (c) .Net Foundation. All Rights Reserved

Licensed under the MIT License which can be found at https://github.com/dotnet/SqlClient/blob/main/LICENSE

Link to NuGet Package: https://www.nuget.org/packages/Microsoft.Data.SqlClient/5.2.2

Link to SqlClient repository on GitHub: https://github.com/dotnet/SqlClient

-----------------------------------------------------------------------------------------------------

System.Configuration.ConfigurationManager (9.0.0) Copyright (c) .Net Foundation and Contributors. All Rights Reserved.

Licensed under the MIT License which can be found at https://github.com/dotnet/runtime/blob/main/LICENSE.TXT

Link to NuGet Package: https://www.nuget.org/packages/System.Configuration.ConfigurationManager/9.0.0#readme-body-tab

Link to GitHub repository: https://github.com/dotnet/runtime














