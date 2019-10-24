#include "reverse_string.h"

namespace reverse_string
{
    std::string reverse_string(std::string str)
    {
        int length = str.length();

        if(length < 1)
            return "";

        for (int i = 0; i < length / 2; ++i)
            std::swap(str[i], str[length - i - 1]);

        return str;
    }
}  // namespace reverse_string
