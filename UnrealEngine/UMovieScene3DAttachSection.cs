using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002326 RID: 8998
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DAttachSection")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UMovieScene3DAttachSection : UMovieScene3DConstraintSection, IUnrealUObject, IUnrealObject, IMovieSceneEntityProvider, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060220A9 RID: 139433 RVA: 0x00325286 File Offset: 0x00323486
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DAttachSection._ClassPtr;
		}

		// Token: 0x060220AA RID: 139434 RVA: 0x00325292 File Offset: 0x00323492
		int IMovieSceneEntityProvider.InterfaceOffset()
		{
			return UMovieScene3DAttachSection.__InterfaceOffset_IMovieSceneEntityProvider;
		}

		// Token: 0x060220AB RID: 139435 RVA: 0x0032529C File Offset: 0x0032349C
		public UMovieScene3DAttachSection() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DAttachSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220AC RID: 139436 RVA: 0x003252C4 File Offset: 0x003234C4
		[NullableContext(1)]
		public UMovieScene3DAttachSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DAttachSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008381 RID: 33665
		// (get) Token: 0x060220AD RID: 139437 RVA: 0x003252F7 File Offset: 0x003234F7
		// (set) Token: 0x060220AE RID: 139438 RVA: 0x0032530B File Offset: 0x0032350B
		public unsafe FName AttachSocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachSocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachSocketName) = value;
			}
		}

		// Token: 0x17008382 RID: 33666
		// (get) Token: 0x060220AF RID: 139439 RVA: 0x00325320 File Offset: 0x00323520
		// (set) Token: 0x060220B0 RID: 139440 RVA: 0x00325334 File Offset: 0x00323534
		public unsafe FName AttachComponentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachComponentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachComponentName) = value;
			}
		}

		// Token: 0x17008383 RID: 33667
		// (get) Token: 0x060220B1 RID: 139441 RVA: 0x00325349 File Offset: 0x00323549
		// (set) Token: 0x060220B2 RID: 139442 RVA: 0x00325359 File Offset: 0x00323559
		public unsafe bool DetachRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008384 RID: 33668
		// (get) Token: 0x060220B3 RID: 139443 RVA: 0x0032536A File Offset: 0x0032356A
		// (set) Token: 0x060220B4 RID: 139444 RVA: 0x0032537A File Offset: 0x0032357A
		public unsafe bool DetachScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008385 RID: 33669
		// (get) Token: 0x060220B5 RID: 139445 RVA: 0x0032538B File Offset: 0x0032358B
		// (set) Token: 0x060220B6 RID: 139446 RVA: 0x0032539B File Offset: 0x0032359B
		public unsafe EAttachmentRule AttachmentLocationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentLocationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentLocationRule) = (byte)value;
			}
		}

		// Token: 0x17008386 RID: 33670
		// (get) Token: 0x060220B7 RID: 139447 RVA: 0x003253AC File Offset: 0x003235AC
		// (set) Token: 0x060220B8 RID: 139448 RVA: 0x003253BC File Offset: 0x003235BC
		public unsafe EAttachmentRule AttachmentRotationRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentRotationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentRotationRule) = (byte)value;
			}
		}

		// Token: 0x17008387 RID: 33671
		// (get) Token: 0x060220B9 RID: 139449 RVA: 0x003253CD File Offset: 0x003235CD
		// (set) Token: 0x060220BA RID: 139450 RVA: 0x003253DD File Offset: 0x003235DD
		public unsafe EAttachmentRule AttachmentScaleRule
		{
			get
			{
				return (EAttachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_AttachmentScaleRule) = (byte)value;
			}
		}

		// Token: 0x17008388 RID: 33672
		// (get) Token: 0x060220BB RID: 139451 RVA: 0x003253EE File Offset: 0x003235EE
		// (set) Token: 0x060220BC RID: 139452 RVA: 0x003253FE File Offset: 0x003235FE
		public unsafe EDetachmentRule DetachmentLocationRule
		{
			get
			{
				return (EDetachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentLocationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentLocationRule) = (byte)value;
			}
		}

		// Token: 0x17008389 RID: 33673
		// (get) Token: 0x060220BD RID: 139453 RVA: 0x0032540F File Offset: 0x0032360F
		// (set) Token: 0x060220BE RID: 139454 RVA: 0x0032541F File Offset: 0x0032361F
		public unsafe EDetachmentRule DetachmentRotationRule
		{
			get
			{
				return (EDetachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentRotationRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentRotationRule) = (byte)value;
			}
		}

		// Token: 0x1700838A RID: 33674
		// (get) Token: 0x060220BF RID: 139455 RVA: 0x00325430 File Offset: 0x00323630
		// (set) Token: 0x060220C0 RID: 139456 RVA: 0x00325440 File Offset: 0x00323640
		public unsafe EDetachmentRule DetachmentScaleRule
		{
			get
			{
				return (EDetachmentRule)(*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentScaleRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieScene3DAttachSection.__PropertyOffset_DetachmentScaleRule) = (byte)value;
			}
		}

		// Token: 0x060220C1 RID: 139457 RVA: 0x00325451 File Offset: 0x00323651
		static UMovieScene3DAttachSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DAttachSection");
		}

		// Token: 0x060220C2 RID: 139458 RVA: 0x0032545F File Offset: 0x0032365F
		protected UMovieScene3DAttachSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401229E RID: 74398
		internal static int __InterfaceOffset_IMovieSceneEntityProvider;

		// Token: 0x0401229F RID: 74399
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DAttachSection";

		// Token: 0x040122A0 RID: 74400
		private static IntPtr _ClassPtr;

		// Token: 0x040122A1 RID: 74401
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122A2 RID: 74402
		internal static int __PropertyOffset_AttachSocketName;

		// Token: 0x040122A3 RID: 74403
		internal static int __PropertyOffset_AttachComponentName;

		// Token: 0x040122A4 RID: 74404
		internal static int __PropertyOffset_DetachRotation;

		// Token: 0x040122A5 RID: 74405
		internal static int __PropertyOffset_DetachScale;

		// Token: 0x040122A6 RID: 74406
		internal static int __PropertyOffset_AttachmentLocationRule;

		// Token: 0x040122A7 RID: 74407
		internal static int __PropertyOffset_AttachmentRotationRule;

		// Token: 0x040122A8 RID: 74408
		internal static int __PropertyOffset_AttachmentScaleRule;

		// Token: 0x040122A9 RID: 74409
		internal static int __PropertyOffset_DetachmentLocationRule;

		// Token: 0x040122AA RID: 74410
		internal static int __PropertyOffset_DetachmentRotationRule;

		// Token: 0x040122AB RID: 74411
		internal static int __PropertyOffset_DetachmentScaleRule;
	}
}
