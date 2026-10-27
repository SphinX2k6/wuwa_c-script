using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C18 RID: 3096
	[UnrealObjectPath("/Script/Engine.HapticFeedbackEffect_SoundWave")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UHapticFeedbackEffect_SoundWave : UHapticFeedbackEffect_Base, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009C70 RID: 40048 RVA: 0x000DE791 File Offset: 0x000DC991
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHapticFeedbackEffect_SoundWave._ClassPtr;
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x000DE7A0 File Offset: 0x000DC9A0
		public UHapticFeedbackEffect_SoundWave() : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_SoundWave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x000DE7C8 File Offset: 0x000DC9C8
		[NullableContext(1)]
		public UHapticFeedbackEffect_SoundWave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHapticFeedbackEffect_SoundWave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002550 RID: 9552
		// (get) Token: 0x06009C73 RID: 40051 RVA: 0x000DE7FB File Offset: 0x000DC9FB
		// (set) Token: 0x06009C74 RID: 40052 RVA: 0x000DE80F File Offset: 0x000DCA0F
		[Nullable(2)]
		public unsafe USoundWave SoundWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + UHapticFeedbackEffect_SoundWave.__PropertyOffset_SoundWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UHapticFeedbackEffect_SoundWave.__PropertyOffset_SoundWave, value);
			}
		}

		// Token: 0x06009C75 RID: 40053 RVA: 0x000DE824 File Offset: 0x000DCA24
		static UHapticFeedbackEffect_SoundWave()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.HapticFeedbackEffect_SoundWave");
		}

		// Token: 0x06009C76 RID: 40054 RVA: 0x000DE832 File Offset: 0x000DCA32
		protected UHapticFeedbackEffect_SoundWave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005659 RID: 22105
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.HapticFeedbackEffect_SoundWave";

		// Token: 0x0400565A RID: 22106
		private static IntPtr _ClassPtr;

		// Token: 0x0400565B RID: 22107
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400565C RID: 22108
		internal static int __PropertyOffset_SoundWave;
	}
}
