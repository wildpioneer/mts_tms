Feature: Parallel Testing Thread 2

    @GUI
    Scenario: Using different defs classes 1
        Given new browser is opened
        * a login page is opened
        * the user "atrostyanko@gmail.com" with password "Americana#1978" logged in
        Then settings page is opened

    @GUI
    Scenario: Using different defs classes 2
        Given new browser is opened
        * a login page is opened
        * the user "atrostyanko@gmail.com" with password "Americana#1978" logged in
        Then settings page is opened