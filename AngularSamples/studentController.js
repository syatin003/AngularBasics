mainApp.controller("studentController", function ($scope) {                     //we declare a controller studentController module using mainApp.controller function.
    $scope.student = {                      //Controller module
        firstName: "ABC",
        lastName: "XYZ",
        fees: 500,
        subjects: [
           { name: 'Physics', marks: 70 },
           { name: 'Chemistry', marks: 80 },
           { name: 'Math', marks: 65 },
           { name: 'English', marks: 75 },
           { name: 'Hindi', marks: 67 }
        ],
        fullName: function () {
            var studentObject;
            studentObject = $scope.student;
            return studentObject.firstName + " " + studentObject.lastName;
        }
    };
});