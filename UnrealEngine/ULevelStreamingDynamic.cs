using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000232 RID: 562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.LevelStreamingDynamic")]
	[UnrealStructLayout(496, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 496)]
	public class ULevelStreamingDynamic : ULevelStreaming, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002DA5 RID: 11685 RVA: 0x000407F5 File Offset: 0x0003E9F5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULevelStreamingDynamic._ClassPtr;
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00040804 File Offset: 0x0003EA04
		public ULevelStreamingDynamic() : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingDynamic.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x0004082C File Offset: 0x0003EA2C
		public ULevelStreamingDynamic(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULevelStreamingDynamic.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x0004085F File Offset: 0x0003EA5F
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x00040878 File Offset: 0x0003EA78
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

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x000408A8 File Offset: 0x0003EAA8
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x000408C1 File Offset: 0x0003EAC1
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

		// Token: 0x06002DAC RID: 11692 RVA: 0x000408F4 File Offset: 0x0003EAF4
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

		// Token: 0x06002DAD RID: 11693 RVA: 0x00040950 File Offset: 0x0003EB50
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

		// Token: 0x06002DAE RID: 11694 RVA: 0x000409B0 File Offset: 0x0003EBB0
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

		// Token: 0x06002DAF RID: 11695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadLevelInstanceBySoftObjectPtr_Internal(IntPtr WorldContextObject, IntPtr Level, FVector Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x06002DB0 RID: 11696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LoadLevelInstance_Internal(IntPtr WorldContextObject, in FString LevelName, FVector Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x06002DB1 RID: 11697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_LoadLevelInstance_Internal(IntPtr WorldContextObject, in FString LevelName, FVectorDouble Location, FRotator Rotation, ref bool bOutSuccess, in FString OptionalLevelNameOverride, IntPtr OptionalLevelStreamingClass);

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00040A0D File Offset: 0x0003EC0D
		static ULevelStreamingDynamic()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LevelStreamingDynamic");
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x00040A1B File Offset: 0x0003EC1B
		protected ULevelStreamingDynamic(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E9D RID: 3741
		public new const string __ObjectPath = "/Script/Engine.LevelStreamingDynamic";

		// Token: 0x04000E9E RID: 3742
		private static IntPtr _ClassPtr;

		// Token: 0x04000E9F RID: 3743
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000EA0 RID: 3744
		internal static int __PropertyOffset_bInitiallyLoaded;

		// Token: 0x04000EA1 RID: 3745
		internal static byte __PropertyMask_bInitiallyLoaded;

		// Token: 0x04000EA2 RID: 3746
		internal static int __PropertyOffset_bInitiallyVisible;

		// Token: 0x04000EA3 RID: 3747
		internal static byte __PropertyMask_bInitiallyVisible;
	}
}
