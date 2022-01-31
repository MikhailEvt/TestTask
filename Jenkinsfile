pipeline {
    agent any

    stages {
  
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
