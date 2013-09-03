﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.ContentManagement;
using Orchard.ContentManagement.Handlers;

namespace Coevery.Entities.Services {
    public abstract class ContentFieldValueProvider<TContentField> : IContentFieldValueProvider where TContentField : ContentField, new() {

        object IContentFieldValueProvider.GetValue(ContentItem contentItem, ContentField field) {
            var concreteFiled = field as TContentField;

            if (concreteFiled == null) {
                return null;
            }
            var result = GetValue(contentItem, concreteFiled);
            return result;
        }

        public virtual object GetValue(ContentItem contentItem, ContentField field) {
            return null;
        }
    }
}