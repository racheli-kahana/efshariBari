
create database Recepies
go
use Recepies
go
create table products(
idprod int identity(1,1)  ,--קוד מזהה למצרך
code int primary key,
smlmitrach int,--סמל מצרך
shmmitzrach varchar(60) ,--שם מצרך
protein float ,--חלבון
total_fat float,--סך שומן
food_energy float,--קלוריות
carbohydrates float,--פחממות זמינות
total_dieatry_fiber float,--סיבים
calcium float,--סידן
iron float ,--ברזל
total_sugars float ,--סוכרים
trans_fatty_acids float,--שומן טראנס
magnesium float,--מגנזיום
phosphours float,--זרחן
potassium float,--אשלגן
sodium float,--נתרן
zinc float,--אבץ
cholesterol float,--כולסטרול
saturated_fat float,--שומן רווי
vitamin_a_ui float,--ויטמין אי יו אי
vitamin_e float,--ויטמין אי
vitamin_c float,--ויטמין סי
vitamin_a_re float,--ויטמין אי אראיואי
vitamin_k float,--ויטמין קי
vitamin_b6 float,--ויטמין בי שש
vitamin_b12 float,--ויטמין בי שתיים עשרה
vitamin_d float,--ויטמין די
--double thiamin,
--double riboflavin,
--double niacin,
--double folate,
--double folate_dfe,
--double butyric,
--double caproic,
--double capric,
--double lauric,
--double myristic,
--double myristic,
--double palmitic,
--double stearic,
--double oleic,
--double linoleic,
--double arachidonic,
--double docosahexanoic,
--double palmitoleic,
--double parinaric,
--double gadoleic,
--double eicosapentaenoic,
--double erucic,
--double docosapentaenoic,
--double mono_saturated,--שומן חד בלתי רווי 
--double poly_saturated,--שומן רב בלתי רווי
--double isoleucine,
--double leucine,
--double valine,
--double lysine,
--double threonine,
--double methionine,
--double phenylalanine,
--double tryptophan,
--double histidine,
--double tyrosine,
--double arginine,
--double cystine,
--double serine,
--double pantothenic_acid,
--double selenium,
--double choline,
--double manganese,
--double manganese,
--double fructose,
--double taric_i,

)
go
create table Measures(
idmida int identity(1,1) , 
kodmida int primary key,
shmmida varchar(40 ),
)
go
create table Weights(
idmishkal int identity(1,1) primary key,
codemitzrach int foreign key references products(code),
kodmidaa int foreign key references Measures(kodmida),
mishkal float,
)


