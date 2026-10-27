using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000146 RID: 326
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BTDecorator_KeepInCone")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UBTDecorator_KeepInCone : UBTDecorator, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016A4 RID: 5796 RVA: 0x000215AF File Offset: 0x0001F7AF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTDecorator_KeepInCone._ClassPtr;
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x000215BC File Offset: 0x0001F7BC
		public UBTDecorator_KeepInCone() : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_KeepInCone.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000215E4 File Offset: 0x0001F7E4
		public UBTDecorator_KeepInCone(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTDecorator_KeepInCone.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00021617 File Offset: 0x0001F817
		// (set) Token: 0x060016A8 RID: 5800 RVA: 0x00021627 File Offset: 0x0001F827
		public unsafe float ConeHalfAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_ConeHalfAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_ConeHalfAngle) = value;
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00021638 File Offset: 0x0001F838
		// (set) Token: 0x060016AA RID: 5802 RVA: 0x00021671 File Offset: 0x0001F871
		public FBlackboardKeySelector ConeOrigin
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._ConeOrigin) == null)
				{
					result = (this._ConeOrigin = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_ConeOrigin, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_ConeOrigin, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x060016AB RID: 5803 RVA: 0x00021694 File Offset: 0x0001F894
		// (set) Token: 0x060016AC RID: 5804 RVA: 0x000216CD File Offset: 0x0001F8CD
		public FBlackboardKeySelector Observed
		{
			get
			{
				base.FastCheckIsValid();
				FBlackboardKeySelector result;
				if ((result = this._Observed) == null)
				{
					result = (this._Observed = new FBlackboardKeySelector(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_Observed, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBlackboardKeySelector.StaticStruct(), base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_Observed, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x060016AD RID: 5805 RVA: 0x000216EE File Offset: 0x0001F8EE
		// (set) Token: 0x060016AE RID: 5806 RVA: 0x00021707 File Offset: 0x0001F907
		public unsafe bool bUseSelfAsOrigin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsOrigin) & UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsOrigin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsOrigin) = ((*(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsOrigin) & ~UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsOrigin) | (value ? UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsOrigin : 0));
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x060016AF RID: 5807 RVA: 0x00021737 File Offset: 0x0001F937
		// (set) Token: 0x060016B0 RID: 5808 RVA: 0x00021750 File Offset: 0x0001F950
		public unsafe bool bUseSelfAsObserved
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsObserved) & UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsObserved) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsObserved) = ((*(base.NativePtr + (IntPtr)UBTDecorator_KeepInCone.__PropertyOffset_bUseSelfAsObserved) & ~UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsObserved) | (value ? UBTDecorator_KeepInCone.__PropertyMask_bUseSelfAsObserved : 0));
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00021780 File Offset: 0x0001F980
		static UBTDecorator_KeepInCone()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTDecorator_KeepInCone");
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x0002178E File Offset: 0x0001F98E
		protected UBTDecorator_KeepInCone(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000539 RID: 1337
		public new const string __ObjectPath = "/Script/AIModule.BTDecorator_KeepInCone";

		// Token: 0x0400053A RID: 1338
		private static IntPtr _ClassPtr;

		// Token: 0x0400053B RID: 1339
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400053C RID: 1340
		internal static int __PropertyOffset_ConeHalfAngle;

		// Token: 0x0400053D RID: 1341
		internal static int __PropertyOffset_ConeOrigin;

		// Token: 0x0400053E RID: 1342
		[Nullable(2)]
		private FBlackboardKeySelector _ConeOrigin;

		// Token: 0x0400053F RID: 1343
		internal static int __PropertyOffset_Observed;

		// Token: 0x04000540 RID: 1344
		[Nullable(2)]
		private FBlackboardKeySelector _Observed;

		// Token: 0x04000541 RID: 1345
		internal static int __PropertyOffset_bUseSelfAsOrigin;

		// Token: 0x04000542 RID: 1346
		internal static byte __PropertyMask_bUseSelfAsOrigin;

		// Token: 0x04000543 RID: 1347
		internal static int __PropertyOffset_bUseSelfAsObserved;

		// Token: 0x04000544 RID: 1348
		internal static byte __PropertyMask_bUseSelfAsObserved;
	}
}
