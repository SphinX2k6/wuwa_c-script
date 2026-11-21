using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000295 RID: 661
	[UnrealObjectPath("/Script/Engine.SubsystemBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USubsystemBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004901 RID: 18689 RVA: 0x000666A5 File Offset: 0x000648A5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubsystemBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x000666B4 File Offset: 0x000648B4
		public USubsystemBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(USubsystemBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x000666DC File Offset: 0x000648DC
		[NullableContext(1)]
		public USubsystemBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubsystemBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0006670F File Offset: 0x0006490F
		[NullableContext(2)]
		public static UWorldSubsystem GetWorldSubsystem(UObject ContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UWorldSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWorldSubsystem>(USubsystemBlueprintLibrary.__GetWorldSubsystem_Internal((ContextObject != null) ? ContextObject.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x00066731 File Offset: 0x00064931
		[NullableContext(2)]
		public static UGameInstanceSubsystem GetGameInstanceSubsystem(UObject ContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameInstanceSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstanceSubsystem>(USubsystemBlueprintLibrary.__GetGameInstanceSubsystem_Internal((ContextObject != null) ? ContextObject.NativePtr : IntPtr.Zero, Class._NativePtr));
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x00066753 File Offset: 0x00064953
		[NullableContext(2)]
		public static UEngineSubsystem GetEngineSubsystem([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UEngineSubsystem> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UEngineSubsystem>(USubsystemBlueprintLibrary.__GetEngineSubsystem_Internal(Class._NativePtr));
		}

		// Token: 0x06004907 RID: 18695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWorldSubsystem_Internal(IntPtr ContextObject, IntPtr Class);

		// Token: 0x06004908 RID: 18696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstanceSubsystem_Internal(IntPtr ContextObject, IntPtr Class);

		// Token: 0x06004909 RID: 18697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEngineSubsystem_Internal(IntPtr Class);

		// Token: 0x0600490A RID: 18698 RVA: 0x00066765 File Offset: 0x00064965
		static USubsystemBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SubsystemBlueprintLibrary");
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x00066773 File Offset: 0x00064973
		protected USubsystemBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001C62 RID: 7266
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SubsystemBlueprintLibrary";

		// Token: 0x04001C63 RID: 7267
		private static IntPtr _ClassPtr;

		// Token: 0x04001C64 RID: 7268
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
