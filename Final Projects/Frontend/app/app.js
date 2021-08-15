var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/index.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
    .when("/player_f", {
        templateUrl : "views/pages/players.html",
        controller: 'player_f'
    })

    .when("/coach_f", {
        templateUrl : "views/pages/coach.html",
        controller: 'coach_f'
    })
    .when("/physio_f", {
        templateUrl : "views/pages/physio.html",
        controller: 'physio_f'
    })
    .when("/admin_f", {
        templateUrl : "views/pages/admin.html",
        controller: 'admin_f'
    })

    .when("/loginf", {
        templateUrl : "views/pages/loginForm.html",
        controller: 'loginf'
    })


    .when("/admin_registration", {
        templateUrl : "views/pages/admin_registrationForm.html",
        controller: 'admin_registration'
    })

    .when("/admin_coachCreate", {
        templateUrl : "views/pages/admin_coachCreateForm.html",
        controller: 'admin_coachCreate'
    })
    .when("/admin_coachRead", {
        templateUrl : "views/pages/coach.html",
          controller: 'admin_coachRead'
    })
    .when("/admin_coachUpdate", {
        templateUrl : "views/pages/admin_coachCreateForm.html",
          controller: 'admin_coachUpdate'
    })
    .when("/admin_coachDelete", {
        templateUrl : "views/pages/coach.html",
          controller: 'admin_coachDelete'
    })



    .when("/admin_fixtureCreate", {
        templateUrl : "views/pages/admin_fixtureCreateForm.html",
        controller: 'admin_fixtureCreate'
    })
    .when("/admin_fixtureRead", {
        templateUrl : "views/pages/fixtures.html",
          controller: 'admin_fixtureRead'
    })
    .when("/admin_fixtureDelete", {
        templateUrl : "views/pages/fixtures.html",
          controller: 'admin_fixtureDelete'
    })
    .when("/admin_fixtureUpdate", {
        templateUrl : "views/pages/admin_fixtureCreateForm.html",
          controller: 'admin_fixtureUpdate'
    })



    .when("/admin_playersCreate", {
        templateUrl : "views/pages/admin_playersCreateForm.html",
        controller: 'PlayerCreate'
    })
    .when("/admin_playerDetails:id", {
         templateUrl : "views/pages/player_details.html",
          controller: 'admin_playerDetails'
    })
    .when("/admin_playerDelete:id", {
          templateUrl : "views/pages/admin_playerDelete.html",
          controller: 'admin_playerDelete'
    })
    .when("/admin_playerUpdate:id", {
        templateUrl : "views/pages/admin_playerUpdate.html",
          controller: 'admin_playersUpdate'
    })

    .when("/admin_playerSearch:search", {
        templateUrl : "views/pages/playersSearchValue.html",
          controller: 'PlayerSearch'
    })

    .when("/SearchGK", {
          templateUrl : "views/pages/admin_playerGK.html",
          controller: 'admin_playerGK'
    })

    .when("/admin_physioCreate", {
        templateUrl : "views/pages/admin_physioCreateForm.html",
        controller: 'admin_physioCreate'
    })
    .when("/admin_physioRead", {
        templateUrl : "views/pages/physio.html",
          controller: 'admin_physioRead'
    })
    .when("/admin_physioDelete", {
        templateUrl : "views/pages/physio.html",
          controller: 'admin_physioDelete'
    })
    .when("/admin_physioUpdate", {
        templateUrl : "views/pages/admin_physioCreateForm.html",
          controller: 'admin_physioUpdate'
    })


    .when("/admin_salaryCreate", {
        templateUrl : "views/pages/admin_salaryCreateForm.html",
        controller: 'admin_salaryCreate'
    })
    .when("/admin_salaryRead", {
        templateUrl : "views/pages/salary.html",
          controller: 'admin_salaryRead'
    })
    .when("/admin_salaryUpdate", {
        templateUrl : "views/pages/admin_salaryCreateForm.html",
          controller: 'admin_salaryUpdate'
    })
    .when("/admin_salaryDelete", {
        templateUrl : "views/pages/salary.html",
          controller: 'admin_salaryDelete'
    })

    .when("/coach_formationCreate", {
        templateUrl : "views/pages/coach_formationCreateForm.html",
        controller: 'coach_formationCreate'
    })
    .when("/coach_formationRead", {
        templateUrl : "views/pages/formation.html",
          controller: 'coach_formationRead'
    })
    .when("/coach_formationUpdate", {
        templateUrl : "views/pages/coach_formationCreateForm.html",
          controller: 'coach_formationUpdate'
    })
    .when("/coach_formationDelete", {
        templateUrl : "views/pages/formation.html",
          controller: 'coach_formationDelete'
    })

    .when("/physio_fitnessCreate", {
        templateUrl : "views/pages/physio_fitnessCreateForm.html",
        controller: 'physio_fitnessCreate'
    })
    .when("/physio_fitnessRead", {
        templateUrl : "views/pages/fitness.html",
          controller: 'physio_fitnessRead'
    })
    .when("/physio_fitnessUpdate", {
        templateUrl : "views/pages/physio_fitnessCreateForm.html",
          controller: 'physio_fitnessUpdate'
    })
    .when("/physio_fitnessDelete", {
        templateUrl : "views/pages/fitness.html",
          controller: 'physio_fitnessDelete'
    })


    .when("/player_f", {
        templateUrl : "views/pages/players.html",
        controller: 'player_f'
    })



    .when("/player_editPassword", {
        templateUrl : "views/pages/players_loginInfo.html",
        controller: 'player_editPassword'
    })

    .when("/coach_editPassword", {
        templateUrl : "views/pages/coach_loginInfo.html",
        controller: 'coach_editPassword'
    })

    .when("/physio_editPassword", {
        templateUrl : "views/pages/physio_loginInfo.html",
        controller: 'physio_editPassword'
    })




    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
