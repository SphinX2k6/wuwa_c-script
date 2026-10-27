using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002927 RID: 10535
	[UnrealObjectPath("/Script/TpSafe.TpSafeSetting")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UTpSafeSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026FDF RID: 159711 RVA: 0x003B75A1 File Offset: 0x003B57A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTpSafeSetting._ClassPtr;
		}

		// Token: 0x06026FE0 RID: 159712 RVA: 0x003B75B0 File Offset: 0x003B57B0
		public UTpSafeSetting() : this(BuiltinUtils.AllocNativeUObject(UTpSafeSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FE1 RID: 159713 RVA: 0x003B75D8 File Offset: 0x003B57D8
		[NullableContext(1)]
		public UTpSafeSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTpSafeSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009615 RID: 38421
		// (get) Token: 0x06026FE2 RID: 159714 RVA: 0x003B760B File Offset: 0x003B580B
		// (set) Token: 0x06026FE3 RID: 159715 RVA: 0x003B761B File Offset: 0x003B581B
		public unsafe bool Enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UTpSafeSetting.__PropertyOffset_Enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UTpSafeSetting.__PropertyOffset_Enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026FE4 RID: 159716 RVA: 0x003B762C File Offset: 0x003B582C
		static UTpSafeSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TpSafe.TpSafeSetting");
		}

		// Token: 0x06026FE5 RID: 159717 RVA: 0x003B763A File Offset: 0x003B583A
		protected UTpSafeSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156B6 RID: 87734
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TpSafe.TpSafeSetting";

		// Token: 0x040156B7 RID: 87735
		private static IntPtr _ClassPtr;

		// Token: 0x040156B8 RID: 87736
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156B9 RID: 87737
		internal static int __PropertyOffset_Enable;
	}
}
