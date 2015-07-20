# ExemploEntityFramework
Projeto com exemplo de uma aplicação básica em asp.net MVC utilizando Entity Framework 6.3.1 com SqlServer

===========================================================================================
O projeto inclui algumas classes para abstrair o Contexto do EF, ao invés de utilizar o DbContext Direto, utilizamos uma classe de contexto, uma de repositório, e outra de escopo. 

- Contexto : Extende o DbContext, tem a responsabilidade de conhecer os mapeamentos de tabelas, e comunicar com o banco;
- Repositorio: É utilizada para realizar comnandos em uma determinada tabela;
- Escopo: É a classe que é responsável por realizar a conexão com o banco, devolver os repositórios para a aplicação e realizar o commit das alterações.

===========================================================================================
Configuração para uma nova Entidade/Tabela
===========================================================================================

1 - Criar a classe com suas propriedades na pasta Model: A classe deve ter Id, deve ser analizada a necessidade de tamanho para escolher entre short (smallint), int (int) e long (bigint);
  
2 - Criar a classe de mapeamentos:  Na pasta \Models\ORM\Mapeamentos\ seguindo modelo das classes já existentes, setando tipo e tamano das colunas;

3 - Adicionar mapeamento ao contexto: Na pasta \Models\ORM\ Classe "Contexto", adicionar o mapeamento no método "ConfigurarMapeamento", isto faz com que o contexto do EntityFramework tenha conhecimento da tabela recem-criada;

4 - Migrations: Na aba Package Manager Console, que fica na parte inferior da IDE, digitar: 
 - add-migrations nomeQualquer (você escolhe o nome qualquer tá)
 - Depois de criado, update-database -script (caso vc não tenha o banco criado ainda, execute sem o -script)
 - Qualquer problema pesquisem entity framework migrations, ou me procurem que eu ajudo =D
 
5 - Se tudo deu certo tá pronto pra usar.

===========================================================================================
Criar cadastro básico
===========================================================================================

Para criar um cadastro, existem 1500 formas, pra testes o mais rápido é ir na pasta Controllers, clicar com o botão direito sobre ela e "add/controller", vai te mostrar uma série de opções, selecione MVC 5 controller with views, using Entity Framework, na próxima tela, selecione em Model class, a classe de entidade que criou anteriormente, e marcar as 3 opções: Generate views, Reference script libraries, use layout page "~/Views/Shared/_Layout.cshtml", e clicar em Add, depois disso tem que corrigir os métodos conforme o padrão dos controller existentes.
