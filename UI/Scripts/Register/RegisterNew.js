
document.getElementsByClassName('cy-click-validateCode')[0]
    .onclick = function show() {
        document.getElementsByClassName('cy-click-contentHidden')[0]
            .style.display = 'none';
        document.getElementsByClassName('cy-click-contentShow')[0]
            .style.visibility = '';
    }

$(document).ready(function () {
    $('[cy-click-changImg]').on('click', function (event) {
        event.preventDefault();
        $('[cy-validationCodeImg]').attr('src', '/Register/ValidationCode?v=' + Math.random())
    })
})
