# Selenium
Selenium

This project uses Selenium Web Driver for Chrome. It builds the following unit tests for the Bellevue College web site (https://www.bellevuecollege.edu/).

1.Start at home page.
2.For each top nav bar item (that is, Home, Classes, Programs of Study, Enrollment, Service, Campus Life and About US):
-Click on the tab.
-Record the page title in a List<string>.
-Return to the home page using the Back button.
-Record that the back button was clicked by adding the string “<<Back” to your List<string>.
3.Using FluentAssertions, validate that the sequence of operations and titles of pages are as expected in the list.
