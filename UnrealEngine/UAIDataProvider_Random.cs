using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EC RID: 236
	[UnrealObjectPath("/Script/AIModule.AIDataProvider_Random")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UAIDataProvider_Random : UAIDataProvider_QueryParams, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060012AA RID: 4778 RVA: 0x0001BA5E File Offset: 0x00019C5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIDataProvider_Random._ClassPtr;
		}

		// Token: 0x060012AB RID: 4779 RVA: 0x0001BA6C File Offset: 0x00019C6C
		public UAIDataProvider_Random() : this(BuiltinUtils.AllocNativeUObject(UAIDataProvider_Random.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060012AC RID: 4780 RVA: 0x0001BA94 File Offset: 0x00019C94
		[NullableContext(1)]
		public UAIDataProvider_Random(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIDataProvider_Random.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x060012AD RID: 4781 RVA: 0x0001BAC7 File Offset: 0x00019CC7
		// (set) Token: 0x060012AE RID: 4782 RVA: 0x0001BAD7 File Offset: 0x00019CD7
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x060012AF RID: 4783 RVA: 0x0001BAE8 File Offset: 0x00019CE8
		// (set) Token: 0x060012B0 RID: 4784 RVA: 0x0001BAF8 File Offset: 0x00019CF8
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x0001BB09 File Offset: 0x00019D09
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x0001BB22 File Offset: 0x00019D22
		public unsafe bool bInteger
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_bInteger) & UAIDataProvider_Random.__PropertyMask_bInteger) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_bInteger) = ((*(base.NativePtr + (IntPtr)UAIDataProvider_Random.__PropertyOffset_bInteger) & ~UAIDataProvider_Random.__PropertyMask_bInteger) | (value ? UAIDataProvider_Random.__PropertyMask_bInteger : 0));
			}
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x0001BB52 File Offset: 0x00019D52
		static UAIDataProvider_Random()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIDataProvider_Random");
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x0001BB60 File Offset: 0x00019D60
		protected UAIDataProvider_Random(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400033C RID: 828
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProvider_Random";

		// Token: 0x0400033D RID: 829
		private static IntPtr _ClassPtr;

		// Token: 0x0400033E RID: 830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400033F RID: 831
		internal static int __PropertyOffset_Min;

		// Token: 0x04000340 RID: 832
		internal static int __PropertyOffset_Max;

		// Token: 0x04000341 RID: 833
		internal static int __PropertyOffset_bInteger;

		// Token: 0x04000342 RID: 834
		internal static byte __PropertyMask_bInteger;
	}
}
