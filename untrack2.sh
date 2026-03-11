git ls-files | grep -E '/[0-9]+【[^】]*】/' | xargs -I {} git rm --cached -r "{}"
