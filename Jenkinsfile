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
        
     stage('Clean') {
  steps {
    bat "msbuild.exe FinalTest.sln" /nologo /nr:false /p:platform=\"x64\" /p:configuration=\"release\" /t:clean"
  }
}
        
        stage('Build') {
 steps {
  bat "msbuild.exe FinalTest /nologo /nr:false  /p:platform=\"x64\" /p:configuration=\"release\" /p:PackageCertificateKeyFile=<path-to-certificate-file>.pfx /t:clean;restore;rebuild"
 }
}
    }
}
