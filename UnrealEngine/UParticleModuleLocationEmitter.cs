using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F78 RID: 3960
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationEmitter")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UParticleModuleLocationEmitter : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D58A RID: 54666 RVA: 0x0013A1C5 File Offset: 0x001383C5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationEmitter._ClassPtr;
		}

		// Token: 0x0600D58B RID: 54667 RVA: 0x0013A1D4 File Offset: 0x001383D4
		public UParticleModuleLocationEmitter() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationEmitter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D58C RID: 54668 RVA: 0x0013A1FC File Offset: 0x001383FC
		[NullableContext(1)]
		public UParticleModuleLocationEmitter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationEmitter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600D58D RID: 54669 RVA: 0x0013A22F File Offset: 0x0013842F
		// (set) Token: 0x0600D58E RID: 54670 RVA: 0x0013A243 File Offset: 0x00138443
		public unsafe FName EmitterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_EmitterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_EmitterName) = value;
			}
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600D58F RID: 54671 RVA: 0x0013A258 File Offset: 0x00138458
		// (set) Token: 0x0600D590 RID: 54672 RVA: 0x0013A26C File Offset: 0x0013846C
		public unsafe TEnumAsByte<ELocationEmitterSelectionMethod> SelectionMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_SelectionMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_SelectionMethod) = value;
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600D591 RID: 54673 RVA: 0x0013A281 File Offset: 0x00138481
		// (set) Token: 0x0600D592 RID: 54674 RVA: 0x0013A29A File Offset: 0x0013849A
		public unsafe bool InheritSourceVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceVelocity) & UParticleModuleLocationEmitter.__PropertyMask_InheritSourceVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceVelocity) & ~UParticleModuleLocationEmitter.__PropertyMask_InheritSourceVelocity) | (value ? UParticleModuleLocationEmitter.__PropertyMask_InheritSourceVelocity : 0));
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600D593 RID: 54675 RVA: 0x0013A2CA File Offset: 0x001384CA
		// (set) Token: 0x0600D594 RID: 54676 RVA: 0x0013A2DA File Offset: 0x001384DA
		public unsafe float InheritSourceVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceVelocityScale) = value;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600D595 RID: 54677 RVA: 0x0013A2EB File Offset: 0x001384EB
		// (set) Token: 0x0600D596 RID: 54678 RVA: 0x0013A304 File Offset: 0x00138504
		public unsafe bool bInheritSourceRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_bInheritSourceRotation) & UParticleModuleLocationEmitter.__PropertyMask_bInheritSourceRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_bInheritSourceRotation) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_bInheritSourceRotation) & ~UParticleModuleLocationEmitter.__PropertyMask_bInheritSourceRotation) | (value ? UParticleModuleLocationEmitter.__PropertyMask_bInheritSourceRotation : 0));
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600D597 RID: 54679 RVA: 0x0013A334 File Offset: 0x00138534
		// (set) Token: 0x0600D598 RID: 54680 RVA: 0x0013A344 File Offset: 0x00138544
		public unsafe float InheritSourceRotationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceRotationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationEmitter.__PropertyOffset_InheritSourceRotationScale) = value;
			}
		}

		// Token: 0x0600D599 RID: 54681 RVA: 0x0013A355 File Offset: 0x00138555
		static UParticleModuleLocationEmitter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationEmitter");
		}

		// Token: 0x0600D59A RID: 54682 RVA: 0x0013A363 File Offset: 0x00138563
		protected UParticleModuleLocationEmitter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04007327 RID: 29479
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationEmitter";

		// Token: 0x04007328 RID: 29480
		private static IntPtr _ClassPtr;

		// Token: 0x04007329 RID: 29481
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400732A RID: 29482
		internal static int __PropertyOffset_EmitterName;

		// Token: 0x0400732B RID: 29483
		internal static int __PropertyOffset_SelectionMethod;

		// Token: 0x0400732C RID: 29484
		internal static int __PropertyOffset_InheritSourceVelocity;

		// Token: 0x0400732D RID: 29485
		internal static byte __PropertyMask_InheritSourceVelocity;

		// Token: 0x0400732E RID: 29486
		internal static int __PropertyOffset_InheritSourceVelocityScale;

		// Token: 0x0400732F RID: 29487
		internal static int __PropertyOffset_bInheritSourceRotation;

		// Token: 0x04007330 RID: 29488
		internal static byte __PropertyMask_bInheritSourceRotation;

		// Token: 0x04007331 RID: 29489
		internal static int __PropertyOffset_InheritSourceRotationScale;
	}
}
