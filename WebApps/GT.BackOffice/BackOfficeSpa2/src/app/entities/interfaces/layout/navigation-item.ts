export interface INavigationItem
{
  displayName: string;
  icon?: string;
  route?: string;
  disabled?: boolean;
  children?: INavigationItem[];
}
