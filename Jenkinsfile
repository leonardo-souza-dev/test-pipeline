pipeline {
  agent any
  environment {
    dotnet = '/usr/bin/dotnet'
  }
  stages {
    // stage('Checkout') {
    //   steps {
    //     git credentialsId: 'bitbucket', url: 'git clone https://ltreze@bitbucket.org/lsouzaserra/test-pipeline.git', branch: 'master'
    //   }
    // }
    stage('Restore PACKAGES') {
      steps {
        bat "dotnet restore"
      }
    }
    stage('Clean') {
      steps {
        bat 'dotnet clean'
      }
    }
    stage('Build') {
      steps {
        bat 'dotnet build'
      }
    }
  }
  post { 
    always { 
      cleanWs()
    }
  }
}