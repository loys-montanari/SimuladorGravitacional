
<h1 align="center">
    Simulador Gravitacional 🪐

</h1>



## 💻 Descrição do Projeto

Esta atividade acadêmica teve como intuito a implementação de um simulador gravitacional 2D, que lê as informações dos corpos em um arquivo texto formatado, realiza os cálculos necessários e posteriormente armazena os resultados em outro arquivo texto formatado.

No arquivo de entrada, foram definidos: 
•	A quantidade de corpos.
•	A quantidade de iterações.
•	O tempo utilizado em cada iteração.
•	As informações de cada corpo:
o	Nome;
o	Massa;
o	Raio;
o	PosX;
o	PosY;
o	VelX;
o	VelY.

No arquivo de saída foi armazenado, para cada iteração, as informações de cada corpo, com as informações atualizadas de posição e velocidade, após a realização dos cálculos.

Para obter-se o valor das velocidades e posições em cada iteração, seguiu-se os seguintes passos:
1)	Calculou-se a distância entre os centros dos corpos, sempre de 2 em 2 corpos. Utilizando a fórmula da distância entre 2 pontos em um plano cartesiano, a partir do teorema de Pitágoras. 
2)	Utilizando a Fórmula da Gravitação Universal, calculou-se a Força de Atração Gravitacional entre 2 corpos;
3)	Por meio da decomposição vetorial, com as propriedades de seno e cosseno, decompõe-se a Força de Atração Gravitacional em “Força de Atração na Direção X” e “Força de Atração na Direção Y”.
4)	Para cada um dos corpos, somou-se todas as forças na direção X e na direção Y;
5)	Para cada um dos corpos, com o somatório das forças, na direção X e depois na direção Y, calculou-se: 
a.	Utilizando a 2ª Lei de Newton (Princípio Fundamental da Dinâmica), calculou-se a Aceleração adquirida pelo corpo, na direção X, a partir da Força de Atração na Direção X e da massa do corpo.

b.	Utilizando a Função Horária da Velocidade do MRUV (Movimento Retilíneo Uniformemente Variado), calculou-se a Velocidade na Direção X, a partir da velocidade inicial na direção X, da Aceleração na direção X (calculada em 5.a) e do tempo (definido no arquivo de entrada). 

c.	Utilizando a Função Horária da Posição do MRUV (Movimento Retilíneo Uniformemente Variado), calculou-se a Posição na Direção X, a partir da posição inicial na direção X, da Velocidade na direção X (calculada em 5.b), da Aceleração na direção X (calculada em 5.a) e do tempo (definido no arquivo de entrada). 

d.	Realizou-se os mesmos cálculos mencionados em 5.a, 5.b e 5.c para a direção Y.

e.	Armazenou-se as informações do corpo, com a atualização das Posições (X,Y) e Velocidades (X,Y) , referente a esta iteração.

Com a movimentação dos Corpos Celestes, devido a Força de Atração Gravitacional, em determinados momentos podem ocorrer colisões entre 2 corpos, assim, para tratar estes casos fez-se as seguintes considerações: 
1)	Verificou-se a distância entre os centros dos corpos, quando esta distância é MENOR que a soma dos raios dos corpos, identifica-se a COLISÃO.
2)	Considerou-se que todos os corpos celestes são esféricos, sendo então possível obter seu volume por meio do Raio.
3)	Adotou-se que após a colisão, a nova posição do corpo celeste será dada pelo cálculo do Centro de Massa. O centro de massa é uma posição definida relativa a um objeto ou sistema de objetos. Sendo que é a posição média de todas as partes do sistema, ponderada de acordo com a massa de cada objeto.
4)	Considerou-se que todas as colisões são PERFEITAMENTE INELÁSTICAS, e sendo que a quantidade de movimento sempre se conserva, temos Qantes = Qdepois, sendo Q = m*v, temos: m1v1+m2v2 = (m1+m2)*Vfinal, calcularemos separadamente para X e Y.

Quando ocorrem COLISÕES (distancia < raio1 + raio2), o simulador gravitacional realiza as seguintes tarefas: 
1)	Não chamado o método que calcula a Força de Atração Gravitacional entre os 2 corpos;

2)	É criado um novo corpo celestial, possuindo os seguintes atributos:

a.	Nome: Concatenar nomes[Cp1Cp2]

b.	Massa: m1+m2

c.	Raio: 1º Calcular Volume Cp1 e Volume Cp2 usando a fórmula: V = 4/3*(pi()*r^3)     2º Somar Volume 1 e Volume 2.   3º Calcular o RaioNovo usando a fórmula [r = ((3*somavolumes)/(4*pi()))^1/3]

d.	PosX: PosXnovo = ((PosX1*m1)+(PosX2*m2))/(m1+m2)

e.	PosY: PosYnovo = ((PosY1*m1)+(PosY2*m2))/(m1+m2)

f.	VelX: Vnovox = ((m1*veloc1x) + (m2*veloc2x)) / (m1+m2)

g.	VelY: Vnovoy = ((m1*veloc1y) + (m2*veloc2y)) / (m1+m2)

3)	É atualizada a lista de corpos celestes, com a remoção dos corpos celestes que colidiram e inclusão do novo corpo celeste, a partir da iteração onde ocorreu a colisão.



---


## ⚙️ Ferramentas utilizadas

**C#**


---


## Autores

  <br>

  
  <a href="https://github.com/loys-montanari">
  <img src="https://img.shields.io/static/v1?label=Github&message=@loys-montanari&color=7159c1&style=for-the-badge&logo=github"/>
  <br>
  <a href="https://www.linkedin.com/in/loyslene-montanari-55380511b/">
  <img src="https://img.shields.io/static/v1?label=Linkedin&message=Loyslene Montanari&color=7159c1&style=for-the-badge&logo=linkedin"/>

      
  <br>
  <br>
  <br>

  
  
  <a href="https://github.com/vanessa-sm">
  <img src="https://img.shields.io/static/v1?label=Github&message=@vanessa-sm&color=7159c1&style=for-the-badge&logo=github"/>
  <br>
  <a href="https://www.linkedin.com/in/vanessa-machado-4302b8ab/">
  <img src="https://img.shields.io/static/v1?label=Linkedin&message=Vanessa Machado&color=7159c1&style=for-the-badge&logo=linkedin"/>

    

    
  

