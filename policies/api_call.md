# Signature

```
setProgress(true);
get(url)
.then(data => {
    setProgress(false);
    // code
}, error => {
    setProgress(false);
    // code
});
```

```
setProgress(true);
post(url)
.then(data => {
    setProgress(false);
    // code
}, error => {
    setProgress(false);
    // code
});
```

`put` and `delete` are like `post`.

# DO NOT USE ANY OTHER API