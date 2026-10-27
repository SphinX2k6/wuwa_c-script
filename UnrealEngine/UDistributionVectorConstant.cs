using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009D1 RID: 2513
	[UnrealObjectPath("/Script/Engine.DistributionVectorConstant")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UDistributionVectorConstant : UDistributionVector, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E20 RID: 36384 RVA: 0x000CB2AD File Offset: 0x000C94AD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionVectorConstant._ClassPtr;
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x000CB2BC File Offset: 0x000C94BC
		public UDistributionVectorConstant() : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x000CB2E4 File Offset: 0x000C94E4
		[NullableContext(1)]
		public UDistributionVectorConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionVectorConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700217A RID: 8570
		// (get) Token: 0x06008E23 RID: 36387 RVA: 0x000CB317 File Offset: 0x000C9517
		// (set) Token: 0x06008E24 RID: 36388 RVA: 0x000CB32B File Offset: 0x000C952B
		public unsafe FVector Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x1700217B RID: 8571
		// (get) Token: 0x06008E25 RID: 36389 RVA: 0x000CB340 File Offset: 0x000C9540
		// (set) Token: 0x06008E26 RID: 36390 RVA: 0x000CB359 File Offset: 0x000C9559
		public unsafe bool bLockAxes
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_bLockAxes) & UDistributionVectorConstant.__PropertyMask_bLockAxes) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_bLockAxes) = ((*(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_bLockAxes) & ~UDistributionVectorConstant.__PropertyMask_bLockAxes) | (value ? UDistributionVectorConstant.__PropertyMask_bLockAxes : 0));
			}
		}

		// Token: 0x1700217C RID: 8572
		// (get) Token: 0x06008E27 RID: 36391 RVA: 0x000CB389 File Offset: 0x000C9589
		// (set) Token: 0x06008E28 RID: 36392 RVA: 0x000CB39D File Offset: 0x000C959D
		public unsafe TEnumAsByte<EDistributionVectorLockFlags> LockedAxes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_LockedAxes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionVectorConstant.__PropertyOffset_LockedAxes) = value;
			}
		}

		// Token: 0x06008E29 RID: 36393 RVA: 0x000CB3B2 File Offset: 0x000C95B2
		static UDistributionVectorConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionVectorConstant");
		}

		// Token: 0x06008E2A RID: 36394 RVA: 0x000CB3C0 File Offset: 0x000C95C0
		protected UDistributionVectorConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004387 RID: 17287
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionVectorConstant";

		// Token: 0x04004388 RID: 17288
		private static IntPtr _ClassPtr;

		// Token: 0x04004389 RID: 17289
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400438A RID: 17290
		internal static int __PropertyOffset_Constant;

		// Token: 0x0400438B RID: 17291
		internal static int __PropertyOffset_bLockAxes;

		// Token: 0x0400438C RID: 17292
		internal static byte __PropertyMask_bLockAxes;

		// Token: 0x0400438D RID: 17293
		internal static int __PropertyOffset_LockedAxes;
	}
}
