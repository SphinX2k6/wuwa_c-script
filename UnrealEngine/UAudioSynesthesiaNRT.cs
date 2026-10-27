using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000389 RID: 905
	[UnrealObjectPath("/Script/AudioSynesthesia.AudioSynesthesiaNRT")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UAudioSynesthesiaNRT : UAudioAnalyzerNRT, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031F5 RID: 12789 RVA: 0x0004D2A4 File Offset: 0x0004B4A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioSynesthesiaNRT._ClassPtr;
		}

		// Token: 0x060031F6 RID: 12790 RVA: 0x0004D2B0 File Offset: 0x0004B4B0
		static UAudioSynesthesiaNRT()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.AudioSynesthesiaNRT");
		}

		// Token: 0x060031F7 RID: 12791 RVA: 0x0004D2C0 File Offset: 0x0004B4C0
		protected UAudioSynesthesiaNRT() : this(BuiltinUtils.AllocNativeUObject(UAudioSynesthesiaNRT.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031F8 RID: 12792 RVA: 0x0004D2E8 File Offset: 0x0004B4E8
		protected UAudioSynesthesiaNRT(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040015D1 RID: 5585
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.AudioSynesthesiaNRT";

		// Token: 0x040015D2 RID: 5586
		private static IntPtr _ClassPtr;

		// Token: 0x040015D3 RID: 5587
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
