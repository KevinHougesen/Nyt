// wwwroot/piral-instance.js
import { createInstance } from 'piral-core';
import { createBlazorApi } from 'piral-blazor';

const instance = createInstance({
  plugins: [createBlazorApi()],
});

window['piralInstance'] = instance;