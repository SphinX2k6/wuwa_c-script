using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001CFB RID: 7419
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_AttrSet")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class UKSC_AttrSet : UKSC_BaseObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C8AD RID: 116909 RVA: 0x002A32A3 File Offset: 0x002A14A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_AttrSet._ClassPtr;
		}

		// Token: 0x0601C8AE RID: 116910 RVA: 0x002A32B0 File Offset: 0x002A14B0
		public UKSC_AttrSet() : this(BuiltinUtils.AllocNativeUObject(UKSC_AttrSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C8AF RID: 116911 RVA: 0x002A32D8 File Offset: 0x002A14D8
		public UKSC_AttrSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_AttrSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007302 RID: 29442
		// (get) Token: 0x0601C8B0 RID: 116912 RVA: 0x002A330B File Offset: 0x002A150B
		// (set) Token: 0x0601C8B1 RID: 116913 RVA: 0x002A331F File Offset: 0x002A151F
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

		// Token: 0x17007303 RID: 29443
		// (get) Token: 0x0601C8B2 RID: 116914 RVA: 0x002A3334 File Offset: 0x002A1534
		// (set) Token: 0x0601C8B3 RID: 116915 RVA: 0x002A336D File Offset: 0x002A156D
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

		// Token: 0x17007304 RID: 29444
		// (get) Token: 0x0601C8B4 RID: 116916 RVA: 0x002A337C File Offset: 0x002A157C
		// (set) Token: 0x0601C8B5 RID: 116917 RVA: 0x002A33B5 File Offset: 0x002A15B5
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

		// Token: 0x17007305 RID: 29445
		// (get) Token: 0x0601C8B6 RID: 116918 RVA: 0x002A33C4 File Offset: 0x002A15C4
		// (set) Token: 0x0601C8B7 RID: 116919 RVA: 0x002A33FD File Offset: 0x002A15FD
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

		// Token: 0x17007306 RID: 29446
		// (get) Token: 0x0601C8B8 RID: 116920 RVA: 0x002A340B File Offset: 0x002A160B
		// (set) Token: 0x0601C8B9 RID: 116921 RVA: 0x002A341F File Offset: 0x002A161F
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

		// Token: 0x17007307 RID: 29447
		// (get) Token: 0x0601C8BA RID: 116922 RVA: 0x002A3434 File Offset: 0x002A1634
		// (set) Token: 0x0601C8BB RID: 116923 RVA: 0x002A346D File Offset: 0x002A166D
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

		// Token: 0x17007308 RID: 29448
		// (get) Token: 0x0601C8BC RID: 116924 RVA: 0x002A347C File Offset: 0x002A167C
		// (set) Token: 0x0601C8BD RID: 116925 RVA: 0x002A34B5 File Offset: 0x002A16B5
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

		// Token: 0x17007309 RID: 29449
		// (get) Token: 0x0601C8BE RID: 116926 RVA: 0x002A34C4 File Offset: 0x002A16C4
		// (set) Token: 0x0601C8BF RID: 116927 RVA: 0x002A34FD File Offset: 0x002A16FD
		public TMap<int, FKSC_AttrBoundLocker> LowerBoundLockerMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKSC_AttrBoundLocker> result;
				if ((result = this._LowerBoundLockerMap) == null)
				{
					result = (this._LowerBoundLockerMap = new TMap<int, FKSC_AttrBoundLocker>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_LowerBoundLockerMap, this));
				}
				return result;
			}
			set
			{
				this.LowerBoundLockerMap.CopyAssign(value);
			}
		}

		// Token: 0x1700730A RID: 29450
		// (get) Token: 0x0601C8C0 RID: 116928 RVA: 0x002A350C File Offset: 0x002A170C
		// (set) Token: 0x0601C8C1 RID: 116929 RVA: 0x002A3545 File Offset: 0x002A1745
		public TMap<int, FKSC_AttrBoundLocker> UpperBoundLockerMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, FKSC_AttrBoundLocker> result;
				if ((result = this._UpperBoundLockerMap) == null)
				{
					result = (this._UpperBoundLockerMap = new TMap<int, FKSC_AttrBoundLocker>(base.NativePtr + (IntPtr)UKSC_AttrSet.__PropertyOffset_UpperBoundLockerMap, this));
				}
				return result;
			}
			set
			{
				this.UpperBoundLockerMap.CopyAssign(value);
			}
		}

		// Token: 0x1700730B RID: 29451
		// (get) Token: 0x0601C8C2 RID: 116930 RVA: 0x002A3554 File Offset: 0x002A1754
		// (set) Token: 0x0601C8C3 RID: 116931 RVA: 0x002A358D File Offset: 0x002A178D
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

		// Token: 0x0601C8C4 RID: 116932 RVA: 0x002A359B File Offset: 0x002A179B
		public void UnlockAttrValue(EKSC_AttrType Id)
		{
			UKSC_AttrSet.__UnlockAttrValue_Internal(base.NativePtr, Id);
		}

		// Token: 0x0601C8C5 RID: 116933 RVA: 0x002A35A9 File Offset: 0x002A17A9
		public void RemoveUpperBoundLocker(EKSC_AttrType Id, int HandleId)
		{
			UKSC_AttrSet.__RemoveUpperBoundLocker_Internal(base.NativePtr, Id, HandleId);
		}

		// Token: 0x0601C8C6 RID: 116934 RVA: 0x002A35B8 File Offset: 0x002A17B8
		public void RemoveLowerBoundLocker(EKSC_AttrType Id, int HandleId)
		{
			UKSC_AttrSet.__RemoveLowerBoundLocker_Internal(base.NativePtr, Id, HandleId);
		}

		// Token: 0x0601C8C7 RID: 116935 RVA: 0x002A35C7 File Offset: 0x002A17C7
		[NullableContext(2)]
		public void RemoveAttrListen(EKSC_AttrType Id, in FOnKSCAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAttrChange fonKSCAttrChange = InDelegate;
			UKSC_AttrSet.__RemoveAttrListen_Internal(nativePtr, Id, (fonKSCAttrChange != null) ? fonKSCAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601C8C8 RID: 116936 RVA: 0x002A35E4 File Offset: 0x002A17E4
		[NullableContext(2)]
		public void RemoveAllAttrListen(in FOnKSCAllAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAllAttrChange fonKSCAllAttrChange = InDelegate;
			UKSC_AttrSet.__RemoveAllAttrListen_Internal(nativePtr, (fonKSCAllAttrChange != null) ? fonKSCAllAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601C8C9 RID: 116937 RVA: 0x002A3600 File Offset: 0x002A1800
		public void LockAttrValue(EKSC_AttrType Id, int Value)
		{
			UKSC_AttrSet.__LockAttrValue_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x0601C8CA RID: 116938 RVA: 0x002A360F File Offset: 0x002A180F
		public bool IsAttrValueLocked(EKSC_AttrType Id)
		{
			return UKSC_AttrSet.__IsAttrValueLocked_Internal(base.NativePtr, Id);
		}

		// Token: 0x0601C8CB RID: 116939 RVA: 0x002A3620 File Offset: 0x002A1820
		public unsafe bool GetLockedAttrValue(EKSC_AttrType Id, ref int Value)
		{
			fixed (int* ptr = &Value)
			{
				void* ptr2 = (void*)ptr;
				return UKSC_AttrSet.__GetLockedAttrValue_Internal(base.NativePtr, Id, ref Value);
			}
		}

		// Token: 0x0601C8CC RID: 116940 RVA: 0x002A363F File Offset: 0x002A183F
		public void ClearAllLockedAttrValues()
		{
			UKSC_AttrSet.__ClearAllLockedAttrValues_Internal(base.NativePtr);
		}

		// Token: 0x0601C8CD RID: 116941 RVA: 0x002A364C File Offset: 0x002A184C
		[NullableContext(2)]
		public void AssignAttrListen(EKSC_AttrType Id, in FOnKSCAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAttrChange fonKSCAttrChange = InDelegate;
			UKSC_AttrSet.__AssignAttrListen_Internal(nativePtr, Id, (fonKSCAttrChange != null) ? fonKSCAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601C8CE RID: 116942 RVA: 0x002A3669 File Offset: 0x002A1869
		[NullableContext(2)]
		public void AssignAllAttrListen(in FOnKSCAllAttrChange InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FOnKSCAllAttrChange fonKSCAllAttrChange = InDelegate;
			UKSC_AttrSet.__AssignAllAttrListen_Internal(nativePtr, (fonKSCAllAttrChange != null) ? fonKSCAllAttrChange.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601C8CF RID: 116943 RVA: 0x002A3685 File Offset: 0x002A1885
		public int AddUpperBoundLocker(EKSC_AttrType Id, int Value)
		{
			return UKSC_AttrSet.__AddUpperBoundLocker_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x0601C8D0 RID: 116944 RVA: 0x002A3694 File Offset: 0x002A1894
		public int AddLowerBoundLocker(EKSC_AttrType Id, int Value)
		{
			return UKSC_AttrSet.__AddLowerBoundLocker_Internal(base.NativePtr, Id, Value);
		}

		// Token: 0x0601C8D1 RID: 116945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnlockAttrValue_Internal(IntPtr @this, EKSC_AttrType Id);

		// Token: 0x0601C8D2 RID: 116946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveUpperBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int HandleId);

		// Token: 0x0601C8D3 RID: 116947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveLowerBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int HandleId);

		// Token: 0x0601C8D4 RID: 116948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAttrListen_Internal(IntPtr @this, EKSC_AttrType Id, IntPtr InDelegate);

		// Token: 0x0601C8D5 RID: 116949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllAttrListen_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601C8D6 RID: 116950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LockAttrValue_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x0601C8D7 RID: 116951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAttrValueLocked_Internal(IntPtr @this, EKSC_AttrType Id);

		// Token: 0x0601C8D8 RID: 116952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLockedAttrValue_Internal(IntPtr @this, EKSC_AttrType Id, ref int Value);

		// Token: 0x0601C8D9 RID: 116953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAllLockedAttrValues_Internal(IntPtr @this);

		// Token: 0x0601C8DA RID: 116954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignAttrListen_Internal(IntPtr @this, EKSC_AttrType Id, IntPtr InDelegate);

		// Token: 0x0601C8DB RID: 116955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AssignAllAttrListen_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0601C8DC RID: 116956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddUpperBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x0601C8DD RID: 116957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AddLowerBoundLocker_Internal(IntPtr @this, EKSC_AttrType Id, int Value);

		// Token: 0x0601C8DE RID: 116958 RVA: 0x002A36A3 File Offset: 0x002A18A3
		static UKSC_AttrSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_AttrSet");
		}

		// Token: 0x0601C8DF RID: 116959 RVA: 0x002A36B1 File Offset: 0x002A18B1
		protected UKSC_AttrSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F792 RID: 63378
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_AttrSet";

		// Token: 0x0400F793 RID: 63379
		private static IntPtr _ClassPtr;

		// Token: 0x0400F794 RID: 63380
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F795 RID: 63381
		internal static int __PropertyOffset_Owner_;

		// Token: 0x0400F796 RID: 63382
		internal static int __PropertyOffset_SourceAttrs_;

		// Token: 0x0400F797 RID: 63383
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _SourceAttrs_;

		// Token: 0x0400F798 RID: 63384
		internal static int __PropertyOffset_Attrs_;

		// Token: 0x0400F799 RID: 63385
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _Attrs_;

		// Token: 0x0400F79A RID: 63386
		internal static int __PropertyOffset_MoveReduceAttrs;

		// Token: 0x0400F79B RID: 63387
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<UObject, int> _MoveReduceAttrs;

		// Token: 0x0400F79C RID: 63388
		internal static int __PropertyOffset_CurMoveReduceObject;

		// Token: 0x0400F79D RID: 63389
		internal static int __PropertyOffset_AttrsLockLowerBound;

		// Token: 0x0400F79E RID: 63390
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttrsLockLowerBound;

		// Token: 0x0400F79F RID: 63391
		internal static int __PropertyOffset_AttrsLockUpperBound;

		// Token: 0x0400F7A0 RID: 63392
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _AttrsLockUpperBound;

		// Token: 0x0400F7A1 RID: 63393
		internal static int __PropertyOffset_LowerBoundLockerMap;

		// Token: 0x0400F7A2 RID: 63394
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKSC_AttrBoundLocker> _LowerBoundLockerMap;

		// Token: 0x0400F7A3 RID: 63395
		internal static int __PropertyOffset_UpperBoundLockerMap;

		// Token: 0x0400F7A4 RID: 63396
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, FKSC_AttrBoundLocker> _UpperBoundLockerMap;

		// Token: 0x0400F7A5 RID: 63397
		internal static int __PropertyOffset_LockedAttrValues_;

		// Token: 0x0400F7A6 RID: 63398
		[Nullable(2)]
		private TMap<EKSC_AttrType, int> _LockedAttrValues_;
	}
}
