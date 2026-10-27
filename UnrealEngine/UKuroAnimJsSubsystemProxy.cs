using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200165C RID: 5724
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimJsSubsystemProxy")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimJsSubsystemProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014BC6 RID: 84934 RVA: 0x001E7F1A File Offset: 0x001E611A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimJsSubsystemProxy._ClassPtr;
		}

		// Token: 0x06014BC7 RID: 84935 RVA: 0x001E7F28 File Offset: 0x001E6128
		public UKuroAnimJsSubsystemProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystemProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014BC8 RID: 84936 RVA: 0x001E7F50 File Offset: 0x001E6150
		[NullableContext(1)]
		public UKuroAnimJsSubsystemProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystemProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014BC9 RID: 84937 RVA: 0x001E7F83 File Offset: 0x001E6183
		public static void UnregisterUpdateAnimInfoFunction(UGameInstance World)
		{
			UKuroAnimJsSubsystemProxy.__UnregisterUpdateAnimInfoFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014BCA RID: 84938 RVA: 0x001E7F9A File Offset: 0x001E619A
		public static void UnregisterEntity(UGameInstance World, int EntityId)
		{
			UKuroAnimJsSubsystemProxy.__UnregisterEntity_Internal((World != null) ? World.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x06014BCB RID: 84939 RVA: 0x001E7FB2 File Offset: 0x001E61B2
		public static void RegisterUpdateNpcInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateNpcInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06014BCC RID: 84940 RVA: 0x001E7FD6 File Offset: 0x001E61D6
		public static void RegisterUpdateMonsterInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateMonsterInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06014BCD RID: 84941 RVA: 0x001E7FFA File Offset: 0x001E61FA
		public static void RegisterUpdateAnimInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateAnimInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06014BCE RID: 84942 RVA: 0x001E801E File Offset: 0x001E621E
		public static void RegisterEntity(UGameInstance World, int EntityId)
		{
			UKuroAnimJsSubsystemProxy.__RegisterEntity_Internal((World != null) ? World.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x06014BCF RID: 84943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterUpdateAnimInfoFunction_Internal(IntPtr World);

		// Token: 0x06014BD0 RID: 84944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterEntity_Internal(IntPtr World, int EntityId);

		// Token: 0x06014BD1 RID: 84945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateNpcInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06014BD2 RID: 84946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateMonsterInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06014BD3 RID: 84947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateAnimInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06014BD4 RID: 84948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntity_Internal(IntPtr World, int EntityId);

		// Token: 0x06014BD5 RID: 84949 RVA: 0x001E8036 File Offset: 0x001E6236
		static UKuroAnimJsSubsystemProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimJsSubsystemProxy");
		}

		// Token: 0x06014BD6 RID: 84950 RVA: 0x001E8044 File Offset: 0x001E6244
		protected UKuroAnimJsSubsystemProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B4EA RID: 46314
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimJsSubsystemProxy";

		// Token: 0x0400B4EB RID: 46315
		private static IntPtr _ClassPtr;

		// Token: 0x0400B4EC RID: 46316
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
