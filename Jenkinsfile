pipeline {
    
    agent any
    agent {
        docker { image 'mcr.microsoft.com/dotnet/sdk:6.0' }
    }
    environment {
        HOME = '/tmp'
    } 
    stages {
  
        /*stage('Buid') {
            steps {
                sh 'dotnet build'
            }
        }*/
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
