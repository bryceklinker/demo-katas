from unittest import TestCase

from bowling.bowling_game import BowlingGame


class TestBowlingGame(TestCase):
    def test_something(self):
        game = BowlingGame()

        self.assertEqual(0, game.score())