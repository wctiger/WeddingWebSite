const apiRoot = 'https://jingyiguoandxiaoyang.azurewebsites.net';
//const apiRoot = 'http://localhost:54983';


const form = document.querySelector('.js--register')
form && form.addEventListener('submit', register)
const formButton = document.getElementsByClassName('js--button')[0]

function register (e) {
  e && e.preventDefault()
  e.target.checkValidity() && saveGuest(guest())
}

function saveGuest (guest) {
  //console.log(guest);
  formButton.disabled = true   
  $.ajax({
      method: 'POST',
      url: apiRoot + '/api/guest/registerguest',
    data: guest,
    success: function (msg) {
        console.log(msg);
        if (msg === 'success') {
            form.classList.add('js--complete');            
        }
        else {
            if (msg === 'WRONG_EMAIL_CODE')
                msg = 'Incorrect Email or Invitation Code. Please try again.';
            alert(msg);
            formButton.disabled = false;
        }
    },
    error: function () {
        alert('An error occurred. Please try again later. If problem persists, please contact me');
    }
  });
}

let guest = () => ({
  Email: document.getElementsByName('email')[0].value,
  Code: document.getElementsByName('code')[0].value,  
  NumAdults: document.getElementsByName('adults')[0].value,
  NumKids: document.getElementsByName('kids')[0].value,
  Message: document.getElementsByName('msg')[0].value,
  TimeStamp: new Date()
})
