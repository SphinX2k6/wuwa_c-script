using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001521 RID: 5409
	[UnrealObjectPath("/Script/ImposterManager.ImposterPoolHolder")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AImposterPoolHolder : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B05 RID: 80645 RVA: 0x001CEB3A File Offset: 0x001CCD3A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AImposterPoolHolder._ClassPtr;
		}

		// Token: 0x06013B06 RID: 80646 RVA: 0x001CEB48 File Offset: 0x001CCD48
		public AImposterPoolHolder() : this(BuiltinUtils.AllocNativeUObject(AImposterPoolHolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B07 RID: 80647 RVA: 0x001CEB70 File Offset: 0x001CCD70
		[NullableContext(1)]
		public AImposterPoolHolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AImposterPoolHolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013B08 RID: 80648 RVA: 0x001CEBA3 File Offset: 0x001CCDA3
		static AImposterPoolHolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ImposterManager.ImposterPoolHolder");
		}

		// Token: 0x06013B09 RID: 80649 RVA: 0x001CEBB1 File Offset: 0x001CCDB1
		protected AImposterPoolHolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA1B RID: 43547
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ImposterManager.ImposterPoolHolder";

		// Token: 0x0400AA1C RID: 43548
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA1D RID: 43549
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
