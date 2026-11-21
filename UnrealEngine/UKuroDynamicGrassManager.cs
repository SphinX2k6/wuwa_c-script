using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004C3 RID: 1219
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UKuroDynamicGrassManager : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007079 RID: 28793 RVA: 0x000A6250 File Offset: 0x000A4450
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroDynamicGrassManager._ClassPtr;
		}

		// Token: 0x0600707A RID: 28794 RVA: 0x000A625C File Offset: 0x000A445C
		public UKuroDynamicGrassManager() : this(BuiltinUtils.AllocNativeUObject(UKuroDynamicGrassManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600707B RID: 28795 RVA: 0x000A6284 File Offset: 0x000A4484
		[NullableContext(1)]
		public UKuroDynamicGrassManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroDynamicGrassManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600707C RID: 28796 RVA: 0x000A62B8 File Offset: 0x000A44B8
		// (set) Token: 0x0600707D RID: 28797 RVA: 0x000A62F1 File Offset: 0x000A44F1
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

		// Token: 0x0600707E RID: 28798 RVA: 0x000A6300 File Offset: 0x000A4500
		public unsafe void UnregisterGrassActor(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__UnregisterGrassActor_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x0600707F RID: 28799 RVA: 0x000A6324 File Offset: 0x000A4524
		public unsafe bool ShouldGrassBeHiddenByEntity(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				return UKuroDynamicGrassManager.__ShouldGrassBeHiddenByEntity_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x06007080 RID: 28800 RVA: 0x000A6344 File Offset: 0x000A4544
		[NullableContext(2)]
		public unsafe void SetGrassActorVisibleByEntity(in int ActorID, bool bVisible, AActor EntityActor)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__SetGrassActorVisibleByEntity_Internal(base.NativePtr, ActorID, bVisible, (EntityActor != null) ? EntityActor.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06007081 RID: 28801 RVA: 0x000A6378 File Offset: 0x000A4578
		public unsafe void SetGrassActorVisible(in int ActorID, bool bVisible)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				UKuroDynamicGrassManager.__SetGrassActorVisible_Internal(base.NativePtr, ActorID, bVisible);
			}
		}

		// Token: 0x06007082 RID: 28802 RVA: 0x000A639A File Offset: 0x000A459A
		public void SetAllGrassActorsVisible(bool bVisible)
		{
			UKuroDynamicGrassManager.__SetAllGrassActorsVisible_Internal(base.NativePtr, bVisible);
		}

		// Token: 0x06007083 RID: 28803 RVA: 0x000A63A8 File Offset: 0x000A45A8
		public unsafe bool IsGrassActorRegistered(in int ActorID)
		{
			fixed (int* ptr = &ActorID)
			{
				void* ptr2 = (void*)ptr;
				return UKuroDynamicGrassManager.__IsGrassActorRegistered_Internal(base.NativePtr, ActorID);
			}
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x000A63C6 File Offset: 0x000A45C6
		[NullableContext(2)]
		public static UKuroDynamicGrassManager GetInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroDynamicGrassManager>(UKuroDynamicGrassManager.__GetInstance_Internal());
		}

		// Token: 0x06007085 RID: 28805 RVA: 0x000A63D2 File Offset: 0x000A45D2
		public void ClearAll()
		{
			UKuroDynamicGrassManager.__ClearAll_Internal(base.NativePtr);
		}

		// Token: 0x06007086 RID: 28806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterGrassActor_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06007087 RID: 28807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ShouldGrassBeHiddenByEntity_Internal(IntPtr @this, in int ActorID);

		// Token: 0x06007088 RID: 28808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGrassActorVisibleByEntity_Internal(IntPtr @this, in int ActorID, bool bVisible, IntPtr EntityActor);

		// Token: 0x06007089 RID: 28809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGrassActorVisible_Internal(IntPtr @this, in int ActorID, bool bVisible);

		// Token: 0x0600708A RID: 28810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllGrassActorsVisible_Internal(IntPtr @this, bool bVisible);

		// Token: 0x0600708B RID: 28811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsGrassActorRegistered_Internal(IntPtr @this, in int ActorID);

		// Token: 0x0600708C RID: 28812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInstance_Internal();

		// Token: 0x0600708D RID: 28813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAll_Internal(IntPtr @this);

		// Token: 0x0600708E RID: 28814 RVA: 0x000A63DF File Offset: 0x000A45DF
		static UKuroDynamicGrassManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager");
		}

		// Token: 0x0600708F RID: 28815 RVA: 0x000A63ED File Offset: 0x000A45ED
		protected UKuroDynamicGrassManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400309C RID: 12444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDynamicGrassManager";

		// Token: 0x0400309D RID: 12445
		private static IntPtr _ClassPtr;

		// Token: 0x0400309E RID: 12446
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400309F RID: 12447
		internal static int __PropertyOffset_EntityActorMap;

		// Token: 0x040030A0 RID: 12448
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<int, TWeakObjectPtr<AActor>> _EntityActorMap;
	}
}
