# Billing

## Prerequisites
* Visual Studio 2012 or later.
* An internet connection (to download the bill and NuGet packages).

## How to run the solution
* Download a copy of the source from this repository.
* Load the Billing.sln solution in Visual Studio and build the solution. NuGet packages will be downloaded as the solution is built.
* Make sure IIS Express is working by starting the Billing.Service and Billing.Site projects.
* Make sure the WCF service is working by clicking here: [http://localhost:57889/BillingService.svc](http://localhost:57889/BillingService.svc)
* View the bill by clicking here: [http://localhost:53292/](http://localhost:53292/)
