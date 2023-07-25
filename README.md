<h1 align="center">Explorador De Arquivos</h1>
<p>  Este é um programa em C# que implementa um explorador de arquivos. O programa percorre todos os diretórios e subdiretórios do diretório raiz escolhido pelo usuário e exibe todos os arquivos encontrados na saída do console.</p>
<br>
<h2>Como usar</h2>
<p>  Para usar, certifique-se de ter o C# e o Visual Studio, Visual Studio Code ou qualquer outro ambiente de desenvolvimento instalado na máquina.</p>
<ol>
      <li>Clone o repositório ou abra e o arquivo "program.cs" em um editor de código, como o Visual Studio.</li>
      <br>
      <li>O programa terá o diretório raiz definido como "C:\\", caso queira mudar basta modificar a linha: " foreach (string arquivo in GetArquivos("C:\\")) " com o diretório raiz escolhido.</li>
      <br>
      <li>Compile e execute o código para que seja possível a exploração de arquivo.</li>
      <br>
      <li>O programa irá explorar todos os diretórios e subdiretórios do diretório raiz e exibirá os nomes de todos os arquivos encontrados no console.</li> 
</ol>
<br>
<h2>Pontos importantes</h2>
<ol>
  <li>Caso o programa encontre diretórios para os quais não possui permissão de acesso, ele continuará explorando os outros diretórios 
      normalmente, sem interromper a execução.</li>
      <br>
  <li>O programa ultiliza a biblioteca "System.IO" do .NET para acessar e exibir os diretórios.</li>
      <br>
  <li>Tenha em mente que em diretórios muitos grandes, ele pode levar algum tempo para concluir a execução.</li>
</ol>
<br>
<h2>Contribuições</h2>
<p>  Se você encontrou um bug ou tiver alguma sugestão, sinta-se à vontade para abrir um "Pull Request".</p>
