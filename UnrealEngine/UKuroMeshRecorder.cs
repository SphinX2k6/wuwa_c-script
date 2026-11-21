using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FC RID: 764
	[UnrealObjectPath("/Script/KuroAnim.KuroMeshRecorder")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UKuroMeshRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600528F RID: 21135 RVA: 0x0007377E File Offset: 0x0007197E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMeshRecorder._ClassPtr;
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x0007378C File Offset: 0x0007198C
		public UKuroMeshRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroMeshRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x000737B4 File Offset: 0x000719B4
		[NullableContext(1)]
		public UKuroMeshRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMeshRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x000737E7 File Offset: 0x000719E7
		static UKuroMeshRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroMeshRecorder");
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x000737F5 File Offset: 0x000719F5
		protected UKuroMeshRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021A9 RID: 8617
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroMeshRecorder";

		// Token: 0x040021AA RID: 8618
		private static IntPtr _ClassPtr;

		// Token: 0x040021AB RID: 8619
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
