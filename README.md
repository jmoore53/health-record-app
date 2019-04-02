# README

Health record application for AMIS 3610. 

## Setup

Dotnet: v2.2.105
Node: v11.6.0
Postgresql: v10.3


### Database Setup

This application uses a postgresql database and some variables in the database needs to be configured with the following settings:
  - Database named: health_record_app
  - Database User:  health_record_user
  - Database User Password: password


# Getting Started

### Clone 

![Image of Clone](https://www.github.com/jmoore53/health-record-app/readme_help/clone.png)

Click the clone button on Github and in a terminal within a folder you can locate; run the command `git clone https://github.com/jmoore53/health-record-app.git`

Within this folder, you should be able to run `git checkout "your controller/feature name here"` filling in the "controller/feature name" in quotes with the controller or feature you are working on. MAKE SURE TO CHECKOUT YOUR 'CHANGE' BEFORE WORKING!!! 


### Pulling down the latest updates

If you have yet to make any changes or you are already up to date with the master branch, but want to see the latest master version everyone has worked on, you should be able to pull down the latest version using `git pull` and "pull" down the latest version of the master branch. This assumes you have already cloned the repo! 

Assuming you have everything pulled down in a current state, it should say `Already up to date` in your terminal, and you should also be able to see the versions everyone else has been working on.

If pulling the current version does not work, please ask me for help! This could be due to merge requests and your current changes to files that have been already edited.


## Pushing up changes and Pull Requests

Assuming you are ready to push up changes, when you make changes to the current branch you are working on, assuming you used `git checkout "branch/feature name here"`, in github you should be able to use `git add .` and `git commit -m "message here"` and then you should be able to use `git push origin "branch/feature name here"` and this should push up your changes to github.

Using the `git push origin branch-name`, I should be able to see the changes you made and merge them with the current version of the application. You will need to open a Pull Request for this; see next paragraph.

With this being said, you will need to make a pull request on github using the "merge pull request feature" or "create pull request" button. I will then be able to merge your commits and add the commits to the master branch.


## Controller Edits

See the `AppointmentController.cs` for help with controllers and making the necessary edits to the controllers. 

The `AppointmentController.cs` will be difficult to replicate as appointments require the Doctor and a Patient id, but its not impossible.


