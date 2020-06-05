function getRequest(location, callback){
    fetch(location)
    .then(response => response.json())
    .then(jsonData => callback(jsonData))
    .catch(err => console.log(err))
}


function postRequest(location, requestBody, callback) {
fetch(location, {
    method: 'POST',
    body: JSON.stringify(requestBody),
    headers: {
        'Content-Type': 'application/json'
    },
})
.then(res => res.json())
.then(jsonData => callback(jsonData))
.catch(err => console.log(err))
}

function deleteRequest(location, requestBody, callback){
    fetch(location,  {
        method: 'DELETE',
        body: JSON.stringify
        (requestBody),
        headers: {
            'Content-Type': 
            'application/json'
        }
    })
    .then(res => res.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

function putRequest(location, requestBody, callback){
    fetch(location,  {
        method: 'PUT',
        body: JSON.stringify
        (requestBody),
        headers: {
            'Content-Type': 
            'application/json'
        }
    })
    .then(res => res.json())
    .then(data => callback(data))
    .catch(err => console.log(err));
}

getRequest('https://localhost:44334/widgettype', widgetTypes => {
    document.querySelector('#type1').innerHTML = widgetTypes[0].type;
    document.querySelector('#type1').value = widgetTypes[0].type;
    document.querySelector('#type2').innerHTML = widgetTypes[1].type;
    document.querySelector('#type1').value = widgetTypes[1].type;
    document.querySelector('#type3').innerHTML = widgetTypes[2].type;
    document.querySelector('#type1').value = widgetTypes[2].type;
    document.querySelector('#type4').innerHTML = widgetTypes[3].type;
    document.querySelector('#type1').value = widgetTypes[3].type;
})


setInterval( function() {
var type = document.getElementById('type').value 
if(type !== "0"){
getRequest(`https://localhost:44334/widgetsubtype/${type}`, widgetSubTypes => {
    document.querySelector('#sub-type1').innerHTML = widgetSubTypes[0].subType
    document.querySelector('#sub-type1').value = widgetSubTypes[0].subType
    document.querySelector('#sub-type2').innerHTML = widgetSubTypes[1].subType
    document.querySelector('#sub-type2').value = widgetSubTypes[1].subType
    document.querySelector('#sub-type3').innerHTML = widgetSubTypes[2].subType
    document.querySelector('#sub-type3').value = widgetSubTypes[2].subType
    document.querySelector('#sub-type4').innerHTML = widgetSubTypes[3].subType
    document.querySelector('#sub-type4').value = widgetSubTypes[3].subType
})
}
},300)
