
//点击输入框出现验证码
$(document).ready(function () {
    $('[cy-click-validatecode]').on('click', function () {
        $('[cy-click-contenthidden]').css('display', 'none');
        $('[cy-click-contentshow]').css('visibility', '');
    })
})



//验证码的更换
$(document).ready(function () {
    $('[cy-click-changImg]').on('click', function (event) {
        event.preventDefault();
        $('[cy-validationCodeImg]').attr('src', '/Register/ValidationCode?v=' + Math.random())
    })
})
