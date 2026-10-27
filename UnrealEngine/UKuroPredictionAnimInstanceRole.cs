using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001669 RID: 5737
	[UnrealObjectPath("/Script/KuroAnim.KuroPredictionAnimInstanceRole")]
	[UnrealStructLayout(4096, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 4096)]
	public class UKuroPredictionAnimInstanceRole : UKuroAnimInstanceRole, IUnrealUObject, IUnrealObject, IInterface_KuroTerrainSurveyPredictionAnimIns, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06014C86 RID: 85126 RVA: 0x001E904C File Offset: 0x001E724C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroPredictionAnimInstanceRole._ClassPtr;
		}

		// Token: 0x06014C87 RID: 85127 RVA: 0x001E9058 File Offset: 0x001E7258
		int IInterface_KuroTerrainSurveyPredictionAnimIns.InterfaceOffset()
		{
			return UKuroPredictionAnimInstanceRole.__InterfaceOffset_IInterface_KuroTerrainSurveyPredictionAnimIns;
		}

		// Token: 0x06014C88 RID: 85128 RVA: 0x001E9060 File Offset: 0x001E7260
		public UKuroPredictionAnimInstanceRole() : this(BuiltinUtils.AllocNativeUObject(UKuroPredictionAnimInstanceRole.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014C89 RID: 85129 RVA: 0x001E9088 File Offset: 0x001E7288
		[NullableContext(1)]
		public UKuroPredictionAnimInstanceRole(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroPredictionAnimInstanceRole.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x06014C8A RID: 85130 RVA: 0x001E90BC File Offset: 0x001E72BC
		// (set) Token: 0x06014C8B RID: 85131 RVA: 0x001E90F5 File Offset: 0x001E72F5
		[Nullable(1)]
		public FCollectPropertyParams CPPPropertyData
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollectPropertyParams result;
				if ((result = this._CPPPropertyData) == null)
				{
					result = (this._CPPPropertyData = new FCollectPropertyParams(base.NativePtr + (IntPtr)UKuroPredictionAnimInstanceRole.__PropertyOffset_CPPPropertyData, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollectPropertyParams.StaticStruct(), base.NativePtr + (IntPtr)UKuroPredictionAnimInstanceRole.__PropertyOffset_CPPPropertyData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06014C8C RID: 85132 RVA: 0x001E9116 File Offset: 0x001E7316
		[NullableContext(2)]
		public static void CallOnComponentStart(UKuroAnimInstance InInstance)
		{
			UKuroPredictionAnimInstanceRole.__CallOnComponentStart_Internal((InInstance != null) ? InInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014C8D RID: 85133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CallOnComponentStart_Internal(IntPtr InInstance);

		// Token: 0x06014C8E RID: 85134 RVA: 0x001E912D File Offset: 0x001E732D
		static UKuroPredictionAnimInstanceRole()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroPredictionAnimInstanceRole");
		}

		// Token: 0x06014C8F RID: 85135 RVA: 0x001E913B File Offset: 0x001E733B
		protected UKuroPredictionAnimInstanceRole(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B54A RID: 46410
		internal static int __InterfaceOffset_IInterface_KuroTerrainSurveyPredictionAnimIns;

		// Token: 0x0400B54B RID: 46411
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroPredictionAnimInstanceRole";

		// Token: 0x0400B54C RID: 46412
		private static IntPtr _ClassPtr;

		// Token: 0x0400B54D RID: 46413
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B54E RID: 46414
		internal static int __PropertyOffset_CPPPropertyData;

		// Token: 0x0400B54F RID: 46415
		[Nullable(2)]
		private FCollectPropertyParams _CPPPropertyData;
	}
}
