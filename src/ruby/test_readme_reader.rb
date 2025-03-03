require 'minitest/autorun'
require_relative 'readme_reader'

class TestReadmeReader < Minitest::Test
  def test_read_readme
    temp_file = Tempfile.new("README.md")
    temp_file.write("Sample README content")
    temp_file.rewind

    assert_equal "Sample README content", read_readme(temp_file.path)

    temp_file.close
    temp_file.unlink
  end

  def test_readme_not_found
    assert_raises(RuntimeError) { read_readme("non_existent.md") }
  end
end
