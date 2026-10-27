using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E93 RID: 3731
	[UnrealObjectPath("/Script/Engine.MaterialParameterCollectionInstance")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UMaterialParameterCollectionInstance : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C8B7 RID: 51383 RVA: 0x001242F6 File Offset: 0x001224F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialParameterCollectionInstance._ClassPtr;
		}

		// Token: 0x0600C8B8 RID: 51384 RVA: 0x00124304 File Offset: 0x00122504
		public UMaterialParameterCollectionInstance() : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollectionInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C8B9 RID: 51385 RVA: 0x0012432C File Offset: 0x0012252C
		[NullableContext(1)]
		public UMaterialParameterCollectionInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialParameterCollectionInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002EF1 RID: 12017
		// (get) Token: 0x0600C8BA RID: 51386 RVA: 0x0012435F File Offset: 0x0012255F
		// (set) Token: 0x0600C8BB RID: 51387 RVA: 0x00124373 File Offset: 0x00122573
		[Nullable(2)]
		public unsafe UMaterialParameterCollection Collection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialParameterCollectionInstance.__PropertyOffset_Collection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMaterialParameterCollectionInstance.__PropertyOffset_Collection, value);
			}
		}

		// Token: 0x0600C8BC RID: 51388 RVA: 0x00124388 File Offset: 0x00122588
		static UMaterialParameterCollectionInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialParameterCollectionInstance");
		}

		// Token: 0x0600C8BD RID: 51389 RVA: 0x00124396 File Offset: 0x00122596
		protected UMaterialParameterCollectionInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006C01 RID: 27649
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialParameterCollectionInstance";

		// Token: 0x04006C02 RID: 27650
		private static IntPtr _ClassPtr;

		// Token: 0x04006C03 RID: 27651
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006C04 RID: 27652
		internal static int __PropertyOffset_Collection;
	}
}
