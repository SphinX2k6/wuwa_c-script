using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007B0 RID: 1968
	[UnrealObjectPath("/Script/OHNearby.OHNearbyNotifyLib")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOHNearbyNotifyLib : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AAEB RID: 43755 RVA: 0x000FC225 File Offset: 0x000FA425
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOHNearbyNotifyLib._ClassPtr;
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x000FC234 File Offset: 0x000FA434
		public UOHNearbyNotifyLib() : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotifyLib.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x000FC25C File Offset: 0x000FA45C
		[NullableContext(1)]
		public UOHNearbyNotifyLib(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotifyLib.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x000FC28F File Offset: 0x000FA48F
		[NullableContext(2)]
		public static UOHNearbyNotify GetNotify()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOHNearbyNotify>(UOHNearbyNotifyLib.__GetNotify_Internal());
		}

		// Token: 0x0600AAEF RID: 43759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNotify_Internal();

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x000FC29B File Offset: 0x000FA49B
		static UOHNearbyNotifyLib()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OHNearby.OHNearbyNotifyLib");
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x000FC2A9 File Offset: 0x000FA4A9
		protected UOHNearbyNotifyLib(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400492D RID: 18733
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OHNearby.OHNearbyNotifyLib";

		// Token: 0x0400492E RID: 18734
		private static IntPtr _ClassPtr;

		// Token: 0x0400492F RID: 18735
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
