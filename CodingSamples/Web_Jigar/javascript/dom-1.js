// console.log('file tested');

// console.log(typeof document);
// console.log(document);
// console.log(document.getElementById('btn111'));
// console.log(document.getElementById('btn'));

/*
    getElementById() -- first 
    getElementsByClassName() -- All  Classes
    getElementsByName() -- All Name 
    getElementsByTagName() -- All Tags 
*/

// document --- object
// document.getElementById --- DOM method
// onclick --- DOM Property

//DOM Event handing
document.getElementById('btn').onclick = function(){
    // alert();
    // console.log(document.querySelector('h1'));
    // console.log(document.querySelector('p'));
    document.querySelector('h1').style.background='#456';
    document.querySelector('p').style.textAlign='center';

    document.querySelector('h1').innerHTML='<u> test</u>';
    document.querySelector('p').innerText='<u> test</u>';
    document.querySelector('h2').remove();
}