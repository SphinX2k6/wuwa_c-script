using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001AC RID: 428
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryTest_Dot")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class UEnvQueryTest_Dot : UEnvQueryTest, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A3E RID: 6718 RVA: 0x00026F08 File Offset: 0x00025108
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryTest_Dot._ClassPtr;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x00026F14 File Offset: 0x00025114
		public UEnvQueryTest_Dot() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Dot.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A40 RID: 6720 RVA: 0x00026F3C File Offset: 0x0002513C
		public UEnvQueryTest_Dot(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEnvQueryTest_Dot.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001A41 RID: 6721 RVA: 0x00026F70 File Offset: 0x00025170
		// (set) Token: 0x06001A42 RID: 6722 RVA: 0x00026FA9 File Offset: 0x000251A9
		public FEnvDirection LineA
		{
			get
			{
				base.FastCheckIsValid();
				FEnvDirection result;
				if ((result = this._LineA) == null)
				{
					result = (this._LineA = new FEnvDirection(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_LineA, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvDirection.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_LineA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001A43 RID: 6723 RVA: 0x00026FCC File Offset: 0x000251CC
		// (set) Token: 0x06001A44 RID: 6724 RVA: 0x00027005 File Offset: 0x00025205
		public FEnvDirection LineB
		{
			get
			{
				base.FastCheckIsValid();
				FEnvDirection result;
				if ((result = this._LineB) == null)
				{
					result = (this._LineB = new FEnvDirection(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_LineB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FEnvDirection.StaticStruct(), base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_LineB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001A45 RID: 6725 RVA: 0x00027026 File Offset: 0x00025226
		// (set) Token: 0x06001A46 RID: 6726 RVA: 0x00027036 File Offset: 0x00025236
		public unsafe EEnvTestDot TestMode
		{
			get
			{
				return (EEnvTestDot)(*(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_TestMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_TestMode) = (byte)value;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001A47 RID: 6727 RVA: 0x00027047 File Offset: 0x00025247
		// (set) Token: 0x06001A48 RID: 6728 RVA: 0x00027057 File Offset: 0x00025257
		public unsafe bool bAbsoluteValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_bAbsoluteValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryTest_Dot.__PropertyOffset_bAbsoluteValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x00027068 File Offset: 0x00025268
		static UEnvQueryTest_Dot()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryTest_Dot");
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x00027076 File Offset: 0x00025276
		protected UEnvQueryTest_Dot(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007DE RID: 2014
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryTest_Dot";

		// Token: 0x040007DF RID: 2015
		private static IntPtr _ClassPtr;

		// Token: 0x040007E0 RID: 2016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007E1 RID: 2017
		internal static int __PropertyOffset_LineA;

		// Token: 0x040007E2 RID: 2018
		[Nullable(2)]
		private FEnvDirection _LineA;

		// Token: 0x040007E3 RID: 2019
		internal static int __PropertyOffset_LineB;

		// Token: 0x040007E4 RID: 2020
		[Nullable(2)]
		private FEnvDirection _LineB;

		// Token: 0x040007E5 RID: 2021
		internal static int __PropertyOffset_TestMode;

		// Token: 0x040007E6 RID: 2022
		internal static int __PropertyOffset_bAbsoluteValue;
	}
}
