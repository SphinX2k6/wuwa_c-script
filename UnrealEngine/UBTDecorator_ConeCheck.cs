using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000140 RID: 320
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_ConeCheck")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UBTDecorator_ConeCheck : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001664 RID: 5732 RVA: 0x00020E6A File Offset: 0x0001F06A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_ConeCheck._ClassPtr;
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00020E78 File Offset: 0x0001F078
		public UBTDecorator_ConeCheck() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ConeCheck.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x00020EA0 File Offset: 0x0001F0A0
		public UBTDecorator_ConeCheck(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_ConeCheck.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06001667 RID: 5735 RVA: 0x00020ED3 File Offset: 0x0001F0D3
		// (set) Token: 0x06001668 RID: 5736 RVA: 0x00020EE3 File Offset: 0x0001F0E3
		public unsafe float ConeHalfAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeHalfAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeHalfAngle) = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06001669 RID: 5737 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		// (set) Token: 0x0600166A RID: 5738 RVA: 0x00020F2D File Offset: 0x0001F12D
		public FBlackboardKeySelector ConeOrigin
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._ConeOrigin) == null)
				{
					result = (this._ConeOrigin = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeOrigin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeOrigin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x0600166B RID: 5739 RVA: 0x00020F50 File Offset: 0x0001F150
		// (set) Token: 0x0600166C RID: 5740 RVA: 0x00020F89 File Offset: 0x0001F189
		public FBlackboardKeySelector ConeDirection
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._ConeDirection) == null)
				{
					result = (this._ConeDirection = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeDirection, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_ConeDirection, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x0600166D RID: 5741 RVA: 0x00020FAC File Offset: 0x0001F1AC
		// (set) Token: 0x0600166E RID: 5742 RVA: 0x00020FE5 File Offset: 0x0001F1E5
		public FBlackboardKeySelector Observed
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._Observed) == null)
				{
					result = (this._Observed = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_Observed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_ConeCheck.__PropertyOffset_Observed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00021006 File Offset: 0x0001F206
		static UBTDecorator_ConeCheck()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_ConeCheck");
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00021014 File Offset: 0x0001F214
		protected UBTDecorator_ConeCheck(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400050C RID: 1292
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_ConeCheck";

		// Token: 0x0400050D RID: 1293
		private static IntPtr _ClassPtr;

		// Token: 0x0400050E RID: 1294
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400050F RID: 1295
		internal static int __PropertyOffset_ConeHalfAngle;

		// Token: 0x04000510 RID: 1296
		internal static int __PropertyOffset_ConeOrigin;

		// Token: 0x04000511 RID: 1297
		[Nullable(2)]
		private FBlackboardKeySelector _ConeOrigin;

		// Token: 0x04000512 RID: 1298
		internal static int __PropertyOffset_ConeDirection;

		// Token: 0x04000513 RID: 1299
		[Nullable(2)]
		private FBlackboardKeySelector _ConeDirection;

		// Token: 0x04000514 RID: 1300
		internal static int __PropertyOffset_Observed;

		// Token: 0x04000515 RID: 1301
		[Nullable(2)]
		private FBlackboardKeySelector _Observed;
	}
}
