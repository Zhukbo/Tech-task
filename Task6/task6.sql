SELECT  title 
FROM book JOIN book_author ON
book.book_id=book_author.book_id
GROUP BY book.book_id
HAVING COUNT(book_author.book_id)>1;