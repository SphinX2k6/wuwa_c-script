using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C17 RID: 3095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HapticFeedbackEffect_Curve")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UHapticFeedbackEffect_Curve : UHapticFeedbackEffect_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C69 RID: 40041 RVA: 0x000DE6B7 File Offset: 0x000DC8B7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHapticFeedbackEffect_Curve._ClassPtr;
		}

		// Token: 0x06009C6A RID: 40042 RVA: 0x000DE6C4 File Offset: 0x000DC8C4
		public UHapticFeedbackEffect_Curve() : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Curve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x000DE6EC File Offset: 0x000DC8EC
		public UHapticFeedbackEffect_Curve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_Curve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700254F RID: 9551
		// (get) Token: 0x06009C6C RID: 40044 RVA: 0x000DE720 File Offset: 0x000DC920
		// (set) Token: 0x06009C6D RID: 40045 RVA: 0x000DE759 File Offset: 0x000DC959
		public FHapticFeedbackDetails_Curve HapticDetails
		{
			get
			{
				base.FastCheckIsValid();
				FHapticFeedbackDetails_Curve result;
				if ((result = this._HapticDetails) == null)
				{
					result = (this._HapticDetails = new FHapticFeedbackDetails_Curve(base.NativePtr + (IntPtr)UHapticFeedbackEffect_Curve.__PropertyOffset_HapticDetails, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHapticFeedbackDetails_Curve.StaticStruct(), base.NativePtr + (IntPtr)UHapticFeedbackEffect_Curve.__PropertyOffset_HapticDetails, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x000DE77A File Offset: 0x000DC97A
		static UHapticFeedbackEffect_Curve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HapticFeedbackEffect_Curve");
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x000DE788 File Offset: 0x000DC988
		protected UHapticFeedbackEffect_Curve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005654 RID: 22100
		public new const string __ObjectPath = "/Script/Engine.HapticFeedbackEffect_Curve";

		// Token: 0x04005655 RID: 22101
		private static IntPtr _ClassPtr;

		// Token: 0x04005656 RID: 22102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005657 RID: 22103
		internal static int __PropertyOffset_HapticDetails;

		// Token: 0x04005658 RID: 22104
		[Nullable(2)]
		private FHapticFeedbackDetails_Curve _HapticDetails;
	}
}
