using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FC8 RID: 4040
	[UnrealObjectPath("/Script/Engine.ParticleSystemReplay")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UParticleSystemReplay : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DA03 RID: 55811 RVA: 0x00141CE1 File Offset: 0x0013FEE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleSystemReplay._ClassPtr;
		}

		// Token: 0x0600DA04 RID: 55812 RVA: 0x00141CF0 File Offset: 0x0013FEF0
		public UParticleSystemReplay() : this(BuiltinUtils.AllocNativeUObject(UParticleSystemReplay.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DA05 RID: 55813 RVA: 0x00141D18 File Offset: 0x0013FF18
		[NullableContext(1)]
		public UParticleSystemReplay(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleSystemReplay.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700337A RID: 13178
		// (get) Token: 0x0600DA06 RID: 55814 RVA: 0x00141D4B File Offset: 0x0013FF4B
		// (set) Token: 0x0600DA07 RID: 55815 RVA: 0x00141D5B File Offset: 0x0013FF5B
		public unsafe int ClipIDNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleSystemReplay.__PropertyOffset_ClipIDNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleSystemReplay.__PropertyOffset_ClipIDNumber) = value;
			}
		}

		// Token: 0x0600DA08 RID: 55816 RVA: 0x00141D6C File Offset: 0x0013FF6C
		static UParticleSystemReplay()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleSystemReplay");
		}

		// Token: 0x0600DA09 RID: 55817 RVA: 0x00141D7A File Offset: 0x0013FF7A
		protected UParticleSystemReplay(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007637 RID: 30263
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleSystemReplay";

		// Token: 0x04007638 RID: 30264
		private static IntPtr _ClassPtr;

		// Token: 0x04007639 RID: 30265
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400763A RID: 30266
		internal static int __PropertyOffset_ClipIDNumber;
	}
}
