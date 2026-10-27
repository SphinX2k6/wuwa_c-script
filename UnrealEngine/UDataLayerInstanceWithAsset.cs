using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000999 RID: 2457
	[UnrealObjectPath("/Script/Engine.DataLayerInstanceWithAsset")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UDataLayerInstanceWithAsset : UDataLayerInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008AD4 RID: 35540 RVA: 0x000C6DB4 File Offset: 0x000C4FB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerInstanceWithAsset._ClassPtr;
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x000C6DC0 File Offset: 0x000C4FC0
		public UDataLayerInstanceWithAsset() : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstanceWithAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x000C6DE8 File Offset: 0x000C4FE8
		[NullableContext(1)]
		public UDataLayerInstanceWithAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstanceWithAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06008AD7 RID: 35543 RVA: 0x000C6E1B File Offset: 0x000C501B
		// (set) Token: 0x06008AD8 RID: 35544 RVA: 0x000C6E2F File Offset: 0x000C502F
		[Nullable(2)]
		public unsafe UDataLayerAsset DataLayerAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataLayerAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstanceWithAsset.__PropertyOffset_DataLayerAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstanceWithAsset.__PropertyOffset_DataLayerAsset, value);
			}
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x000C6E44 File Offset: 0x000C5044
		static UDataLayerInstanceWithAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerInstanceWithAsset");
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x000C6E52 File Offset: 0x000C5052
		protected UDataLayerInstanceWithAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041ED RID: 16877
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DataLayerInstanceWithAsset";

		// Token: 0x040041EE RID: 16878
		private static IntPtr _ClassPtr;

		// Token: 0x040041EF RID: 16879
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041F0 RID: 16880
		internal static int __PropertyOffset_DataLayerAsset;
	}
}
