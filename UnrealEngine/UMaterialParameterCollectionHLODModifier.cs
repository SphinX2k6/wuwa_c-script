using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E91 RID: 3729
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialParameterCollectionHLODModifier")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UMaterialParameterCollectionHLODModifier : UWorldPartitionHLODModifier, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C8A2 RID: 51362 RVA: 0x0012413E File Offset: 0x0012233E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialParameterCollectionHLODModifier._ClassPtr;
		}

		// Token: 0x0600C8A3 RID: 51363 RVA: 0x0012414C File Offset: 0x0012234C
		public UMaterialParameterCollectionHLODModifier() : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollectionHLODModifier.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C8A4 RID: 51364 RVA: 0x00124174 File Offset: 0x00122374
		public UMaterialParameterCollectionHLODModifier(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollectionHLODModifier.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EED RID: 12013
		// (get) Token: 0x0600C8A5 RID: 51365 RVA: 0x001241A7 File Offset: 0x001223A7
		// (set) Token: 0x0600C8A6 RID: 51366 RVA: 0x001241BB File Offset: 0x001223BB
		[Nullable(2)]
		public unsafe UMaterialParameterCollection MPC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialParameterCollectionHLODModifier.__PropertyOffset_MPC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialParameterCollectionHLODModifier.__PropertyOffset_MPC, value);
			}
		}

		// Token: 0x17002EEE RID: 12014
		// (get) Token: 0x0600C8A7 RID: 51367 RVA: 0x001241D0 File Offset: 0x001223D0
		// (set) Token: 0x0600C8A8 RID: 51368 RVA: 0x00124209 File Offset: 0x00122409
		public TArray<FHLODModifierScalarParameter> ScalarParameters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHLODModifierScalarParameter> result;
				if ((result = this._ScalarParameters) == null)
				{
					result = (this._ScalarParameters = new TArray<FHLODModifierScalarParameter>(base.NativePtr + (IntPtr)UMaterialParameterCollectionHLODModifier.__PropertyOffset_ScalarParameters, this));
				}
				return result;
			}
			set
			{
				this.ScalarParameters.CopyAssign(value);
			}
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x00124217 File Offset: 0x00122417
		static UMaterialParameterCollectionHLODModifier()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialParameterCollectionHLODModifier");
		}

		// Token: 0x0600C8AA RID: 51370 RVA: 0x00124225 File Offset: 0x00122425
		protected UMaterialParameterCollectionHLODModifier(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006BF7 RID: 27639
		public new const string __ObjectPath = "/Script/Engine.MaterialParameterCollectionHLODModifier";

		// Token: 0x04006BF8 RID: 27640
		private static IntPtr _ClassPtr;

		// Token: 0x04006BF9 RID: 27641
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006BFA RID: 27642
		internal static int __PropertyOffset_MPC;

		// Token: 0x04006BFB RID: 27643
		internal static int __PropertyOffset_ScalarParameters;

		// Token: 0x04006BFC RID: 27644
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHLODModifierScalarParameter> _ScalarParameters;
	}
}
