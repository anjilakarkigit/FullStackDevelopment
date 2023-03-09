//Question Number 1
//Write the code to sum all salaries and store in the variable sum
let salaries = {
John: 100,
Ann: 160,
Pete: 130
}
var sum =0;

function Sum(obj){
    for(let temp in obj){
        if(typeof obj[temp] == 'number'){
            sum+=obj[temp];
        }
    }
    return sum;
}

console.log(Sum(salaries));

/*
Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
// before the call
let menu = {
width: 200,
height: 300,
title: "My menu"
};
Please note that multiplyNumeric does not need to return anything. It should modify the object in-place 
*/

let menu = {
width: 200,
height: 300,
title: "My menu"
};

function multiplyNumeric(obj){
    for(let temp in obj){
        if(typeof obj[temp] == 'number'){
            obj[temp] *= 2;
        }
    }
}
multiplyNumeric(menu);
console.log(menu);

/* Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure
'@' must come before '.' and there must be some characters between '@' and '.'
The function must be case-insensitive:*/

function checkEmailId(str){
    str = str.toLowerCase();

    if(str.includes('@') && str.includes('.')){
        let atIndex = str.indexOf('@');
        let dotIndex = str.indexOf('.');

        if(atIndex<dotIndex){
            if(dotIndex - atIndex > 1){
                return true;
            }
        }
    }
    return false;
}

console.log(checkEmailId('john@example.com')); 
console.log(checkEmailId('john@com')); 

/*Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength
– replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
The result of the function should be the truncated (if needed) string.
truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
truncate("Hi everyone!", 20) = "Hi everyone!" */

function truncate(str, maxlength){
    if(str.length > maxlength){
        return str.slice(0, maxlength-1)+"...";
    } else{
        return str;
    }
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

/* Question 5
 Let’s try 5 array operations.
*/

let names = ["James", "Brennie"];
console.log(names);
//append Robert to the end
names.push("Robert");
console.log(names);
//replace value in the middle by Clavin
let midIndex = Math.floor(names.length / 2);
names[midIndex] = "Calvin";
console.log(names);
//Remove the first value of the array and show it.
console.log(names.shift());
console.log(names);
//Prepend Rose and Regal to the array.
names.unshift("Rose","Regal");
console.log(names);

