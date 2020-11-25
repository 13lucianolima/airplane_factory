using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneFactory.Common
{
    public class ResponseResult<TModel>
    {
        public ResponseResult(TModel model)
        {
            this.Data = model;
            ValidationResult = new ValidationResult();
        }

        public ResponseResult(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }

        public ResponseResult()
        {
            ValidationResult = new ValidationResult();
        }
        public TModel Data { get; set; }
        public ValidationResult ValidationResult { get; set; }

        public bool IsValid
        {
            get
            {
                return this.ValidationResult.IsValid;
            }
        }
    }
}
