using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224E RID: 8782
	[UnrealObjectPath("/Script/LTween.LTweenerVector")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class ULTweenerVector : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021666 RID: 136806 RVA: 0x0031379A File Offset: 0x0031199A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerVector._ClassPtr;
		}

		// Token: 0x06021667 RID: 136807 RVA: 0x003137A8 File Offset: 0x003119A8
		public ULTweenerVector() : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021668 RID: 136808 RVA: 0x003137D0 File Offset: 0x003119D0
		[NullableContext(1)]
		public ULTweenerVector(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021669 RID: 136809 RVA: 0x00313803 File Offset: 0x00311A03
		static ULTweenerVector()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerVector");
		}

		// Token: 0x0602166A RID: 136810 RVA: 0x00313811 File Offset: 0x00311A11
		protected ULTweenerVector(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CCF RID: 72911
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerVector";

		// Token: 0x04011CD0 RID: 72912
		private static IntPtr _ClassPtr;

		// Token: 0x04011CD1 RID: 72913
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
