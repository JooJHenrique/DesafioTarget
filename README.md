1. Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo 0, 1, 1, 2, 3, 5, 8, 13, 21, 34....) escreva um programa na linguagem que desejar onde, informando um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
[Resposta da primeira questão](https://github.com/JooJHenrique/DesafioTarget/blob/master/DesafioTarget/Fibonacci/Fibonnaci.cs).

2. Escreva um programa que verifique, em uma string, a existência da letra 'a', seja maiúscula ou minúscula, além de informar a quantidade de vezes que ela ocorre.<br>
[Resposta da segunda questão](https://github.com/JooJHenrique/DesafioTarget/blob/master/DesafioTarget/FindStringA/FindLetraA.cs).

3. Observe o trecho de código abaixo:<br>
int INDICE = 12, SOMA = 0; enquanto K < INDICE faça {K = K + 1; SOMA = SOMA + K; } imprimir (SOMA);<br>
Ao final do processamento, qual será o valor da variável SOMA ?<br>
[Resposta da terceira questão](https://github.com/JooJHenrique/DesafioTarget/blob/master/DesafioTarget/VariavelSOMA/VariavelSOMA.cs). = 78

4. Descubra a lógica e complete o próximo elemento:<br>
a) 1, 3, 5, 7, 9<br>
b) 2, 4, 8, 16, 32, 64, 128<br>
c) 0, 1, 4, 9, 16, 25, 36, 49<br>
d) 4, 16, 36, 64, 100<br>
e) 1, 1, 2, 3, 5, 8, 13<br>
f) 2, 10, 12, 16, 17, 18, 19, 200<br>

5. Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em salas diferentes. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser, sei objetivo é descobrir qual interruptor controla qual lâmpada. Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada ?<br>

Resposta:<br>

Entendendo que há 3 salas cada um com uma lâmapda:<br>
Na primeira ida:

- Ligo o interruptor  1 por 5 minutos e o desligo, ligo oo interruptor 2 e na mesma hora vou até uma das 3 salas
- Se a lampada estiver acessa, pertence ao interruptor 2, se estiver desligada e quente pertence ao interruptor 1, se estiver desligada e fria pertence ao interruptor 3.

Na segunda ida:
- Sabendo já a qual pertence um interruptor, apenas deixo um ligado e outro desligado entre o restantes
- Vou até outra sala e descubro os outros dois.


