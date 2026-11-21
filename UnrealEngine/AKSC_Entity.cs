using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000578 RID: 1400
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_Entity")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class AKSC_Entity : AKSC_BaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007F49 RID: 32585 RVA: 0x000BC6F4 File Offset: 0x000BA8F4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKSC_Entity._ClassPtr;
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x000BC700 File Offset: 0x000BA900
		public AKSC_Entity() : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x000BC728 File Offset: 0x000BA928
		[NullableContext(1)]
		public AKSC_Entity(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKSC_Entity.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06007F4C RID: 32588 RVA: 0x000BC75B File Offset: 0x000BA95B
		// (set) Token: 0x06007F4D RID: 32589 RVA: 0x000BC76F File Offset: 0x000BA96F
		public unsafe UKSC_Move Move_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Move>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Move_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_Move_, value);
			}
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06007F4E RID: 32590 RVA: 0x000BC784 File Offset: 0x000BA984
		// (set) Token: 0x06007F4F RID: 32591 RVA: 0x000BC798 File Offset: 0x000BA998
		public unsafe UKSC_SkillComp SkillComp_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SkillComp_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_SkillComp_, value);
			}
		}

		// Token: 0x170018CC RID: 6348
		// (get) Token: 0x06007F50 RID: 32592 RVA: 0x000BC7AD File Offset: 0x000BA9AD
		// (set) Token: 0x06007F51 RID: 32593 RVA: 0x000BC7C1 File Offset: 0x000BA9C1
		public unsafe UKSC_DA_Entity DaEntity_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_DA_Entity>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_DaEntity_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_DaEntity_, value);
			}
		}

		// Token: 0x170018CD RID: 6349
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x000BC7D8 File Offset: 0x000BA9D8
		// (set) Token: 0x06007F53 RID: 32595 RVA: 0x000BC811 File Offset: 0x000BAA11
		[Nullable(1)]
		public TMap<FName, FVector> SocketOffsets
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FVector> result;
				if ((result = this._SocketOffsets) == null)
				{
					result = (this._SocketOffsets = new TMap<FName, FVector>(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_SocketOffsets, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SocketOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170018CE RID: 6350
		// (get) Token: 0x06007F54 RID: 32596 RVA: 0x000BC81F File Offset: 0x000BAA1F
		// (set) Token: 0x06007F55 RID: 32597 RVA: 0x000BC82F File Offset: 0x000BAA2F
		public unsafe int EntityId_
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_EntityId_);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_EntityId_) = value;
			}
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06007F56 RID: 32598 RVA: 0x000BC840 File Offset: 0x000BAA40
		// (set) Token: 0x06007F57 RID: 32599 RVA: 0x000BC850 File Offset: 0x000BAA50
		public unsafe bool IsKscEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_IsKscEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKSC_Entity.__PropertyOffset_IsKscEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06007F58 RID: 32600 RVA: 0x000BC861 File Offset: 0x000BAA61
		// (set) Token: 0x06007F59 RID: 32601 RVA: 0x000BC875 File Offset: 0x000BAA75
		public unsafe AActor RenderActor_
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_RenderActor_);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKSC_Entity.__PropertyOffset_RenderActor_, value);
			}
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x000BC88A File Offset: 0x000BAA8A
		public void UpdateBuffWithStackNumSelf(UKSC_DA_Buff DaBuff, int StackNum)
		{
			AKSC_Entity.__UpdateBuffWithStackNumSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero, StackNum);
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x000BC8A8 File Offset: 0x000BAAA8
		public void TryActiveSKill(int SkillIndex)
		{
			AKSC_Entity.__TryActiveSKill_Internal(base.NativePtr, SkillIndex);
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x000BC8B8 File Offset: 0x000BAAB8
		public unsafe void SetTransformByWorld(in FTransformDouble D_Transform)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = D_Transform;
			AKSC_Entity.__SetTransformByWorld_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x000BC8ED File Offset: 0x000BAAED
		public void SetRenderActor(AActor RenderActor)
		{
			AKSC_Entity.__SetRenderActor_Internal(base.NativePtr, (RenderActor != null) ? RenderActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x000BC90A File Offset: 0x000BAB0A
		public void SetLocationByWorld(in FVectorDouble D_Location)
		{
			AKSC_Entity.__SetLocationByWorld_Internal(base.NativePtr, D_Location);
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x000BC918 File Offset: 0x000BAB18
		public void SetIgnoreFactions(in TArray<EKSC_Faction> Factions)
		{
			AKSC_Entity.__SetIgnoreFactions_Internal(base.NativePtr, (Factions ?? new TArray<EKSC_Faction>()).NativePtr);
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x000BC935 File Offset: 0x000BAB35
		public void SetFaction(EKSC_Faction Faction)
		{
			AKSC_Entity.__SetFaction_Internal(base.NativePtr, Faction);
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x000BC943 File Offset: 0x000BAB43
		public bool SetEntityActive(bool InActive)
		{
			return AKSC_Entity.__SetEntityActive_Internal(base.NativePtr, InActive);
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x000BC951 File Offset: 0x000BAB51
		public void SetAttr(EKSC_AttrType Type, int Value)
		{
			AKSC_Entity.__SetAttr_Internal(base.NativePtr, Type, Value);
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x000BC960 File Offset: 0x000BAB60
		public void RemoveDaBuffImmediately(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__RemoveDaBuffImmediately_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x000BC97D File Offset: 0x000BAB7D
		public void RemoveBuffSelf(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__RemoveBuffSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x000BC99A File Offset: 0x000BAB9A
		public float GetTimeScale()
		{
			return AKSC_Entity.__GetTimeScale_Internal(base.NativePtr);
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x000BC9A7 File Offset: 0x000BABA7
		public UKSC_SkillComp GetSkillComp()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_SkillComp>(AKSC_Entity.__GetSkillComp_Internal(base.NativePtr));
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x000BC9B9 File Offset: 0x000BABB9
		public AActor GetRenderActor()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(AKSC_Entity.__GetRenderActor_Internal(base.NativePtr));
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x000BC9CB File Offset: 0x000BABCB
		public UKSC_Move GetMoveComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKSC_Move>(AKSC_Entity.__GetMoveComponent_Internal(base.NativePtr));
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x000BC9DD File Offset: 0x000BABDD
		public void Dead(int KillBy)
		{
			AKSC_Entity.__Dead_Internal(base.NativePtr, KillBy);
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x000BC9EB File Offset: 0x000BABEB
		public void ApplyBuffSelf(UKSC_DA_Buff DaBuff)
		{
			AKSC_Entity.__ApplyBuffSelf_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x000BCA08 File Offset: 0x000BAC08
		public void ApplyBuffByOther(UKSC_DA_Buff DaBuff, int EntityId)
		{
			AKSC_Entity.__ApplyBuffByOther_Internal(base.NativePtr, (DaBuff != null) ? DaBuff.NativePtr : IntPtr.Zero, EntityId);
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x000BCA26 File Offset: 0x000BAC26
		public void AddAttr(EKSC_AttrType Type, int Delta)
		{
			AKSC_Entity.__AddAttr_Internal(base.NativePtr, Type, Delta);
		}

		// Token: 0x06007F6D RID: 32621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBuffWithStackNumSelf_Internal(IntPtr @this, IntPtr DaBuff, int StackNum);

		// Token: 0x06007F6E RID: 32622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryActiveSKill_Internal(IntPtr @this, int SkillIndex);

		// Token: 0x06007F6F RID: 32623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransformByWorld_Internal(IntPtr @this, in FTransformDouble D_Transform);

		// Token: 0x06007F70 RID: 32624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderActor_Internal(IntPtr @this, IntPtr RenderActor);

		// Token: 0x06007F71 RID: 32625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLocationByWorld_Internal(IntPtr @this, in FVectorDouble D_Location);

		// Token: 0x06007F72 RID: 32626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreFactions_Internal(IntPtr @this, IntPtr Factions);

		// Token: 0x06007F73 RID: 32627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFaction_Internal(IntPtr @this, EKSC_Faction Faction);

		// Token: 0x06007F74 RID: 32628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetEntityActive_Internal(IntPtr @this, bool InActive);

		// Token: 0x06007F75 RID: 32629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAttr_Internal(IntPtr @this, EKSC_AttrType Type, int Value);

		// Token: 0x06007F76 RID: 32630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveDaBuffImmediately_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x06007F77 RID: 32631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveBuffSelf_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x06007F78 RID: 32632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTimeScale_Internal(IntPtr @this);

		// Token: 0x06007F79 RID: 32633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSkillComp_Internal(IntPtr @this);

		// Token: 0x06007F7A RID: 32634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderActor_Internal(IntPtr @this);

		// Token: 0x06007F7B RID: 32635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMoveComponent_Internal(IntPtr @this);

		// Token: 0x06007F7C RID: 32636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Dead_Internal(IntPtr @this, int KillBy);

		// Token: 0x06007F7D RID: 32637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyBuffSelf_Internal(IntPtr @this, IntPtr DaBuff);

		// Token: 0x06007F7E RID: 32638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyBuffByOther_Internal(IntPtr @this, IntPtr DaBuff, int EntityId);

		// Token: 0x06007F7F RID: 32639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAttr_Internal(IntPtr @this, EKSC_AttrType Type, int Delta);

		// Token: 0x06007F80 RID: 32640 RVA: 0x000BCA35 File Offset: 0x000BAC35
		static AKSC_Entity()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_Entity");
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x000BCA43 File Offset: 0x000BAC43
		protected AKSC_Entity(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037A3 RID: 14243
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_Entity";

		// Token: 0x040037A4 RID: 14244
		private static IntPtr _ClassPtr;

		// Token: 0x040037A5 RID: 14245
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037A6 RID: 14246
		internal static int __PropertyOffset_Move_;

		// Token: 0x040037A7 RID: 14247
		internal static int __PropertyOffset_SkillComp_;

		// Token: 0x040037A8 RID: 14248
		internal static int __PropertyOffset_DaEntity_;

		// Token: 0x040037A9 RID: 14249
		internal static int __PropertyOffset_SocketOffsets;

		// Token: 0x040037AA RID: 14250
		private TMap<FName, FVector> _SocketOffsets;

		// Token: 0x040037AB RID: 14251
		internal static int __PropertyOffset_EntityId_;

		// Token: 0x040037AC RID: 14252
		internal static int __PropertyOffset_IsKscEnable;

		// Token: 0x040037AD RID: 14253
		internal static int __PropertyOffset_RenderActor_;
	}
}
