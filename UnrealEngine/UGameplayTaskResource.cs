using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020013F2 RID: 5106
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTaskResource")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public abstract class UGameplayTaskResource : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012A5D RID: 76381 RVA: 0x001B6F45 File Offset: 0x001B5145
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameplayTaskResource._ClassPtr;
		}

		// Token: 0x17004844 RID: 18500
		// (get) Token: 0x06012A5E RID: 76382 RVA: 0x001B6F51 File Offset: 0x001B5151
		// (set) Token: 0x06012A5F RID: 76383 RVA: 0x001B6F61 File Offset: 0x001B5161
		public unsafe int ManualResourceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_ManualResourceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_ManualResourceID) = value;
			}
		}

		// Token: 0x17004845 RID: 18501
		// (get) Token: 0x06012A60 RID: 76384 RVA: 0x001B6F72 File Offset: 0x001B5172
		// (set) Token: 0x06012A61 RID: 76385 RVA: 0x001B6F82 File Offset: 0x001B5182
		public unsafe sbyte AutoResourceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_AutoResourceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_AutoResourceID) = (byte)value;
			}
		}

		// Token: 0x17004846 RID: 18502
		// (get) Token: 0x06012A62 RID: 76386 RVA: 0x001B6F93 File Offset: 0x001B5193
		// (set) Token: 0x06012A63 RID: 76387 RVA: 0x001B6FAC File Offset: 0x001B51AC
		public unsafe bool bManuallySetID
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_bManuallySetID) & UGameplayTaskResource.__PropertyMask_bManuallySetID) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_bManuallySetID) = ((*(base.NativePtr + (IntPtr)UGameplayTaskResource.__PropertyOffset_bManuallySetID) & ~UGameplayTaskResource.__PropertyMask_bManuallySetID) | (value ? UGameplayTaskResource.__PropertyMask_bManuallySetID : 0));
			}
		}

		// Token: 0x06012A64 RID: 76388 RVA: 0x001B6FDC File Offset: 0x001B51DC
		static UGameplayTaskResource()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayTasks.GameplayTaskResource");
		}

		// Token: 0x06012A65 RID: 76389 RVA: 0x001B6FEC File Offset: 0x001B51EC
		protected UGameplayTaskResource() : this(BuiltinUtils.AllocNativeUObject(UGameplayTaskResource.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012A66 RID: 76390 RVA: 0x001B7014 File Offset: 0x001B5214
		protected UGameplayTaskResource(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009F70 RID: 40816
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayTasks.GameplayTaskResource";

		// Token: 0x04009F71 RID: 40817
		private static IntPtr _ClassPtr;

		// Token: 0x04009F72 RID: 40818
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009F73 RID: 40819
		internal static int __PropertyOffset_ManualResourceID;

		// Token: 0x04009F74 RID: 40820
		internal static int __PropertyOffset_AutoResourceID;

		// Token: 0x04009F75 RID: 40821
		internal static int __PropertyOffset_bManuallySetID;

		// Token: 0x04009F76 RID: 40822
		internal static byte __PropertyMask_bManuallySetID;
	}
}
