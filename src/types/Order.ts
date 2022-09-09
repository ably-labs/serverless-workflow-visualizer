export type Order = {
  id: string;
  customerName: string;
  customerAddress: string;
  menuItems: MenuItem[];
};

export type MenuItem = {
  type: MenuItemType;
  name: string;
};

export enum MenuItemType {
  Pizza = "Pizza",
  Drink = "Drink",
}
