pipeline {
  agent any
  environment {
    dotnet = '/usr/bin/dotnet'
  }
  stages {
    // stage('Restore PACKAGES') {
    //   steps {
    //     sh 'dotnet restore '
    //   }
    // }
    // stage('Clean') {
    //   steps {
    //     sh 'dotnet clean'
    //   }
    // }
    // stage('Dotnet Build Stage') {
    //   steps {
    //     sh 'dotnet build '
    //   }
    // }
    // stage('Docker build Stage') {
    //   steps {
    //     sh 'docker build -t test-pipeline:latest . '
    //   }
    // }
    stage('Docker login') {
      steps {
        echo "${DOCKERHUB_LOGIN}"
        echo "${DOCKERHUB_CREDENTIALS}"
        sh "docker login -u=${DOCKERHUB_LOGIN} -p=${DOCKERHUB_CREDENTIALS} "
      }
    }
    // stage('Docker tag') {
    //   steps {
    //     sh 'docker tag test-pipeline ltreze/test-pipeline:hub '
    //   }
    // }
    // stage('Docker push') {
    //   steps {
    //     sh 'docker push ltreze/test-pipeline '
    //   }
    // }
  }
  post { 
    always { 
      cleanWs()
    }
  }
}