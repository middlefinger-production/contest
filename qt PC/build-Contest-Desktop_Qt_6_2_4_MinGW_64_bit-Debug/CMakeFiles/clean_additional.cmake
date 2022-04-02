# Additional clean files
cmake_minimum_required(VERSION 3.16)

if("${CONFIG}" STREQUAL "" OR "${CONFIG}" STREQUAL "Debug")
  file(REMOVE_RECURSE
  "CMakeFiles\\Contest_autogen.dir\\AutogenUsed.txt"
  "CMakeFiles\\Contest_autogen.dir\\ParseCache.txt"
  "Contest_autogen"
  )
endif()
