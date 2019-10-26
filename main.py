from random import randint

guessed = 0
tries = 1

number = randint(0, 100)

print("Guess numbers. You have 10 tries.")

while (guessed != 1):

  if (tries == 10):
    break

  guess = int(input("> "))

  if guess < number:
    triesRemaining = 10 - tries
    print("Guess higher, you have " + str(triesRemaining) + " tries left.")
    tries = tries + 1
  
  if guess > number:
    triesRemaining = 10 - tries
    print("Guess lower, you have " + str(triesRemaining) + " tries left.")
    tries = tries + 1

  if guess == number:
    triesRemaining = 10 - tries
    print("Correct! You took " + str(triesRemaining) + " tries")
    guessed = 1
    break