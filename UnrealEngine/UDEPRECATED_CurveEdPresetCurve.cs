using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200097A RID: 2426
	[UnrealObjectPath("/Script/Engine.CurveEdPresetCurve")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UDEPRECATED_CurveEdPresetCurve : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008949 RID: 35145 RVA: 0x000C4920 File Offset: 0x000C2B20
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDEPRECATED_CurveEdPresetCurve._ClassPtr;
		}

		// Token: 0x0600894A RID: 35146 RVA: 0x000C492C File Offset: 0x000C2B2C
		public UDEPRECATED_CurveEdPresetCurve() : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_CurveEdPresetCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600894B RID: 35147 RVA: 0x000C4954 File Offset: 0x000C2B54
		[NullableContext(1)]
		public UDEPRECATED_CurveEdPresetCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDEPRECATED_CurveEdPresetCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600894C RID: 35148 RVA: 0x000C4987 File Offset: 0x000C2B87
		static UDEPRECATED_CurveEdPresetCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CurveEdPresetCurve");
		}

		// Token: 0x0600894D RID: 35149 RVA: 0x000C4995 File Offset: 0x000C2B95
		protected UDEPRECATED_CurveEdPresetCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004134 RID: 16692
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CurveEdPresetCurve";

		// Token: 0x04004135 RID: 16693
		private static IntPtr _ClassPtr;

		// Token: 0x04004136 RID: 16694
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
