using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000998 RID: 2456
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DataLayerInstancePrivate")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UDataLayerInstancePrivate : UDataLayerInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008ACB RID: 35531 RVA: 0x000C6CE3 File Offset: 0x000C4EE3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDataLayerInstancePrivate._ClassPtr;
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x000C6CF0 File Offset: 0x000C4EF0
		public UDataLayerInstancePrivate() : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstancePrivate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x000C6D18 File Offset: 0x000C4F18
		public UDataLayerInstancePrivate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDataLayerInstancePrivate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06008ACE RID: 35534 RVA: 0x000C6D4B File Offset: 0x000C4F4B
		// (set) Token: 0x06008ACF RID: 35535 RVA: 0x000C6D5F File Offset: 0x000C4F5F
		public unsafe string ShortName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDataLayerInstancePrivate.__PropertyOffset_ShortName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDataLayerInstancePrivate.__PropertyOffset_ShortName)), value);
			}
		}

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06008AD0 RID: 35536 RVA: 0x000C6D74 File Offset: 0x000C4F74
		// (set) Token: 0x06008AD1 RID: 35537 RVA: 0x000C6D88 File Offset: 0x000C4F88
		[Nullable(2)]
		public unsafe UDataLayerAsset DataLayerAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDataLayerAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstancePrivate.__PropertyOffset_DataLayerAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UDataLayerInstancePrivate.__PropertyOffset_DataLayerAsset, value);
			}
		}

		// Token: 0x06008AD2 RID: 35538 RVA: 0x000C6D9D File Offset: 0x000C4F9D
		static UDataLayerInstancePrivate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DataLayerInstancePrivate");
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x000C6DAB File Offset: 0x000C4FAB
		protected UDataLayerInstancePrivate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041E8 RID: 16872
		public new const string __ObjectPath = "/Script/Engine.DataLayerInstancePrivate";

		// Token: 0x040041E9 RID: 16873
		private static IntPtr _ClassPtr;

		// Token: 0x040041EA RID: 16874
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041EB RID: 16875
		internal static int __PropertyOffset_ShortName;

		// Token: 0x040041EC RID: 16876
		internal static int __PropertyOffset_DataLayerAsset;
	}
}
