use library

go
create table Author(
	id_author int identity(1,1) not null constraint PK_Author primary key,
	name nvarchar(100) not null
)

create table Genre(
	id_genre int identity(1,1) not null constraint PK_Genre primary key,
	name nvarchar(100) not null
)

create table BookLanguage(
	id_language int identity(1,1) not null constraint PK_BookLanguage primary key,
	name nvarchar(100) not null
)

create table PublishingHouse(
	id_publishing_house int identity(1,1) not null constraint PK_PublishingHouse primary key,
	name nvarchar(100) not null,
	country nvarchar(100) not null,
	city nvarchar(100) not null
)

create table Book(
	id_book int identity(1,1) not null constraint PK_Book primary key,
	title nvarchar(100) not null,
	id_author int not null,
	id_genre int not null,
	id_language int not null,
	id_publishing_house int not null,
)

create table Reader(
	id_reader int identity(1,1) not null constraint PK_Reader primary key,
	full_name nvarchar(100) not null,
	age int not null
)

create table ReadersBooks(
	id_readers_books int identity(1,1) not null constraint PK_ReadersBooks primary key,
	id_reader int not null,
	id_book int not null
)

alter table Book with check add constraint FK_Book_Author foreign key(id_author) references Author(id_author)
alter table Book with check add constraint FK_Book_Genre foreign key(id_genre) references Genre(id_genre)
alter table Book with check add constraint FK_Book_Language foreign key(id_language) references BookLanguage(id_language)
alter table Book with check add constraint FK_Book_PublishingHouse foreign key(id_publishing_house) references PublishingHouse(id_publishing_house)
alter table ReadersBooks with check add constraint FK_ReadersBooks_Reader foreign key(id_reader) references Reader(id_reader)
alter table ReadersBooks with check add constraint FK_ReadersBooks_Book foreign key(id_book) references Book(id_book)


INSERT INTO Author([name]) VALUES('Xavier Sharp'),('Bernard Houston'),('Daphne Vasquez'),('Gareth Joyner'),('Thaddeus Serrano'),('Chase Kerr'),('Shelley Blackburn'),('Herrod Gill'),('Latifah Rodriquez'),('Halla Holder');
INSERT INTO Author([name]) VALUES('Amy Sims'),('Alma Flowers'),('Colt Lloyd'),('Phyllis West'),('Ryan Patrick'),('Paula Weeks'),('Alan Wilkerson'),('Silas Rios'),('Fredericka Ruiz'),('India Weber');
INSERT INTO Author([name]) VALUES('Quinlan Matthews'),('Kasper Macdonald'),('Karen Dorsey'),('Ferdinand Hahn'),('Hedda Mcgee'),('Carlos Monroe'),('Imelda Knapp'),('Marsden Rosales'),('Harlan Hinton'),('Stone Hubbard');
INSERT INTO Author([name]) VALUES('Jessica Lambert'),('Coby Briggs'),('Paula Cervantes'),('Jeremy Shields'),('Hoyt Walters'),('Harper Mooney'),('Quemby Deleon'),('Arden Dudley'),('Rashad Rojas'),('Leila Galloway');
INSERT INTO Author([name]) VALUES('Jessamine Mccullough'),('Ian Cobb'),('Kylynn Luna'),('Harrison Perez'),('Seth Alston'),('Magee Vinson'),('Hedy Warner'),('Zenia Ratliff'),('Wyoming Perry'),('Tobias Vang');
INSERT INTO Author([name]) VALUES('Harding Mercer'),('Hyatt Russell'),('Sopoline Blackwell'),('Chelsea French'),('Uta Lawrence'),('Alice Davidson'),('Iris Suarez'),('Clio Bailey'),('Prescott Woods'),('Riley Vaughan');
INSERT INTO Author([name]) VALUES('Stuart Nicholson'),('Virginia Burt'),('Lunea Whitfield'),('Kibo Maldonado'),('Chaim Ball'),('Gail Richard'),('Dawn Young'),('Fredericka Meyer'),('Adam Cook'),('Maite Rodriguez');
INSERT INTO Author([name]) VALUES('Leo Mckee'),('Alexandra Holcomb'),('Jennifer Palmer'),('Marsden Bentley'),('Kuame Mendoza'),('Jackson Vaughn'),('Castor Ford'),('Zorita Ellis'),('Isabella Lawson'),('Abbot Pittman');
INSERT INTO Author([name]) VALUES('Mufutau Woodward'),('Sarah Gonzalez'),('Beverly Vazquez'),('Justina Dalton'),('Steel Bradford'),('Amanda Martin'),('Nelle Cohen'),('Talon Collins'),('Gisela Washington'),('Malachi Fletcher');
INSERT INTO Author([name]) VALUES('Ora Massey'),('Nolan Guerra'),('Patrick Crane'),('Blossom Hess'),('Myra Mathews'),('Alana Myers'),('Berk Payne'),('Dawn Tyler'),('Savannah Lester'),('Fletcher Cherry');

