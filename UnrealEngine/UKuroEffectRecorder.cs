using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001662 RID: 5730
	[UnrealObjectPath("/Script/KuroAnim.KuroEffectRecorder")]
	[UnrealStructLayout(352, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UKuroEffectRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014C16 RID: 85014 RVA: 0x001E856F File Offset: 0x001E676F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectRecorder._ClassPtr;
		}

		// Token: 0x06014C17 RID: 85015 RVA: 0x001E857C File Offset: 0x001E677C
		public UKuroEffectRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014C18 RID: 85016 RVA: 0x001E85A4 File Offset: 0x001E67A4
		[NullableContext(1)]
		public UKuroEffectRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014C19 RID: 85017 RVA: 0x001E85D7 File Offset: 0x001E67D7
		static UKuroEffectRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroEffectRecorder");
		}

		// Token: 0x06014C1A RID: 85018 RVA: 0x001E85E5 File Offset: 0x001E67E5
		protected UKuroEffectRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B508 RID: 46344
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroEffectRecorder";

		// Token: 0x0400B509 RID: 46345
		private static IntPtr _ClassPtr;

		// Token: 0x0400B50A RID: 46346
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
