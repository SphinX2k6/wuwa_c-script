using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AE7 RID: 6887
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroDynamicGrassManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019AF3 RID: 105203 RVA: 0x0025F396 File Offset: 0x0025D596
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDynamicGrassManager._ClassPtr;
		}

		// Token: 0x06019AF4 RID: 105204 RVA: 0x0025F3A4 File Offset: 0x0025D5A4
		public UKuroDynamicGrassManager() : this(BuiltinUtils.AllocNativeUObject(UKuroDynamicGrassManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019AF5 RID: 105205 RVA: 0x0025F3CC File Offset: 0x0025D5CC
		[NullableContext(1)]
		public UKuroDynamicGrassManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDynamicGrassManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170066A3 RID: 26275
		// (get) Token: 0x06019AF6 RID: 105206 RVA: 0x0025F400 File Offset: 0x0025D600
		// (set) Token: 0x06019AF7 RID: 105207 RVA: 0x0025F439 File Offset: 0x0025D639
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<int, TWeakObjectPtr<AKuroDynamicGrassActor>> GrassActorMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<int, TWeakObjectPtr<AKuroDynamicGrassActor>> result;
				if ((result = this._GrassActorMap) == null)
				{
					result = (this._GrassActorMap = new TMap<int, TWeakObjectPtr<AKuroDynamicGrassActor>>(base.NativePtr + (IntPtr)UKuroDynamicGrassManager.__PropertyOffset_GrassActorMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.GrassActorMap.CopyAssign(value);
			}
		}

		// Token: 0x170066A4 RID: 26276
		// (get) Token: 0x06019AF8 RID: 105208 RVA: 0x0025F448 File Offset: 0x0025D648
		// (set) Token: 0x06019AF9 RID: 105209 RVA: 0x0025F481 File Offset: 0x0025D681
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<int, TWeakObjectPtr<AActor>> EntityActorMap
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<int, TWeakObjectPtr<AActor>> result;
				if ((result = this._EntityActorMap) == null)
				{
					result = (this._EntityActorMap = new TMap<int, TWeakObjectPtr<AActor>>(base.NativePtr + (IntPtr)UKuroDynamicGrassManager.__PropertyOffset_EntityActorMap, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.EntityActorMap.CopyAssign(value);
			}
		}

		// Token: 0x06019AFA RID: 105210 RVA: 0x0025F490 File Offset: 0x0025D690
		public unsafe void UnregisterGrassActor(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__UnregisterGrassActor_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x06019AFB RID: 105211 RVA: 0x0025F4B4 File Offset: 0x0025D6B4
		public unsafe bool ShouldGrassBeHiddenByEntity(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				return UKuroDynamicGrassManager.__ShouldGrassBeHiddenByEntity_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x06019AFC RID: 105212 RVA: 0x0025F4D4 File Offset: 0x0025D6D4
		public unsafe void SetGrassActorVisibleByEntity(in int ActorID, bool bVisible, AActor EntityActor)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__SetGrassActorVisibleByEntity_Internal(base.NativePtr, ActorID, bVisible, (EntityActor != null) ? EntityActor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06019AFD RID: 105213 RVA: 0x0025F508 File Offset: 0x0025D708
		public unsafe void SetGrassActorVisible(in int ActorID, bool bVisible)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__SetGrassActorVisible_Internal(base.NativePtr, ActorID, bVisible);
			}
		}

		// Token: 0x06019AFE RID: 105214 RVA: 0x0025F52A File Offset: 0x0025D72A
		public void SetAllGrassActorsVisible(bool bVisible)
		{
			UKuroDynamicGrassManager.__SetAllGrassActorsVisible_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x06019AFF RID: 105215 RVA: 0x0025F538 File Offset: 0x0025D738
		public unsafe void RegisterGrassActor(in int ActorID, AKuroDynamicGrassActor Actor)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__RegisterGrassActor_Internal(base.NativePtr, ActorID, (Actor != null) ? Actor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06019B00 RID: 105216 RVA: 0x0025F56C File Offset: 0x0025D76C
		public unsafe bool IsGrassActorRegistered(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				return UKuroDynamicGrassManager.__IsGrassActorRegistered_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x06019B01 RID: 105217 RVA: 0x0025F58A File Offset: 0x0025D78A
		public static UKuroDynamicGrassManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroDynamicGrassManager>(UKuroDynamicGrassManager.__GetInstance_Internal());
		}

		// Token: 0x06019B02 RID: 105218 RVA: 0x0025F598 File Offset: 0x0025D798
		public unsafe AKuroDynamicGrassActor GetGrassActor(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroDynamicGrassActor>(UKuroDynamicGrassManager.__GetGrassActor_Internal(base.NativePtr, ActorID));
			}
		}

		// Token: 0x06019B03 RID: 105219 RVA: 0x0025F5BB File Offset: 0x0025D7BB
		public void ClearAll()
		{
			UKuroDynamicGrassManager.__ClearAll_Internal(base.NativePtr);
		}

		// Token: 0x06019B04 RID: 105220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterGrassActor_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06019B05 RID: 105221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldGrassBeHiddenByEntity_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06019B06 RID: 105222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGrassActorVisibleByEntity_Internal(IntPtr @this, in int ActorID, bool bVisible, IntPtr EntityActor);

		// Token: 0x06019B07 RID: 105223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGrassActorVisible_Internal(IntPtr @this, in int ActorID, bool bVisible);

		// Token: 0x06019B08 RID: 105224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllGrassActorsVisible_Internal(IntPtr @this, bool bVisible);

		// Token: 0x06019B09 RID: 105225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterGrassActor_Internal(IntPtr @this, in int ActorID, IntPtr Actor);

		// Token: 0x06019B0A RID: 105226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGrassActorRegistered_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06019B0B RID: 105227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x06019B0C RID: 105228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrassActor_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06019B0D RID: 105229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAll_Internal(IntPtr @this);

		// Token: 0x06019B0E RID: 105230 RVA: 0x0025F5C8 File Offset: 0x0025D7C8
		static UKuroDynamicGrassManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager");
		}

		// Token: 0x06019B0F RID: 105231 RVA: 0x0025F5D6 File Offset: 0x0025D7D6
		protected UKuroDynamicGrassManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF8F RID: 57231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager";

		// Token: 0x0400DF90 RID: 57232
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF91 RID: 57233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF92 RID: 57234
		internal static int __PropertyOffset_GrassActorMap;

		// Token: 0x0400DF93 RID: 57235
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<int, TWeakObjectPtr<AKuroDynamicGrassActor>> _GrassActorMap;

		// Token: 0x0400DF94 RID: 57236
		internal static int __PropertyOffset_EntityActorMap;

		// Token: 0x0400DF95 RID: 57237
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<int, TWeakObjectPtr<AActor>> _EntityActorMap;
	}
}
