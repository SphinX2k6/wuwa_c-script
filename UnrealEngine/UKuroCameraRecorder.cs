using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F7 RID: 759
	[UnrealObjectPath("/Script/KuroAnim.KuroCameraRecorder")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UKuroCameraRecorder : UKuroTrackRecorder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005269 RID: 21097 RVA: 0x0007340E File Offset: 0x0007160E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCameraRecorder._ClassPtr;
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x0007341C File Offset: 0x0007161C
		public UKuroCameraRecorder() : this(BuiltinUtils.AllocNativeUObject(UKuroCameraRecorder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00073444 File Offset: 0x00071644
		[NullableContext(1)]
		public UKuroCameraRecorder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCameraRecorder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00073477 File Offset: 0x00071677
		static UKuroCameraRecorder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroCameraRecorder");
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00073485 File Offset: 0x00071685
		protected UKuroCameraRecorder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400218C RID: 8588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroCameraRecorder";

		// Token: 0x0400218D RID: 8589
		private static IntPtr _ClassPtr;

		// Token: 0x0400218E RID: 8590
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
