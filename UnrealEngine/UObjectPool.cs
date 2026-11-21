using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200024B RID: 587
	[UnrealObjectPath("/Script/Engine.ObjectPool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UObjectPool : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060032A5 RID: 12965 RVA: 0x000483C1 File Offset: 0x000465C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPool._ClassPtr;
		}

		// Token: 0x060032A6 RID: 12966 RVA: 0x000483D0 File Offset: 0x000465D0
		public UObjectPool() : this(BuiltinUtils.AllocNativeUObject(UObjectPool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060032A7 RID: 12967 RVA: 0x000483F8 File Offset: 0x000465F8
		[NullableContext(1)]
		public UObjectPool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectPool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060032A8 RID: 12968 RVA: 0x0004842C File Offset: 0x0004662C
		[NullableContext(2)]
		public unsafe static AActor SpawnActor(UObject WorldContext, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UObjectPool.__SpawnActor_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, Class._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060032A9 RID: 12969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Preload();

		// Token: 0x060032AA RID: 12970 RVA: 0x0004849B File Offset: 0x0004669B
		[NullableContext(2)]
		public static void DespawnActor(AActor Actor, bool DestroyImmediately = false)
		{
			UObjectPool.__DespawnActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, DestroyImmediately);
		}

		// Token: 0x060032AB RID: 12971 RVA: 0x000484B4 File Offset: 0x000466B4
		[NullableContext(2)]
		public unsafe static AActor D_SpawnActor(UObject WorldContext, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.Undefined, AActor Owner = null, APawn Instigator = null)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = SpawnTransform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UObjectPool.__D_SpawnActor_Internal((WorldContext != null) ? WorldContext.NativePtr : IntPtr.Zero, Class._NativePtr, ptr, CollisionHandlingOverride, (Owner != null) ? Owner.NativePtr : IntPtr.Zero, (Instigator != null) ? Instigator.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060032AC RID: 12972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActor_Internal(IntPtr WorldContext, IntPtr Class, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator);

		// Token: 0x060032AD RID: 12973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DespawnActor_Internal(IntPtr Actor, bool DestroyImmediately);

		// Token: 0x060032AE RID: 12974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActor_Internal(IntPtr WorldContext, IntPtr Class, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator);

		// Token: 0x060032AF RID: 12975 RVA: 0x00048523 File Offset: 0x00046723
		static UObjectPool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ObjectPool");
		}

		// Token: 0x060032B0 RID: 12976 RVA: 0x00048531 File Offset: 0x00046731
		protected UObjectPool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011AF RID: 4527
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ObjectPool";

		// Token: 0x040011B0 RID: 4528
		private static IntPtr _ClassPtr;

		// Token: 0x040011B1 RID: 4529
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
