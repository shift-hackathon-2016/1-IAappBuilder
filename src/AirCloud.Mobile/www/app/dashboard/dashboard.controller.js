(function(){
    angular.module('app').controller('DashboardController', DashboardController);

	DashboardController.$inject = ['$scope', '$ionicPlatform', '$rootScope']; 
    function DashboardController($scope, $ionicPlatform, $rootScope) {
        var vm = this;
        $rootScope.$on('deviceDataEmitter:update', function (event, data) {
            console.log(data);
        });
        $scope.$on("$ionicView.enter", function () {          
            $ionicPlatform.ready(function() {
                
            });
        });
    }
})();