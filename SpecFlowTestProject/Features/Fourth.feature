Feature: Параметризированные тесты

    Scenario: Параметризация
        Given открыт браузер
        And страница логина открыта
        When user "atrostyanko+0401@gmail.com" with password "QqtRK9elseEfAk6ilYcJ" logged in
        Then add project button is displayed
        And username is "Alex Tros"
        And project id is 23

    Scenario Outline: Таблицы
        Given открыт браузер
        * страница логина открыта
        When user "<username>" with password "<password>" logged in
        Then username is "<visibleText>"
        Examples:
          | username                           | password             | visibleText                        |
          | atrostyanko+0401@gmail.com         | QqtRK9elseEfAk6ilYcJ | Alex Tros                          |
          | atrostyanko+StandardUser@gmail.com | 1234567              | atrostyanko+StandardUser@gmail.com |
          
    Scenario: ds
        Given a blog post named "Random" with Markdown body
        """markdown
        Some Title, Eh?
        ===============
        Here is the first paragraph of my blog post. Lorem ipsum dolor sit amet,
        consectetur adipiscing elit.
        """