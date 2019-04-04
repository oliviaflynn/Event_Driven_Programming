using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystemOlivia
{
    /// <summary>
    /// User Class
    /// </summary>
    public class User
    {
        /// <summary>
        /// Variable for users first name
        /// </summary>
        public string firstName;
        /// <summary>
        /// Variable for users last name
        /// </summary>
        public string lastName;
        /// <summary>
        /// Variable for users ID
        /// </summary>
        public string userID;
        /// <summary>
        /// Variable for users password
        /// </summary>
        public string password;
        /// <summary>
        /// Variable for users role
        /// </summary>
        public string role;
        /// <summary>
        /// Variable for users account number
        /// </summary>
        public string accountNumber;
        /// <summary>
        /// Variable for users email address
        /// </summary>
        public string emailAddress;
        /// <summary>
        /// Variable bool for full access to system or not
        /// </summary>
        public bool adminFullAccess;
        /// <summary>
        /// Variable bool for report privileges of system or not
        /// </summary>
        public bool adminReportPrivileges;
        /// <summary>
        /// Variable bool to generate audit reports or not
        /// </summary>
        public bool genAuditReports;
        /// <summary>
        /// Variable bool to view audit reports or not
        /// </summary>
        public bool viewAuditRecords;
        /// <summary>
        /// Variable bool to input account payements or not
        /// </summary>
        public bool inputAccountPayments;
        /// <summary>
        /// Variable bool to authorise account payments or not
        /// </summary>
        public bool authAccountPayments;
        /// <summary>
        /// Variable bool to manage accounts or not
        /// </summary>
        public bool manageAccount;
        /// <summary>
        /// Variable bool view account information or not
        /// </summary>
        public bool viewAccountInformation;
        /// <summary>
        /// Variable bool to view account balances or not
        /// </summary>
        public bool viewAccountBalances;
        /// <summary>
        /// Getters and Setters for User Class
        /// </summary> 
        /// First Name of User
        public string FirstName { get => firstName; set => firstName = value; }
        /// <summary>
        /// Last Name of User
        /// </summary>
        public string LastName { get => lastName; set => lastName = value; }
        /// <summary>
        /// UserID for User
        /// </summary>
        public string UserID { get => userID; set => userID = value; }
        /// <summary>
        /// Password for User
        /// </summary>
        public string Password { get => password; set => password = value; }
        /// <summary>
        /// Role for User
        /// </summary>
        public string Role { get => role; set => role = value; }
        /// <summary>
        /// Account Number for User, Only for Customers
        /// </summary>
        public string AccountNumber { get => accountNumber; set => accountNumber = value; }
        /// <summary>
        /// Email Address for User
        /// </summary>
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        /// <summary>
        /// Full Privileges
        /// </summary>
        public bool AdminFullAccess { get => adminFullAccess; set => adminFullAccess = value; }
        /// <summary>
        /// Admin Privileges
        /// </summary>
        public bool AdminReportPrivileges { get => adminReportPrivileges; set => adminReportPrivileges = value; }
        /// <summary>
        /// Privileges to Audit Reports
        /// </summary>
        public bool GenAuditReports { get => genAuditReports; set => genAuditReports = value; }
        /// <summary>
        /// Privileges View Audit Records
        /// </summary>
        public bool ViewAuditRecords { get => viewAuditRecords; set => viewAuditRecords = value; }
        /// <summary>
        /// Privileges to Input payments to accounts
        /// </summary>
        public bool InputAccountPayments { get => inputAccountPayments; set => inputAccountPayments = value; }
        /// <summary>
        /// Privileges to Authorise Account Payments
        /// </summary>
        public bool AuthAccountPayments { get => authAccountPayments; set => authAccountPayments = value; }
        /// <summary>
        /// Privileges to Manage Accounts
        /// </summary>
        public bool ManageAccount { get => manageAccount; set => manageAccount = value; }
        /// <summary>
        /// Privileges to View Account Information
        /// </summary>
        public bool ViewAccountInformation { get => viewAccountInformation; set => viewAccountInformation = value; }
        /// <summary>
        /// Privileges to view account balances
        /// </summary>
        public bool ViewAccountBalances { get => viewAccountBalances; set => viewAccountBalances = value; }
    }
}
