using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000142 RID: 322
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_DoesPathExist")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UBTDecorator_DoesPathExist : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001678 RID: 5752 RVA: 0x000210BF File Offset: 0x0001F2BF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_DoesPathExist._ClassPtr;
		}

		// Token: 0x06001679 RID: 5753 RVA: 0x000210CC File Offset: 0x0001F2CC
		public UBTDecorator_DoesPathExist() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_DoesPathExist.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600167A RID: 5754 RVA: 0x000210F4 File Offset: 0x0001F2F4
		public UBTDecorator_DoesPathExist(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_DoesPathExist.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x0600167B RID: 5755 RVA: 0x00021128 File Offset: 0x0001F328
		// (set) Token: 0x0600167C RID: 5756 RVA: 0x00021161 File Offset: 0x0001F361
		public FBlackboardKeySelector BlackboardKeyA
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKeyA) == null)
				{
					result = (this._BlackboardKeyA = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_BlackboardKeyA, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_BlackboardKeyA, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x00021184 File Offset: 0x0001F384
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x000211BD File Offset: 0x0001F3BD
		public FBlackboardKeySelector BlackboardKeyB
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._BlackboardKeyB) == null)
				{
					result = (this._BlackboardKeyB = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_BlackboardKeyB, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_BlackboardKeyB, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005DB RID: 1499
		// (get) Token: 0x0600167F RID: 5759 RVA: 0x000211DE File Offset: 0x0001F3DE
		// (set) Token: 0x06001680 RID: 5760 RVA: 0x000211F7 File Offset: 0x0001F3F7
		public unsafe bool bUseSelf
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_bUseSelf) & UBTDecorator_DoesPathExist.__PropertyMask_bUseSelf) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_bUseSelf) = ((*(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_bUseSelf) & ~UBTDecorator_DoesPathExist.__PropertyMask_bUseSelf) | (value ? UBTDecorator_DoesPathExist.__PropertyMask_bUseSelf : 0));
			}
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x06001681 RID: 5761 RVA: 0x00021227 File Offset: 0x0001F427
		// (set) Token: 0x06001682 RID: 5762 RVA: 0x0002123B File Offset: 0x0001F43B
		[Nullable(0)]
		public unsafe TEnumAsByte<EPathExistanceQueryType> PathQueryType
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_PathQueryType);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_PathQueryType) = value;
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x06001683 RID: 5763 RVA: 0x00021250 File Offset: 0x0001F450
		// (set) Token: 0x06001684 RID: 5764 RVA: 0x00021264 File Offset: 0x0001F464
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
				return *(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_FilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_DoesPathExist.__PropertyOffset_FilterClass) = value;
			}
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00021279 File Offset: 0x0001F479
		static UBTDecorator_DoesPathExist()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_DoesPathExist");
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00021287 File Offset: 0x0001F487
		protected UBTDecorator_DoesPathExist(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400051A RID: 1306
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_DoesPathExist";

		// Token: 0x0400051B RID: 1307
		private static IntPtr _ClassPtr;

		// Token: 0x0400051C RID: 1308
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400051D RID: 1309
		internal static int __PropertyOffset_BlackboardKeyA;

		// Token: 0x0400051E RID: 1310
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKeyA;

		// Token: 0x0400051F RID: 1311
		internal static int __PropertyOffset_BlackboardKeyB;

		// Token: 0x04000520 RID: 1312
		[Nullable(2)]
		private FBlackboardKeySelector _BlackboardKeyB;

		// Token: 0x04000521 RID: 1313
		internal static int __PropertyOffset_bUseSelf;

		// Token: 0x04000522 RID: 1314
		internal static byte __PropertyMask_bUseSelf;

		// Token: 0x04000523 RID: 1315
		internal static int __PropertyOffset_PathQueryType;

		// Token: 0x04000524 RID: 1316
		internal static int __PropertyOffset_FilterClass;
	}
}
