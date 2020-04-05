var User_Login = {
    Init: function () {

    },
    Login: {
        Login: function () {
            var email = $("#user-login-email").val();
            var password = $("#user-login-password").val();
            var rememberMe = $("#user-login-rememberme").prop("checked");

            var data = { Email: email, Password: password, RememberMe: rememberMe };

            data = JSON.stringify(data);

            $.ajax({
                type: "POST",
                url: "/user/loginaction",
                data: data,
                success: User_Login.Login.Login_Callback,
                error: User_Login.Login.Login_Callback_Error,
                dataType: "json",
                contentType: "application/json; charset=utf-8;"
            });
        },
        Login_Callback: function (result) {
            window.location = "/";
        },
        Login_Callback_Error: function (result) {
            alert("YAPTIĞIN AYIP");
        }
    },
    validateEmail: function (email) {
        var re = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
          return re.test(String(email).toLowerCase());
            },
    Register: {
        Register: function () {
            var name = $("#user-register-name").val();
            var surname = $("#user-register-surname").val();
            var email = $("#user-register-email").val();
            var password = $("#user-register-password").val();
            var password2 = $("#user-register-password2").val();

            //client side validation
            //send to server
            
            if (password != password2)
            {
                Helper.UI.Alert("Hata", "Oluşturduğunuz şifre, tekrar şifresi ile aynı değil!", "error");          
            }
            else if (name.length < 2 || name.length > 50)
            {
              Helper.UI.Alert("hata","isim uzunluğuna dikkat edin","error");
            }
            else if (surname.length < 2 || surname.length > 50)
            {
              
                Helper.UI.Alert("Hata", "Şuanki şifreniz 8 karakterden kısa 64 karakterden uzun olamaz!", "error");
            }
            else if (password.length < 8 || password.length > 64)
            {
              
                Helper.UI.Alert("Hata", "Oluşturduğunuz şifre 8 karakterden kısa 64 karakterden uzun olamaz!", "error");
            }
            else if (password2.length < 8 || password2.length > 64)
            {
              
                Helper.UI.Alert("Hata", "Tekrar şifreniz 8 karakterden kısa 64 karakterden uzun olamaz!", "error");
            }
            else if (User_Login.validateEmail(email) == false)
            {
                Helper.UI.Alert("Hata", "Geçerli bir email giriniz!", "error");
            } else {
                //success
                //ajax request

                var data = { Name: name, Surname: surname, Email: email, Password: password };
                data = JSON.stringify(data);

                $.ajax({
                    type: "POST",
                    url: "/user/registeraction",
                    data: data,
                    success: User_Login.Register.Register_Callback,
                    error: User_Login.Register.Register_Callback_Error,
                    dataType: "json",
                    contentType: "application/json; charset=utf-8;"
                });
            }
        },
        Register_Callback: function (result)
        {
            Helper.UI.Alert("Başarılı", "Kaydınız başarıyla gerçekleştirilmiştir.", "success");
            $("#user-register-name").val("");
            $("#user-register-surname").val("");
            $("#user-register-email").val(""); 
            $("#user-register-password").val("");
            $("#user-register-password2").val("");
        },
        Register_Callback_Error: function (result)
        {

            Helper.UI.Alert("Hata", result.responseText, "error");
        },

         
    }
}