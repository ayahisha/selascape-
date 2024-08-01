/* style.css */

body {
    font-family: 'Arial', sans-serif;
    margin: 0;
    padding: 0;
}

.navbar-brand img {
    height: 40px;
}

.carousel-caption {
    background-color: rgba(0, 0, 0, 0.5);
    padding: 20px;
    border-radius: 10px;
}

.carousel-caption p {
    margin: 0;
}

.carousel-caption h5 {
    margin-top: 10px;
    font-size: 2rem;
}

.main-carousel .carousel-inner img {
    width: 100%;
    height: auto;
}

.text-center h1 {
    color: #3f2a1d;
}

.property-box2 {
    background-color: #f9f9f9;
    border-radius: 10px;
    overflow: hidden;
    text-align: center;
    transition: transform 0.3s;
}

.property-box2:hover {
    transform: scale(1.05);
}

.property-box2 img {
    width: 100%;
    height: auto;
    border-bottom: 5px solid #fff;
}

.property-box2 h2 {
    font-size: 1.5rem;
    margin-top: 10px;
}

.property-box2 p {
    font-size: 1rem;
    margin: 10px 0;
}

.btn-outline-dark {
    border-color: #3f2a1d;
    color: #3f2a1d;
}

.btn-outline-dark:hover {
    background-color: #3f2a1d;
    color: #fff;
}

.image-container {
    position: relative;
}

.image-container img {
    width: 100%;
    height: auto;
}

.image-container .text-container {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    background-color: rgba(0, 0, 0, 0.5);
    color: #fff;
    padding: 20px;
    border-radius: 10px;
}

.footer {
    background-color: #222;
}

.footer p {
    margin: 0;
}

.footer .text-right a {
    color: #fff;
}

.footer .text-right a:hover {
    color: #ddd;
}

@media (max-width: 768px) {
    .carousel-caption {
        padding: 10px;
    }

    .carousel-caption h5 {
        font-size: 1.5rem;
    }

    .text-container h1 {
        font-size: 1.5rem;
    }

    .text-container p {
        font-size: 1rem;
    }
}
