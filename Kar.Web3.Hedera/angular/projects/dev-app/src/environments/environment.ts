import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'Hedera',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44324/',
    redirectUri: baseUrl,
    clientId: 'Hedera_App',
    responseType: 'code',
    scope: 'offline_access Hedera',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44324',
      rootNamespace: 'Kar.Web3.Hedera',
    },
    Hedera: {
      url: 'https://localhost:44337',
      rootNamespace: 'Kar.Web3.Hedera',
    },
  },
} as Environment;
