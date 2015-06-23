using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactsSystemAppProto
{
	public class ContactsService
	{
		private ContactsModelContainer contactsContainer;

		public ContactsService()
		{
			this.contactsContainer = new ContactsModelContainer();
		}

		// The business logic behind the UI should provide the contacts data.
		// If WPF is used for example, the view model should prepare a Contact object and pass it to this service.

		public bool AddContact(Contact contact)
		{
			if (contact == null)
				return false;

			try
			{
				this.contactsContainer.ContactSet.Add(contact);
				var writtenObjectsCount = this.contactsContainer.SaveChanges();
				return writtenObjectsCount > 0;
			}
			catch
			{
				// TODO: log exception
				return false;
			}
		}

		public bool UpdateContact(int contactId, Contact updateData)
		{
			var contactToUpdate = this.contactsContainer.ContactSet.Find(contactId);

			if (contactToUpdate == null || updateData == null || contactToUpdate.Equals(updateData))
				return false;
			try
			{
				// TODO: Update contact's details from updateData object

				var writtenObjectsCount = this.contactsContainer.SaveChanges();
				return writtenObjectsCount > 0;
			}
			catch
			{
				// TODO: log exception
				return false;
			}
		}

		public bool DeleteContact(int contactId)
		{
			var contactToDelete = this.contactsContainer.ContactSet.Find(contactId);

			try
			{
				this.contactsContainer.ContactSet.Remove(contactToDelete);

				var writtenObjectsCount = this.contactsContainer.SaveChanges();
				return writtenObjectsCount > 0;
			}
			catch
			{
				// TODO: log exception
				return false;
			}
		}

		public Contact GetContact(int contactId)
		{
			return this.contactsContainer.ContactSet.Find(contactId);
		}

		public IEnumerable<Contact> FindContacts()
		{
			return Enumerable.Empty<Contact>();
		}
	}
}
