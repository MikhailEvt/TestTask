pipeline {
    agent any

    stages {
        stage('GitHub connection') {
            steps {
                git credentialsId: 'd97ec45f-dd20-4e7f-99b8-4511fa880242', url: 'https://github.com/MikhailEvt/TestTask.git'
            }
        }
        stage('Buid') {
            steps {
                sh 'dotnet build *.sln'
            }
        }
        stage('Test') {
            steps {
               sh 'dotnet test TestTask.sln --logger \'trx;LogFileName=\$WORKSPACE/Result.trx\''
                
            }
        }
       
    }
    post {
        always {
            mstest testResultsFile: '**/Result.trx'
        }
    }
}
