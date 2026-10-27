using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002250 RID: 8784
	[UnrealObjectPath("/Script/LTween.LTweenerVector4")]
	[UnrealStructLayout(384, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class ULTweenerVector4 : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021670 RID: 136816 RVA: 0x0031389A File Offset: 0x00311A9A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerVector4._ClassPtr;
		}

		// Token: 0x06021671 RID: 136817 RVA: 0x003138A8 File Offset: 0x00311AA8
		public ULTweenerVector4() : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector4.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021672 RID: 136818 RVA: 0x003138D0 File Offset: 0x00311AD0
		[NullableContext(1)]
		public ULTweenerVector4(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerVector4.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021673 RID: 136819 RVA: 0x00313903 File Offset: 0x00311B03
		static ULTweenerVector4()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerVector4");
		}

		// Token: 0x06021674 RID: 136820 RVA: 0x00313911 File Offset: 0x00311B11
		protected ULTweenerVector4(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CD5 RID: 72917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerVector4";

		// Token: 0x04011CD6 RID: 72918
		private static IntPtr _ClassPtr;

		// Token: 0x04011CD7 RID: 72919
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
