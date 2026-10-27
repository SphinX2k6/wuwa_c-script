using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001EF RID: 495
	[UnrealObjectPath("/Script/AkAudio.AkAudioBank")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UAkAudioBank : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D21 RID: 7457 RVA: 0x0002B68F File Offset: 0x0002988F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAudioBank._ClassPtr;
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x0002B69C File Offset: 0x0002989C
		public UAkAudioBank() : this(BuiltinUtils.AllocNativeUObject(UAkAudioBank.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x0002B6C4 File Offset: 0x000298C4
		[NullableContext(1)]
		public UAkAudioBank(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAudioBank.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x0002B6F7 File Offset: 0x000298F7
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x0002B707 File Offset: 0x00029907
		public unsafe bool AutoLoad_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkAudioBank.__PropertyOffset_AutoLoad_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkAudioBank.__PropertyOffset_AutoLoad_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x0002B718 File Offset: 0x00029918
		static UAkAudioBank()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAudioBank");
		}

		// Token: 0x06001D27 RID: 7463 RVA: 0x0002B726 File Offset: 0x00029926
		protected UAkAudioBank(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000996 RID: 2454
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAudioBank";

		// Token: 0x04000997 RID: 2455
		private static IntPtr _ClassPtr;

		// Token: 0x04000998 RID: 2456
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000999 RID: 2457
		internal static int __PropertyOffset_AutoLoad_DEPRECATED;
	}
}
