  PASSI REFACTORING

rimosso width da GameField
rimosso height da GameField
rimosso depth da GemaField
modificato chiamata a costruttore Location in GameField.placingBirds per accettare anche altezza (h)
modificato Bird.Heightper ritornare location.h
cancellato int height = bird.Height; da GameField.shot
cancellato metodo Height da Bird
spostato int h = bird.Height; sotto dichiarazione di location in GameField.isGameFieldValid
sostituito bird.Heigth con location.h
implementato equals su Location
estratta responsabilità di random placing strategy in placeBirds()
creato null placing strategy
creato placingstrategy factory
inlainato placeBirds
trasformato in field placingStrategyFactory
creato costruttore che accetta placingStrategyFactory
Height su Chicker imposta location.h a 0
rimossi i throw exception da IPlacingStrategy
rimosso try catch da startGame
estratto metodo per gameStarted 
spostata responsabilità di determinazione uccello colpito da FameField.shot a bird.wasHit
introdotto location come unico parametro di FieldSize.isWithinField
cambiato GameFieldValid per mettere in AND le condizioni
creata classe BirdList ed usata nel costruttore di GameField
spostata responsabilità anyBirdsWasHit e areAllBirdsPlaaceWithinField
semplificato GameField.shot mettendo in AND gamestartede birds. anyBirdsWasHit
cancellato Bird.Height e overridato su Chicken
cambiata firma FameField.shot per ricevere direttamente una Location
Applicata naming convention suggerita da Resharper
