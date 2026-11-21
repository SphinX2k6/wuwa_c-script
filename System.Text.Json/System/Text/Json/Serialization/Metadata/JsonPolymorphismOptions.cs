using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000B8 RID: 184
	[NullableContext(1)]
	[Nullable(0)]
	public class JsonPolymorphismOptions
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0002B8A0 File Offset: 0x00029AA0
		public IList<JsonDerivedType> DerivedTypes
		{
			get
			{
				JsonPolymorphismOptions.DerivedTypeList result;
				if ((result = this._derivedTypes) == null)
				{
					result = (this._derivedTypes = new JsonPolymorphismOptions.DerivedTypeList(this));
				}
				return result;
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000A23 RID: 2595 RVA: 0x0002B8C6 File Offset: 0x00029AC6
		// (set) Token: 0x06000A24 RID: 2596 RVA: 0x0002B8CE File Offset: 0x00029ACE
		public bool IgnoreUnrecognizedTypeDiscriminators
		{
			get
			{
				return this._ignoreUnrecognizedTypeDiscriminators;
			}
			set
			{
				this.VerifyMutable();
				this._ignoreUnrecognizedTypeDiscriminators = value;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000A25 RID: 2597 RVA: 0x0002B8DD File Offset: 0x00029ADD
		// (set) Token: 0x06000A26 RID: 2598 RVA: 0x0002B8E5 File Offset: 0x00029AE5
		public JsonUnknownDerivedTypeHandling UnknownDerivedTypeHandling
		{
			get
			{
				return this._unknownDerivedTypeHandling;
			}
			set
			{
				this.VerifyMutable();
				this._unknownDerivedTypeHandling = value;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000A27 RID: 2599 RVA: 0x0002B8F4 File Offset: 0x00029AF4
		// (set) Token: 0x06000A28 RID: 2600 RVA: 0x0002B905 File Offset: 0x00029B05
		public string TypeDiscriminatorPropertyName
		{
			get
			{
				return this._typeDiscriminatorPropertyName ?? "$type";
			}
			[param: AllowNull]
			set
			{
				this.VerifyMutable();
				this._typeDiscriminatorPropertyName = value;
			}
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x0002B914 File Offset: 0x00029B14
		private void VerifyMutable()
		{
			JsonTypeInfo declaringTypeInfo = this.DeclaringTypeInfo;
			if (declaringTypeInfo == null)
			{
				return;
			}
			declaringTypeInfo.VerifyMutable();
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x0002B926 File Offset: 0x00029B26
		// (set) Token: 0x06000A2B RID: 2603 RVA: 0x0002B92E File Offset: 0x00029B2E
		[Nullable(2)]
		internal JsonTypeInfo DeclaringTypeInfo { get; set; }

		// Token: 0x06000A2C RID: 2604 RVA: 0x0002B938 File Offset: 0x00029B38
		internal static JsonPolymorphismOptions CreateFromAttributeDeclarations(Type baseType)
		{
			JsonPolymorphismOptions jsonPolymorphismOptions = null;
			JsonPolymorphicAttribute customAttribute = baseType.GetCustomAttribute(false);
			if (customAttribute != null)
			{
				jsonPolymorphismOptions = new JsonPolymorphismOptions
				{
					IgnoreUnrecognizedTypeDiscriminators = customAttribute.IgnoreUnrecognizedTypeDiscriminators,
					UnknownDerivedTypeHandling = customAttribute.UnknownDerivedTypeHandling,
					TypeDiscriminatorPropertyName = customAttribute.TypeDiscriminatorPropertyName
				};
			}
			foreach (JsonDerivedTypeAttribute jsonDerivedTypeAttribute in baseType.GetCustomAttributes(false))
			{
				JsonPolymorphismOptions jsonPolymorphismOptions2;
				if ((jsonPolymorphismOptions2 = jsonPolymorphismOptions) == null)
				{
					jsonPolymorphismOptions2 = (jsonPolymorphismOptions = new JsonPolymorphismOptions());
				}
				jsonPolymorphismOptions2.DerivedTypes.Add(new JsonDerivedType(jsonDerivedTypeAttribute.DerivedType, jsonDerivedTypeAttribute.TypeDiscriminator));
			}
			return jsonPolymorphismOptions;
		}

		// Token: 0x040002D9 RID: 729
		private JsonPolymorphismOptions.DerivedTypeList _derivedTypes;

		// Token: 0x040002DA RID: 730
		private bool _ignoreUnrecognizedTypeDiscriminators;

		// Token: 0x040002DB RID: 731
		private JsonUnknownDerivedTypeHandling _unknownDerivedTypeHandling;

		// Token: 0x040002DC RID: 732
		private string _typeDiscriminatorPropertyName;

		// Token: 0x020000B9 RID: 185
		private sealed class DerivedTypeList : ConfigurationList<JsonDerivedType>
		{
			// Token: 0x06000A2D RID: 2605 RVA: 0x0002B9E0 File Offset: 0x00029BE0
			public DerivedTypeList(JsonPolymorphismOptions parent) : base(null)
			{
				this._parent = parent;
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x06000A2E RID: 2606 RVA: 0x0002B9F0 File Offset: 0x00029BF0
			public override bool IsReadOnly
			{
				get
				{
					JsonTypeInfo declaringTypeInfo = this._parent.DeclaringTypeInfo;
					return declaringTypeInfo != null && declaringTypeInfo.IsReadOnly;
				}
			}

			// Token: 0x06000A2F RID: 2607 RVA: 0x0002BA08 File Offset: 0x00029C08
			protected override void OnCollectionModifying()
			{
				JsonTypeInfo declaringTypeInfo = this._parent.DeclaringTypeInfo;
				if (declaringTypeInfo == null)
				{
					return;
				}
				declaringTypeInfo.VerifyMutable();
			}

			// Token: 0x040002DE RID: 734
			private readonly JsonPolymorphismOptions _parent;
		}
	}
}
