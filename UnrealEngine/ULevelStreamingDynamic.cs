using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D3A RID: 3386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelStreamingDynamic")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class ULevelStreamingDynamic : ULevelStreaming, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B58B RID: 46475 RVA: 0x00102F16 File Offset: 0x00101116
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingDynamic._ClassPtr;
		}

		// Token: 0x0600B58C RID: 46476 RVA: 0x00102F24 File Offset: 0x00101124
		public ULevelStreamingDynamic() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B58D RID: 46477 RVA: 0x00102F4C File Offset: 0x0010114C
		public ULevelStreamingDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700298A RID: 10634
		// (get) Token: 0x0600B58E RID: 46478 RVA: 0x00102F7F File Offset: 0x0010117F
		// (set) Token: 0x0600B58F RID: 46479 RVA: 0x00102F98 File Offset: 0x00101198
		public unsafe bool bInitiallyLoaded
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyLoaded) & ULevelStreamingDynamic.__PropertyMask_bInitiallyLoaded) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyLoaded) = ((*(base.NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyLoaded) & ~ULevelStreamingDynamic.__PropertyMask_bInitiallyLoaded) | (value ? ULevelStreamingDynamic.__PropertyMask_bInitiallyLoaded : 0));
			}
		}

		// Token: 0x1700298B RID: 10635
		// (get) Token: 0x0600B590 RID: 46480 RVA: 0x00102FC8 File Offset: 0x001011C8
		// (set) Token: 0x0600B591 RID: 46481 RVA: 0x00102FE1 File Offset: 0x001011E1
		public unsafe bool bInitiallyVisible
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyVisible) & ULevelStreamingDynamic.__PropertyMask_bInitiallyVisible) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyVisible) = ((*(base.NativePtr + (IntPtr)ULevelStreamingDynamic.__PropertyOffset_bInitiallyVisible) & ~ULevelStreamingDynamic.__PropertyMask_bInitiallyVisible) | (value ? ULevelStreamingDynamic.__PropertyMask_bInitiallyVisible : 0));
			}
		}

		// Token: 0x0600B592 RID: 46482 RVA: 0x00103014 File Offset: 0x00101214
		[return: Nullable(2)]
		public unsafe static ULevelStreamingDynamic LoadLevelInstanceBySoftObjectPtr([Nullable(2)] UObject WorldContextObject, TSoftObjectPtr<UWorld> Level, FVector Location, FRotator Rotation, ref bool bOutSuccess, string OptionalLevelNameOverride = "", [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass = default(TSubclassOf<ULevelStreamingDynamic>))
		{
			FString fstring = FString.AllocTemp(OptionalLevelNameOverride);
			fixed (bool* ptr = &bOutSuccess)
			{
				void* ptr2 = (void*)ptr;
				ULevelStreamingDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreamingDynamic>(ULevelStreamingDynamic.__LoadLevelInstanceBySoftObjectPtr_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (Level ?? new TSoftObjectPtr<UWorld>()).NativePtr, Location, Rotation, ref bOutSuccess, fstring, OptionalLevelStreamingClass._NativePtr));
				FString.NativeDestruct(&fstring, 1);
				return orCreateUObjectByNativePointer;
			}
		}

		// Token: 0x0600B593 RID: 46483 RVA: 0x00103070 File Offset: 0x00101270
		[return: Nullable(2)]
		public unsafe static ULevelStreamingDynamic LoadLevelInstance([Nullable(2)] UObject WorldContextObject, string LevelName, FVector Location, FRotator Rotation, ref bool bOutSuccess, string OptionalLevelNameOverride = "", [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass = default(TSubclassOf<ULevelStreamingDynamic>))
		{
			FString fstring = FString.AllocTemp(LevelName);
			FString fstring2 = FString.AllocTemp(OptionalLevelNameOverride);
			fixed (bool* ptr = &bOutSuccess)
			{
				void* ptr2 = (void*)ptr;
				ULevelStreamingDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreamingDynamic>(ULevelStreamingDynamic.__LoadLevelInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Location, Rotation, ref bOutSuccess, fstring2, OptionalLevelStreamingClass._NativePtr));
				FString.NativeDestruct(&fstring, 1);
				FString.NativeDestruct(&fstring2, 1);
				return orCreateUObjectByNativePointer;
			}
		}

		// Token: 0x0600B594 RID: 46484 RVA: 0x001030D0 File Offset: 0x001012D0
		[return: Nullable(2)]
		public unsafe static ULevelStreamingDynamic D_LoadLevelInstance([Nullable(2)] UObject WorldContextObject, string LevelName, FVectorDouble Location, FRotator Rotation, ref bool bOutSuccess, string OptionalLevelNameOverride = "", [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULevelStreamingDynamic> OptionalLevelStreamingClass = default(TSubclassOf<ULevelStreamingDynamic>))
		{
			FString fstring = FString.AllocTemp(LevelName);
			FString fstring2 = FString.AllocTemp(OptionalLevelNameOverride);
			fixed (bool* ptr = &bOutSuccess)
			{
				void* ptr2 = (void*)ptr;
				ULevelStreamingDynamic orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<ULevelStreamingDynamic>(ULevelStreamingDynamic.__D_LoadLevelInstance_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, fstring, Location, Rotation, ref bOutSuccess, fstring2, OptionalLevelStreamingClass._NativePtr));
				FString.NativeDestruct(&fstring, 1);
				FString.NativeDestruct(&fstring2, 1);
				return orCreateUObjectByNativePointer;
			}
		}

		// Token: 0x0600B595 RID: 46485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadLevelInstanceBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, FVector Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x0600B596 RID: 46486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadLevelInstance_Internal(IntPtr WorldContextObject, in FString LevelName, FVector Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x0600B597 RID: 46487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_LoadLevelInstance_Internal(IntPtr WorldContextObject, in FString LevelName, FVectorDouble Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x0600B598 RID: 46488 RVA: 0x0010312D File Offset: 0x0010132D
		static ULevelStreamingDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingDynamic");
		}

		// Token: 0x0600B599 RID: 46489 RVA: 0x0010313B File Offset: 0x0010133B
		protected ULevelStreamingDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005F6A RID: 24426
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingDynamic";

		// Token: 0x04005F6B RID: 24427
		private static IntPtr _ClassPtr;

		// Token: 0x04005F6C RID: 24428
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005F6D RID: 24429
		internal static int __PropertyOffset_bInitiallyLoaded;

		// Token: 0x04005F6E RID: 24430
		internal static byte __PropertyMask_bInitiallyLoaded;

		// Token: 0x04005F6F RID: 24431
		internal static int __PropertyOffset_bInitiallyVisible;

		// Token: 0x04005F70 RID: 24432
		internal static byte __PropertyMask_bInitiallyVisible;
	}
}
