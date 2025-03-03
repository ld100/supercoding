import unittest
import tempfile
from readme_reader import read_readme

class TestReadmeReader(unittest.TestCase):
    def test_read_readme(self):
        with tempfile.NamedTemporaryFile(mode="w+", delete=False) as temp_file:
            temp_file.write("Sample README content")
            temp_file.seek(0)
            self.assertEqual(read_readme(temp_file.name), "Sample README content")

    def test_readme_not_found(self):
        with self.assertRaises(FileNotFoundError):
            read_readme("non_existent.md")

if __name__ == "__main__":
    unittest.main()
