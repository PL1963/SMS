function isValidEmail(email) {
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}

function isValidPhoneNumber(phoneNumber) {
    var phoneRegex = /^\d{10}$/;
    return phoneRegex.test(phoneNumber);
}



$(document).ready(function () {
    $("#form").submit(function (e) {
        // Clear previous error messages
        $(".error-message").remove();

        // Perform validation
        var isValid = true;

        // Validate First Name
        var firstName = $("#FirstName").val();
        if (!firstName) {
            isValid = false;
            $("#FirstName").after('<span class="error-message">Please enter First Name</span>');
        }

        // Validate Last Name
        var lastName = $("#LastName").val();
        if (!lastName) {
            isValid = false;
            $("#LastName").after('<span class="error-message">Please enter Last Name</span>');
        }

        // Validate Age
        var age = $("#Age").val();
        if (!age || isNaN(age) || parseInt(age) <= 0) {
            isValid = false;
            $("#Age").after('<span class="error-message">Please enter a valid Age</span>');
        }

        // Validate Date of Birth
        var dob = $("#DateOfBirth").val();
        if (!dob) {
            isValid = false;
            $("#DateOfBirth").after('<span class="error-message">Please enter Date of Birth</span>');
        }


        // Validate Email
        var email = $("#Email").val();
        if (!email || !isValidEmail(email)) {
            isValid = false;
            $("#Email").after('<span class="error-message">Please enter a valid Email address</span>');
        }



        var cname = $("#CourseName").val();
        if (!cname) {
            isValid = false;
            $("#CourseName").after('<span class="error-message">Please enter CourseName</span>');
        }

        // Validate Phone Number
        var phoneNumber = $("#PhoneNumber").val();
        if (!phoneNumber || !isValidPhoneNumber(phoneNumber)) {
            isValid = false;
            $("#PhoneNumber").after('<span class="error-message">Please enter a valid Phone Number</span>');
        }


        var UName = $("#UniversityName").val();
        if (!UName) {
            isValid = false;
            $("#UniversityName").after('<span class="error-message">Please enter University</span>');
        }

        var yearOfPassing = $("#YearOfPassing").val();
        if (!yearOfPassing || isNaN(yearOfPassing) || parseInt(yearOfPassing) <= 0) {
            isValid = false;
            $("#YearOfPassing").after('<span class="error-message">Please enter a valid Year of Passing</span>');
        }

        // Validate Percentage
        var percentage = $("#Percentage").val();
        if (!percentage || isNaN(percentage) || parseFloat(percentage) < 0 || parseFloat(percentage) > 100) {
            isValid = false;
            $("#Percentage").after('<span class="error-message">Please enter a valid Percentage</span>');
        }

        

        
        if (!isValid) {
            e.preventDefault();
        }
    });
    // Function to validate email address





});

