using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224C RID: 8780
	[UnrealObjectPath("/Script/LTween.LTweenerRotator")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class ULTweenerRotator : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602165C RID: 136796 RVA: 0x0031369A File Offset: 0x0031189A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerRotator._ClassPtr;
		}

		// Token: 0x0602165D RID: 136797 RVA: 0x003136A8 File Offset: 0x003118A8
		public ULTweenerRotator() : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotator.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602165E RID: 136798 RVA: 0x003136D0 File Offset: 0x003118D0
		[NullableContext(1)]
		public ULTweenerRotator(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerRotator.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602165F RID: 136799 RVA: 0x00313703 File Offset: 0x00311903
		static ULTweenerRotator()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerRotator");
		}

		// Token: 0x06021660 RID: 136800 RVA: 0x00313711 File Offset: 0x00311911
		protected ULTweenerRotator(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CC9 RID: 72905
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerRotator";

		// Token: 0x04011CCA RID: 72906
		private static IntPtr _ClassPtr;

		// Token: 0x04011CCB RID: 72907
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
