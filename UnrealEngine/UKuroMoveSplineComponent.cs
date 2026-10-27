using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001E7C RID: 7804
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSplines.KuroMoveSplineComponent")]
	[UnrealStructLayout(1952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class UKuroMoveSplineComponent : USplineComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DB45 RID: 121669 RVA: 0x002BE145 File Offset: 0x002BC345
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMoveSplineComponent._ClassPtr;
		}

		// Token: 0x0601DB46 RID: 121670 RVA: 0x002BE154 File Offset: 0x002BC354
		public UKuroMoveSplineComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroMoveSplineComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DB47 RID: 121671 RVA: 0x002BE17C File Offset: 0x002BC37C
		public UKuroMoveSplineComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMoveSplineComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007770 RID: 30576
		// (get) Token: 0x0601DB48 RID: 121672 RVA: 0x002BE1B0 File Offset: 0x002BC3B0
		// (set) Token: 0x0601DB49 RID: 121673 RVA: 0x002BE1E9 File Offset: 0x002BC3E9
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

		// Token: 0x17007771 RID: 30577
		// (get) Token: 0x0601DB4A RID: 121674 RVA: 0x002BE1F8 File Offset: 0x002BC3F8
		// (set) Token: 0x0601DB4B RID: 121675 RVA: 0x002BE231 File Offset: 0x002BC431
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

		// Token: 0x17007772 RID: 30578
		// (get) Token: 0x0601DB4C RID: 121676 RVA: 0x002BE240 File Offset: 0x002BC440
		// (set) Token: 0x0601DB4D RID: 121677 RVA: 0x002BE279 File Offset: 0x002BC479
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

		// Token: 0x17007773 RID: 30579
		// (get) Token: 0x0601DB4E RID: 121678 RVA: 0x002BE288 File Offset: 0x002BC488
		// (set) Token: 0x0601DB4F RID: 121679 RVA: 0x002BE2C1 File Offset: 0x002BC4C1
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

		// Token: 0x17007774 RID: 30580
		// (get) Token: 0x0601DB50 RID: 121680 RVA: 0x002BE2D0 File Offset: 0x002BC4D0
		// (set) Token: 0x0601DB51 RID: 121681 RVA: 0x002BE309 File Offset: 0x002BC509
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

		// Token: 0x0601DB52 RID: 121682 RVA: 0x002BE317 File Offset: 0x002BC517
		public int GetStayTime(int Index)
		{
			return UKuroMoveSplineComponent.__GetStayTime_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB53 RID: 121683 RVA: 0x002BE325 File Offset: 0x002BC525
		public int GetMoveState(int Index)
		{
			return UKuroMoveSplineComponent.__GetMoveState_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB54 RID: 121684 RVA: 0x002BE333 File Offset: 0x002BC533
		public int GetMoveSpeed(int Index)
		{
			return UKuroMoveSplineComponent.__GetMoveSpeed_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB55 RID: 121685 RVA: 0x002BE341 File Offset: 0x002BC541
		public int GetIsHide(int Index)
		{
			return UKuroMoveSplineComponent.__GetIsHide_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB56 RID: 121686 RVA: 0x002BE34F File Offset: 0x002BC54F
		public int GetIgnorePoint(int Index)
		{
			return UKuroMoveSplineComponent.__GetIgnorePoint_Internal(base.NativePtr, Index);
		}

		// Token: 0x0601DB57 RID: 121687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStayTime_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB58 RID: 121688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMoveState_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB59 RID: 121689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMoveSpeed_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB5A RID: 121690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIsHide_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB5B RID: 121691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIgnorePoint_Internal(IntPtr @this, int Index);

		// Token: 0x0601DB5C RID: 121692 RVA: 0x002BE35D File Offset: 0x002BC55D
		static UKuroMoveSplineComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSplines.KuroMoveSplineComponent");
		}

		// Token: 0x0601DB5D RID: 121693 RVA: 0x002BE36B File Offset: 0x002BC56B
		protected UKuroMoveSplineComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401015A RID: 65882
		public new const string __ObjectPath = "/Script/KuroSplines.KuroMoveSplineComponent";

		// Token: 0x0401015B RID: 65883
		private static IntPtr _ClassPtr;

		// Token: 0x0401015C RID: 65884
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401015D RID: 65885
		internal static int __PropertyOffset_MoveStates;

		// Token: 0x0401015E RID: 65886
		[Nullable(2)]
		private TArray<int> _MoveStates;

		// Token: 0x0401015F RID: 65887
		internal static int __PropertyOffset_MoveSpeeds;

		// Token: 0x04010160 RID: 65888
		[Nullable(2)]
		private TArray<int> _MoveSpeeds;

		// Token: 0x04010161 RID: 65889
		internal static int __PropertyOffset_IgnorePoints;

		// Token: 0x04010162 RID: 65890
		[Nullable(2)]
		private TArray<int> _IgnorePoints;

		// Token: 0x04010163 RID: 65891
		internal static int __PropertyOffset_StayTimes;

		// Token: 0x04010164 RID: 65892
		[Nullable(2)]
		private TArray<int> _StayTimes;

		// Token: 0x04010165 RID: 65893
		internal static int __PropertyOffset_IsHides;

		// Token: 0x04010166 RID: 65894
		[Nullable(2)]
		private TArray<int> _IsHides;
	}
}
