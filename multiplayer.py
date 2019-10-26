from random import randint

global number = 0
global player1Tries = 7 
global player2Tries = 7
global player1Points = 0
global player2Points = 0

def player1Win():
  print("Player 1 Wins!")
  player1Points = player1Points + 1
  start()

def player2Win():
  print("Player 2 Wins!")
  player2Points = player2Points + 1
  start()

def player1():
  if (player1Tries == 0):
    player2Win()
  
  print("Player 1:")
  guess = int(input("> "))

  if (guess < number):
    print("Too low! Guess higher!")
    player1Tries = player1Tries - 1
    player2()

  if (guess > number):
    print("Too high! Guess lower!")
    player1Tries = player1Tries - 1
    player2()

def player2():
  if (player2Tries == 0):
    player1Win()
  
  print("Player 2:")
  guess = int(input("> "))

  if (guess < number):
    print("Too low! Guess higher!")
    player2Tries = player2Tries - 1
    player1()

  if (guess > number):
    print("Too high! Guess lower!")
    player2Tries = player2Tries - 1
    player1()

def start():
  player1Tries = 7
  player2Tries = 7
  number = randint(0, 100)
    
  print("")
  print("Player1: " + str(player1Points))
  print("Player2: " + str(player2Points))
  print("")
  player1()

start()
