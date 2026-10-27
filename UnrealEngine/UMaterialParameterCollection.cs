using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E90 RID: 3728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialParameterCollection")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UMaterialParameterCollection : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C897 RID: 51351 RVA: 0x00124007 File Offset: 0x00122207
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialParameterCollection._ClassPtr;
		}

		// Token: 0x0600C898 RID: 51352 RVA: 0x00124014 File Offset: 0x00122214
		public UMaterialParameterCollection() : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C899 RID: 51353 RVA: 0x0012403C File Offset: 0x0012223C
		public UMaterialParameterCollection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EEA RID: 12010
		// (get) Token: 0x0600C89A RID: 51354 RVA: 0x0012406F File Offset: 0x0012226F
		// (set) Token: 0x0600C89B RID: 51355 RVA: 0x00124083 File Offset: 0x00122283
		public unsafe FGuid StateId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_StateId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_StateId) = value;
			}
		}

		// Token: 0x17002EEB RID: 12011
		// (get) Token: 0x0600C89C RID: 51356 RVA: 0x00124098 File Offset: 0x00122298
		// (set) Token: 0x0600C89D RID: 51357 RVA: 0x001240D1 File Offset: 0x001222D1
		public TArray<FCollectionScalarParameter> ScalarParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCollectionScalarParameter> result;
				if ((result = this._ScalarParameters) == null)
				{
					result = (this._ScalarParameters = new TArray<FCollectionScalarParameter>(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_ScalarParameters, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameters.CopyAssign(value);
			}
		}

		// Token: 0x17002EEC RID: 12012
		// (get) Token: 0x0600C89E RID: 51358 RVA: 0x001240E0 File Offset: 0x001222E0
		// (set) Token: 0x0600C89F RID: 51359 RVA: 0x00124119 File Offset: 0x00122319
		public TArray<FCollectionVectorParameter> VectorParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCollectionVectorParameter> result;
				if ((result = this._VectorParameters) == null)
				{
					result = (this._VectorParameters = new TArray<FCollectionVectorParameter>(base.NativePtr + (IntPtr)UMaterialParameterCollection.__PropertyOffset_VectorParameters, this));
				}
				return result;
			}
			set
			{
				this.VectorParameters.CopyAssign(value);
			}
		}

		// Token: 0x0600C8A0 RID: 51360 RVA: 0x00124127 File Offset: 0x00122327
		static UMaterialParameterCollection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialParameterCollection");
		}

		// Token: 0x0600C8A1 RID: 51361 RVA: 0x00124135 File Offset: 0x00122335
		protected UMaterialParameterCollection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006BEF RID: 27631
		public new const string __ObjectPath = "/Script/Engine.MaterialParameterCollection";

		// Token: 0x04006BF0 RID: 27632
		private static IntPtr _ClassPtr;

		// Token: 0x04006BF1 RID: 27633
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006BF2 RID: 27634
		internal static int __PropertyOffset_StateId;

		// Token: 0x04006BF3 RID: 27635
		internal static int __PropertyOffset_ScalarParameters;

		// Token: 0x04006BF4 RID: 27636
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCollectionScalarParameter> _ScalarParameters;

		// Token: 0x04006BF5 RID: 27637
		internal static int __PropertyOffset_VectorParameters;

		// Token: 0x04006BF6 RID: 27638
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCollectionVectorParameter> _VectorParameters;
	}
}
