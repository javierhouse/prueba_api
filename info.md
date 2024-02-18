sudo docker run -p 5166:5166 -e ASPNETCORE_URLS=http://+:5166 prueba_api

sudo docker build . -t prueba_api

    environment:
      - ConnectionStrings__DefaultConnection=User ID=postgres;Password=1234;Server=localhost;Port=5432;Database=SampleDriver;IntegratedSecurity=true;Pooling=true;
      - ASPNETCORE_URLS=http://+:5166