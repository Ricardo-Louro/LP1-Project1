# **LP1-Project1**
---
##### **Autoria:** 

| Nome | Número |
| - | - |
| Ricardo de Almeida | 21807601 |
| Paulo Silva | 22206205 | 
**Ricardo Almeida:**
 - Criou os ficheiros
 - Adicionou os métodos de pedir informação ao utilizador e interação com as lâmpadas
 - Criou Flags
 - Melhorou código para ser mais legível, compacto e eficiente
 - Adicionou comentários
**Paulo Silva:**
 - Criou a condição de vitória
 - Criou o loop do jogo
 - Adicionou enumeração
 - Deixou o jogo mais legível ao utilizador
---
**Repositório Git:** [GitHub](https://github.com/Ricardo-Louro/LP1-Project1)

##### **Arquitetura da Solução:**
**Program.cs:**
- Define-se uma variável de vitória;
- Vai-se buscar os valores das lâmpadas e definimos uma nova varável com essa informação;
- Mostramos que as lâmpadas estão todas desligadas;
- Começa o loop do jogo:
  - Mostramos o turno em que o jogador se encontra;
  - Pedimos ao jogador que botão quer selecionar;
  - E recebemos na variável de vitória se o jogador ganhou ou não;
    - Caso o jogador tenha ganho, o loop acaba;
  - O loop acaba depois de 6 turnos;
- Caso o jogador não ganhe, mostra a mensagem que perdeu;

**LampState.cs:**
- Define o valor de cada lâmpada;

**Selectors.cs:**
- Inicializa a variável botão;
- Começa o loop da pergunta ao jogador:
  - Pedimos ao jogador que escolha o botão a premir e adicionamos a uma varável string;
  - Tentamos tornar o string em um int:
    - Caso seja sucedido para aí;
    - Caso não dê, pede-se ao jogador que mande uma nova resposta;
  - Verifica se o número escolhido é entre 1 a 3, se não pede-se ao jogador que mande uma nova resposta;

**Output.cs:**
- Inicializa a variável botão;
##### **Fluxograma:**

##### **Referências:**
 - [W3Schools](https://www.w3schools.com/python/) para a consulta das diversas funções e funcionalidades de Python utilizadas durante este trabalho (ex: *Class*, *isinstance()*, etc...)
 
 - [GeeksForGeeks](https://www.geeksforgeeks.org/clear-screen-python/) para a consulta de referências para problemas que não tinha encontrado previamente.
 
 - [Docs.Python](https://docs.python.org/) para a consulta de diversas funções e funcionalidades de Python de forma mais aprofundada e específica do que W3Schools., utilizado maioritariamente para perceber o *defaultdict()* e a biblioteca *os*.