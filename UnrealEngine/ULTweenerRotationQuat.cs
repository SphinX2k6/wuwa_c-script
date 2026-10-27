using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224B RID: 8779
	[UnrealObjectPath("/Script/LTween.LTweenerRotationQuat")]
	[UnrealStructLayout(416, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 416)]
	public class ULTweenerRotationQuat : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021657 RID: 136791 RVA: 0x0031361A File Offset: 0x0031181A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerRotationQuat._ClassPtr;
		}

		// Token: 0x06021658 RID: 136792 RVA: 0x00313628 File Offset: 0x00311828
		public ULTweenerRotationQuat() : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotationQuat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021659 RID: 136793 RVA: 0x00313650 File Offset: 0x00311850
		[NullableContext(1)]
		public ULTweenerRotationQuat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotationQuat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602165A RID: 136794 RVA: 0x00313683 File Offset: 0x00311883
		static ULTweenerRotationQuat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerRotationQuat");
		}

		// Token: 0x0602165B RID: 136795 RVA: 0x00313691 File Offset: 0x00311891
		protected ULTweenerRotationQuat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CC6 RID: 72902
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerRotationQuat";

		// Token: 0x04011CC7 RID: 72903
		private static IntPtr _ClassPtr;

		// Token: 0x04011CC8 RID: 72904
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
