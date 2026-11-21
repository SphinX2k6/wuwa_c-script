using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F2 RID: 754
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimJsSubsystemProxy")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAnimJsSubsystemProxy : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005226 RID: 21030 RVA: 0x00072F25 File Offset: 0x00071125
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimJsSubsystemProxy._ClassPtr;
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00072F34 File Offset: 0x00071134
		public UKuroAnimJsSubsystemProxy() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystemProxy.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00072F5C File Offset: 0x0007115C
		[NullableContext(1)]
		public UKuroAnimJsSubsystemProxy(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimJsSubsystemProxy.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00072F8F File Offset: 0x0007118F
		public static void UnregisterUpdateAnimInfoFunction(UGameInstance World)
		{
			UKuroAnimJsSubsystemProxy.__UnregisterUpdateAnimInfoFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00072FA6 File Offset: 0x000711A6
		public static void UnregisterEntity(UGameInstance World, int EntityId)
		{
			UKuroAnimJsSubsystemProxy.__UnregisterEntity_Internal((World != null) ? World.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00072FBE File Offset: 0x000711BE
		public static void RegisterUpdateNpcInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateNpcInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00072FE2 File Offset: 0x000711E2
		public static void RegisterUpdateMonsterInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateMonsterInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00073006 File Offset: 0x00071206
		public static void RegisterUpdateAnimInfoCsFunction(UGameInstance World, FUpdateAnimInfoDelegate UpdateAnimInfoCsFunction)
		{
			UKuroAnimJsSubsystemProxy.__RegisterUpdateAnimInfoCsFunction_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (UpdateAnimInfoCsFunction != null) ? UpdateAnimInfoCsFunction.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x0007302A File Offset: 0x0007122A
		public static void RegisterEntity(UGameInstance World, int EntityId)
		{
			UKuroAnimJsSubsystemProxy.__RegisterEntity_Internal((World != null) ? World.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x0600522F RID: 21039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterUpdateAnimInfoFunction_Internal(IntPtr World);

		// Token: 0x06005230 RID: 21040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterEntity_Internal(IntPtr World, int EntityId);

		// Token: 0x06005231 RID: 21041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateNpcInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06005232 RID: 21042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateMonsterInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06005233 RID: 21043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterUpdateAnimInfoCsFunction_Internal(IntPtr World, IntPtr UpdateAnimInfoCsFunction);

		// Token: 0x06005234 RID: 21044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntity_Internal(IntPtr World, int EntityId);

		// Token: 0x06005235 RID: 21045 RVA: 0x00073042 File Offset: 0x00071242
		static UKuroAnimJsSubsystemProxy()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimJsSubsystemProxy");
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00073050 File Offset: 0x00071250
		protected UKuroAnimJsSubsystemProxy(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400217A RID: 8570
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimJsSubsystemProxy";

		// Token: 0x0400217B RID: 8571
		private static IntPtr _ClassPtr;

		// Token: 0x0400217C RID: 8572
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
