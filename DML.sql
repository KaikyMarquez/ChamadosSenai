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
Values				('FE297A6E-3A19-4A17-A7EA-34D61C913CC5',1,'3º Andar','Limpeza','Suco no chão, proximo ao bebedouro','387BA4E9-DBEC-4C43-84D2-8F1C6F2AB045');




go

SELECT*FROM TipoUsuario

SELECT*FROM Usuario

SELECT*FROM Instituicao

SELECT*FROM Equipamento

SELECT*FROM Chamado

DELETE from Usuario WHERE id=0602B448-D542-409E-B225-13D7726E96DD