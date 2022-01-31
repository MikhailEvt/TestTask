pipeline {
    agent {
        docker { image 'mcr.microsoft.com/dotnet/sdk:6.0' }
    }
    stages {
  
        stage('Buid') {
            steps {
                sh 'dotnet publish -c release -o out'
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
