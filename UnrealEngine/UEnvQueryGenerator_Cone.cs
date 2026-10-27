using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000196 RID: 406
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator_Cone")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 408)]
	public class UEnvQueryGenerator_Cone : UEnvQueryGenerator_ProjectedPoints, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001924 RID: 6436 RVA: 0x000251B9 File Offset: 0x000233B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator_Cone._ClassPtr;
		}

		// Token: 0x06001925 RID: 6437 RVA: 0x000251C8 File Offset: 0x000233C8
		public UEnvQueryGenerator_Cone() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Cone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001926 RID: 6438 RVA: 0x000251F0 File Offset: 0x000233F0
		public UEnvQueryGenerator_Cone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator_Cone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x00025224 File Offset: 0x00023424
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0002525D File Offset: 0x0002345D
		public FAIDataProviderFloatValue AlignedPointsDistance
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._AlignedPointsDistance) == null)
				{
					result = (this._AlignedPointsDistance = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_AlignedPointsDistance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_AlignedPointsDistance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x00025280 File Offset: 0x00023480
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x000252B9 File Offset: 0x000234B9
		public FAIDataProviderFloatValue ConeDegrees
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._ConeDegrees) == null)
				{
					result = (this._ConeDegrees = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_ConeDegrees, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_ConeDegrees, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x000252DC File Offset: 0x000234DC
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x00025315 File Offset: 0x00023515
		public FAIDataProviderFloatValue AngleStep
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._AngleStep) == null)
				{
					result = (this._AngleStep = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_AngleStep, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_AngleStep, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x0600192D RID: 6445 RVA: 0x00025338 File Offset: 0x00023538
		// (set) Token: 0x0600192E RID: 6446 RVA: 0x00025371 File Offset: 0x00023571
		public FAIDataProviderFloatValue Range
		{
			get
			{
				base.FastCheckIsValid();
				FAIDataProviderFloatValue result;
				if ((result = this._Range) == null)
				{
					result = (this._Range = new FAIDataProviderFloatValue(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_Range, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAIDataProviderFloatValue.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_Range, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x0600192F RID: 6447 RVA: 0x00025392 File Offset: 0x00023592
		// (set) Token: 0x06001930 RID: 6448 RVA: 0x000253A6 File Offset: 0x000235A6
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryContext> CenterActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_CenterActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_CenterActor) = value;
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001931 RID: 6449 RVA: 0x000253BB File Offset: 0x000235BB
		// (set) Token: 0x06001932 RID: 6450 RVA: 0x000253D4 File Offset: 0x000235D4
		public unsafe bool bIncludeContextLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_bIncludeContextLocation) & UEnvQueryGenerator_Cone.__PropertyMask_bIncludeContextLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_bIncludeContextLocation) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator_Cone.__PropertyOffset_bIncludeContextLocation) & ~UEnvQueryGenerator_Cone.__PropertyMask_bIncludeContextLocation) | (value ? UEnvQueryGenerator_Cone.__PropertyMask_bIncludeContextLocation : 0));
			}
		}

		// Token: 0x06001933 RID: 6451 RVA: 0x00025404 File Offset: 0x00023604
		static UEnvQueryGenerator_Cone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator_Cone");
		}

		// Token: 0x06001934 RID: 6452 RVA: 0x00025412 File Offset: 0x00023612
		protected UEnvQueryGenerator_Cone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400072A RID: 1834
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator_Cone";

		// Token: 0x0400072B RID: 1835
		private static IntPtr _ClassPtr;

		// Token: 0x0400072C RID: 1836
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400072D RID: 1837
		internal static int __PropertyOffset_AlignedPointsDistance;

		// Token: 0x0400072E RID: 1838
		[Nullable(2)]
		private FAIDataProviderFloatValue _AlignedPointsDistance;

		// Token: 0x0400072F RID: 1839
		internal static int __PropertyOffset_ConeDegrees;

		// Token: 0x04000730 RID: 1840
		[Nullable(2)]
		private FAIDataProviderFloatValue _ConeDegrees;

		// Token: 0x04000731 RID: 1841
		internal static int __PropertyOffset_AngleStep;

		// Token: 0x04000732 RID: 1842
		[Nullable(2)]
		private FAIDataProviderFloatValue _AngleStep;

		// Token: 0x04000733 RID: 1843
		internal static int __PropertyOffset_Range;

		// Token: 0x04000734 RID: 1844
		[Nullable(2)]
		private FAIDataProviderFloatValue _Range;

		// Token: 0x04000735 RID: 1845
		internal static int __PropertyOffset_CenterActor;

		// Token: 0x04000736 RID: 1846
		internal static int __PropertyOffset_bIncludeContextLocation;

		// Token: 0x04000737 RID: 1847
		internal static byte __PropertyMask_bIncludeContextLocation;
	}
}
