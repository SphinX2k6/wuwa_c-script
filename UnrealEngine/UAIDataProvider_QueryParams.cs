using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000EB RID: 235
	[UnrealObjectPath("/Script/AIModule.AIDataProvider_QueryParams")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UAIDataProvider_QueryParams : UAIDataProvider, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600129D RID: 4765 RVA: 0x0001B953 File Offset: 0x00019B53
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAIDataProvider_QueryParams._ClassPtr;
		}

		// Token: 0x0600129E RID: 4766 RVA: 0x0001B960 File Offset: 0x00019B60
		public UAIDataProvider_QueryParams() : this(BuiltinUtils.AllocNativeUObject(UAIDataProvider_QueryParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600129F RID: 4767 RVA: 0x0001B988 File Offset: 0x00019B88
		[NullableContext(1)]
		public UAIDataProvider_QueryParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAIDataProvider_QueryParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x060012A0 RID: 4768 RVA: 0x0001B9BB File Offset: 0x00019BBB
		// (set) Token: 0x060012A1 RID: 4769 RVA: 0x0001B9CF File Offset: 0x00019BCF
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x060012A2 RID: 4770 RVA: 0x0001B9E4 File Offset: 0x00019BE4
		// (set) Token: 0x060012A3 RID: 4771 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		public unsafe float FloatValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_FloatValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_FloatValue) = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x060012A4 RID: 4772 RVA: 0x0001BA05 File Offset: 0x00019C05
		// (set) Token: 0x060012A5 RID: 4773 RVA: 0x0001BA15 File Offset: 0x00019C15
		public unsafe int IntValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_IntValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_IntValue) = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x060012A6 RID: 4774 RVA: 0x0001BA26 File Offset: 0x00019C26
		// (set) Token: 0x060012A7 RID: 4775 RVA: 0x0001BA36 File Offset: 0x00019C36
		public unsafe bool BoolValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_BoolValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAIDataProvider_QueryParams.__PropertyOffset_BoolValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x060012A8 RID: 4776 RVA: 0x0001BA47 File Offset: 0x00019C47
		static UAIDataProvider_QueryParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AIDataProvider_QueryParams");
		}

		// Token: 0x060012A9 RID: 4777 RVA: 0x0001BA55 File Offset: 0x00019C55
		protected UAIDataProvider_QueryParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000335 RID: 821
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AIDataProvider_QueryParams";

		// Token: 0x04000336 RID: 822
		private static IntPtr _ClassPtr;

		// Token: 0x04000337 RID: 823
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000338 RID: 824
		internal static int __PropertyOffset_ParamName;

		// Token: 0x04000339 RID: 825
		internal static int __PropertyOffset_FloatValue;

		// Token: 0x0400033A RID: 826
		internal static int __PropertyOffset_IntValue;

		// Token: 0x0400033B RID: 827
		internal static int __PropertyOffset_BoolValue;
	}
}
