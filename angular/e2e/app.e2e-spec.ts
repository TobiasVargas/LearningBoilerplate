import { LearningBoilerplateTemplatePage } from './app.po';

describe('LearningBoilerplate App', function() {
  let page: LearningBoilerplateTemplatePage;

  beforeEach(() => {
    page = new LearningBoilerplateTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
