(function () {
    var app = angular.module('gameApp', []);

    app.controller('GameController',['$http', function ($http) {
        var user = this;
        user.moves = [];

        $http.get('http://localhost:60642/api/User/').success(function (data) {
            user = data;
        }).error(function(){
            user = {
                id: '001',
                playsOfUser: []
            };
        });
    }]);

    app.controller('MovesController', function () {
        this.moves = {};

        this.addMove = function (game) {
            game.playsOfUser.push(move);
        }
            
    });
});