INSERT INTO Genre([name]) VALUES('pede'),('lorem'),('malesuada'),('sem.'),('non'),('venenatis'),('mi.'),('enim'),('sodales'),('lacinia');
INSERT INTO Genre([name]) VALUES('fermentum'),('consectetuer'),('sociis'),('eu'),('dictum'),('non,'),('blandit'),('ante.'),('nibh.'),('ac');
INSERT INTO Genre([name]) VALUES('viverra.'),('eu'),('Fusce'),('gravida.'),('magna.'),('at,'),('imperdiet'),('condimentum'),('eu'),('Aenean');
INSERT INTO Genre([name]) VALUES('semper'),('magna'),('sollicitudin'),('lectus'),('luctus'),('ut'),('est,'),('Ut'),('eleifend,'),('sodales');
INSERT INTO Genre([name]) VALUES('nec'),('mauris.'),('magna'),('facilisis'),('magna.'),('mauris'),('quis'),('volutpat'),('Aenean'),('ac');
INSERT INTO Genre([name]) VALUES('quam'),('mauris,'),('interdum'),('Cras'),('Cras'),('ante'),('sem.'),('Aenean'),('leo.'),('non');
INSERT INTO Genre([name]) VALUES('Mauris'),('scelerisque'),('gravida.'),('sed,'),('feugiat'),('tincidunt,'),('vel'),('metus'),('Phasellus'),('montes,');
INSERT INTO Genre([name]) VALUES('vel,'),('cursus'),('justo'),('Nullam'),('feugiat'),('vulputate,'),('libero'),('nunc'),('ornare,'),('vehicula');
INSERT INTO Genre([name]) VALUES('faucibus'),('posuere'),('Pellentesque'),('dolor'),('convallis,'),('Donec'),('tristique'),('placerat.'),('Nullam'),('Donec');
INSERT INTO Genre([name]) VALUES('dolor.'),('ultrices.'),('felis.'),('Sed'),('Cras'),('ut,'),('luctus'),('parturient'),('id'),('nulla');

INSERT INTO BookLanguage([name]) VALUES('Pellentesque'),('orci,'),('egestas.'),('Vestibulum'),('ipsum.'),('lorem,'),('Aenean'),('at,'),('Phasellus'),('Nam');
INSERT INTO BookLanguage([name]) VALUES('diam.'),('mauris'),('cursus'),('Aliquam'),('lacus.'),('Mauris'),('eget'),('Nullam'),('urna.'),('Proin');
INSERT INTO BookLanguage([name]) VALUES('erat'),('Aliquam'),('sodales.'),('Integer'),('aliquet,'),('quis'),('dolor.'),('at'),('nunc'),('eget');
INSERT INTO BookLanguage([name]) VALUES('orci'),('est,'),('erat'),('blandit'),('at,'),('lacinia'),('augue'),('nascetur'),('nibh'),('torquent');
INSERT INTO BookLanguage([name]) VALUES('egestas'),('mauris.'),('eget'),('velit.'),('Donec'),('sapien'),('non'),('justo.'),('penatibus'),('erat');
INSERT INTO BookLanguage([name]) VALUES('et'),('mauris,'),('pede'),('Donec'),('faucibus'),('cursus'),('molestie'),('risus.'),('mauris'),('eu');
INSERT INTO BookLanguage([name]) VALUES('elementum,'),('purus,'),('Vivamus'),('nec,'),('euismod'),('elementum'),('Fusce'),('ad'),('et'),('sapien,');
INSERT INTO BookLanguage([name]) VALUES('et'),('massa'),('Sed'),('sapien.'),('orci.'),('Curabitur'),('erat'),('ut'),('Cras'),('tellus');
INSERT INTO BookLanguage([name]) VALUES('egestas.'),('eu'),('vulputate,'),('dui'),('metus.'),('ullamcorper'),('elit,'),('tristique'),('id,'),('In');
INSERT INTO BookLanguage([name]) VALUES('consequat'),('sem,'),('metus.'),('fringilla'),('a'),('aliquam,'),('tristique'),('tempor'),('Curae;'),('ac,');

