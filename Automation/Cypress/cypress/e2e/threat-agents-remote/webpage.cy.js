describe('Threat Agents Remote site', () => {
  it('can be accessed', () => {
    cy.visit('https://threatagentsgame.com/remote/')
    cy.title(true).should('eq', 'Threat Agents Remote')
  })
})