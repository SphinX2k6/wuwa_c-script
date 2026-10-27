using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011B9 RID: 4537
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SubsystemBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010BA9 RID: 68521 RVA: 0x00188EED File Offset: 0x001870ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubsystemBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06010BAA RID: 68522 RVA: 0x00188EFC File Offset: 0x001870FC
		public USubsystemBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(USubsystemBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010BAB RID: 68523 RVA: 0x00188F24 File Offset: 0x00187124
		[NullableContext(1)]
		public USubsystemBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubsystemBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06010BAC RID: 68524 RVA: 0x00188F57 File Offset: 0x00187157
		public static UWorldSubsystem GetWorldSubsystem(UObject ContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UWorldSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldSubsystem>(USubsystemBlueprintLibrary.__GetWorldSubsystem_Internal((ContextObject != null) ? ContextObject.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06010BAD RID: 68525 RVA: 0x00188F79 File Offset: 0x00187179
		public static ULocalPlayerSubsystem GetLocalPlayerSubSystemFromPlayerController(APlayerController PlayerController, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULocalPlayerSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULocalPlayerSubsystem>(USubsystemBlueprintLibrary.__GetLocalPlayerSubSystemFromPlayerController_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06010BAE RID: 68526 RVA: 0x00188F9B File Offset: 0x0018719B
		public static ULocalPlayerSubsystem GetLocalPlayerSubsystem(UObject ContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<ULocalPlayerSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULocalPlayerSubsystem>(USubsystemBlueprintLibrary.__GetLocalPlayerSubsystem_Internal((ContextObject != null) ? ContextObject.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06010BAF RID: 68527 RVA: 0x00188FBD File Offset: 0x001871BD
		public static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameInstanceSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstanceSubsystem>(USubsystemBlueprintLibrary.__GetGameInstanceSubsystem_Internal((ContextObject != null) ? ContextObject.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06010BB0 RID: 68528 RVA: 0x00188FDF File Offset: 0x001871DF
		public static UEngineSubsystem GetEngineSubsystem([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEngineSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEngineSubsystem>(USubsystemBlueprintLibrary.__GetEngineSubsystem_Internal(Class._NativePtr));
		}

		// Token: 0x06010BB1 RID: 68529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldSubsystem_Internal(IntPtr ContextObject, IntPtr Class);

		// Token: 0x06010BB2 RID: 68530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLocalPlayerSubSystemFromPlayerController_Internal(IntPtr PlayerController, IntPtr Class);

		// Token: 0x06010BB3 RID: 68531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLocalPlayerSubsystem_Internal(IntPtr ContextObject, IntPtr Class);

		// Token: 0x06010BB4 RID: 68532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstanceSubsystem_Internal(IntPtr ContextObject, IntPtr Class);

		// Token: 0x06010BB5 RID: 68533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineSubsystem_Internal(IntPtr Class);

		// Token: 0x06010BB6 RID: 68534 RVA: 0x00188FF1 File Offset: 0x001871F1
		static USubsystemBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SubsystemBlueprintLibrary");
		}

		// Token: 0x06010BB7 RID: 68535 RVA: 0x00188FFF File Offset: 0x001871FF
		protected USubsystemBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F18 RID: 36632
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SubsystemBlueprintLibrary";

		// Token: 0x04008F19 RID: 36633
		private static IntPtr _ClassPtr;

		// Token: 0x04008F1A RID: 36634
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
