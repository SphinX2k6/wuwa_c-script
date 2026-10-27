using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002915 RID: 10517
	[UnrealObjectPath("/Script/TimeManagement.GenlockedTimecodeProvider")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public abstract class UGenlockedTimecodeProvider : UTimecodeProvider, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F9C RID: 159644 RVA: 0x003B71B9 File Offset: 0x003B53B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGenlockedTimecodeProvider._ClassPtr;
		}

		// Token: 0x17009610 RID: 38416
		// (get) Token: 0x06026F9D RID: 159645 RVA: 0x003B71C5 File Offset: 0x003B53C5
		// (set) Token: 0x06026F9E RID: 159646 RVA: 0x003B71D5 File Offset: 0x003B53D5
		public unsafe bool bUseGenlockToCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGenlockedTimecodeProvider.__PropertyOffset_bUseGenlockToCount) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGenlockedTimecodeProvider.__PropertyOffset_bUseGenlockToCount) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026F9F RID: 159647 RVA: 0x003B71E6 File Offset: 0x003B53E6
		static UGenlockedTimecodeProvider()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TimeManagement.GenlockedTimecodeProvider");
		}

		// Token: 0x06026FA0 RID: 159648 RVA: 0x003B71F4 File Offset: 0x003B53F4
		protected UGenlockedTimecodeProvider() : this(BuiltinUtils.AllocNativeUObject(UGenlockedTimecodeProvider.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026FA1 RID: 159649 RVA: 0x003B721C File Offset: 0x003B541C
		protected UGenlockedTimecodeProvider(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401565A RID: 87642
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TimeManagement.GenlockedTimecodeProvider";

		// Token: 0x0401565B RID: 87643
		private static IntPtr _ClassPtr;

		// Token: 0x0401565C RID: 87644
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401565D RID: 87645
		internal static int __PropertyOffset_bUseGenlockToCount;
	}
}
