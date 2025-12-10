import http from 'k6/http';
import { check } from 'k6';
import { parseHTML } from 'k6/html';
import { expect } from 'https://jslib.k6.io/k6chaijs/4.3.4.3/index.js';

const getUrl = 'http://localtesting:5109/Game/';
const postUrl = 'http://localtesting:5109/Game/SubmitInt';

export const options = {
  vus: 1,
  duration: '30s',
  // define thresholds
  thresholds: {
    http_req_failed: ['rate<0.01'], // http errors should be less than 1%
    http_req_duration: ['p(99)<500'], // 99% of requests should be below 500ms
  },
};

export default function() {
  //
  // Check that the GET URL can load
  //
  let res = http.get(getUrl);
  check(res, { "GET status is 200": (res) => res.status === 200 });

  // Submit the form with any number between 1-4 (valid answers)
  res = res.submitForm({
    formSelector: 'form',
    fields: { UserAnswer: Math.ceil(Math.random() * 4) },
  })

  check(
    res,
    {
      "Submit status is 200": (res) => res.status === 200,
      "Submit URL": (res) => res.request.url === postUrl
    });

  //
  // Check the question title to see if it is the Game Over or Quest Complete! message.
  // The intent is that we should have a low hit rate if you just press random numbers...
  //
  const doc2 = parseHTML(res.body);
  let currentQ = doc2.find('h1').text();
  
  expect(currentQ, 'question title').to.not.equal('Quest Complete!');
  expect(currentQ, 'question title').to.not.equal('Game Over');
}
