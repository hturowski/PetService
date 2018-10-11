pipeline {
    agent any

    stages {
        stage('Build') {
            steps {
                echo 'Building..'
				docker build -t rest-test .
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