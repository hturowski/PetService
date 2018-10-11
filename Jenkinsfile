pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				bat "docker build -t rest-test ."
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }
    }
}