# HotAPI_Modelo

Modelo de projeto para o Visual Studio 2022 utilizando a HotAPP.

A HotAPI facilita a criação de APIs web/desktop usando Blazor.

Veja mais detalhes na <a href="https://github.com/mrebello/HotAPP">HotAPP</a>.


Para instalar o modelo, use <a href="https://github.com/mrebello/HotAPI_Modelo/raw/master/HotAPP_Modelo_install.exe">este instalador</a>.

O instalador extrai o arquivo HotAPP_Modelo.zip para a pasta
%USERPROFILE%\Documents\Visual Studio 2022\Templates\ProjectTemplates

## Falta implementar:

- Não está excluindo os arquivos API.xml e wwwroot\(ApplicationName).styles.css da publicação da aplicação



## Principais recursos:

- Encapsulamento das funções usadas para gerar o APP, deixando o projeto extremamente simples
- Utiliza recursos da <a href="https://github.com/mrebello/HotAPI">HotAPI</a>
	- aplicativo *selfhosting*
	- aplicativo *sefthosting* publicado em arquivo único
	- serviço de windows
	- serviço de linux
	- aplicação hospedada no IIS
- Adiciona
    - aplicação desktop (usando Photino)
- arquivos de configuração (appsettings.json) e documentação da API embutidos no executável
- arquivos estáticos embutidos no executável
- Linha de comando para instalação/desinstalação como serviço
- Linha de comando para atualização de aplicativo ou serviço rodando em outra máquina (atualizar a aplicação em produção)
- Simplificação de acesso às configurações de aplicativo
- Logs por email e em arquivo
- Publicação em arquivo único funcionando para Windows e Linux

Instale o modelo de projeto e veja a simplicidade da aplicação gerada!

Mais detalhes na <a href="https://github.com/mrebello/HotAPP">HotAPP</a>, <a href="https://github.com/mrebello/HotAPI">HotAPI</a> e <a href="https://github.com/mrebello/HotLIB">HotLIB</a>.
