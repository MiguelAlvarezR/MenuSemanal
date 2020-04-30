// Create a "close" button and append it to each list item
var myNodelist = document.getElementsByTagName("LI");
var i;
for (i = 0; i < myNodelist.length; i++) {
    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    myNodelist[i].appendChild(span);
}

// Click on a close button to hide the current list item
var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
    close[i].onclick = function () {
        var div = this.parentElement;
        div.style.display = "none";
    }
}

//// Add a "checked" symbol when clicking on a list item
//var list = document.querySelector('.myUL');
//list.addEventListener('click', function (ev) {
//    if (ev.target.tagName === 'LI') {
//        ev.target.classList.toggle('checked');
//    }
//}, false);

// Create a new list item when clicking on the "Add" button
function newElement(el) {
    var li = document.createElement("li");
    var inputValue = $(el).closest('.buscador').find('input').val();
    var t = document.createTextNode(inputValue);
    li.appendChild(t);
    if (inputValue === '') {
        alert("Debe digitar para agregar");
    } else {
        if ($(el).closest('.buscador').find('ul li:visible').length < 3) {
            $(el).closest('.buscador').find('ul').append(li);
        } else {
            $(el).closest('.buscador').find('input').val("");
            return;
        }
    }
    $(el).closest('.buscador').find('input').val("");
    
    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    li.appendChild(span);

    for (i = 0; i < close.length; i++) {
        close[i].onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
        }
    }
}
