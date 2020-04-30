import { BackOfficeSpaPage } from './app.po';

describe('back-office-spa App', function() {
  let page: BackOfficeSpaPage;

  beforeEach(() => {
    page = new BackOfficeSpaPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
