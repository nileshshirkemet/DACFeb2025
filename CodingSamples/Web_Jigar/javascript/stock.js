document.getElementById('btn').onclick = function
(){
    var unit1 = document.getElementById('x1').value;
    var price1 = document.getElementById('x2').value;
    var unit2 = document.getElementById('x3').value;
    var price2 = document.getElementById('x4').value;

    if(unit1 == '' || price1 == '' || unit2 =='' || price2==''){
        document.getElementById('message').innerText = 'All values Required';
        document.getElementById('message').className = 'alert alert-danger';
    }
    else if(isNaN(unit1) || isNaN(unit2) || isNaN(price1) || isNaN(price2) ){
        document.getElementById('message').innerText = 'Valid Numbers Required';
        document.getElementById('message').className = 'alert alert-danger';
    }
    else{
        unit1 = Number(unit1);
        unit2 = Number(unit2);
        price1 = Number(price1);
        price2 = Number(price2);

        document.getElementsByTagName('span')[0].innerHTML = unit1*price1;
        document.getElementsByTagName('span')[1].innerHTML = unit2*price2;
        document.getElementsByTagName('span')[2].innerHTML = (unit2*price2 + unit1*price1);
        document.getElementsByTagName('span')[3].innerHTML = (unit2+unit1);
        document.getElementsByTagName('span')[4].innerHTML = ((unit2*price2 + unit1*price1)/(unit2+unit1)).toFixed(2);
    }
}