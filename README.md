# gemma-zaken
[![Build Status](https://travis-ci.org/sjefvanleeuwen/gemma-zaken.svg?branch=master)](https://travis-ci.org/sjefvanleeuwen/gemma-zaken)
[![Ask Me Anything !](https://img.shields.io/badge/Ask%20me-anything-1abc9c.svg)](https://GitHub.com/Naereen/ama)
[![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat-square)](http://makeapullrequest.com)
[![GPLv3 license](https://img.shields.io/badge/License-GPLv3-blue.svg)](http://perso.crans.org/besson/LICENSE.html)
[![Open Source Love svg2](https://badges.frapsoft.com/os/v2/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)  
OpenAPI .NET Core test implementations for ZDS / Zaakgericht werken

## Status

This project is in alpha and currently supports DRC with an in memory database, there's no sanity/range checking. Please use for development purposes only.

## Docker

### Compose

```
docker-compose up -d
```

### Pull & Run

```
docker pull wigo4it/openapi-drc:alpha
docker run --rm -d -p 5094:5094 wigo4it/openapi-drc:alpha
```

The openapi can now be reached from the browser to the following endpoints:

http://localhost:5094/swagger  
http://localhost:5094/redoc  
http://localhost:5094/metrics  

## Testing

Though very limited, a postman file is included.

## Built With

* [VSCODE](https://code.visualstudio.com/) - The IDE used
* [DOCKER](https://www.docker.com/) - Build, Ship, and Run Any App, Anywhere

## Contributing

Pull requests are accepted

## Authors

* **Sjef van Leeuwen** - *Initial work* - [github](https://github.com/sjefvanleeuwen)

## License

This project is licensed under the GPL-V3 License - see the [LICENSE](LICENSE) file for details
