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
    stage('cd app root') {
      steps {
        sh 'cd /var/jenkins_home/workspace/test-pipeline_master '
      }
    }
    stage('Docker build Stage') {
      steps {
        sh 'docker build -t test-pipeline:latest . '
      }
    }
    stage('Docker login') {
      steps {
        sh 'echo "$DOCKERHUB_CREDENTIALS" | docker login -u=ltreze --password-stdin '
      }
    }
    stage('Docker tag') {
      steps {
        sh 'docker tag test-pipeline ltreze/test-pipeline:hub '
      }
    }
    stage('Docker push') {
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