use library

go
create view BookInfo
as select Book.id_book as ID,
       Book.title as Title,
	   Author.name as Author,
	   Genre.name as Genre,
	   BookLanguage.name as Book_Language,
	   PublishingHouse.name as Publishing_House
from Book
		inner join Author on Book.id_author = Author.id_author
		inner join Genre on Book.id_genre = Genre.id_genre
		inner join BookLanguage on Book.id_language = BookLanguage.id_language
		inner join PublishingHouse on Book.id_publishing_house = PublishingHouse.id_publishing_house