/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package poo;

/**
 *
 * @author Icaro
 */
public class Gerente extends Funcionario{
    @Override
    public double calcularParticipacaoNosLucros(){
    return getSalario() * 0.5;
    }
}
