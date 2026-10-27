using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000192 RID: 402
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.EnvQueryGenerator")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public abstract class UEnvQueryGenerator : UEnvQueryNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060018EE RID: 6382 RVA: 0x00024C75 File Offset: 0x00022E75
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryGenerator._ClassPtr;
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x060018EF RID: 6383 RVA: 0x00024C81 File Offset: 0x00022E81
		// (set) Token: 0x060018F0 RID: 6384 RVA: 0x00024C95 File Offset: 0x00022E95
		public unsafe string OptionName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UEnvQueryGenerator.__PropertyOffset_OptionName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UEnvQueryGenerator.__PropertyOffset_OptionName)), value);
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00024CAA File Offset: 0x00022EAA
		// (set) Token: 0x060018F2 RID: 6386 RVA: 0x00024CBE File Offset: 0x00022EBE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UEnvQueryItemType> ItemType
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryGenerator.__PropertyOffset_ItemType);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryGenerator.__PropertyOffset_ItemType) = value;
			}
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x00024CD3 File Offset: 0x00022ED3
		// (set) Token: 0x060018F4 RID: 6388 RVA: 0x00024CEC File Offset: 0x00022EEC
		public unsafe bool bAutoSortTests
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UEnvQueryGenerator.__PropertyOffset_bAutoSortTests) & UEnvQueryGenerator.__PropertyMask_bAutoSortTests) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UEnvQueryGenerator.__PropertyOffset_bAutoSortTests) = ((*(base.NativePtr + (IntPtr)UEnvQueryGenerator.__PropertyOffset_bAutoSortTests) & ~UEnvQueryGenerator.__PropertyMask_bAutoSortTests) | (value ? UEnvQueryGenerator.__PropertyMask_bAutoSortTests : 0));
			}
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00024D1C File Offset: 0x00022F1C
		static UEnvQueryGenerator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryGenerator");
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00024D2C File Offset: 0x00022F2C
		protected UEnvQueryGenerator() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryGenerator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00024D54 File Offset: 0x00022F54
		protected UEnvQueryGenerator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000709 RID: 1801
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryGenerator";

		// Token: 0x0400070A RID: 1802
		private static IntPtr _ClassPtr;

		// Token: 0x0400070B RID: 1803
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400070C RID: 1804
		internal static int __PropertyOffset_OptionName;

		// Token: 0x0400070D RID: 1805
		internal static int __PropertyOffset_ItemType;

		// Token: 0x0400070E RID: 1806
		internal static int __PropertyOffset_bAutoSortTests;

		// Token: 0x0400070F RID: 1807
		internal static byte __PropertyMask_bAutoSortTests;
	}
}
