function saveAsFile(fileName, base64Str) {
    var a = document.createElement('a');
    a.download = fileName;
    a.href = "data:application/octet-stream;base64," + base64Str;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
}