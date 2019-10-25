#include "reverse_string.h"

#include <algorithm>

namespace reverse_string
{
    std::string reverse_string(std::string str)
    {
        if(str.length() < 1)
            return "";

        std::reverse(str.begin(), str.end());

        return str;
    }
}  // namespace reverse_string
