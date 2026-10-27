using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002245 RID: 8773
	[UnrealObjectPath("/Script/LTween.LTweenerLinearColor")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class ULTweenerLinearColor : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021639 RID: 136761 RVA: 0x0031331A File Offset: 0x0031151A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerLinearColor._ClassPtr;
		}

		// Token: 0x0602163A RID: 136762 RVA: 0x00313328 File Offset: 0x00311528
		public ULTweenerLinearColor() : this(BuiltinUtils.AllocNativeUObject(ULTweenerLinearColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602163B RID: 136763 RVA: 0x00313350 File Offset: 0x00311550
		[NullableContext(1)]
		public ULTweenerLinearColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerLinearColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602163C RID: 136764 RVA: 0x00313383 File Offset: 0x00311583
		static ULTweenerLinearColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerLinearColor");
		}

		// Token: 0x0602163D RID: 136765 RVA: 0x00313391 File Offset: 0x00311591
		protected ULTweenerLinearColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CB4 RID: 72884
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerLinearColor";

		// Token: 0x04011CB5 RID: 72885
		private static IntPtr _ClassPtr;

		// Token: 0x04011CB6 RID: 72886
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
