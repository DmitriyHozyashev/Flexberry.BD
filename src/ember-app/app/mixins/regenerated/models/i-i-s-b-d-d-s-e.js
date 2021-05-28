import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';

export let Model = Mixin.create({
  code: DS.attr('number'),
  name: DS.attr('string')
});

export let ValidationRules = {
  code: {
    descriptionKey: 'models.i-i-s-b-d-d-s-e.validations.code.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, integer: true }),
    ],
  },
  name: {
    descriptionKey: 'models.i-i-s-b-d-d-s-e.validations.name.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};
