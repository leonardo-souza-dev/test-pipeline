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
        sh "dotnet restore"
      }
    }
    stage('Clean') {
      steps {
        sh 'dotnet clean'
      }
    }
    stage('Build') {
      steps {
        sh 'dotnet build'
      }
    }
  }
  post { 
    always { 
      cleanWs()
    }
  }
}