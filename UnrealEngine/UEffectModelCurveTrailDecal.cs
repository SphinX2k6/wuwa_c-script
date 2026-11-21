using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003C1 RID: 961
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelCurveTrailDecal")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UEffectModelCurveTrailDecal : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005DFB RID: 24059 RVA: 0x00084D37 File Offset: 0x00082F37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelCurveTrailDecal._ClassPtr;
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x00084D44 File Offset: 0x00082F44
		public UEffectModelCurveTrailDecal() : this(BuiltinUtils.AllocNativeUObject(UEffectModelCurveTrailDecal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x00084D6C File Offset: 0x00082F6C
		[NullableContext(1)]
		public UEffectModelCurveTrailDecal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelCurveTrailDecal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x00084D9F File Offset: 0x00082F9F
		static UEffectModelCurveTrailDecal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelCurveTrailDecal");
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x00084DAD File Offset: 0x00082FAD
		protected UEffectModelCurveTrailDecal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002732 RID: 10034
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelCurveTrailDecal";

		// Token: 0x04002733 RID: 10035
		private static IntPtr _ClassPtr;

		// Token: 0x04002734 RID: 10036
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
