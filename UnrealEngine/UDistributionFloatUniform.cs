using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009CC RID: 2508
	[UnrealObjectPath("/Script/Engine.DistributionFloatUniform")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UDistributionFloatUniform : UDistributionFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DEE RID: 36334 RVA: 0x000CADFE File Offset: 0x000C8FFE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatUniform._ClassPtr;
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x000CAE0C File Offset: 0x000C900C
		public UDistributionFloatUniform() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatUniform.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x000CAE34 File Offset: 0x000C9034
		[NullableContext(1)]
		public UDistributionFloatUniform(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatUniform.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700216C RID: 8556
		// (get) Token: 0x06008DF1 RID: 36337 RVA: 0x000CAE67 File Offset: 0x000C9067
		// (set) Token: 0x06008DF2 RID: 36338 RVA: 0x000CAE77 File Offset: 0x000C9077
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatUniform.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatUniform.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x1700216D RID: 8557
		// (get) Token: 0x06008DF3 RID: 36339 RVA: 0x000CAE88 File Offset: 0x000C9088
		// (set) Token: 0x06008DF4 RID: 36340 RVA: 0x000CAE98 File Offset: 0x000C9098
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatUniform.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatUniform.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x06008DF5 RID: 36341 RVA: 0x000CAEA9 File Offset: 0x000C90A9
		static UDistributionFloatUniform()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatUniform");
		}

		// Token: 0x06008DF6 RID: 36342 RVA: 0x000CAEB7 File Offset: 0x000C90B7
		protected UDistributionFloatUniform(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004364 RID: 17252
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatUniform";

		// Token: 0x04004365 RID: 17253
		private static IntPtr _ClassPtr;

		// Token: 0x04004366 RID: 17254
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004367 RID: 17255
		internal static int __PropertyOffset_Min;

		// Token: 0x04004368 RID: 17256
		internal static int __PropertyOffset_Max;
	}
}
