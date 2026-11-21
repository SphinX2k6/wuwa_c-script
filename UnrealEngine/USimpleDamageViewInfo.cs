using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003AC RID: 940
	[UnrealObjectPath("/Script/KuroGameplayUI.SimpleDamageViewInfo")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class USimpleDamageViewInfo : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005D06 RID: 23814 RVA: 0x00082E7D File Offset: 0x0008107D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimpleDamageViewInfo._ClassPtr;
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x00082E8C File Offset: 0x0008108C
		public USimpleDamageViewInfo() : this(BuiltinUtils.AllocNativeUObject(USimpleDamageViewInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x00082EB4 File Offset: 0x000810B4
		[NullableContext(1)]
		public USimpleDamageViewInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USimpleDamageViewInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700126B RID: 4715
		// (get) Token: 0x06005D09 RID: 23817 RVA: 0x00082EE7 File Offset: 0x000810E7
		// (set) Token: 0x06005D0A RID: 23818 RVA: 0x00082EFB File Offset: 0x000810FB
		[Nullable(2)]
		public unsafe UGeometryHandle GeometryHandle
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryHandle>(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_GeometryHandle);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USimpleDamageViewInfo.__PropertyOffset_GeometryHandle, value);
			}
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x00082F10 File Offset: 0x00081110
		static USimpleDamageViewInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayUI.SimpleDamageViewInfo");
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x00082F1E File Offset: 0x0008111E
		protected USimpleDamageViewInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040026C8 RID: 9928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayUI.SimpleDamageViewInfo";

		// Token: 0x040026C9 RID: 9929
		private static IntPtr _ClassPtr;

		// Token: 0x040026CA RID: 9930
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040026CB RID: 9931
		internal static int __PropertyOffset_GeometryHandle;
	}
}
