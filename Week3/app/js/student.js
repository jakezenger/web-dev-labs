function initializeStudents() {
    var data = getTestStudents();
    displayStudents(data.students);
}

function getTestStudents() {
    return JSON.parse(testStudents);
}

function displayStudents(students) {

    for(i = 0; i < students.length; i++) {

        console.log('email: ' + students[i].email);
        
        var email = students[i].email;
        var id = students[i].id;

        var markup = "<tr><td>" + email + "</td><td>$" + id + "</td><td>";

        $("table tbody").append(markup);
    }
}

var testStudents = '{"students": [{"email": "johnny.goode@oit.edu","id": 15379446},{"email": "jack.white@oit.edu","id": 34681275},{"email": "jimi.hendrix@oit.edu","id": 64986523},{"email": "jimmy.page@oit.edu","id": 72185385},{"email": "brian.may@oit.edu","id": 58213468}]}'