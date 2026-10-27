using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001D9 RID: 473
	[UnrealObjectPath("/Script/AIModule.PawnAction_Move")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UPawnAction_Move : UPawnAction, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001BE9 RID: 7145 RVA: 0x000298FD File Offset: 0x00027AFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPawnAction_Move._ClassPtr;
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x0002990C File Offset: 0x00027B0C
		public UPawnAction_Move() : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Move.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x00029934 File Offset: 0x00027B34
		[NullableContext(1)]
		public UPawnAction_Move(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPawnAction_Move.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001BEC RID: 7148 RVA: 0x00029967 File Offset: 0x00027B67
		// (set) Token: 0x06001BED RID: 7149 RVA: 0x0002997B File Offset: 0x00027B7B
		[Nullable(2)]
		public unsafe AActor GoalActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Move.__PropertyOffset_GoalActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UPawnAction_Move.__PropertyOffset_GoalActor, value);
			}
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x06001BEE RID: 7150 RVA: 0x00029990 File Offset: 0x00027B90
		// (set) Token: 0x06001BEF RID: 7151 RVA: 0x000299A4 File Offset: 0x00027BA4
		public unsafe FVector GoalLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_GoalLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_GoalLocation) = value;
			}
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x06001BF0 RID: 7152 RVA: 0x000299B9 File Offset: 0x00027BB9
		// (set) Token: 0x06001BF1 RID: 7153 RVA: 0x000299C9 File Offset: 0x00027BC9
		public unsafe float AcceptableRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_AcceptableRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_AcceptableRadius) = value;
			}
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x000299DA File Offset: 0x00027BDA
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x000299EE File Offset: 0x00027BEE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> FilterClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_FilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_FilterClass) = value;
			}
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00029A03 File Offset: 0x00027C03
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00029A1C File Offset: 0x00027C1C
		public unsafe bool bAllowStrafe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowStrafe) & UPawnAction_Move.__PropertyMask_bAllowStrafe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowStrafe) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowStrafe) & ~UPawnAction_Move.__PropertyMask_bAllowStrafe) | (value ? UPawnAction_Move.__PropertyMask_bAllowStrafe : 0));
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00029A4C File Offset: 0x00027C4C
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x00029A65 File Offset: 0x00027C65
		public unsafe bool bFinishOnOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bFinishOnOverlap) & UPawnAction_Move.__PropertyMask_bFinishOnOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bFinishOnOverlap) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bFinishOnOverlap) & ~UPawnAction_Move.__PropertyMask_bFinishOnOverlap) | (value ? UPawnAction_Move.__PropertyMask_bFinishOnOverlap : 0));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001BF8 RID: 7160 RVA: 0x00029A95 File Offset: 0x00027C95
		// (set) Token: 0x06001BF9 RID: 7161 RVA: 0x00029AAE File Offset: 0x00027CAE
		public unsafe bool bUsePathfinding
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUsePathfinding) & UPawnAction_Move.__PropertyMask_bUsePathfinding) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUsePathfinding) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUsePathfinding) & ~UPawnAction_Move.__PropertyMask_bUsePathfinding) | (value ? UPawnAction_Move.__PropertyMask_bUsePathfinding : 0));
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001BFA RID: 7162 RVA: 0x00029ADE File Offset: 0x00027CDE
		// (set) Token: 0x06001BFB RID: 7163 RVA: 0x00029AF7 File Offset: 0x00027CF7
		public unsafe bool bAllowPartialPath
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowPartialPath) & UPawnAction_Move.__PropertyMask_bAllowPartialPath) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowPartialPath) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAllowPartialPath) & ~UPawnAction_Move.__PropertyMask_bAllowPartialPath) | (value ? UPawnAction_Move.__PropertyMask_bAllowPartialPath : 0));
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00029B27 File Offset: 0x00027D27
		// (set) Token: 0x06001BFD RID: 7165 RVA: 0x00029B40 File Offset: 0x00027D40
		public unsafe bool bProjectGoalToNavigation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bProjectGoalToNavigation) & UPawnAction_Move.__PropertyMask_bProjectGoalToNavigation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bProjectGoalToNavigation) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bProjectGoalToNavigation) & ~UPawnAction_Move.__PropertyMask_bProjectGoalToNavigation) | (value ? UPawnAction_Move.__PropertyMask_bProjectGoalToNavigation : 0));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00029B70 File Offset: 0x00027D70
		// (set) Token: 0x06001BFF RID: 7167 RVA: 0x00029B89 File Offset: 0x00027D89
		public unsafe bool bUpdatePathToGoal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUpdatePathToGoal) & UPawnAction_Move.__PropertyMask_bUpdatePathToGoal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUpdatePathToGoal) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bUpdatePathToGoal) & ~UPawnAction_Move.__PropertyMask_bUpdatePathToGoal) | (value ? UPawnAction_Move.__PropertyMask_bUpdatePathToGoal : 0));
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00029BB9 File Offset: 0x00027DB9
		// (set) Token: 0x06001C01 RID: 7169 RVA: 0x00029BD2 File Offset: 0x00027DD2
		public unsafe bool bAbortChildActionOnPathChange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAbortChildActionOnPathChange) & UPawnAction_Move.__PropertyMask_bAbortChildActionOnPathChange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAbortChildActionOnPathChange) = ((*(base.NativePtr + (IntPtr)UPawnAction_Move.__PropertyOffset_bAbortChildActionOnPathChange) & ~UPawnAction_Move.__PropertyMask_bAbortChildActionOnPathChange) | (value ? UPawnAction_Move.__PropertyMask_bAbortChildActionOnPathChange : 0));
			}
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00029C02 File Offset: 0x00027E02
		static UPawnAction_Move()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.PawnAction_Move");
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00029C10 File Offset: 0x00027E10
		protected UPawnAction_Move(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040008FA RID: 2298
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.PawnAction_Move";

		// Token: 0x040008FB RID: 2299
		private static IntPtr _ClassPtr;

		// Token: 0x040008FC RID: 2300
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040008FD RID: 2301
		internal static int __PropertyOffset_GoalActor;

		// Token: 0x040008FE RID: 2302
		internal static int __PropertyOffset_GoalLocation;

		// Token: 0x040008FF RID: 2303
		internal static int __PropertyOffset_AcceptableRadius;

		// Token: 0x04000900 RID: 2304
		internal static int __PropertyOffset_FilterClass;

		// Token: 0x04000901 RID: 2305
		internal static int __PropertyOffset_bAllowStrafe;

		// Token: 0x04000902 RID: 2306
		internal static byte __PropertyMask_bAllowStrafe;

		// Token: 0x04000903 RID: 2307
		internal static int __PropertyOffset_bFinishOnOverlap;

		// Token: 0x04000904 RID: 2308
		internal static byte __PropertyMask_bFinishOnOverlap;

		// Token: 0x04000905 RID: 2309
		internal static int __PropertyOffset_bUsePathfinding;

		// Token: 0x04000906 RID: 2310
		internal static byte __PropertyMask_bUsePathfinding;

		// Token: 0x04000907 RID: 2311
		internal static int __PropertyOffset_bAllowPartialPath;

		// Token: 0x04000908 RID: 2312
		internal static byte __PropertyMask_bAllowPartialPath;

		// Token: 0x04000909 RID: 2313
		internal static int __PropertyOffset_bProjectGoalToNavigation;

		// Token: 0x0400090A RID: 2314
		internal static byte __PropertyMask_bProjectGoalToNavigation;

		// Token: 0x0400090B RID: 2315
		internal static int __PropertyOffset_bUpdatePathToGoal;

		// Token: 0x0400090C RID: 2316
		internal static byte __PropertyMask_bUpdatePathToGoal;

		// Token: 0x0400090D RID: 2317
		internal static int __PropertyOffset_bAbortChildActionOnPathChange;

		// Token: 0x0400090E RID: 2318
		internal static byte __PropertyMask_bAbortChildActionOnPathChange;
	}
}
