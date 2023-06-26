# Flow

#### On user rejoin

  1. Assign all the roles the user previously had.

#### On new user join

  1. Assign _new comer_ role.
  2. Wait for the user to click the "introduce myself" button.
  3. Upon click, show a modal with questions like "What should we call you?", "Pronouns" and "Bio".
  4. Proxy post the answers on the _introductions_ channel and use it to create a new public thread.
  5. Remove the _new comer_ role.
  6. Assign the _regular user_ role.

#### On message command: ticket

  0. Check if the user has the _staff_ role.
  1. Show a modal asking reasoning and severity for the infraction ticket.
  2. Update the user's point score.
  3. Send a DM to the user with ticket info the message that prompted the ticket.
  4. Delete the message if that's what the moderator asked.

#### On message command: report

  0. Check if the message has already been reported.
  1. If not, send a copy of it to a mod-only channel.
  2. Notify the user with an ephemeral message.