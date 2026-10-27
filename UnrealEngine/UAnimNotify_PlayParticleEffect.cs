using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000830 RID: 2096
	[UnrealObjectPath("/Script/Engine.AnimNotify_PlayParticleEffect")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAnimNotify_PlayParticleEffect : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070D6 RID: 28886 RVA: 0x000A1C3E File Offset: 0x0009FE3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PlayParticleEffect._ClassPtr;
		}

		// Token: 0x060070D7 RID: 28887 RVA: 0x000A1C4C File Offset: 0x0009FE4C
		public UAnimNotify_PlayParticleEffect() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayParticleEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070D8 RID: 28888 RVA: 0x000A1C74 File Offset: 0x0009FE74
		[NullableContext(1)]
		public UAnimNotify_PlayParticleEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayParticleEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x000A1CA7 File Offset: 0x0009FEA7
		// (set) Token: 0x060070DA RID: 28890 RVA: 0x000A1CBB File Offset: 0x0009FEBB
		[Nullable(2)]
		public unsafe UParticleSystem PSTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlayParticleEffect.__PropertyOffset_PSTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlayParticleEffect.__PropertyOffset_PSTemplate, value);
			}
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x060070DB RID: 28891 RVA: 0x000A1CD0 File Offset: 0x0009FED0
		// (set) Token: 0x060070DC RID: 28892 RVA: 0x000A1CE4 File Offset: 0x0009FEE4
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x060070DD RID: 28893 RVA: 0x000A1CF9 File Offset: 0x0009FEF9
		// (set) Token: 0x060070DE RID: 28894 RVA: 0x000A1D0D File Offset: 0x0009FF0D
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x060070DF RID: 28895 RVA: 0x000A1D22 File Offset: 0x0009FF22
		// (set) Token: 0x060070E0 RID: 28896 RVA: 0x000A1D36 File Offset: 0x0009FF36
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x060070E1 RID: 28897 RVA: 0x000A1D4B File Offset: 0x0009FF4B
		// (set) Token: 0x060070E2 RID: 28898 RVA: 0x000A1D64 File Offset: 0x0009FF64
		public unsafe bool Attached
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_Attached) & UAnimNotify_PlayParticleEffect.__PropertyMask_Attached) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_Attached) = ((*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_Attached) & ~UAnimNotify_PlayParticleEffect.__PropertyMask_Attached) | (value ? UAnimNotify_PlayParticleEffect.__PropertyMask_Attached : 0));
			}
		}

		// Token: 0x17001A91 RID: 6801
		// (get) Token: 0x060070E3 RID: 28899 RVA: 0x000A1D94 File Offset: 0x0009FF94
		// (set) Token: 0x060070E4 RID: 28900 RVA: 0x000A1DA8 File Offset: 0x0009FFA8
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayParticleEffect.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x060070E5 RID: 28901 RVA: 0x000A1DBD File Offset: 0x0009FFBD
		static UAnimNotify_PlayParticleEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotify_PlayParticleEffect");
		}

		// Token: 0x060070E6 RID: 28902 RVA: 0x000A1DCB File Offset: 0x0009FFCB
		protected UAnimNotify_PlayParticleEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003628 RID: 13864
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotify_PlayParticleEffect";

		// Token: 0x04003629 RID: 13865
		private static IntPtr _ClassPtr;

		// Token: 0x0400362A RID: 13866
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400362B RID: 13867
		internal static int __PropertyOffset_PSTemplate;

		// Token: 0x0400362C RID: 13868
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x0400362D RID: 13869
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x0400362E RID: 13870
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400362F RID: 13871
		internal static int __PropertyOffset_Attached;

		// Token: 0x04003630 RID: 13872
		internal static byte __PropertyMask_Attached;

		// Token: 0x04003631 RID: 13873
		internal static int __PropertyOffset_SocketName;
	}
}
