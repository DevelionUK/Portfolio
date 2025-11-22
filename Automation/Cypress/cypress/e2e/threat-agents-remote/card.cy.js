describe('Threat Agent Cards', function () {
  beforeEach(function () {
    cy.visit('https://threatagentsgame.com/remote/')
  })

  context('The card behaviour when page is initially opened', function () {
    it('exists', () => {
      cy.get('[id="Small-The-Liar"]').should('exist')
    })
    it('defaults to the card image', function() {
      cy.get('[id="Small-The-Liar"]').should('exist')
      cy.get('[id="Small-The-Liar"]').should('have.attr', 'src').should('include','Small-The-Liar.png')
      cy.get('[id="Small-The-Liar"]').click()
      cy.get('[id="Small-The-Liar"]').should('have.attr', 'src').should('include','ThreatAgentBg.png')
    })
  })

  context('The card behaviour when clicked', function () {
    it('changes to the reverse image', function() {
      cy.get('[id="Small-The-Liar"]').click()
      cy.get('[id="Small-The-Liar"]').should('have.attr', 'src').should('include','ThreatAgentBg.png')
    })
  })
})