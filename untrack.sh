#!/bin/bash

until [ ! $(git ls-files -c | grep 'Library/*' | head -n 10 | wc -l) -gt 0 ]; do
    # 只能单个文件处理
    git rm --cached "$(git ls-files -c | grep 'Library/*' | head -n 1 | sed 's/ /\\ /g' | sed "s/.*/echo \$'&'/" | bash | sed 's/"//g')"
    # git rm --cached $(git ls-files -c | grep 'Library/*' | head -n 5000 | sed 's/ /\\ /g' | sed "s/.*/echo \$'&'/" | bash | sed "s/['\"]//g")
    # break
done
