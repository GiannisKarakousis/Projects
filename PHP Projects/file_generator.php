<?php
$directory = new RecursiveDirectoryIterator("Skeleton", RecursiveDirectoryIterator::SKIP_DOTS);

foreach (new RecursiveIteratorIterator($directory) as $filename=>$current) {
    $file = trim($current->getPathName(), 'Skeleton');
    $dir = dirname($file);
    $new_dir = 'NewSkeleton' . $dir;
    $new_file = 'NewSkeleton' . $file;
    if (!file_exists($new_dir)) {
        mkdir($new_dir, 0755, true);
    }

    ob_start();
    include $current;
    $file_cont = ob_get_contents();

    if (file_exists($new_dir)) {
        file_put_contents($new_file, $file_cont);
    }

    ob_end_flush();
}