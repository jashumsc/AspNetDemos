const signupBtn = document.querySelector(".signupBtn");
const loginBtn = document.querySelector(".loginBtn");
const moveBtn = document.querySelector(".moveBtn");
const signup = document.querySelector(".signup");
const login = document.querySelector(".login");



loginBtn.addEventListener("click", () => {
    moveBtn.classList.add("rightBtn");
    login.classList.add("loginForm");
    signup.classList.remove("signupForm");
    moveBtn.innerHTML = "Login";
})

signupBtn.addEventListener("click", () => {
    moveBtn.classList.remove("rightBtn");
    login.classList.remove("loginForm");
    signup.classList.add("signupForm");
    moveBtn.innerHTML = "Signup";
})

function fCheckRequired(txtBox, errSpan) {
	var isValid = false;
	if (txtBox.value == "") {
		errSpan.innerText = "*";
		isValid = false;
	}
	else {
		errSpan.innerText = "";
		isValid = true;
	}
	return isValid;
}

function fValidateName() {
	var isValid = fCheckRequired(window.document.Form1.fname, document.getElementById('errfname'));
	if (fname.value != "") {
		if (isFinite(fname.value)) {
			errfname.innerText = "only alphabets";
			isValid = false;
		}
	}
	return isValid;
}

function fValidateLname() {
	var isValid = fCheckRequired(window.document.Form1.lname, document.getElementById('errlname'));
	if (lname.value != "") {
		if (isFinite(lname.value)) {
			errlname.innerText = "only alphabets";
			isValid = false;
		}
	}
	return isValid;
}

function fValidatePass() {
	var isValid = fCheckRequired(window.document.Form1.pass, document.getElementById('errpass'));
	var Pass = window.document.Form1.pass.value;
	if (Pass != "") {
		if (Pass.length > 0 && Pass.length < 8) {
			errpass.innerText = "Password should be more than 8 characters";
			isvalid = false;
		} else {
			isValid = true;
		}
	}
return isValid;
}

function fValidateCpass() {
	var isValid = fCheckRequired(window.document.Form1.cpass, document.getElementById('errcpass'));
	var Pass = window.document.Form1.pass.value;
	var Cpass = window.document.Form1.cpass.value;
	if (Cpass.length > 0 && Cpass.length < 8) {
		errcpass.innerText = "Password should be 8 or more characters";
		isValid = false;
	}else if (Pass != "" && Cpass != "") {
		if (Pass != Cpass ) {
			errcpass.innerText = "Password doesnt match";
			isValid = false;
		}
		else {
			isValid = true;
		}
	}
return isValid;
}

function fValidateEmail() {
	var isValid = fCheckRequired(window.document.Form1.email, document.getElementById('erremail'));
	var testemail = window.document.Form1.email.value;
	var validRegex = /^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)$/;
	if (testemail) {
		if (!testemail.match(validRegex)) {
			erremail.innerText = "Please provide in 'somename@domain.com' format";
			isValid = false;
		}
	}
	return isValid;
}

function fValidateAll() {
	var isValidName, isValidlname, isValidpass,isValidemail, isValidcpass;
	isValidName = fValidateName();
	isValidlname = fValidateLname();
	isValidpass = fValidatePass();
	isValidcpass = fValidateCpass();
	isValidemail = fValidateEmail();
	return (isValidName && isValidlname && isValidpass && isValidcpass && isValidemail);
}

function fSubmitMe() {
	if (fValidateAll()) {
		alert("Register succesfull")
	window.document.Form1.submit();
}
}




function fValidateLpass() {
	var isValid = fCheckRequired(window.document.Form2.lpass, document.getElementById('errlpass'));
	var Lpass = window.document.Form2.lpass.value;
	if (Lpass != "") {
		if (Lpass.length > 0 && Lpass.length < 8) {
			errlpass.innerText = "Password must be 8 or more characters";
			isValid = false;
		} else {
			isValid = true;
		}
	}
	return isValid;
}

function fValidateLemail() {
	var isValid = fCheckRequired(window.document.Form2.lemail, document.getElementById('errlemail'));
	var temail = window.document.Form2.lemail.value;
	var validRegex = /^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)$/;
	if (temail) {
		if (!temail.match(validRegex)) {
			errlemail.innerText = "Please provide in 'somename@domain.com' format";
			isValid = false;
		}
	}
	return isValid;

}

function fValidateAll1() {
	var isValidLpass, isValidLemail;
	isvalidLemail = fValidateLemail();
	isValidLpass = fValidateLpass();
	return (isValidLpass && isvalidLemail);
}

function fSubmitMe1() {
	if (fValidateAll1()) {
		
		window.document.Form2.submit();
		alert("Login Successfull");
	}
}



