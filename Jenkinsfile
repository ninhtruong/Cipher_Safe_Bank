pipeline {
	agent any
	stages {
		stage('Clone'){
			steps {
				git branch: 'main', credentialsId: '005b3321-b018-4f50-b1db-f6ef4d6d9018', url: 'https://github.com/ninhtruong/WebApplication1.git'
			}
		}
		stage('Build'){
			steps {
				sh 'cd Cipher_Safe_Bank'
				sh 'sudo docker-compose build'
				sh 'sudo docker-compose up -d'
				sh 'sudo docker start Cipher_Safe_Bank_Cipher_Safe_Bank_1'
				sh 'docker system prune -f'
			}
		}
	}
}
