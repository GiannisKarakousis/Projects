<?php
function sort_clothing_sizes($sizes) {

    $sorted_sizes = array();
    $int_array = array();

    foreach ($sizes as $size) {
        if (is_int($size)) {
            array_push($int_array, $size);
        } else {
            switch ($size) {
                case "4XL":
                    $sorted_sizes['varchars'][9] = "4XL";
                    break;
                case "3XL":
                    $sorted_sizes['varchars'][8] = "3XL";
                    break;
                case "2XL":
                    $sorted_sizes['varchars'][7] = "2XL";
                    break;
                case "XL":
                    $sorted_sizes['varchars'][6] = "XL";
                    break;
                case "L":
                    $sorted_sizes['varchars'][5] = "L";
                    break;
                case "M":
                    $sorted_sizes['varchars'][4] = "M";
                    break;
                case "S":
                    $sorted_sizes['varchars'][3] = "S";
                    break;
                case "XS":
                    $sorted_sizes['varchars'][2] = "XS";
                    break;
                case "ONE SIZE":
                    $sorted_sizes['varchars'][1] = "ONE SIZE";
                    break;
            }
        }
    }
    sort($int_array);
    $sorted_sizes['numerics'] = $int_array;
    return $sorted_sizes;
}