INSERT INTO PublishingHouse([name],[country],[city]) VALUES('in','Yemen','Lagundo/Algund'),('et,','Tajikistan','Palayankottai'),('Nunc','Togo','Maringá'),('non','Central African Republic','Santa Juana'),('ipsum.','Saint Kitts and Nevis','Dalbeattie'),('fringilla.','Curaçao','Mold'),('Proin','Israel','Forge-Philippe'),('ullamcorper','Ghana','Helchteren'),('ac,','Central African Republic','Wichita'),('consequat','Libya','Lawton');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('tincidunt','Guernsey','Muzaffarnagar'),('et','Faroe Islands','Kapuskasing'),('erat','Netherlands','Jette'),('feugiat.','Zimbabwe','Wardin'),('et','Virgin Islands, British','Inveraray'),('magnis','Monaco','Arbroath'),('convallis','Costa Rica','Grand Rapids'),('venenatis','Korea, North','Fino Mornasco'),('viverra.','Australia','Villers-la-Bonne-Eau'),('Integer','Finland','Casnate con Bernate');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('velit','Lesotho','Wellington'),('adipiscing','China','Thurso'),('adipiscing,','New Zealand','Friedrichsdorf'),('tempus','Jamaica','Grand-Manil'),('et','Sri Lanka','Washington'),('sit','Armenia','La Valle/Wengen'),('magna.','Svalbard and Jan Mayen Islands','Londerzeel'),('nascetur','South Georgia and The South Sandwich Islands','Cerrillos'),('Quisque','Malaysia','Hoshiarpur'),('iaculis','Bhutan','Santa María');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('Quisque','Western Sahara','Codigoro'),('montes,','Korea, South','Épinal'),('rutrum','Uruguay','Sint-Ulriks-Kapelle'),('egestas','Laos','Rae Lakes'),('aliquet','Saint Helena, Ascension and Tristan da Cunha','Bolsward'),('Duis','Kyrgyzstan','Port Glasgow'),('gravida','Germany','East Kilbride'),('faucibus','Aruba','Perpignan'),('Nunc','Viet Nam','La Roche-sur-Yon'),('dapibus','Bangladesh','Mainz');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('convallis','Philippines','Dumfries'),('ligula','Virgin Islands, British','BiercŽe'),('ut','Cape Verde','Santa Cesarea Terme'),('Nullam','Canada','Rivi�re-du-Loup'),('fermentum','San Marino','Hollange'),('auctor','Bulgaria','Virelles'),('ac','Saint Martin','Cavaion Veronese'),('aliquet,','Indonesia','Invergordon'),('vel,','Netherlands','Emines'),('Duis','Algeria','Sachs Harbour');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('mi','Pitcairn Islands','Landenne'),('dolor,','Nicaragua','Halkirk'),('vehicula.','Pitcairn Islands','Hampstead'),('vehicula.','Greece','Graneros'),('ac','Kazakhstan','Milena'),('iaculis','Mexico','Wimbledon'),('aliquet.','Singapore','Saint-Georges'),('a,','Peru','Kingston'),('orci,','Turks and Caicos Islands','Quilleco'),('faucibus','Aruba','Wandlitz');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('Pellentesque','Libya','Massimino'),('senectus','Antigua and Barbuda','Dave'),('ut','Nauru','Río Verde'),('imperdiet','Kyrgyzstan','Palmariggi'),('et','Australia','Montignies-sur-Sambre'),('risus.','Zimbabwe','Mottola'),('vitae,','Thailand','Henis'),('per','Liberia','St. Albert'),('Praesent','Israel','Torgiano'),('amet','Qatar','New Glasgow');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('in,','Uruguay','Erpe'),('laoreet','Palestine, State of','Muridke'),('et','Algeria','Curanilahue'),('tortor','Reunion','Thalassery'),('Donec','Nauru','Friedrichshafen'),('faucibus','Saint Martin','Llandovery'),('vitae','Palestine, State of','Kearny'),('diam','Korea, South','Delta'),('est','Palestine, State of','Pedro Aguirre Cerda'),('Sed','Eritrea','Linz');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('posuere,','Cayman Islands','Essex'),('interdum.','Kazakhstan','Nerem'),('Quisque','Congo, the Democratic Republic of the','Heredia'),('nunc.','Bahrain','Sannazzaro de'' Burgondi'),('sodales.','Kiribati','Virginia Beach'),('Ut','Malaysia','Khanpur'),('elit.','Germany','Milestone'),('Integer','Botswana','Pedro Aguirre Cerda'),('egestas','Comoros','Damoh'),('molestie','Argentina','Castel Guelfo di Bologna');
INSERT INTO PublishingHouse([name],[country],[city]) VALUES('commodo','Luxembourg','Nashville'),('vitae,','Congo (Brazzaville)','Cavaion Veronese'),('mi.','Papua New Guinea','Köthen'),('elit','Ireland','Oklahoma City'),('sem','Montenegro','San Pedro'),('sem','Vanuatu','Tuscaloosa'),('Donec','Bahamas','Saint-Martin'),('odio,','Svalbard and Jan Mayen Islands','Cannock'),('tempor','Guadeloupe','Chippenham'),('nec,','Bulgaria','Talence');

INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('pede.',26,15,29,65),('libero.',75,75,2,66),('mus.',67,53,5,63),('Aenean',63,96,99,59),('tellus.',77,68,73,11),('tincidunt',24,21,20,32),('commodo',67,73,64,19),('taciti',99,29,92,34),('dictum.',26,53,69,48),('vel',60,10,51,95);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('lacinia',8,10,100,28),('venenatis',74,3,38,54),('sit',24,35,27,1),('a,',93,80,95,57),('In',76,38,51,1),('nibh.',54,98,65,10),('semper',98,20,66,90),('laoreet',96,2,59,30),('vehicula',87,10,98,32),('a,',97,44,66,9);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('nibh',100,73,91,61),('scelerisque',65,25,78,38),('eleifend',68,50,18,34),('enim',4,7,78,69),('et',7,56,72,80),('neque',21,79,40,50),('felis',49,41,26,49),('vel,',22,2,2,71),('Etiam',61,6,53,90),('pellentesque',29,94,46,43);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('convallis',64,59,87,88),('dictum',38,60,93,51),('dui.',80,70,51,100),('a',10,7,88,80),('tincidunt',30,34,26,16),('fringilla',24,98,54,7),('hendrerit',25,34,55,67),('sem',15,51,33,30),('Integer',18,1,98,73),('dictum',98,34,73,100);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('Suspendisse',79,66,13,93),('dolor',18,54,54,10),('magna.',91,6,71,97),('dictum.',90,30,31,95),('mi.',10,65,23,3),('aliquet',13,6,86,21),('velit',72,93,18,45),('mi',92,51,97,50),('scelerisque',61,95,31,38),('ut',86,50,86,20);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('velit',20,61,44,88),('volutpat',26,26,59,63),('urna.',71,20,89,36),('gravida',66,11,54,11),('Nunc',73,75,44,52),('Integer',83,35,70,5),('ac',6,22,85,71),('tempor',6,33,4,77),('amet',87,40,99,34),('ligula.',83,14,78,60);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('feugiat',3,29,67,6),('eleifend.',61,90,83,2),('fringilla.',10,94,47,65),('ut,',53,78,53,7),('Integer',57,28,55,1),('venenatis',73,21,98,41),('pharetra.',79,44,27,78),('ligula.',90,32,81,12),('iaculis,',48,18,60,37),('sit',37,76,62,46);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('neque',18,67,8,57),('non,',47,84,5,74),('ut,',83,25,19,14),('lacinia.',17,70,49,92),('Cras',9,52,48,62),('lorem,',40,22,59,91),('elit',97,5,44,50),('et,',12,57,95,21),('sit',1,71,77,75),('sed,',35,66,31,69);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('hendrerit',32,47,40,61),('Suspendisse',18,17,40,42),('et',52,51,79,13),('justo',6,22,17,14),('et,',45,56,14,89),('vitae',83,89,44,97),('dictum.',9,19,63,54),('eros',12,51,92,34),('Duis',97,33,100,60),('at',12,57,96,24);
INSERT INTO Book([title],[id_author],[id_genre],[id_language],[id_publishing_house]) VALUES('sit',24,28,37,73),('vel,',1,57,77,97),('nisl',76,91,71,52),('vulputate',35,69,83,3),('posuere',65,53,56,60),('molestie',50,64,10,65),('sed',56,19,86,63),('mi',55,18,79,29),('tortor.',89,36,44,43),('Nullam',7,69,39,19);

