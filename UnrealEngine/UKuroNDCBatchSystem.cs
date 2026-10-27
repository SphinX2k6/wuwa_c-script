using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B7B RID: 7035
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroNDCBatchSystem")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UKuroNDCBatchSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601AB26 RID: 109350 RVA: 0x00275606 File Offset: 0x00273806
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNDCBatchSystem._ClassPtr;
		}

		// Token: 0x0601AB27 RID: 109351 RVA: 0x00275614 File Offset: 0x00273814
		public UKuroNDCBatchSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroNDCBatchSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601AB28 RID: 109352 RVA: 0x0027563C File Offset: 0x0027383C
		[NullableContext(1)]
		public UKuroNDCBatchSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNDCBatchSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601AB29 RID: 109353 RVA: 0x0027566F File Offset: 0x0027386F
		[NullableContext(2)]
		public static UKuroNDCBatchSystem GetKuroNDCBatchSystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroNDCBatchSystem>(UKuroNDCBatchSystem.__GetKuroNDCBatchSystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601AB2A RID: 109354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroNDCBatchSystem_Internal(IntPtr InWorld);

		// Token: 0x0601AB2B RID: 109355 RVA: 0x0027568B File Offset: 0x0027388B
		static UKuroNDCBatchSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroNDCBatchSystem");
		}

		// Token: 0x0601AB2C RID: 109356 RVA: 0x00275699 File Offset: 0x00273899
		protected UKuroNDCBatchSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E714 RID: 59156
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroNDCBatchSystem";

		// Token: 0x0400E715 RID: 59157
		private static IntPtr _ClassPtr;

		// Token: 0x0400E716 RID: 59158
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
