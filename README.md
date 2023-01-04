# ProximoCodeTask

Hosted on Azure: https://proximocodetask.azurewebsites.net

Notion Page: https://exclusive-balance-d69.notion.site/Proximo-Coding-Task-Notes-5485536e4e8e4ffea7b7ab42a9fc7199 


# Things I wanted to achieve

## Address

When initially adding the address related properties, I created an object for them. I aim was to have a class I could apply to other classes and make the code more DRY. For the most part this did work though I had issues with validating the form when adding a new Company to the database through the form. Due to time constrictions I decided it would be best to leave this and make the form more user friendly 

## Multiple Phone Numbers and Email Address

I initially planned to add functionality to allow for multiple Phone Numbers and Email Addresses to be added to a company. Within the database I created tables for both and created the classes. I’ve left the classes and any controls I build for them within the project to demonstrate some of the next steps I would have taken. As an alterative I have used a single phone number and email address.

# Next Steps / things to discuss with the client / Things I’d want to improve or add

- add a notes section to document things like when a client was called, duration of call, general notes about contact / company, etc
- Add search
- add in authentication (probably use Azure's Active Directory)
- Better Design of pages
- More Validation of fields
- Standardise components and codebase where possible
- Redirect back to previous page
- Bread crumps
- Stylise pages
- Contacts/People Table and classes
- Ability to add more than one phone number and email address
- Create Custom Validators
- Create a single interface for all future classes inside Data Access Library (as shown in Notion). Would use a generic type so that it can be flexible
- Add unit tests
