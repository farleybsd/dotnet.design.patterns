/***
 *  Mediador 
 *  Padrao de Projeto Comportammental
 *  Com Objetivo impedir a comunicacao direta entre os objetos tendo um mediador responsavel por esse trabalho
 *  Exe:.
 *  Para exemplificar pense no mediador  como um carteiro as cartas(mensagens) estao na mao dele e ele que e o responsavel por entregar cada carta.
 *  Vamos criar uma solucao que permita troca de mensagem entre jogadores
 *  
 *  1 -> Comecaremos criando uma classe abastrada que representa o jogador.
 *  2 -> Criaremos os jogadores que irao estabelecer a mensagem 
 *  3 ->  Criaremos o Mediador
 *  4 -> Implementar o Mediador 
 * 
***/

using ChatJogadores._02;
using ChatJogadores._04;

MediadorConcreto mediador = new MediadorConcreto();

Jogador1 j1 = new Jogador1(mediador);
JogadorDois j2 = new JogadorDois(mediador);

mediador.JogadorUm = j1;
mediador.JogadorDois = j2;

j1.Enviar("A partida foi muito boa");
j2.Enviar("Foi Otima");

Console.ReadKey();