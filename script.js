const url='http://localhost:53828/api/values';

// document.getElementById('btn1').addEventListener('click',getData);



function getData(){

    var requestOptions = {

     method: 'GET',
     redirect: 'follow'
    };
    fetch(url, requestOptions)
    .then(response => response.text())
    .then(result => show1(result));
    }    
 
 function show1(data) {
 
 document.getElementById('table').innerHTML = data;
 
 }
 
 //data by id

 
 function getS(){
 
   var id=document.getElementById("Btn2").value;
   console.log(id);
 
   var url='http://localhost:53828/api/values/'+id;
 
   fetch(url)
 
   .then(response => response.text())
 
   .then(result=> show2(result))
 
   .catch(error => console.log('Errorrr', error));}
 
   function show2(data){
 
 document.getElementById('table').innerHTML = data;

 
   } 


   function sendJSON(){
    let firstname = document.getElementById("firstname");
    let lastname = document.getElementById("lastname");
    let age = document.getElementById("age");
    
// Creating a XHR object
     let xhr = new XMLHttpRequest();
     let url = "http://localhost:53828/api/values"
    
// open a connection
    xhr.open("POST", url, true);
    
    
// Set the request header i.e. which type of content you are sending
    xhr.setRequestHeader("Content-Type", "application/json");
    
    
// Create a state change callback
     xhr.onreadystatechange = function () {
    if (xhr.readyState === 4 && xhr.status === 200) {
    
    // Print received data from server
    result.innerHTML = this.responseText;
     }
    };
    // Converting JSON data to string
    var data = JSON.stringify({ "firstname": firstname.value , "lastname":lastname.value, "age":age.value });
    
// Sending data with the request
    xhr.send(data);
    }