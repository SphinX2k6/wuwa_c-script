using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FA RID: 762
	[UnrealObjectPath("/Script/KuroAnim.KuroEffectRecorder")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKuroEffectRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600528A RID: 21130 RVA: 0x000736FF File Offset: 0x000718FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectRecorder._ClassPtr;
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x0007370C File Offset: 0x0007190C
		public UKuroEffectRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00073734 File Offset: 0x00071934
		[NullableContext(1)]
		public UKuroEffectRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x00073767 File Offset: 0x00071967
		static UKuroEffectRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroEffectRecorder");
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x00073775 File Offset: 0x00071975
		protected UKuroEffectRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400219F RID: 8607
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroEffectRecorder";

		// Token: 0x040021A0 RID: 8608
		private static IntPtr _ClassPtr;

		// Token: 0x040021A1 RID: 8609
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
