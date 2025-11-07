const { beforeEach } = require("mocha")
const { before } = require("mocha")

//Inicio
describe('Grupo 1: Inicio', () => {
  it('entrar a la pagina principal', () => {
    cy.visit('https://localhost:7258')
    cy.url().should('include', 'localhost:7258')
    cy.get('.navbar-brand').should('have.text', 'ManejoPresupuesto')
    cy.get('.display-4').should('have.text', 'Welcome')

  })

   it('entrar a la TiposCuentas', () => {
    cy.visit('https://localhost:7258')
    cy.get(':nth-child(2) > .nav-link').should('have.text', 'Tipos Cuentas').click()
    cy.url().should('include', '/TiposCuentas')
    cy.get('h1').should('have.text', 'Tipos Cuentas')
    cy.get('.pb-3 > .mb-3').should('have.text', 'Crear nuevo')
    cy.get('.table').should('exist')


  })



})

describe('Grupo 2: Leer', () => {
  beforeEach('Entrar a tipos cuentas', () => {
    cy.visit('https://localhost:7258')
    cy.get(':nth-child(2) > .nav-link').should('have.text', 'Tipos Cuentas').click()
    cy.url().should('include', '/TiposCuentas')
    cy.get('h1').should('have.text', 'Tipos Cuentas')


  })

  it('Leer TiposCuentas', () => {
    cy.get('.table').should('exist')
    cy.get('tbody > :nth-child(1) > :nth-child(2)').should('exist')
  })
  
})





