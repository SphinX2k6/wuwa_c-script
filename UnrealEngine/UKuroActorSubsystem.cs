using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000228 RID: 552
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroActorSubsystem")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UKuroActorSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002CAF RID: 11439 RVA: 0x0003F273 File Offset: 0x0003D473
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroActorSubsystem._ClassPtr;
		}

		// Token: 0x06002CB0 RID: 11440 RVA: 0x0003F280 File Offset: 0x0003D480
		public UKuroActorSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroActorSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x0003F2A8 File Offset: 0x0003D4A8
		public UKuroActorSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroActorSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x0003F2DC File Offset: 0x0003D4DC
		// (set) Token: 0x06002CB3 RID: 11443 RVA: 0x0003F315 File Offset: 0x0003D515
		public FActorSubsystemDelegate OnAddToSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FActorSubsystemDelegate result;
				if ((result = this._OnAddToSubsystem) == null)
				{
					result = (this._OnAddToSubsystem = new FActorSubsystemDelegate(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnAddToSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnAddToSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002CB4 RID: 11444 RVA: 0x0003F338 File Offset: 0x0003D538
		// (set) Token: 0x06002CB5 RID: 11445 RVA: 0x0003F371 File Offset: 0x0003D571
		public FActorSubsystemDelegate OnRemoveFromSubsystem
		{
			get
			{
				base.FastCheckIsValid();
				FActorSubsystemDelegate result;
				if ((result = this._OnRemoveFromSubsystem) == null)
				{
					result = (this._OnRemoveFromSubsystem = new FActorSubsystemDelegate(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnRemoveFromSubsystem, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroActorSubsystem.__PropertyOffset_OnRemoveFromSubsystem, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0003F392 File Offset: 0x0003D592
		public void UnRegisterEntity(int EntityId)
		{
			UKuroActorSubsystem.__UnRegisterEntity_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0003F3A0 File Offset: 0x0003D5A0
		public void RegisterEntity(int EntityId, bool bPreAwake = false)
		{
			UKuroActorSubsystem.__RegisterEntity_Internal(base.NativePtr, EntityId, bPreAwake);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x0003F3AF File Offset: 0x0003D5AF
		public void RecordEntityModifiedActor(int EntityId)
		{
			UKuroActorSubsystem.__RecordEntityModifiedActor_Internal(base.NativePtr, EntityId);
		}

		// Token: 0x06002CB9 RID: 11449 RVA: 0x0003F3C0 File Offset: 0x0003D5C0
		public unsafe bool GetActorOriginalTransform(FName ActorKey, ref FTransform OutTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			bool result = UKuroActorSubsystem.__GetActorOriginalTransform_Internal(base.NativePtr, ActorKey, ref ptr);
			OutTransform = ptr;
			return result;
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x0003F402 File Offset: 0x0003D602
		[NullableContext(2)]
		public AActor GetActor(FName ActorKey)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UKuroActorSubsystem.__GetActor_Internal(base.NativePtr, ActorKey));
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x0003F418 File Offset: 0x0003D618
		[NullableContext(2)]
		public unsafe bool D_GetActorOriginalTransform(UObject WorldContext, FName ActorKey, ref FTransformDouble OutTransform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTransform;
			bool result = UKuroActorSubsystem.__D_GetActorOriginalTransform_Internal(base.NativePtr, (WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, ActorKey, ref ptr);
			OutTransform = ptr;
			return result;
		}

		// Token: 0x06002CBC RID: 11452 RVA: 0x0003F46C File Offset: 0x0003D66C
		public unsafe static bool CheckAssetPlatformInclude(string ResourcePlatformTag)
		{
			FString fstring = FString.AllocTemp(ResourcePlatformTag);
			bool result = UKuroActorSubsystem.__CheckAssetPlatformInclude_Internal(fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002CBD RID: 11453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterEntity_Internal(IntPtr @this, int EntityId);

		// Token: 0x06002CBE RID: 11454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntity_Internal(IntPtr @this, int EntityId, bool bPreAwake);

		// Token: 0x06002CBF RID: 11455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RecordEntityModifiedActor_Internal(IntPtr @this, int EntityId);

		// Token: 0x06002CC0 RID: 11456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActorOriginalTransform_Internal(IntPtr @this, FName ActorKey, ref FTransform OutTransform);

		// Token: 0x06002CC1 RID: 11457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActor_Internal(IntPtr @this, FName ActorKey);

		// Token: 0x06002CC2 RID: 11458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_GetActorOriginalTransform_Internal(IntPtr @this, IntPtr WorldContext, FName ActorKey, ref FTransformDouble OutTransform);

		// Token: 0x06002CC3 RID: 11459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckAssetPlatformInclude_Internal(in FString ResourcePlatformTag);

		// Token: 0x06002CC4 RID: 11460 RVA: 0x0003F490 File Offset: 0x0003D690
		static UKuroActorSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KuroActorSubsystem");
		}

		// Token: 0x06002CC5 RID: 11461 RVA: 0x0003F49E File Offset: 0x0003D69E
		protected UKuroActorSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E25 RID: 3621
		public new const string __ObjectPath = "/Script/Engine.KuroActorSubsystem";

		// Token: 0x04000E26 RID: 3622
		private static IntPtr _ClassPtr;

		// Token: 0x04000E27 RID: 3623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E28 RID: 3624
		internal static int __PropertyOffset_OnAddToSubsystem;

		// Token: 0x04000E29 RID: 3625
		[Nullable(2)]
		private FActorSubsystemDelegate _OnAddToSubsystem;

		// Token: 0x04000E2A RID: 3626
		internal static int __PropertyOffset_OnRemoveFromSubsystem;

		// Token: 0x04000E2B RID: 3627
		[Nullable(2)]
		private FActorSubsystemDelegate _OnRemoveFromSubsystem;
	}
}
