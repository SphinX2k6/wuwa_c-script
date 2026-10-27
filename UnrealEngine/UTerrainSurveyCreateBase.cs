using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020011C6 RID: 4550
	[UnrealObjectPath("/Script/Engine.TerrainSurveyCreateBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UTerrainSurveyCreateBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010C3A RID: 68666 RVA: 0x00189F86 File Offset: 0x00188186
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTerrainSurveyCreateBase._ClassPtr;
		}

		// Token: 0x06010C3B RID: 68667 RVA: 0x00189F92 File Offset: 0x00188192
		static UTerrainSurveyCreateBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.TerrainSurveyCreateBase");
		}

		// Token: 0x06010C3C RID: 68668 RVA: 0x00189FA0 File Offset: 0x001881A0
		protected UTerrainSurveyCreateBase() : this(BuiltinUtils.AllocNativeUObject(UTerrainSurveyCreateBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010C3D RID: 68669 RVA: 0x00189FC8 File Offset: 0x001881C8
		protected UTerrainSurveyCreateBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008F58 RID: 36696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TerrainSurveyCreateBase";

		// Token: 0x04008F59 RID: 36697
		private static IntPtr _ClassPtr;

		// Token: 0x04008F5A RID: 36698
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
