using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200082C RID: 2092
	[UnrealObjectPath("/Script/Engine.AnimNotifyState_TimedParticleEffect")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UAnimNotifyState_TimedParticleEffect : UAnimNotifyState, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060070A3 RID: 28835 RVA: 0x000A17EA File Offset: 0x0009F9EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotifyState_TimedParticleEffect._ClassPtr;
		}

		// Token: 0x060070A4 RID: 28836 RVA: 0x000A17F8 File Offset: 0x0009F9F8
		public UAnimNotifyState_TimedParticleEffect() : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_TimedParticleEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060070A5 RID: 28837 RVA: 0x000A1820 File Offset: 0x0009FA20
		[NullableContext(1)]
		public UAnimNotifyState_TimedParticleEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotifyState_TimedParticleEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060070A6 RID: 28838 RVA: 0x000A1853 File Offset: 0x0009FA53
		// (set) Token: 0x060070A7 RID: 28839 RVA: 0x000A1867 File Offset: 0x0009FA67
		[Nullable(2)]
		public unsafe UParticleSystem PSTemplate
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UParticleSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_TimedParticleEffect.__PropertyOffset_PSTemplate);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotifyState_TimedParticleEffect.__PropertyOffset_PSTemplate, value);
			}
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060070A8 RID: 28840 RVA: 0x000A187C File Offset: 0x0009FA7C
		// (set) Token: 0x060070A9 RID: 28841 RVA: 0x000A1890 File Offset: 0x0009FA90
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060070AA RID: 28842 RVA: 0x000A18A5 File Offset: 0x0009FAA5
		// (set) Token: 0x060070AB RID: 28843 RVA: 0x000A18B9 File Offset: 0x0009FAB9
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x060070AC RID: 28844 RVA: 0x000A18CE File Offset: 0x0009FACE
		// (set) Token: 0x060070AD RID: 28845 RVA: 0x000A18E2 File Offset: 0x0009FAE2
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x060070AE RID: 28846 RVA: 0x000A18F7 File Offset: 0x0009FAF7
		// (set) Token: 0x060070AF RID: 28847 RVA: 0x000A1907 File Offset: 0x0009FB07
		public unsafe bool bDestroyAtEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_bDestroyAtEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotifyState_TimedParticleEffect.__PropertyOffset_bDestroyAtEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x060070B0 RID: 28848 RVA: 0x000A1918 File Offset: 0x0009FB18
		static UAnimNotifyState_TimedParticleEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimNotifyState_TimedParticleEffect");
		}

		// Token: 0x060070B1 RID: 28849 RVA: 0x000A1926 File Offset: 0x0009FB26
		protected UAnimNotifyState_TimedParticleEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400360F RID: 13839
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyState_TimedParticleEffect";

		// Token: 0x04003610 RID: 13840
		private static IntPtr _ClassPtr;

		// Token: 0x04003611 RID: 13841
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003612 RID: 13842
		internal static int __PropertyOffset_PSTemplate;

		// Token: 0x04003613 RID: 13843
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04003614 RID: 13844
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x04003615 RID: 13845
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x04003616 RID: 13846
		internal static int __PropertyOffset_bDestroyAtEnd;
	}
}
