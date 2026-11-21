using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CB RID: 203
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkReverbVolume")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class AAkReverbVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x000173FB File Offset: 0x000155FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAkReverbVolume._ClassPtr;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00017408 File Offset: 0x00015608
		public AAkReverbVolume() : this(BuiltinUtils.AllocNativeUObject(AAkReverbVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00017430 File Offset: 0x00015630
		public AAkReverbVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAkReverbVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00017463 File Offset: 0x00015663
		// (set) Token: 0x06000F03 RID: 3843 RVA: 0x00017473 File Offset: 0x00015673
		public unsafe bool bEnabled_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_bEnabled_DEPRECATED) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_bEnabled_DEPRECATED) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x00017484 File Offset: 0x00015684
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00017498 File Offset: 0x00015698
		public unsafe string AuxBusName_DEPRECATED
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AAkReverbVolume.__PropertyOffset_AuxBusName_DEPRECATED)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AAkReverbVolume.__PropertyOffset_AuxBusName_DEPRECATED)), value);
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000F06 RID: 3846 RVA: 0x000174AD File Offset: 0x000156AD
		// (set) Token: 0x06000F07 RID: 3847 RVA: 0x000174BD File Offset: 0x000156BD
		public unsafe float SendLevel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_SendLevel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_SendLevel_DEPRECATED) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000F08 RID: 3848 RVA: 0x000174CE File Offset: 0x000156CE
		// (set) Token: 0x06000F09 RID: 3849 RVA: 0x000174DE File Offset: 0x000156DE
		public unsafe float FadeRate_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_FadeRate_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_FadeRate_DEPRECATED) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000F0A RID: 3850 RVA: 0x000174EF File Offset: 0x000156EF
		// (set) Token: 0x06000F0B RID: 3851 RVA: 0x000174FF File Offset: 0x000156FF
		public unsafe float Priority_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_Priority_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AAkReverbVolume.__PropertyOffset_Priority_DEPRECATED) = value;
			}
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00017510 File Offset: 0x00015710
		static AAkReverbVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkReverbVolume");
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0001751E File Offset: 0x0001571E
		protected AAkReverbVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002FA RID: 762
		public new const string __ObjectPath = "/Script/AkAudio.AkReverbVolume";

		// Token: 0x040002FB RID: 763
		private static IntPtr _ClassPtr;

		// Token: 0x040002FC RID: 764
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002FD RID: 765
		internal static int __PropertyOffset_bEnabled_DEPRECATED;

		// Token: 0x040002FE RID: 766
		internal static int __PropertyOffset_AuxBusName_DEPRECATED;

		// Token: 0x040002FF RID: 767
		internal static int __PropertyOffset_SendLevel_DEPRECATED;

		// Token: 0x04000300 RID: 768
		internal static int __PropertyOffset_FadeRate_DEPRECATED;

		// Token: 0x04000301 RID: 769
		internal static int __PropertyOffset_Priority_DEPRECATED;
	}
}
