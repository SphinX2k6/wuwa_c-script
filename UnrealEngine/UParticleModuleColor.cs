using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F60 RID: 3936
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParticleModuleColor")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UParticleModuleColor : UParticleModuleColorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D49E RID: 54430 RVA: 0x00138658 File Offset: 0x00136858
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleColor._ClassPtr;
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x00138664 File Offset: 0x00136864
		public UParticleModuleColor() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x0013868C File Offset: 0x0013688C
		public UParticleModuleColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600D4A1 RID: 54433 RVA: 0x001386C0 File Offset: 0x001368C0
		// (set) Token: 0x0600D4A2 RID: 54434 RVA: 0x001386F9 File Offset: 0x001368F9
		public FRawDistributionVector StartColor
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionVector result;
				if ((result = this._StartColor) == null)
				{
					result = (this._StartColor = new FRawDistributionVector(base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_StartColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionVector.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_StartColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600D4A3 RID: 54435 RVA: 0x0013871C File Offset: 0x0013691C
		// (set) Token: 0x0600D4A4 RID: 54436 RVA: 0x00138755 File Offset: 0x00136955
		public FRawDistributionFloat StartAlpha
		{
			get
			{
				base.FastCheckIsValid();
				FRawDistributionFloat result;
				if ((result = this._StartAlpha) == null)
				{
					result = (this._StartAlpha = new FRawDistributionFloat(base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_StartAlpha, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRawDistributionFloat.StaticStruct(), base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_StartAlpha, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600D4A5 RID: 54437 RVA: 0x00138776 File Offset: 0x00136976
		// (set) Token: 0x0600D4A6 RID: 54438 RVA: 0x0013878F File Offset: 0x0013698F
		public unsafe bool bClampAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_bClampAlpha) & UParticleModuleColor.__PropertyMask_bClampAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_bClampAlpha) = ((*(base.NativePtr + (IntPtr)UParticleModuleColor.__PropertyOffset_bClampAlpha) & ~UParticleModuleColor.__PropertyMask_bClampAlpha) | (value ? UParticleModuleColor.__PropertyMask_bClampAlpha : 0));
			}
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x001387BF File Offset: 0x001369BF
		static UParticleModuleColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleColor");
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x001387CD File Offset: 0x001369CD
		protected UParticleModuleColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007274 RID: 29300
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleColor";

		// Token: 0x04007275 RID: 29301
		private static IntPtr _ClassPtr;

		// Token: 0x04007276 RID: 29302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04007277 RID: 29303
		internal static int __PropertyOffset_StartColor;

		// Token: 0x04007278 RID: 29304
		[Nullable(2)]
		private FRawDistributionVector _StartColor;

		// Token: 0x04007279 RID: 29305
		internal static int __PropertyOffset_StartAlpha;

		// Token: 0x0400727A RID: 29306
		[Nullable(2)]
		private FRawDistributionFloat _StartAlpha;

		// Token: 0x0400727B RID: 29307
		internal static int __PropertyOffset_bClampAlpha;

		// Token: 0x0400727C RID: 29308
		internal static byte __PropertyMask_bClampAlpha;
	}
}
