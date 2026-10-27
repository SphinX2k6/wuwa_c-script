using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002612 RID: 9746
	[UnrealObjectPath("/Script/OHNearby.OHNearbyNotifyLib")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UOHNearbyNotifyLib : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602440A RID: 148490 RVA: 0x0035AD35 File Offset: 0x00358F35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOHNearbyNotifyLib._ClassPtr;
		}

		// Token: 0x0602440B RID: 148491 RVA: 0x0035AD44 File Offset: 0x00358F44
		public UOHNearbyNotifyLib() : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotifyLib.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602440C RID: 148492 RVA: 0x0035AD6C File Offset: 0x00358F6C
		[NullableContext(1)]
		public UOHNearbyNotifyLib(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UOHNearbyNotifyLib.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602440D RID: 148493 RVA: 0x0035AD9F File Offset: 0x00358F9F
		[NullableContext(2)]
		public static UOHNearbyNotify GetNotify()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOHNearbyNotify>(UOHNearbyNotifyLib.__GetNotify_Internal());
		}

		// Token: 0x0602440E RID: 148494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNotify_Internal();

		// Token: 0x0602440F RID: 148495 RVA: 0x0035ADAB File Offset: 0x00358FAB
		static UOHNearbyNotifyLib()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/OHNearby.OHNearbyNotifyLib");
		}

		// Token: 0x06024410 RID: 148496 RVA: 0x0035ADB9 File Offset: 0x00358FB9
		protected UOHNearbyNotifyLib(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401372F RID: 79663
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/OHNearby.OHNearbyNotifyLib";

		// Token: 0x04013730 RID: 79664
		private static IntPtr _ClassPtr;

		// Token: 0x04013731 RID: 79665
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
