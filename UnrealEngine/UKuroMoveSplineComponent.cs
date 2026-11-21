using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005AD RID: 1453
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSplines.KuroMoveSplineComponent")]
	[UnrealStructLayout(1952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class UKuroMoveSplineComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060082AF RID: 33455 RVA: 0x000C1421 File Offset: 0x000BF621
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMoveSplineComponent._ClassPtr;
		}

		// Token: 0x060082B0 RID: 33456 RVA: 0x000C1430 File Offset: 0x000BF630
		public UKuroMoveSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMoveSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060082B1 RID: 33457 RVA: 0x000C1458 File Offset: 0x000BF658
		public UKuroMoveSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMoveSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x000C148C File Offset: 0x000BF68C
		// (set) Token: 0x060082B3 RID: 33459 RVA: 0x000C14C5 File Offset: 0x000BF6C5
		public TArray<int> MoveStates
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MoveStates) == null)
				{
					result = (this._MoveStates = new TArray<int>(base.NativePtr + (IntPtr)UKuroMoveSplineComponent.__PropertyOffset_MoveStates, this));
				}
				return result;
			}
			set
			{
				this.MoveStates.CopyAssign(value);
			}
		}

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060082B4 RID: 33460 RVA: 0x000C14D4 File Offset: 0x000BF6D4
		// (set) Token: 0x060082B5 RID: 33461 RVA: 0x000C150D File Offset: 0x000BF70D
		public TArray<int> MoveSpeeds
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._MoveSpeeds) == null)
				{
					result = (this._MoveSpeeds = new TArray<int>(base.NativePtr + (IntPtr)UKuroMoveSplineComponent.__PropertyOffset_MoveSpeeds, this));
				}
				return result;
			}
			set
			{
				this.MoveSpeeds.CopyAssign(value);
			}
		}

		// Token: 0x1700194E RID: 6478
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x000C151C File Offset: 0x000BF71C
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x000C1555 File Offset: 0x000BF755
		public TArray<int> IgnorePoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IgnorePoints) == null)
				{
					result = (this._IgnorePoints = new TArray<int>(base.NativePtr + (IntPtr)UKuroMoveSplineComponent.__PropertyOffset_IgnorePoints, this));
				}
				return result;
			}
			set
			{
				this.IgnorePoints.CopyAssign(value);
			}
		}

		// Token: 0x1700194F RID: 6479
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x000C1564 File Offset: 0x000BF764
		// (set) Token: 0x060082B9 RID: 33465 RVA: 0x000C159D File Offset: 0x000BF79D
		public TArray<int> StayTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._StayTimes) == null)
				{
					result = (this._StayTimes = new TArray<int>(base.NativePtr + (IntPtr)UKuroMoveSplineComponent.__PropertyOffset_StayTimes, this));
				}
				return result;
			}
			set
			{
				this.StayTimes.CopyAssign(value);
			}
		}

		// Token: 0x17001950 RID: 6480
		// (get) Token: 0x060082BA RID: 33466 RVA: 0x000C15AC File Offset: 0x000BF7AC
		// (set) Token: 0x060082BB RID: 33467 RVA: 0x000C15E5 File Offset: 0x000BF7E5
		public TArray<int> IsHides
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._IsHides) == null)
				{
					result = (this._IsHides = new TArray<int>(base.NativePtr + (IntPtr)UKuroMoveSplineComponent.__PropertyOffset_IsHides, this));
				}
				return result;
			}
			set
			{
				this.IsHides.CopyAssign(value);
			}
		}

		// Token: 0x060082BC RID: 33468 RVA: 0x000C15F3 File Offset: 0x000BF7F3
		public int GetStayTime(int Index)
		{
			return UKuroMoveSplineComponent.__GetStayTime_Internal(base.NativePtr, Index);
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x000C1601 File Offset: 0x000BF801
		public int GetMoveState(int Index)
		{
			return UKuroMoveSplineComponent.__GetMoveState_Internal(base.NativePtr, Index);
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x000C160F File Offset: 0x000BF80F
		public int GetMoveSpeed(int Index)
		{
			return UKuroMoveSplineComponent.__GetMoveSpeed_Internal(base.NativePtr, Index);
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x000C161D File Offset: 0x000BF81D
		public int GetIsHide(int Index)
		{
			return UKuroMoveSplineComponent.__GetIsHide_Internal(base.NativePtr, Index);
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x000C162B File Offset: 0x000BF82B
		public int GetIgnorePoint(int Index)
		{
			return UKuroMoveSplineComponent.__GetIgnorePoint_Internal(base.NativePtr, Index);
		}

		// Token: 0x060082C1 RID: 33473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStayTime_Internal(IntPtr @this, int Index);

		// Token: 0x060082C2 RID: 33474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMoveState_Internal(IntPtr @this, int Index);

		// Token: 0x060082C3 RID: 33475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMoveSpeed_Internal(IntPtr @this, int Index);

		// Token: 0x060082C4 RID: 33476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIsHide_Internal(IntPtr @this, int Index);

		// Token: 0x060082C5 RID: 33477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIgnorePoint_Internal(IntPtr @this, int Index);

		// Token: 0x060082C6 RID: 33478 RVA: 0x000C1639 File Offset: 0x000BF839
		static UKuroMoveSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSplines.KuroMoveSplineComponent");
		}

		// Token: 0x060082C7 RID: 33479 RVA: 0x000C1647 File Offset: 0x000BF847
		protected UKuroMoveSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040038E6 RID: 14566
		public new const string __ObjectPath = "/Script/KuroSplines.KuroMoveSplineComponent";

		// Token: 0x040038E7 RID: 14567
		private static IntPtr _ClassPtr;

		// Token: 0x040038E8 RID: 14568
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040038E9 RID: 14569
		internal static int __PropertyOffset_MoveStates;

		// Token: 0x040038EA RID: 14570
		[Nullable(2)]
		private TArray<int> _MoveStates;

		// Token: 0x040038EB RID: 14571
		internal static int __PropertyOffset_MoveSpeeds;

		// Token: 0x040038EC RID: 14572
		[Nullable(2)]
		private TArray<int> _MoveSpeeds;

		// Token: 0x040038ED RID: 14573
		internal static int __PropertyOffset_IgnorePoints;

		// Token: 0x040038EE RID: 14574
		[Nullable(2)]
		private TArray<int> _IgnorePoints;

		// Token: 0x040038EF RID: 14575
		internal static int __PropertyOffset_StayTimes;

		// Token: 0x040038F0 RID: 14576
		[Nullable(2)]
		private TArray<int> _StayTimes;

		// Token: 0x040038F1 RID: 14577
		internal static int __PropertyOffset_IsHides;

		// Token: 0x040038F2 RID: 14578
		[Nullable(2)]
		private TArray<int> _IsHides;
	}
}
