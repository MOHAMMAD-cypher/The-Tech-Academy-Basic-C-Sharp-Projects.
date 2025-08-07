# Display a welcome message to the user
print("Welcome to Package Express. Please follow the instructions below.")

# Prompt the user to input the weight of the package
weight = float(input("Please enter the package weight: "))

# Check if the package is too heavy
if weight > 50:
    # Display an error and exit if the package is over the weight limit
    print("Package too heavy to be shipped via Package Express. Have a good day.")
    exit()

# Prompt the user to input the width of the package
width = float(input("Please enter the package width: "))

# Prompt the user to input the height of the package
height = float(input("Please enter the package height: "))

# Prompt the user to input the length of the package
length = float(input("Please enter the package length: "))

# Calculate the sum of dimensions to check size limit
dimension_total = width + height + length

# Check if the package is too large
if dimension_total > 50:
    # Display an error and exit if the dimensions are too large
    print("Package too big to be shipped via Package Express.")
    exit()

# Calculate the volume of the package (width * height * length)
volume = width * height * length

# Calculate the shipping quote using the formula: (volume * weight) / 100
quote = (volume * weight) / 100

# Display the shipping quote formatted to two decimal places
print(f"Your estimated total for shipping this package is: ${quote:.2f}")

# Thank the user
print("Thank you!")
