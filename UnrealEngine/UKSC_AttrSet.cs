using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200055F RID: 1375
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_AttrSet")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UKSC_AttrSet : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007D72 RID: 32114 RVA: 0x000BA11A File Offset: 0x000B831A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_AttrSet._ClassPtr;
		}

		// Token: 0x06007D73 RID: 32115 RVA: 0x000BA128 File Offset: 0x000B8328
		public UKSC_AttrSet() : this(BuiltinUtils.AllocNativeUObject(UKSC_AttrSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x000BA150 File Offset: 0x000B8350
		public UKSC_AttrSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_AttrSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x06007D75 RID: 32117 RVA: 0x000BA183 File Offset: 0x000B8383
		// (set) Token: 0x06007D76 RID: 32118 RVA: 0x000BA197 File Offset: 0x000B8397
		[Nullable(2)]
		public unsafe UKSC_SkillComp Owner_
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_SkillComp>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AttrSet.__PropertyOffset_Owner_);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AttrSet.__PropertyOffset_Owner_, value);
			}
		}

		// Token: 0x1700182F RID: 6191
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x000BA1AC File Offset: 0x000B83AC
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x000BA1E5 File Offset: 0x000B83E5
		public TMap<EKSC_AttrType, int> SourceAttrs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._SourceAttrs_) == null)
				{
					result = (this._SourceAttrs_ = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_SourceAttrs_, this));
				}
				return result;
			}
			set
			{
				this.SourceAttrs_.CopyAssign(value);
			}
		}

		// Token: 0x17001830 RID: 6192
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x000BA1F4 File Offset: 0x000B83F4
		// (set) Token: 0x06007D7A RID: 32122 RVA: 0x000BA22D File Offset: 0x000B842D
		public TMap<EKSC_AttrType, int> Attrs_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._Attrs_) == null)
				{
					result = (this._Attrs_ = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_Attrs_, this));
				}
				return result;
			}
			set
			{
				this.Attrs_.CopyAssign(value);
			}
		}

		// Token: 0x17001831 RID: 6193
		// (get) Token: 0x06007D7B RID: 32123 RVA: 0x000BA23C File Offset: 0x000B843C
		// (set) Token: 0x06007D7C RID: 32124 RVA: 0x000BA275 File Offset: 0x000B8475
		public TMap<UObject, int> MoveReduceAttrs
		{
			get
			{
				base.FastCheckIsValid();
				TMap<UObject, int> result;
				if ((result = this._MoveReduceAttrs) == null)
				{
					result = (this._MoveReduceAttrs = new TMap<UObject, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_MoveReduceAttrs, this));
				}
				return result;
			}
			set
			{
				this.MoveReduceAttrs.CopyAssign(value);
			}
		}

		// Token: 0x17001832 RID: 6194
		// (get) Token: 0x06007D7D RID: 32125 RVA: 0x000BA283 File Offset: 0x000B8483
		// (set) Token: 0x06007D7E RID: 32126 RVA: 0x000BA297 File Offset: 0x000B8497
		[Nullable(2)]
		public unsafe UObject CurMoveReduceObject
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AttrSet.__PropertyOffset_CurMoveReduceObject);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_AttrSet.__PropertyOffset_CurMoveReduceObject, value);
			}
		}

		// Token: 0x17001833 RID: 6195
		// (get) Token: 0x06007D7F RID: 32127 RVA: 0x000BA2AC File Offset: 0x000B84AC
		// (set) Token: 0x06007D80 RID: 32128 RVA: 0x000BA2E5 File Offset: 0x000B84E5
		public TMap<EKSC_AttrType, int> AttrsLockLowerBound
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._AttrsLockLowerBound) == null)
				{
					result = (this._AttrsLockLowerBound = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_AttrsLockLowerBound, this));
				}
				return result;
			}
			set
			{
				this.AttrsLockLowerBound.CopyAssign(value);
			}
		}

		// Token: 0x17001834 RID: 6196
		// (get) Token: 0x06007D81 RID: 32129 RVA: 0x000BA2F4 File Offset: 0x000B84F4
		// (set) Token: 0x06007D82 RID: 32130 RVA: 0x000BA32D File Offset: 0x000B852D
		public TMap<EKSC_AttrType, int> AttrsLockUpperBound
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._AttrsLockUpperBound) == null)
				{
					result = (this._AttrsLockUpperBound = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_AttrsLockUpperBound, this));
				}
				return result;
			}
			set
			{
				this.AttrsLockUpperBound.CopyAssign(value);
			}
		}

		// Token: 0x17001835 RID: 6197
		// (get) Token: 0x06007D83 RID: 32131 RVA: 0x000BA33C File Offset: 0x000B853C
		// (set) Token: 0x06007D84 RID: 32132 RVA: 0x000BA375 File Offset: 0x000B8575
		public TMap<EKSC_AttrType, int> LockedAttrValues_
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKSC_AttrType, int> result;
				if ((result = this._LockedAttrValues_) == null)
				{
					result = (this._LockedAttrValues_ = new TMap<EKSC_AttrType, int>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_LockedAttrValues_, this));
				}
				return result;
			}
			set
			{
				this.LockedAttrValues_.CopyAssign(value);
			}
		}

		// Token: 0x06007D85 RID: 32133 RVA: 0x000BA383 File Offset: 0x000B8583
		public void UnlockAttrValue(EKSC_AttrType Id)
		{
			UKSC_AttrSet.__UnlockAttrValue_Internal(base.NativePtr, Id);
		}

		// Token: 0x06007D86 RID: 32134 RVA: 0x000BA391 File Offset: 0x000B8591
		public void RemoveUpperBoundLocker(EKSC_AttrType Id, int HandleId)
		{
			UKSC_AttrSet.__RemoveUpperBoundLocker_Internal(base.NativePtr, Id, HandleId);
		}

		// Token: 0x06007D87 RID: 32135 RVA: 0x000BA3A0 File Offset: 0x000B85A0
		public void RemoveLowerBoundLocker(EKSC_AttrType Id, int HandleId)
		{
			UKSC_AttrSet.__RemoveLowerBoundLocker_Internal(base.NativePtr, Id, HandleId);
		}

		// Token: 0x06007D88 RID: 32136 RVA: 0x000BA3AF File Offset: 0x000B85AF
		[NullableContext(2)]
		public void RemoveAttrListen(EKSC_AttrType Id, in FOnKSCAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAttrChange fonKSCAttrChange = InDelegate;
			UKSC_AttrSet.__RemoveAttrListen_Internal(nativePtr, Id, (fonKSCAttrChange != null) ? fonKSCAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06007D89 RID: 32137 RVA: 0x000BA3CC File Offset: 0x000B85CC
		[NullableContext(2)]
		public void RemoveAllAttrListen(in FOnKSCAllAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAllAttrChange fonKSCAllAttrChange = InDelegate;
			UKSC_AttrSet.__RemoveAllAttrListen_Internal(nativePtr, (fonKSCAllAttrChange != null) ? fonKSCAllAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06007D8A RID: 32138 RVA: 0x000BA3E8 File Offset: 0x000B85E8
		public void LockAttrValue(EKSC_AttrType Id, int Value)
		{
			UKSC_AttrSet.__LockAttrValue_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x06007D8B RID: 32139 RVA: 0x000BA3F7 File Offset: 0x000B85F7
		public bool IsAttrValueLocked(EKSC_AttrType Id)
		{
			return UKSC_AttrSet.__IsAttrValueLocked_Internal(base.NativePtr, Id);
		}

		// Token: 0x06007D8C RID: 32140 RVA: 0x000BA408 File Offset: 0x000B8608
		public unsafe bool GetLockedAttrValue(EKSC_AttrType Id, ref int Value)
		{
			fixed (int* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				return UKSC_AttrSet.__GetLockedAttrValue_Internal(base.NativePtr, Id, ref Value);
			}
		}

		// Token: 0x06007D8D RID: 32141 RVA: 0x000BA427 File Offset: 0x000B8627
		public void ClearAllLockedAttrValues()
		{
			UKSC_AttrSet.__ClearAllLockedAttrValues_Internal(base.NativePtr);
		}

		// Token: 0x06007D8E RID: 32142 RVA: 0x000BA434 File Offset: 0x000B8634
		[NullableContext(2)]
		public void AssignAttrListen(EKSC_AttrType Id, in FOnKSCAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAttrChange fonKSCAttrChange = InDelegate;
			UKSC_AttrSet.__AssignAttrListen_Internal(nativePtr, Id, (fonKSCAttrChange != null) ? fonKSCAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06007D8F RID: 32143 RVA: 0x000BA451 File Offset: 0x000B8651
		[NullableContext(2)]
		public void AssignAllAttrListen(in FOnKSCAllAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAllAttrChange fonKSCAllAttrChange = InDelegate;
			UKSC_AttrSet.__AssignAllAttrListen_Internal(nativePtr, (fonKSCAllAttrChange != null) ? fonKSCAllAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06007D90 RID: 32144 RVA: 0x000BA46D File Offset: 0x000B866D
		public int AddUpperBoundLocker(EKSC_AttrType Id, int Value)
		{
			return UKSC_AttrSet.__AddUpperBoundLocker_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x06007D91 RID: 32145 RVA: 0x000BA47C File Offset: 0x000B867C
		public int AddLowerBoundLocker(EKSC_AttrType Id, int Value)
		{
			return UKSC_AttrSet.__AddLowerBoundLocker_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x06007D92 RID: 32146
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAttrValue_Internal(IntPtr @this, EKSC_AttrType Id);

		// Token: 0x06007D93 RID: 32147
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveUpperBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int HandleId);

		// Token: 0x06007D94 RID: 32148
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLowerBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int HandleId);

		// Token: 0x06007D95 RID: 32149
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAttrListen_Internal(IntPtr @this, EKSC_AttrType Id, IntPtr InDelegate);

		// Token: 0x06007D96 RID: 32150
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllAttrListen_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06007D97 RID: 32151
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAttrValue_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x06007D98 RID: 32152
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAttrValueLocked_Internal(IntPtr @this, EKSC_AttrType Id);

		// Token: 0x06007D99 RID: 32153
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLockedAttrValue_Internal(IntPtr @this, EKSC_AttrType Id, ref int Value);

		// Token: 0x06007D9A RID: 32154
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllLockedAttrValues_Internal(IntPtr @this);

		// Token: 0x06007D9B RID: 32155
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignAttrListen_Internal(IntPtr @this, EKSC_AttrType Id, IntPtr InDelegate);

		// Token: 0x06007D9C RID: 32156
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignAllAttrListen_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06007D9D RID: 32157
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddUpperBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x06007D9E RID: 32158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLowerBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x06007D9F RID: 32159 RVA: 0x000BA48B File Offset: 0x000B868B
		static UKSC_AttrSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_AttrSet");
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x000BA499 File Offset: 0x000B8699
		protected UKSC_AttrSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040036AC RID: 13996
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_AttrSet";

		// Token: 0x040036AD RID: 13997
		private static IntPtr _ClassPtr;

		// Token: 0x040036AE RID: 13998
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040036AF RID: 13999
		internal static int __PropertyOffset_Owner_;

		// Token: 0x040036B0 RID: 14000
		internal static int __PropertyOffset_SourceAttrs_;

		// Token: 0x040036B1 RID: 14001
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _SourceAttrs_;

		// Token: 0x040036B2 RID: 14002
		internal static int __PropertyOffset_Attrs_;

		// Token: 0x040036B3 RID: 14003
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _Attrs_;

		// Token: 0x040036B4 RID: 14004
		internal static int __PropertyOffset_MoveReduceAttrs;

		// Token: 0x040036B5 RID: 14005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _MoveReduceAttrs;

		// Token: 0x040036B6 RID: 14006
		internal static int __PropertyOffset_CurMoveReduceObject;

		// Token: 0x040036B7 RID: 14007
		internal static int __PropertyOffset_AttrsLockLowerBound;

		// Token: 0x040036B8 RID: 14008
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttrsLockLowerBound;

		// Token: 0x040036B9 RID: 14009
		internal static int __PropertyOffset_AttrsLockUpperBound;

		// Token: 0x040036BA RID: 14010
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttrsLockUpperBound;

		// Token: 0x040036BB RID: 14011
		internal static int __PropertyOffset_LockedAttrValues_;

		// Token: 0x040036BC RID: 14012
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _LockedAttrValues_;
	}
}
