using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021FF RID: 8703
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkCurveRemapSettings")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public class ULiveLinkCurveRemapSettings : ULiveLinkSourceSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060212AA RID: 135850 RVA: 0x0030E6E0 File Offset: 0x0030C8E0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULiveLinkCurveRemapSettings._ClassPtr;
		}

		// Token: 0x060212AB RID: 135851 RVA: 0x0030E6EC File Offset: 0x0030C8EC
		public ULiveLinkCurveRemapSettings() : this(BuiltinUtils.AllocNativeUObject(ULiveLinkCurveRemapSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060212AC RID: 135852 RVA: 0x0030E714 File Offset: 0x0030C914
		public ULiveLinkCurveRemapSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULiveLinkCurveRemapSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700817B RID: 33147
		// (get) Token: 0x060212AD RID: 135853 RVA: 0x0030E748 File Offset: 0x0030C948
		// (set) Token: 0x060212AE RID: 135854 RVA: 0x0030E781 File Offset: 0x0030C981
		public FLiveLinkCurveConversionSettings CurveConversionSettings
		{
			get
			{
				base.FastCheckIsValid();
				FLiveLinkCurveConversionSettings result;
				if ((result = this._CurveConversionSettings) == null)
				{
					result = (this._CurveConversionSettings = new FLiveLinkCurveConversionSettings(base.NativePtr + (IntPtr)ULiveLinkCurveRemapSettings.__PropertyOffset_CurveConversionSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLiveLinkCurveConversionSettings.StaticStruct(), base.NativePtr + (IntPtr)ULiveLinkCurveRemapSettings.__PropertyOffset_CurveConversionSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060212AF RID: 135855 RVA: 0x0030E7A2 File Offset: 0x0030C9A2
		static ULiveLinkCurveRemapSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LiveLinkInterface.LiveLinkCurveRemapSettings");
		}

		// Token: 0x060212B0 RID: 135856 RVA: 0x0030E7B0 File Offset: 0x0030C9B0
		protected ULiveLinkCurveRemapSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011B21 RID: 72481
		public new const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkCurveRemapSettings";

		// Token: 0x04011B22 RID: 72482
		private static IntPtr _ClassPtr;

		// Token: 0x04011B23 RID: 72483
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011B24 RID: 72484
		internal static int __PropertyOffset_CurveConversionSettings;

		// Token: 0x04011B25 RID: 72485
		[Nullable(2)]
		private FLiveLinkCurveConversionSettings _CurveConversionSettings;
	}
}
