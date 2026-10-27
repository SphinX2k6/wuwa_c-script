using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002244 RID: 8772
	[UnrealObjectPath("/Script/LTween.LTweenerInteger")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class ULTweenerInteger : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021634 RID: 136756 RVA: 0x0031329A File Offset: 0x0031149A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerInteger._ClassPtr;
		}

		// Token: 0x06021635 RID: 136757 RVA: 0x003132A8 File Offset: 0x003114A8
		public ULTweenerInteger() : this(BuiltinUtils.AllocNativeUObject(ULTweenerInteger.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021636 RID: 136758 RVA: 0x003132D0 File Offset: 0x003114D0
		[NullableContext(1)]
		public ULTweenerInteger(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerInteger.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021637 RID: 136759 RVA: 0x00313303 File Offset: 0x00311503
		static ULTweenerInteger()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerInteger");
		}

		// Token: 0x06021638 RID: 136760 RVA: 0x00313311 File Offset: 0x00311511
		protected ULTweenerInteger(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CB1 RID: 72881
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerInteger";

		// Token: 0x04011CB2 RID: 72882
		private static IntPtr _ClassPtr;

		// Token: 0x04011CB3 RID: 72883
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