INSERT INTO Reader([full_name],[age]) VALUES('Barbara Morales',30),('Rajah Montgomery',71),('Ulla Davenport',30),('Cherokee Castillo',89),('Cullen Mack',66),('Kimberly Kirby',7),('Taylor Atkinson',1),('Ivan Nicholson',7),('Lester Poole',52),('Melyssa Terry',97);
INSERT INTO Reader([full_name],[age]) VALUES('Emma Estes',86),('Edan Rodriquez',56),('Germane Dudley',76),('Dai Hayden',33),('Maxwell Mccormick',19),('Risa Everett',6),('Bruce Blackwell',13),('Carl Cook',79),('Tatiana Gill',3),('Imelda Blackwell',70);
INSERT INTO Reader([full_name],[age]) VALUES('Deirdre Snow',76),('Orli Patterson',45),('Carter Sweet',16),('Shelby Ellis',22),('Judith Mayer',94),('Iris Rasmussen',16),('Breanna Mathis',60),('Bevis Morales',18),('Mona Hale',24),('Seth Hart',100);
INSERT INTO Reader([full_name],[age]) VALUES('Hoyt Solomon',62),('Ina Ward',33),('Jayme Berger',16),('Kenneth Huber',42),('Ivy Mays',61),('Ryan Collins',2),('Madonna Holland',59),('Sigourney Sargent',18),('Naida Valencia',8),('Chantale Fuentes',12);
INSERT INTO Reader([full_name],[age]) VALUES('Tamekah Mccarthy',24),('Rahim William',44),('Haley Schwartz',17),('Sigourney Lawson',95),('Sean Savage',57),('Graham Reeves',6),('Octavia Burnett',49),('Beatrice Hopper',27),('Dustin Clark',26),('Lara Stuart',12);
INSERT INTO Reader([full_name],[age]) VALUES('Brenna Puckett',99),('Perry Long',38),('Ebony Singleton',38),('Laurel Berg',8),('Halee Dunn',46),('Seth Hunter',89),('Nita Knapp',30),('Laith Hunt',31),('Raven Haney',52),('Stewart Hawkins',40);
INSERT INTO Reader([full_name],[age]) VALUES('Gareth Hardy',82),('Brenda Levine',33),('Leo Alston',87),('India Cote',92),('Kimberley Moon',37),('Barrett Chen',98),('Delilah Barry',53),('Charissa Cummings',62),('Tad Copeland',48),('Tasha Knapp',62);
INSERT INTO Reader([full_name],[age]) VALUES('Brett Vega',64),('Astra Gilmore',53),('Bernard Irwin',80),('Elton Palmer',5),('Tanek Flores',80),('Beau Kemp',2),('Patience Hatfield',7),('Sacha Patton',51),('Brianna Caldwell',88),('Julie Oliver',77);
INSERT INTO Reader([full_name],[age]) VALUES('Dominique Mcmahon',42),('Lawrence Chaney',73),('Jeremy Witt',67),('Rhoda Carrillo',32),('George Cobb',40),('Lesley David',90),('Dieter Norris',94),('Sara Poole',37),('Thomas Mcclain',90),('Mira Justice',29);
INSERT INTO Reader([full_name],[age]) VALUES('Celeste Meyer',80),('Ahmed Riggs',68),('Akeem Franks',9),('Hyatt Parker',12),('Brendan Gonzales',98),('Tasha Atkins',51),('Wynne Craft',14),('Demetria Dalton',31),('Unity Head',19),('Drake Todd',46);

INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(24,5),(50,84),(67,71),(3,28),(42,74),(13,35),(75,51),(5,5),(48,77),(46,83);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(72,32),(91,17),(85,53),(59,44),(18,86),(24,72),(74,94),(24,68),(98,74),(52,90);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(70,99),(88,1),(33,14),(85,72),(82,59),(31,6),(73,11),(16,77),(59,19),(58,76);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(94,42),(13,92),(9,56),(100,95),(4,43),(2,62),(44,94),(98,82),(18,59),(54,54);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(44,13),(45,1),(76,76),(29,16),(98,91),(78,11),(15,14),(74,97),(37,27),(60,36);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(47,34),(33,100),(65,60),(55,17),(27,77),(5,62),(95,62),(57,89),(29,9),(49,47);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(51,34),(99,11),(55,6),(44,84),(67,20),(64,40),(21,33),(31,7),(90,90),(94,25);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(6,23),(45,57),(81,91),(79,51),(94,42),(13,97),(44,97),(29,19),(52,52),(11,41);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(45,17),(29,44),(70,4),(71,81),(75,22),(54,2),(39,8),(4,86),(97,71),(33,85);
INSERT INTO ReadersBooks([id_reader],[id_book]) VALUES(85,9),(95,84),(86,50),(1,91),(28,69),(23,67),(50,99),(73,25),(31,1),(44,46);

go
create procedure AddAuthor @ID int output,
						   @Name nvarchar(100)
as
	insert into Author (name)
	values (@Name)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddGenre @ID int output,
						  @Name nvarchar(100)
as
	insert into Genre(name)
	values (@Name)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddBookLanguage @ID int output,
						         @Name nvarchar(100)
as
	insert into BookLanguage (name)
	values (@Name)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddPublishingHouse @ID int output,
						            @Name nvarchar(100),
									@Country nvarchar(100),
									@City nvarchar(100)
as
	insert into PublishingHouse (name, country, city)
	values (@Name, @Country, @City)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddReader @ID int output,
						   @Name nvarchar(100),
						   @Age nvarchar(100)
as
	insert into Reader (full_name, age)
	values (@Name, @Age)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddBook @ID int output,
						 @Title nvarchar(100),
						 @IDAuthor int,
						 @IDGenre int,
						 @IDLanguage int,
						 @IDPublishingHouse int

as
	insert into Book (title, id_author, id_genre, id_language, id_publishing_house)
	values (@Title, @IDAuthor, @IDGenre, @IDLanguage, @IDPublishingHouse)
	set @ID = SCOPE_IDENTITY()

go
create procedure AddReadersBooks @ID int output,
								 @IDReader int,
								 @IDBook int
as
	insert into ReadersBooks(id_reader, id_book)
	values (@IDReader, @IDBook)
	set @ID = SCOPE_IDENTITY()

go
create procedure DeleteAuthor @ID int 
as
	delete from Author where id_author = @ID

go
create procedure DeleteBook @ID int 
as
	declare @idBook int
	declare @cursor cursor
	set @cursor = cursor scroll for
	select id_book from ReadersBooks
open @cursor
fetch next from @cursor into @idBook
while @@FETCH_STATUS = 0
begin
	if(@idBook = @ID)
	begin 
		delete from ReadersBooks where id_book = @idBook
	end
	fetch next from @cursor into @idBook
end
close @cursor
delete from Book where id_book = @ID

go
create procedure DeleteBookLanguage @ID int 
as
	delete from BookLanguage where id_language = @ID

go
create procedure DeleteGenre @ID int 
as
	delete from Genre where id_genre = @ID

go
create procedure DeletePublishingHouse @ID int 
as
	delete from PublishingHouse where id_publishing_house = @ID

go
create procedure DeleteReader @ID int 
as
	delete from Reader where id_reader = @ID

go
create procedure DeleteReadersBooks @ID int 
as
	delete from ReadersBooks where id_readers_books = @ID

