<h1>DESAFIO #1</h1>
<h2>Passos: </h2> <br/>
•	Crie a classe Pessoa<br/>
•	Crie a classe Aluno<br/>
•	Outras classes se necessário<br/>
•	Aluno herda os atributos e métodos de Pessoa<br/>
•	Analise o manual do arquivo .txt disponibilizado pelos professores para pensar nos métodos e atributos de cada classe<br/>
•	Leia o arquivo .txt disponibilizado pelos professores<br/>
•	Extraia os dados do .txt e crie objetos destes dados<br/>
•	Mostre na tela, quantos objetos Pessoa e quantos Alunos foram criados.<br/>
•	Mostre os cursos de cada Aluno!<br/>

<h2>Manual do arquivo txt:</h2><br/>
<h3>Geral:</h3><br/>
•	“-“ é o caractere delimitador, ele separa os dados em uma mesma linha!<br/>
•	Cada linha tem um significado<br/>
•	A linha que começa com “X” é o cabeçalho, só informa que o arquivo é referente Pessoas<br/>
•	A linha que começa com “Z” traz os dados dos alunos<br/>
•	A linha que começa com “Y”, é referente ao curso que a Pessoa esta cursando, a linha “Y” vem sempre depois de uma linha “Z”, 
logo, a linha “Y” é sobre o curso do Aluno(“Z”).<br/>
•	Nem sempre uma linha “Z” é seguida por uma linha “Y”, significa que é uma Pessoa cadastrada, e não um aluno. Logo, após
uma linha “Z” aparece outra linha “Z”.<br/>

<h3>Linha X:</h3><br/>
•	Cabeçalho do arquivo<br/>
•	Exemplo : X-4565-486544<br/>
•	Dica: Ignorar esta linha<br/>

<h3>Linha Z:</h3><br/>
•	Traz dados das pessoas<br/>
•	Sintaxe: Z-[nome]-[telefone]-[cidade]-[RG]-[CPF]<br/>

<h3>Linha Y:</h3><br/>
•	Traz dados da matricula do aluno (curso)<br/>
•	Sintaxe: Y-[matricula]-[código do curso]-[nome do curso]<br/><br/>

<img src = "/img/Captura de tela 2023-05-25 195432.png">