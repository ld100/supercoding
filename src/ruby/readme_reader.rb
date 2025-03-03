def read_readme(filepath = "../../README.md")
    raise "README.md not found." unless File.exist?(filepath)
  
    File.read(filepath)
  end
  
  if __FILE__ == $0
    puts read_readme
  end