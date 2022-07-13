
create database Recepies
go
use Recepies
go
create table products(
idprod int identity(1,1)  ,--��� ���� �����
code int primary key,
smlmitrach int,--��� ����
shmmitzrach varchar(60) ,--�� ����
protein float ,--�����
total_fat float,--�� ����
food_energy float,--�������
carbohydrates float,--������ ������
total_dieatry_fiber float,--�����
calcium float,--����
iron float ,--����
total_sugars float ,--������
trans_fatty_acids float,--���� �����
magnesium float,--�������
phosphours float,--����
potassium float,--�����
sodium float,--����
zinc float,--���
cholesterol float,--��������
saturated_fat float,--���� ����
vitamin_a_ui float,--������ �� �� ��
vitamin_e float,--������ ��
vitamin_c float,--������ ��
vitamin_a_re float,--������ �� �������
vitamin_k float,--������ ��
vitamin_b6 float,--������ �� ��
vitamin_b12 float,--������ �� ����� ����
vitamin_d float,--������ ��
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
--double mono_saturated,--���� �� ���� ���� 
--double poly_saturated,--���� �� ���� ����
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


