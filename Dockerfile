# Step 1: Use the official .NET 10 SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

# Set the working directory inside the build container
WORKDIR /app

# Copy all source files from your local directory into the container
COPY . .

# Compile and publish the app in Release mode to the 'out' directory
RUN dotnet publish -c Release -o out

# Step 2: Use the smaller .NET 10 Runtime image for the final execution environment
FROM mcr.microsoft.com/dotnet/runtime:10.0

# Set the working directory inside the runtime container
WORKDIR /app

# Copy the compiled output files from the 'build' stage into this stage
COPY --from=build /app/out .

# Define the command that runs when the container starts
ENTRYPOINT ["dotnet", "Exam Qualifier.dll"]