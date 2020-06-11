pipeline {
  agent any
  environment {
    dotnet = '/usr/bin/dotnet'
  }
  stages {
    stage('Restore PACKAGES') {
      steps {
        sh 'dotnet restore '
      }
    }
    stage('Clean') {
      steps {
        sh 'dotnet clean'
      }
    }
    stage('Dotnet Build Stage') {
      steps {
        sh 'dotnet build '
      }
    }
    stage('Docker build Stage') {
      steps {
        sh 'docker build -t test-pipeline:latest . '
      }
    }
    stage('Docker push') {
      steps {
        sh 'echo "$DOCKERHUB_CREDENTIALS" | docker login -u=ltreze --password-stdin '
      }
      steps {
        sh 'docker tag test-pipeline ltreze/test-pipeline:hub '
      }
      steps {
        sh 'docker push ltreze/test-pipeline '
      }
    }
  }
  post { 
    always { 
      cleanWs()
    }
  }
}