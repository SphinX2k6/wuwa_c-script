using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EFB RID: 3835
	[UnrealObjectPath("/Script/Engine.ObjectPool")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UObjectPool : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CFC9 RID: 53193 RVA: 0x0012F0DC File Offset: 0x0012D2DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UObjectPool._ClassPtr;
		}

		// Token: 0x0600CFCA RID: 53194 RVA: 0x0012F0E8 File Offset: 0x0012D2E8
		public UObjectPool() : this(BuiltinUtils.AllocNativeUObject(UObjectPool.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x0012F110 File Offset: 0x0012D310
		[NullableContext(1)]
		public UObjectPool(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UObjectPool.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x0012F144 File Offset: 0x0012D344
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

		// Token: 0x0600CFCD RID: 53197
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Preload();

		// Token: 0x0600CFCE RID: 53198 RVA: 0x0012F1B3 File Offset: 0x0012D3B3
		[NullableContext(2)]
		public static void DespawnActor(AActor Actor, bool DestroyImmediately = false)
		{
			UObjectPool.__DespawnActor_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, DestroyImmediately);
		}

		// Token: 0x0600CFCF RID: 53199 RVA: 0x0012F1CC File Offset: 0x0012D3CC
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

		// Token: 0x0600CFD0 RID: 53200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActor_Internal(IntPtr WorldContext, IntPtr Class, in FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator);

		// Token: 0x0600CFD1 RID: 53201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DespawnActor_Internal(IntPtr Actor, bool DestroyImmediately);

		// Token: 0x0600CFD2 RID: 53202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_SpawnActor_Internal(IntPtr WorldContext, IntPtr Class, in FTransformDouble SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, IntPtr Owner, IntPtr Instigator);

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x0012F23B File Offset: 0x0012D43B
		static UObjectPool()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ObjectPool");
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x0012F249 File Offset: 0x0012D449
		protected UObjectPool(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007005 RID: 28677
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ObjectPool";

		// Token: 0x04007006 RID: 28678
		private static IntPtr _ClassPtr;

		// Token: 0x04007007 RID: 28679
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
