package com.example;

import org.junit.jupiter.api.Test;
import java.nio.file.*;
import static org.junit.jupiter.api.Assertions.*;

public class ReadmeReaderTest {

    @Test
    public void testReadReadme() throws Exception {
        Path tempFile = Files.createTempFile("README", ".md");
        Files.writeString(tempFile, "Sample README content");

        assertEquals("Sample README content", ReadmeReader.readReadme(tempFile.toString()));

        Files.delete(tempFile);
    }

    @Test
    public void testReadmeNotFound() {
        Exception exception = assertThrows(Exception.class, () -> {
            ReadmeReader.readReadme("non_existent.md");
        });

        assertEquals("README.md not found.", exception.getMessage());
    }
}
