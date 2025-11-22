describe('Threat Agent Cards', function () {
  beforeEach(function () {
    Cypress.config('baseUrl', 'https://www.r-adams.co.uk/apitestactivities/profile')
  })

  context("GET /profile/", () => {
    it("returns a result without authentication", () => {
      cy.request("GET", "/").then((response) => {
        expect(response.status).to.eq(200)
      })
    })
  })

  context("GET /profile/get/", () => {
    it("requires authentication", () => {
      cy.request({
        method: "GET",
        url: "/get/",
        failOnStatusCode: false
      }).then((response) => {
        expect(response.status).to.eq(401)
      })
    })
  })

  context("GET /profile/get/", () => {
    it("authentication succeeds", () => {
      cy.request({
        method: "GET",
        url: "/get/",
        auth: {
          username: 'TestUser',
          password: 'TestPw'
        }
      }).then((response) => {
        expect(response.status).to.eq(200)
      })
    })
  })

  context("GET /profile/get/", () => {
    it("body contains profile info in JSON", () => {
      cy.request({
        method: "GET",
        url: "/get/",
        auth: {
          username: 'TestUser',
          password: 'TestPw'
        }
      }).then((response) => {
        const responseBody = JSON.parse(response.body)
        expect(responseBody).to.have.property('username', 'TestUser')
        expect(responseBody).to.have.property('password', 'TestPw')
        expect(responseBody).to.have.property('role', 'User')
        expect(responseBody).to.have.property('bio', 'This is a test biography. Enjoy.')
      })
    })
  })
})