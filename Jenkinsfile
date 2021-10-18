pipeline {
    agent any 
    stages {
        stage('Stage 1') {
            steps {
                echo 'Hello world!' 
            }
        }
        stage('Restore packages') {
  steps {
    bat "dotnet restore FinalTest.sln"
       }
    }
        
     stage('Build') {
  steps {
    bat "msbuild.exe FinalTest.sln" 
  }
         
}
        
      
    }
}
