using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000C4 RID: 196
	[UnrealObjectPath("/Script/AkAudio.AkGroupValue")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public abstract class UAkGroupValue : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000EBD RID: 3773 RVA: 0x00016D6B File Offset: 0x00014F6B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGroupValue._ClassPtr;
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00016D77 File Offset: 0x00014F77
		// (set) Token: 0x06000EBF RID: 3775 RVA: 0x00016D87 File Offset: 0x00014F87
		public unsafe uint GroupShortID_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupShortID_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupShortID_DEPRECATED) = (int)value;
			}
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00016D98 File Offset: 0x00014F98
		static UAkGroupValue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGroupValue");
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00016DA8 File Offset: 0x00014FA8
		protected UAkGroupValue() : this(BuiltinUtils.AllocNativeUObject(UAkGroupValue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00016DD0 File Offset: 0x00014FD0
		protected UAkGroupValue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002D6 RID: 726
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkGroupValue";

		// Token: 0x040002D7 RID: 727
		private static IntPtr _ClassPtr;

		// Token: 0x040002D8 RID: 728
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002D9 RID: 729
		internal static int __PropertyOffset_GroupShortID_DEPRECATED;
	}
}
