Use Chamados

go

Insert into TipoUsuario		(NomeTipoUsuario)
Values						('Suporte'),
							('Manutecao'),
							('Limpeza'),
							('Administrador');
		
go

Insert into Usuario (IdTipoUsuario,EmailUsuario,SenhaUsuario)
Values				(1,'suporte@suporte.com','suporte123'),
					(2,'manutecao@manutecao.com','manutecao123'),
					(3,'limpeza@limpeza.com','limpeza123'),
					(4,'adm@adm.com','adm123');

go

Insert Into Instituicao (NomeInstituicao,CNPJ,CEP,Pais,Estado,Cidade,Bairro,Numero,Endereco,Telefone)
Values					('Senai','03774819000102','01202001','Brasil','São Paulo','São Paulo','Santa Cecilia','539','Alameda Barão de Limeira','00000000000');

go

Insert Into Equipamento (IdInstituicao,NomeEquipamento,Descricao)
Values					(1,'Switch Cisco 2960', 'Switch de 24 Portas em otimo estado');

go

Insert Into Chamado (IdUsuario,IdInstituicao,Localizacao,Motivo,Descricao,IdReceberChamado)
Values				('ECBF1424-6AD6-4CD8-993C-673472B57998',1,'3º Andar','Limpeza','Suco no chão, proximo ao bebedouro','B1B049C5-D17C-4EBF-9F64-5E991EECEB01');




go

SELECT*FROM TipoUsuario

SELECT*FROM Usuario

SELECT*FROM Instituicao

SELECT*FROM Equipamento

SELECT*FROM Chamado