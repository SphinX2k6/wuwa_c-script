using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002243 RID: 8771
	[UnrealObjectPath("/Script/LTween.LTweenerFrame")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class ULTweenerFrame : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602162F RID: 136751 RVA: 0x0031321A File Offset: 0x0031141A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerFrame._ClassPtr;
		}

		// Token: 0x06021630 RID: 136752 RVA: 0x00313228 File Offset: 0x00311428
		public ULTweenerFrame() : this(BuiltinUtils.AllocNativeUObject(ULTweenerFrame.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021631 RID: 136753 RVA: 0x00313250 File Offset: 0x00311450
		[NullableContext(1)]
		public ULTweenerFrame(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerFrame.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021632 RID: 136754 RVA: 0x00313283 File Offset: 0x00311483
		static ULTweenerFrame()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerFrame");
		}

		// Token: 0x06021633 RID: 136755 RVA: 0x00313291 File Offset: 0x00311491
		protected ULTweenerFrame(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CAE RID: 72878
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerFrame";

		// Token: 0x04011CAF RID: 72879
		private static IntPtr _ClassPtr;

		// Token: 0x04011CB0 RID: 72880
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
