FROM node:8-alpine

COPY . /app
WORKDIR /app

RUN npm install
RUN yarn global add @angular/cli

EXPOSE 4200

USER 1000

CMD [ "yarn", "run", "start" ]