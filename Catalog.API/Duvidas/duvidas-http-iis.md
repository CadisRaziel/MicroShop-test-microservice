# Por que escolher HTTP (Kestrel) em vez de IIS Express?

É o mesmo servidor do Docker: O Kestrel é o servidor Web nativo, multiplataforma e de alta performance do .NET. Quando empacotarmos a API dentro do contêiner Linux no Docker, 
será exatamente o Kestrel que rodará lá dentro.
Logs no Console: Rodando via HTTP/Kestrel, a IDE abre uma janela de terminal que exibe todas as requisições, erros e logs SQL em tempo real enquanto você testa.
Sem acoplamento ao Windows: O IIS Express é um servidor legado exclusivo para Windows. Para microsserviços modernos e contêineres, ele adiciona uma camada desnecessária.iner 