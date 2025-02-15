namespace md_notes.DTOs.Auth
{
    /*
     {
        "createdAt": "2025-02-15T12:45:12.6534032",
        "updatedAt": "2025-02-15T12:45:12.6534032",
        "phoneNumber": null,
        "phoneNumberConfirmed": false,
        "email": "string@test",
        "emailConfirmed": false,
     }

        "id": "076231dc-2e70-46df-900f-1a5b63231d2e",
        "normalizedUserName": "STRING@TEST",
        "userName": "string@test",
        "normalizedEmail": "STRING@TEST",
        "passwordHash": "AQAAAAIAAYagAAAAEFrS+g6BnYlOze/Nz7m1DnGOjfqYFY6LU3x3EgH4k31/7Fb8PkOOafI0HeRXaXfMRQ==",
        "securityStamp": "TGGJ7A7J2URT7W45YWX77NWOBAFBVIUA",
        "concurrencyStamp": "d805971b-415f-417e-8ed4-72499327e28d",
        "twoFactorEnabled": false,
        "lockoutEnd": null,
        "lockoutEnabled": true,
        "accessFailedCount": 0
     */
    public class UserInfoResponse
    {
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
