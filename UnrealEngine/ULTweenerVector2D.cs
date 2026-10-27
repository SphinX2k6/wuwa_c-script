using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224F RID: 8783
	[UnrealObjectPath("/Script/LTween.LTweenerVector2D")]
	[UnrealStructLayout(368, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 368)]
	public class ULTweenerVector2D : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602166B RID: 136811 RVA: 0x0031381A File Offset: 0x00311A1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerVector2D._ClassPtr;
		}

		// Token: 0x0602166C RID: 136812 RVA: 0x00313828 File Offset: 0x00311A28
		public ULTweenerVector2D() : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector2D.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602166D RID: 136813 RVA: 0x00313850 File Offset: 0x00311A50
		[NullableContext(1)]
		public ULTweenerVector2D(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector2D.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602166E RID: 136814 RVA: 0x00313883 File Offset: 0x00311A83
		static ULTweenerVector2D()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerVector2D");
		}

		// Token: 0x0602166F RID: 136815 RVA: 0x00313891 File Offset: 0x00311A91
		protected ULTweenerVector2D(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CD2 RID: 72914
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerVector2D";

		// Token: 0x04011CD3 RID: 72915
		private static IntPtr _ClassPtr;

		// Token: 0x04011CD4 RID: 72916
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
