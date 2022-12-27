// Consume our products API

function getProducts() {
    $.ajax({
        url: '/Api/GetProductList/',
        method: 'Get',
        success: function (response) {
            console.log(response);

            $('#our_product').html('');

            for (let i = 0; i < response.length; i++) {
                $('#our_product').append('<a href="/Product/Show?id=' + response[i].id + '" style="text-decoration:none; color: black"><img src=' + response[i].source + ' /><h2>' + response[i].title + '</h2><del style="color: red;">' + response[i].price + '         </del><div style="color: blue">' + response[i].selling_price + '</div></a>');
            }
        },
        error: function (){
            alert("Some error occured");
        }
    });
}
$('#btn-click1').click('click', getProducts);

/*
function getProducts() {
    $.ajax({
        url: '/Api/GetProductList/',
        method: 'Get',
        success: function (response) {
            console.log(response);

            //$('#show-data').append('<ul id="our_product"></ul>');

            for (let i = 0; i < response.length; i++) {
                $('#product_id').append('<a href="/Product/Show?id=' + response[i].id + '"><img src=' + response[i].source + ' class="img-responsive"/></a>');
            }
        },
        error: function () {
            alert("Some error occured");
            console.log("error occur");
        }
    });
}
$('#btn-click').click('click', getProducts);*/