using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C95 RID: 3221
	[UnrealObjectPath("/Script/Engine.InterpTrackFloatParticleParam")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UInterpTrackFloatParticleParam : UInterpTrackFloatBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A369 RID: 41833 RVA: 0x000E83FB File Offset: 0x000E65FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackFloatParticleParam._ClassPtr;
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x000E8408 File Offset: 0x000E6608
		public UInterpTrackFloatParticleParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatParticleParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x000E8430 File Offset: 0x000E6630
		[NullableContext(1)]
		public UInterpTrackFloatParticleParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackFloatParticleParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600A36C RID: 41836 RVA: 0x000E8463 File Offset: 0x000E6663
		// (set) Token: 0x0600A36D RID: 41837 RVA: 0x000E8477 File Offset: 0x000E6677
		public unsafe FName ParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackFloatParticleParam.__PropertyOffset_ParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackFloatParticleParam.__PropertyOffset_ParamName) = value;
			}
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x000E848C File Offset: 0x000E668C
		static UInterpTrackFloatParticleParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackFloatParticleParam");
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x000E849A File Offset: 0x000E669A
		protected UInterpTrackFloatParticleParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059CC RID: 22988
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackFloatParticleParam";

		// Token: 0x040059CD RID: 22989
		private static IntPtr _ClassPtr;

		// Token: 0x040059CE RID: 22990
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059CF RID: 22991
		internal static int __PropertyOffset_ParamName;
	}
}
