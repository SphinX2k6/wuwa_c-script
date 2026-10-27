using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002242 RID: 8770
	[UnrealObjectPath("/Script/LTween.LTweenerFloat")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class ULTweenerFloat : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602162A RID: 136746 RVA: 0x0031319A File Offset: 0x0031139A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerFloat._ClassPtr;
		}

		// Token: 0x0602162B RID: 136747 RVA: 0x003131A8 File Offset: 0x003113A8
		public ULTweenerFloat() : this(BuiltinUtils.AllocNativeUObject(ULTweenerFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602162C RID: 136748 RVA: 0x003131D0 File Offset: 0x003113D0
		[NullableContext(1)]
		public ULTweenerFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602162D RID: 136749 RVA: 0x00313203 File Offset: 0x00311403
		static ULTweenerFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerFloat");
		}

		// Token: 0x0602162E RID: 136750 RVA: 0x00313211 File Offset: 0x00311411
		protected ULTweenerFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CAB RID: 72875
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerFloat";

		// Token: 0x04011CAC RID: 72876
		private static IntPtr _ClassPtr;

		// Token: 0x04011CAD RID: 72877
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
