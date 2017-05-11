# Description
An assignment from Sofi for assessment purposes.

# Build Status

[![Build Status](https://travis-ci.org/furyanPDX/sofi-assignment.svg?branch=master)](https://travis-ci.org/furyanPDX/sofi-assignment)

# Getting Started
1. Install Visual Studio Community 2017
2. Open Visual Studio
3. Open the Team Explorer tab
4. Click on the green connector icon (Manage Connections)
5. Click on the Clone dropdown link under the Local Git Repositories section
6. Copy the https github url into the text field
7. Click clone

# Running the tests in Visual Studio
1. Build the solution
2. Click on the Test menu option
3. Navigate to the Windows option
4. Select Test Explorer
  * The tests should show up in this window
5. Right-click on a test or multiple and click Run Selected Tests

# Running the tests with 'dotnet test'
1. Open a command line (preferrably with Administrator)
2. Change directory to the SofiAssigment.Tests folder
3. Execute the following command:
  * dotnet test SofiAssignment.Tests.csproj
