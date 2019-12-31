/// <reference path="../../../../lib/jquery/dist/jquery.js" />
$(document).ready(function () {
    //$('#btnSubmit').click(function () {
    //    alert('true');
    //});
    var $loginForm = $('#form1');
    $loginForm.validate({
        highlight: function (input) {
            //$(input).parents('.form-line').addClass('error');
            $('.login-tips').show();
        },
        unhighlight: function (input) {
            //$(input).parents('.form-line').removeClass('error');
            console.log('unhighlight');
            $('.login-tips').hide();
        },
        errorPlacement: function (error, element) {
            //$(element).parents('.input-group').append(error);
            console.log('errorPlacement');
            $('.login-tips').show();
        }
    });
    $loginForm.submit(function (e) {
        e.preventDefault();

        if (!$loginForm.valid()) {
            return;
        }

        abp.ui.setBusy(
            $('.loginbody'),

            abp.ajax({
                contentType: 'application/x-www-form-urlencoded',
                url: $loginForm.attr('action'),
                data: $loginForm.serialize()
            }).done(function (data) {
                //abp.notify.success('created new person with id = ' + data.personId);
                if (data.code == 0) {
                    abp.notify.success(data.msg);
                    //if (data.data.returnUrl) {
                    //    window.location.href = data.data.returnUrl;
                    //} else {
                    window.location.href = '/admin/adminhome/index';
                    //}
                } else {
                    abp.notify.warn(data.code + '： ' + data.msg, '登录提示');
                }
            })
        );
    });
});