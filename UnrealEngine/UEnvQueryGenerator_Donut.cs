using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000198 RID: 408
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_Donut")]
	[UnrealStructLayout(512, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 512)]
	public class UEnvQueryGenerator_Donut : UEnvQueryGenerator_ProjectedPoints, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600193C RID: 6460 RVA: 0x000254C3 File Offset: 0x000236C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_Donut._ClassPtr;
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000254D0 File Offset: 0x000236D0
		public UEnvQueryGenerator_Donut() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Donut.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x000254F8 File Offset: 0x000236F8
		public UEnvQueryGenerator_Donut(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Donut.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0002552C File Offset: 0x0002372C
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x00025565 File Offset: 0x00023765
		public FAIDataProviderFloatValue InnerRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._InnerRadius) == null)
				{
					result = (this._InnerRadius = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_InnerRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_InnerRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x00025588 File Offset: 0x00023788
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x000255C1 File Offset: 0x000237C1
		public FAIDataProviderFloatValue OuterRadius
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._OuterRadius) == null)
				{
					result = (this._OuterRadius = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_OuterRadius, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_OuterRadius, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x06001943 RID: 6467 RVA: 0x000255E4 File Offset: 0x000237E4
		// (set) Token: 0x06001944 RID: 6468 RVA: 0x0002561D File Offset: 0x0002381D
		public FAIDataProviderIntValue NumberOfRings
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderIntValue result;
				if ((result = this._NumberOfRings) == null)
				{
					result = (this._NumberOfRings = new FAIDataProviderIntValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_NumberOfRings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderIntValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_NumberOfRings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x06001945 RID: 6469 RVA: 0x00025640 File Offset: 0x00023840
		// (set) Token: 0x06001946 RID: 6470 RVA: 0x00025679 File Offset: 0x00023879
		public FAIDataProviderIntValue PointsPerRing
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderIntValue result;
				if ((result = this._PointsPerRing) == null)
				{
					result = (this._PointsPerRing = new FAIDataProviderIntValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_PointsPerRing, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderIntValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_PointsPerRing, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x06001947 RID: 6471 RVA: 0x0002569C File Offset: 0x0002389C
		// (set) Token: 0x06001948 RID: 6472 RVA: 0x000256D5 File Offset: 0x000238D5
		public FEnvDirection ArcDirection
		{
			get
			{
				base.FastCheckIsValid();
				FEnvDirection result;
				if ((result = this._ArcDirection) == null)
				{
					result = (this._ArcDirection = new FEnvDirection(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_ArcDirection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvDirection.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_ArcDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x06001949 RID: 6473 RVA: 0x000256F8 File Offset: 0x000238F8
		// (set) Token: 0x0600194A RID: 6474 RVA: 0x00025731 File Offset: 0x00023931
		public FAIDataProviderFloatValue ArcAngle
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ArcAngle) == null)
				{
					result = (this._ArcAngle = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_ArcAngle, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_ArcAngle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600194B RID: 6475 RVA: 0x00025752 File Offset: 0x00023952
		// (set) Token: 0x0600194C RID: 6476 RVA: 0x00025762 File Offset: 0x00023962
		public unsafe bool bUseSpiralPattern
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_bUseSpiralPattern) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_bUseSpiralPattern) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600194D RID: 6477 RVA: 0x00025773 File Offset: 0x00023973
		// (set) Token: 0x0600194E RID: 6478 RVA: 0x00025787 File Offset: 0x00023987
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> Center
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_Center);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_Center) = value;
			}
		}

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x0600194F RID: 6479 RVA: 0x0002579C File Offset: 0x0002399C
		// (set) Token: 0x06001950 RID: 6480 RVA: 0x000257B5 File Offset: 0x000239B5
		public unsafe bool bDefineArc
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_bDefineArc) & UEnvQueryGenerator_Donut.__PropertyMask_bDefineArc) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_bDefineArc) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Donut.__PropertyOffset_bDefineArc) & ~UEnvQueryGenerator_Donut.__PropertyMask_bDefineArc) | (value ? UEnvQueryGenerator_Donut.__PropertyMask_bDefineArc : 0));
			}
		}

		// Token: 0x06001951 RID: 6481 RVA: 0x000257E5 File Offset: 0x000239E5
		static UEnvQueryGenerator_Donut()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_Donut");
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x000257F3 File Offset: 0x000239F3
		protected UEnvQueryGenerator_Donut(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400073C RID: 1852
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_Donut";

		// Token: 0x0400073D RID: 1853
		private static IntPtr _ClassPtr;

		// Token: 0x0400073E RID: 1854
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400073F RID: 1855
		internal static int __PropertyOffset_InnerRadius;

		// Token: 0x04000740 RID: 1856
		[Nullable(2)]
		private FAIDataProviderFloatValue _InnerRadius;

		// Token: 0x04000741 RID: 1857
		internal static int __PropertyOffset_OuterRadius;

		// Token: 0x04000742 RID: 1858
		[Nullable(2)]
		private FAIDataProviderFloatValue _OuterRadius;

		// Token: 0x04000743 RID: 1859
		internal static int __PropertyOffset_NumberOfRings;

		// Token: 0x04000744 RID: 1860
		[Nullable(2)]
		private FAIDataProviderIntValue _NumberOfRings;

		// Token: 0x04000745 RID: 1861
		internal static int __PropertyOffset_PointsPerRing;

		// Token: 0x04000746 RID: 1862
		[Nullable(2)]
		private FAIDataProviderIntValue _PointsPerRing;

		// Token: 0x04000747 RID: 1863
		internal static int __PropertyOffset_ArcDirection;

		// Token: 0x04000748 RID: 1864
		[Nullable(2)]
		private FEnvDirection _ArcDirection;

		// Token: 0x04000749 RID: 1865
		internal static int __PropertyOffset_ArcAngle;

		// Token: 0x0400074A RID: 1866
		[Nullable(2)]
		private FAIDataProviderFloatValue _ArcAngle;

		// Token: 0x0400074B RID: 1867
		internal static int __PropertyOffset_bUseSpiralPattern;

		// Token: 0x0400074C RID: 1868
		internal static int __PropertyOffset_Center;

		// Token: 0x0400074D RID: 1869
		internal static int __PropertyOffset_bDefineArc;

		// Token: 0x0400074E RID: 1870
		internal static byte __PropertyMask_bDefineArc;
	}
}
