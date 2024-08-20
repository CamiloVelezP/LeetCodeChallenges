var longestValidParentheses = function(s) {
    let sum = 0
    let max = 0
    let lastWrong;
    let parentesisStack = [];
    let limit = s.length
    for (let i = 0; i < limit; i++) {
        switch (s[i]){
            case "(" :
            parentesisStack.push([s[i],i])
            break;
            case ")" :
            if (parentesisStack.length > 0 && parentesisStack[parentesisStack.length -1][0]=="("){
                parentesisStack.pop()
            }else{
                parentesisStack.push([s[i],i])
            }
            break;
            case "":
            break;
        }
    }
    while (parentesisStack.length > 0){
        lastWrong = parentesisStack.pop()[1]
        max = Math.max(max,limit-lastWrong-1)
        limit = lastWrong
    }
    max = Math.max(max,limit)
    return max;
}