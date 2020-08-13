node('master'){
    stage('Clean Workspace'){
        cleanWs()
    }
    
    stage('Fetch from Git'){
        git url:'https://github.com/frankbj57/CoreTest.git/'
    }
    
    stage('Clean Build') {
        bat '"C:\\Program Files\\dotnet\\dotnet.exe" clean coretest.sln'
    }

    stage('Build') {
        bat '"C:\\Program Files\\dotnet\\dotnet.exe" build coretest.sln'
    }

    try {
        stage('Run unit tests') {
            // bat '"C:\\Program Files\\dotnet\\dotnet.exe" test RegisterTest\\bin\\Debug\\netcoreapp3.1\\RegisterTest.dll --logger:nunit;LogFileName=TestResults.xml'
            bat '"C:\\Program Files\\dotnet\\dotnet.exe" test RegisterTest\\ --logger:nunit;LogFileName=TestResults.xml'
        }
    }
    finally {
        stage('Publish Test Results') {
            nunit testResultsPattern: 'RegisterTest\\TestResults\\TestResults.xml'
        }
    }
    
}
