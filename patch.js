const fs = require('fs');
const path = 'index.html';
let html = fs.readFileSync(path, 'utf8');
// Add clear: both to force secondary tag on new line
html = html.replace(
    /\.article-category-secondary \{\s*display: block;/,
    '.article-category-secondary { display: block; clear: both;'
);
fs.writeFileSync(path, html);
console.log('Done');
