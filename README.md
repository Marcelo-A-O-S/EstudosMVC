# SecondLife - Estudo API

Esse projeto foi feito para aprimoramento dos meus conceitos adquiridos no projeto anterior, estou abordando neste projeto, conceitos mais usuais na programação usando a linguagem C# e o ambiente ASP.NET Core e aprofundando os meus conhecimento, testando também técnicas mais elaboradas de organização!!  
O intuito desse projeto é abordar um problema real com os conhecimentos que tenho e também os conhecimentos que irei adquirir durante o processo!  


Esse projeto está em desenvolvimento, podendo ocorrer alterações devido ao seu desenvolvimento!

## Status do Projeto

Ainda em desenvolvimento...

## Stacks Utilizada

**Back-end:** ASP.NET Core, .NET, C#

## Arquitetura em três camadas, um pouco sobre!

 O que é arquitetura me três camadas? Arquitetura em três camadas é um padrão de arquitetura de projetos que consiste em dividir cada parte da aplicação, organizando cada parte em sua devida responsabilidade! 

**Camada Presentation**: Conhecida como camada de apresentação, é a parte de visualização do projeto, que será responsável por receber e apresentar os dados ao usuário

 **Camada Bussiness**: Conhecida como camada de negócio, é a camada que ficará responsável em tratar as funcionalidades do projeto, e assim enviando para camada de banco de dados, é camada de lógica do projeto

 **Camada Database**: Conhecida como camada de banco de dados, essa camada é responsável pelo acesso ao banco de dados, qualquer função que seja responsavel por acessar o banco de dados, fica esta camada


 O benefício dessa arquitetura, é que pela sua divisão, possibilita de forma mais eficiente, escalar uma aplicação, sem que cada camada afete outra camada e dessa forma dedicando cada equipe a cada camada especifica de atuação em um contexto empresarial, aumentando a segurança de desenvolvimento!  
 Uma pequena demonstração em diagramação dos conceitos acima: 
 
 ![Diagramacaotrescamadas](https://user-images.githubusercontent.com/77033790/216140822-918b4aaa-3bfc-443e-9d60-614a08da822d.PNG)

Nessa demonstração mostra a relação entre camadas na aplicação, aonde a camada de apresentação comunica com a camada de camada de negócio, onde a camada de négocio comunica com a camada de database que por sua vez faz o caminho reverso!

Nessa projeto também será adicionado uma camada adicional chamada ModelDomain, já que será usado nesse projeto o framework do entityframework, para que assim possa ser feito a referência dos projetos de maneira que siga as condições de funcionalidades do projeto!

## Licença

[MIT](https://choosealicense.com/licenses/mit/)


## Referência

 - [Arquitetura de três camadas (tiers)](https://www.ibm.com/br-pt/cloud/learn/three-tier-architecture)

