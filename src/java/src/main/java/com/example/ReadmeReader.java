package com.example;

import java.nio.file.*;

public class ReadmeReader {
    public static String readReadme(String filePath) throws Exception {
        Path path = Paths.get(filePath);
        if (!Files.exists(path)) {
            throw new Exception("README.md not found.");
        }
        return Files.readString(path);
    }
}
