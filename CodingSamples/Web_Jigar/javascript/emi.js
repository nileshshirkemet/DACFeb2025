// event handling
document.getElementById('btn').onclick = function(){
    // console.log('clicked');
    // console.log(document.getElementById('x1'));
    // console.log(document.getElementById('x2'));
    // console.log(document.getElementById('x3'));

    var p = document.getElementById('x1').value;
    var r = document.getElementById('x2').value;
    var n = document.getElementById('x3').value;
    console.log(p,r,n);

    console.log(isNaN(p)); //true, false
    
    
    if( p=='' || r=='' || n=='')
    {
        document.getElementById('message').innerText = 'Values Required';
        document.getElementById('message').className = 'alert alert-danger';
    }
    else if( isNaN(p) || isNaN(r) || isNaN(n) )
    {
        document.getElementById('message').innerText = 'Values Must Be A Number';
        document.getElementById('message').className = 'alert alert-danger';
    }
    else if( p<0 || r<0 || n<0 )
    {
        document.getElementById('message').innerText = 'Values Must Be A Positive number';
        document.getElementById('message').className = 'alert alert-danger';
    }
    else{
        document.getElementById('message').innerText = '';
        console.log(typeof p);
        p = Number(p);
        r = parseFloat(r);
        n = parseInt(n)

        n = n*12;
        r = r/12/100;

        let emi = p*r*(1+r)**n / ( (1+r)**n - 1);

        console.log(document.getElementsByTagName('span'));
        
        document.getElementsByTagName('span')[0].innerHTML=p;
        document.getElementsByTagName('span')[1].innerHTML=emi;
        document.getElementsByTagName('span')[2].innerHTML=emi*n;
        document.getElementsByTagName('span')[3].innerHTML=emi*n - p;
    }

}