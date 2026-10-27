using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000F76 RID: 3958
	[UnrealObjectPath("/Script/Engine.ParticleModuleLocationBoneSocket")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UParticleModuleLocationBoneSocket : UParticleModuleLocationBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600D564 RID: 54628 RVA: 0x00139D49 File Offset: 0x00137F49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UParticleModuleLocationBoneSocket._ClassPtr;
		}

		// Token: 0x0600D565 RID: 54629 RVA: 0x00139D58 File Offset: 0x00137F58
		public UParticleModuleLocationBoneSocket() : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationBoneSocket.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600D566 RID: 54630 RVA: 0x00139D80 File Offset: 0x00137F80
		[NullableContext(1)]
		public UParticleModuleLocationBoneSocket(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UParticleModuleLocationBoneSocket.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600D567 RID: 54631 RVA: 0x00139DB3 File Offset: 0x00137FB3
		// (set) Token: 0x0600D568 RID: 54632 RVA: 0x00139DC7 File Offset: 0x00137FC7
		public unsafe TEnumAsByte<ELocationBoneSocketSource> SourceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SourceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SourceType) = value;
			}
		}

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600D569 RID: 54633 RVA: 0x00139DDC File Offset: 0x00137FDC
		// (set) Token: 0x0600D56A RID: 54634 RVA: 0x00139DF0 File Offset: 0x00137FF0
		public unsafe FVector UniversalOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_UniversalOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_UniversalOffset) = value;
			}
		}

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600D56B RID: 54635 RVA: 0x00139E08 File Offset: 0x00138008
		// (set) Token: 0x0600D56C RID: 54636 RVA: 0x00139E41 File Offset: 0x00138041
		[Nullable(1)]
		public TArray<FLocationBoneSocketInfo> SourceLocations
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLocationBoneSocketInfo> result;
				if ((result = this._SourceLocations) == null)
				{
					result = (this._SourceLocations = new TArray<FLocationBoneSocketInfo>(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SourceLocations, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SourceLocations.CopyAssign(value);
			}
		}

		// Token: 0x17003212 RID: 12818
		// (get) Token: 0x0600D56D RID: 54637 RVA: 0x00139E4F File Offset: 0x0013804F
		// (set) Token: 0x0600D56E RID: 54638 RVA: 0x00139E63 File Offset: 0x00138063
		public unsafe TEnumAsByte<ELocationBoneSocketSelectionMethod> SelectionMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SelectionMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SelectionMethod) = value;
			}
		}

		// Token: 0x17003213 RID: 12819
		// (get) Token: 0x0600D56F RID: 54639 RVA: 0x00139E78 File Offset: 0x00138078
		// (set) Token: 0x0600D570 RID: 54640 RVA: 0x00139E91 File Offset: 0x00138091
		public unsafe bool bUpdatePositionEachFrame
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bUpdatePositionEachFrame) & UParticleModuleLocationBoneSocket.__PropertyMask_bUpdatePositionEachFrame) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bUpdatePositionEachFrame) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bUpdatePositionEachFrame) & ~UParticleModuleLocationBoneSocket.__PropertyMask_bUpdatePositionEachFrame) | (value ? UParticleModuleLocationBoneSocket.__PropertyMask_bUpdatePositionEachFrame : 0));
			}
		}

		// Token: 0x17003214 RID: 12820
		// (get) Token: 0x0600D571 RID: 54641 RVA: 0x00139EC1 File Offset: 0x001380C1
		// (set) Token: 0x0600D572 RID: 54642 RVA: 0x00139EDA File Offset: 0x001380DA
		public unsafe bool bOrientMeshEmitters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bOrientMeshEmitters) & UParticleModuleLocationBoneSocket.__PropertyMask_bOrientMeshEmitters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bOrientMeshEmitters) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bOrientMeshEmitters) & ~UParticleModuleLocationBoneSocket.__PropertyMask_bOrientMeshEmitters) | (value ? UParticleModuleLocationBoneSocket.__PropertyMask_bOrientMeshEmitters : 0));
			}
		}

		// Token: 0x17003215 RID: 12821
		// (get) Token: 0x0600D573 RID: 54643 RVA: 0x00139F0A File Offset: 0x0013810A
		// (set) Token: 0x0600D574 RID: 54644 RVA: 0x00139F23 File Offset: 0x00138123
		public unsafe bool bInheritBoneVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bInheritBoneVelocity) & UParticleModuleLocationBoneSocket.__PropertyMask_bInheritBoneVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bInheritBoneVelocity) = ((*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_bInheritBoneVelocity) & ~UParticleModuleLocationBoneSocket.__PropertyMask_bInheritBoneVelocity) | (value ? UParticleModuleLocationBoneSocket.__PropertyMask_bInheritBoneVelocity : 0));
			}
		}

		// Token: 0x17003216 RID: 12822
		// (get) Token: 0x0600D575 RID: 54645 RVA: 0x00139F53 File Offset: 0x00138153
		// (set) Token: 0x0600D576 RID: 54646 RVA: 0x00139F63 File Offset: 0x00138163
		public unsafe float InheritVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_InheritVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_InheritVelocityScale) = value;
			}
		}

		// Token: 0x17003217 RID: 12823
		// (get) Token: 0x0600D577 RID: 54647 RVA: 0x00139F74 File Offset: 0x00138174
		// (set) Token: 0x0600D578 RID: 54648 RVA: 0x00139F88 File Offset: 0x00138188
		public unsafe FName SkelMeshActorParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SkelMeshActorParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_SkelMeshActorParamName) = value;
			}
		}

		// Token: 0x17003218 RID: 12824
		// (get) Token: 0x0600D579 RID: 54649 RVA: 0x00139F9D File Offset: 0x0013819D
		// (set) Token: 0x0600D57A RID: 54650 RVA: 0x00139FAD File Offset: 0x001381AD
		public unsafe int NumPreSelectedIndices
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_NumPreSelectedIndices);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UParticleModuleLocationBoneSocket.__PropertyOffset_NumPreSelectedIndices) = value;
			}
		}

		// Token: 0x0600D57B RID: 54651 RVA: 0x00139FBE File Offset: 0x001381BE
		static UParticleModuleLocationBoneSocket()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ParticleModuleLocationBoneSocket");
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x00139FCC File Offset: 0x001381CC
		protected UParticleModuleLocationBoneSocket(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400730B RID: 29451
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ParticleModuleLocationBoneSocket";

		// Token: 0x0400730C RID: 29452
		private static IntPtr _ClassPtr;

		// Token: 0x0400730D RID: 29453
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400730E RID: 29454
		internal static int __PropertyOffset_SourceType;

		// Token: 0x0400730F RID: 29455
		internal static int __PropertyOffset_UniversalOffset;

		// Token: 0x04007310 RID: 29456
		internal static int __PropertyOffset_SourceLocations;

		// Token: 0x04007311 RID: 29457
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLocationBoneSocketInfo> _SourceLocations;

		// Token: 0x04007312 RID: 29458
		internal static int __PropertyOffset_SelectionMethod;

		// Token: 0x04007313 RID: 29459
		internal static int __PropertyOffset_bUpdatePositionEachFrame;

		// Token: 0x04007314 RID: 29460
		internal static byte __PropertyMask_bUpdatePositionEachFrame;

		// Token: 0x04007315 RID: 29461
		internal static int __PropertyOffset_bOrientMeshEmitters;

		// Token: 0x04007316 RID: 29462
		internal static byte __PropertyMask_bOrientMeshEmitters;

		// Token: 0x04007317 RID: 29463
		internal static int __PropertyOffset_bInheritBoneVelocity;

		// Token: 0x04007318 RID: 29464
		internal static byte __PropertyMask_bInheritBoneVelocity;

		// Token: 0x04007319 RID: 29465
		internal static int __PropertyOffset_InheritVelocityScale;

		// Token: 0x0400731A RID: 29466
		internal static int __PropertyOffset_SkelMeshActorParamName;

		// Token: 0x0400731B RID: 29467
		internal static int __PropertyOffset_NumPreSelectedIndices;
	}
}
