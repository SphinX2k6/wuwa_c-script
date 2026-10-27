using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224A RID: 8778
	[UnrealObjectPath("/Script/LTween.LTweenerRotationEuler")]
	[UnrealStructLayout(400, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 400)]
	public class ULTweenerRotationEuler : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021652 RID: 136786 RVA: 0x0031359A File Offset: 0x0031179A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerRotationEuler._ClassPtr;
		}

		// Token: 0x06021653 RID: 136787 RVA: 0x003135A8 File Offset: 0x003117A8
		public ULTweenerRotationEuler() : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotationEuler.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021654 RID: 136788 RVA: 0x003135D0 File Offset: 0x003117D0
		[NullableContext(1)]
		public ULTweenerRotationEuler(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotationEuler.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021655 RID: 136789 RVA: 0x00313603 File Offset: 0x00311803
		static ULTweenerRotationEuler()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerRotationEuler");
		}

		// Token: 0x06021656 RID: 136790 RVA: 0x00313611 File Offset: 0x00311811
		protected ULTweenerRotationEuler(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CC3 RID: 72899
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerRotationEuler";

		// Token: 0x04011CC4 RID: 72900
		private static IntPtr _ClassPtr;

		// Token: 0x04011CC5 RID: 72901
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
