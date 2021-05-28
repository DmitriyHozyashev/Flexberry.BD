import { Serializer as DSESerializer } from
  '../mixins/regenerated/serializers/i-i-s-b-d-d-s-e';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(DSESerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
