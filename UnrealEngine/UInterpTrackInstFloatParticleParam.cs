using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA2 RID: 3234
	[UnrealObjectPath("/Script/Engine.InterpTrackInstFloatParticleParam")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstFloatParticleParam : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3C4 RID: 41924 RVA: 0x000E8CC3 File Offset: 0x000E6EC3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstFloatParticleParam._ClassPtr;
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x000E8CD0 File Offset: 0x000E6ED0
		public UInterpTrackInstFloatParticleParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatParticleParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x000E8CF8 File Offset: 0x000E6EF8
		[NullableContext(1)]
		public UInterpTrackInstFloatParticleParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatParticleParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x000E8D2B File Offset: 0x000E6F2B
		// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x000E8D3B File Offset: 0x000E6F3B
		public unsafe float ResetFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstFloatParticleParam.__PropertyOffset_ResetFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstFloatParticleParam.__PropertyOffset_ResetFloat) = value;
			}
		}

		// Token: 0x0600A3C9 RID: 41929 RVA: 0x000E8D4C File Offset: 0x000E6F4C
		static UInterpTrackInstFloatParticleParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstFloatParticleParam");
		}

		// Token: 0x0600A3CA RID: 41930 RVA: 0x000E8D5A File Offset: 0x000E6F5A
		protected UInterpTrackInstFloatParticleParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A03 RID: 23043
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstFloatParticleParam";

		// Token: 0x04005A04 RID: 23044
		private static IntPtr _ClassPtr;

		// Token: 0x04005A05 RID: 23045
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A06 RID: 23046
		internal static int __PropertyOffset_ResetFloat;
	}
}
