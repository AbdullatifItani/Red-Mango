export default interface userModel {
  // Question Mark ? is for null and id and email will never be null so no ? mark
    fullName?: string;
    id: string;
    email: string;
    role?: string;
  }