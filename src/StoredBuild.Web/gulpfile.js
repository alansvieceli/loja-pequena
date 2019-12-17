var gulp = require('gulp');
var concat = require('gulp-concat');
var cssmin = require('gulp-cssmin');
var uncss = require('gulp-uncss');
var browserSync = require('browser-sync').create();

gulp.task('taskJS', function(){
    return gulp.src([
      './node_modules/bootstrap/dist/js/bootstrap.min.js',
      './node_modules/jquery/dist/jquery.min.js',
      './node_modules/jquery-validation/dist/jquery.validate.min.js',
      './node_modules/jquery-validation-unobtrusive/dist/jquery.validate.unobtrusive.min.js',
      './js/site.js'
    ])
    .pipe(gulp.dest("wwwroot/js"))
    .pipe(browserSync.stream());
});

gulp.task('taskCSS', function(){
  return gulp.src([
    './node_modules/bootstrap/dist/css/bootstrap.css',
    './style/site.css'
  ])
  .pipe(concat("site.min.css"))
  .pipe(cssmin())
  .pipe(uncss({html: ["Views/**/*.cshtml"]}))
  .pipe(gulp.dest("wwwroot/css"))
  .pipe(browserSync.stream());
});

gulp.task('taskBrowserSync', function(){
    browserSync.init({
      proxy: 'localhost:5000'
    });

    gulp.watch('./style/*.css', ['taskCSS']);
    gulp.watch('./js/*.js', ['taskJS']);
});