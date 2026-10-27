using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200169B RID: 5787
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.KuroAudioStateVolume")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public class AKuroAudioStateVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014FB6 RID: 85942 RVA: 0x001ED6E2 File Offset: 0x001EB8E2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroAudioStateVolume._ClassPtr;
		}

		// Token: 0x06014FB7 RID: 85943 RVA: 0x001ED6F0 File Offset: 0x001EB8F0
		public AKuroAudioStateVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroAudioStateVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014FB8 RID: 85944 RVA: 0x001ED718 File Offset: 0x001EB918
		public AKuroAudioStateVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroAudioStateVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005310 RID: 21264
		// (get) Token: 0x06014FB9 RID: 85945 RVA: 0x001ED74B File Offset: 0x001EB94B
		// (set) Token: 0x06014FBA RID: 85946 RVA: 0x001ED75F File Offset: 0x001EB95F
		public unsafe string Group
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroAudioStateVolume.__PropertyOffset_Group)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroAudioStateVolume.__PropertyOffset_Group)), value);
			}
		}

		// Token: 0x17005311 RID: 21265
		// (get) Token: 0x06014FBB RID: 85947 RVA: 0x001ED774 File Offset: 0x001EB974
		// (set) Token: 0x06014FBC RID: 85948 RVA: 0x001ED788 File Offset: 0x001EB988
		public unsafe string State
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AKuroAudioStateVolume.__PropertyOffset_State)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AKuroAudioStateVolume.__PropertyOffset_State)), value);
			}
		}

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x06014FBD RID: 85949 RVA: 0x001ED79D File Offset: 0x001EB99D
		// (set) Token: 0x06014FBE RID: 85950 RVA: 0x001ED7AD File Offset: 0x001EB9AD
		public unsafe byte Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroAudioStateVolume.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroAudioStateVolume.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x06014FBF RID: 85951 RVA: 0x001ED7BE File Offset: 0x001EB9BE
		static AKuroAudioStateVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAudioStateVolume");
		}

		// Token: 0x06014FC0 RID: 85952 RVA: 0x001ED7CC File Offset: 0x001EB9CC
		protected AKuroAudioStateVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6DD RID: 46813
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAudioStateVolume";

		// Token: 0x0400B6DE RID: 46814
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6DF RID: 46815
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6E0 RID: 46816
		internal static int __PropertyOffset_Group;

		// Token: 0x0400B6E1 RID: 46817
		internal static int __PropertyOffset_State;

		// Token: 0x0400B6E2 RID: 46818
		internal static int __PropertyOffset_Priority;
	}
}
