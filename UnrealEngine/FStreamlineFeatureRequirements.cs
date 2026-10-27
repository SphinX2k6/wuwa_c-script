using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C8 RID: 10440
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StreamlineBlueprint.StreamlineFeatureRequirements")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FStreamlineFeatureRequirements : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026C04 RID: 158724 RVA: 0x003B1DA8 File Offset: 0x003AFFA8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamlineFeatureRequirements._ScriptStructPtr != 0) ? FStreamlineFeatureRequirements._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/StreamlineBlueprint.StreamlineFeatureRequirements", ref FStreamlineFeatureRequirements._ScriptStructPtr);
		}

		// Token: 0x1700954B RID: 38219
		// (get) Token: 0x06026C05 RID: 158725 RVA: 0x003B1DCC File Offset: 0x003AFFCC
		// (set) Token: 0x06026C06 RID: 158726 RVA: 0x003B1DDC File Offset: 0x003AFFDC
		public unsafe EStreamlineFeatureSupport Support
		{
			get
			{
				return (EStreamlineFeatureSupport)(*(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_Support));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_Support) = (byte)value;
			}
		}

		// Token: 0x1700954C RID: 38220
		// (get) Token: 0x06026C07 RID: 158727 RVA: 0x003B1DED File Offset: 0x003AFFED
		// (set) Token: 0x06026C08 RID: 158728 RVA: 0x003B1DFD File Offset: 0x003AFFFD
		public unsafe EStreamlineFeatureRequirementsFlags Requirements
		{
			get
			{
				return (EStreamlineFeatureRequirementsFlags)(*(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_Requirements));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_Requirements) = (byte)value;
			}
		}

		// Token: 0x1700954D RID: 38221
		// (get) Token: 0x06026C09 RID: 158729 RVA: 0x003B1E10 File Offset: 0x003B0010
		// (set) Token: 0x06026C0A RID: 158730 RVA: 0x003B1E53 File Offset: 0x003B0053
		public FStreamlineVersion RequiredOperatingSystemVersion
		{
			get
			{
				base.FastCheckIsValid();
				FStreamlineVersion result;
				if ((result = this._RequiredOperatingSystemVersion) == null)
				{
					result = (this._RequiredOperatingSystemVersion = new FStreamlineVersion(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_RequiredOperatingSystemVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStreamlineVersion.StaticStruct(), base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_RequiredOperatingSystemVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700954E RID: 38222
		// (get) Token: 0x06026C0B RID: 158731 RVA: 0x003B1E74 File Offset: 0x003B0074
		// (set) Token: 0x06026C0C RID: 158732 RVA: 0x003B1EB7 File Offset: 0x003B00B7
		public FStreamlineVersion DetectedOperatingSystemVersion
		{
			get
			{
				base.FastCheckIsValid();
				FStreamlineVersion result;
				if ((result = this._DetectedOperatingSystemVersion) == null)
				{
					result = (this._DetectedOperatingSystemVersion = new FStreamlineVersion(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_DetectedOperatingSystemVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStreamlineVersion.StaticStruct(), base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_DetectedOperatingSystemVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700954F RID: 38223
		// (get) Token: 0x06026C0D RID: 158733 RVA: 0x003B1ED8 File Offset: 0x003B00D8
		// (set) Token: 0x06026C0E RID: 158734 RVA: 0x003B1F1B File Offset: 0x003B011B
		public FStreamlineVersion RequiredDriverVersion
		{
			get
			{
				base.FastCheckIsValid();
				FStreamlineVersion result;
				if ((result = this._RequiredDriverVersion) == null)
				{
					result = (this._RequiredDriverVersion = new FStreamlineVersion(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_RequiredDriverVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStreamlineVersion.StaticStruct(), base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_RequiredDriverVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009550 RID: 38224
		// (get) Token: 0x06026C0F RID: 158735 RVA: 0x003B1F3C File Offset: 0x003B013C
		// (set) Token: 0x06026C10 RID: 158736 RVA: 0x003B1F7F File Offset: 0x003B017F
		public FStreamlineVersion DetectedDriverVersion
		{
			get
			{
				base.FastCheckIsValid();
				FStreamlineVersion result;
				if ((result = this._DetectedDriverVersion) == null)
				{
					result = (this._DetectedDriverVersion = new FStreamlineVersion(base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_DetectedDriverVersion, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStreamlineVersion.StaticStruct(), base.NativePtr + (IntPtr)FStreamlineFeatureRequirements.__PropertyOffset_DetectedDriverVersion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026C11 RID: 158737 RVA: 0x003B1FA0 File Offset: 0x003B01A0
		public FStreamlineFeatureRequirements()
		{
		}

		// Token: 0x06026C12 RID: 158738 RVA: 0x003B1FA8 File Offset: 0x003B01A8
		public FStreamlineFeatureRequirements(EStreamlineFeatureSupport Support, EStreamlineFeatureRequirementsFlags Requirements, FStreamlineVersion RequiredOperatingSystemVersion, FStreamlineVersion DetectedOperatingSystemVersion, FStreamlineVersion RequiredDriverVersion, FStreamlineVersion DetectedDriverVersion)
		{
			this.Support = Support;
			this.Requirements = Requirements;
			this.RequiredOperatingSystemVersion = RequiredOperatingSystemVersion;
			this.DetectedOperatingSystemVersion = DetectedOperatingSystemVersion;
			this.RequiredDriverVersion = RequiredDriverVersion;
			this.DetectedDriverVersion = DetectedDriverVersion;
		}

		// Token: 0x06026C13 RID: 158739 RVA: 0x003B1FDD File Offset: 0x003B01DD
		protected override IntPtr GetUStructPtr()
		{
			return FStreamlineFeatureRequirements.StaticStruct();
		}

		// Token: 0x06026C14 RID: 158740 RVA: 0x003B1FE9 File Offset: 0x003B01E9
		[NullableContext(2)]
		public FStreamlineFeatureRequirements(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026C15 RID: 158741 RVA: 0x003B1FF3 File Offset: 0x003B01F3
		public FStreamlineFeatureRequirements(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026C16 RID: 158742 RVA: 0x003B1FFE File Offset: 0x003B01FE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamlineFeatureRequirements(Pointer, false, true);
		}

		// Token: 0x06026C17 RID: 158743 RVA: 0x003B2008 File Offset: 0x003B0208
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamlineFeatureRequirements(Pointer, MemoryOwner);
		}

		// Token: 0x04015453 RID: 87123
		public const string __ObjectPath = "/Script/StreamlineBlueprint.StreamlineFeatureRequirements";

		// Token: 0x04015454 RID: 87124
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015455 RID: 87125
		internal static int __PropertyOffset_Support;

		// Token: 0x04015456 RID: 87126
		internal static int __PropertyOffset_Requirements;

		// Token: 0x04015457 RID: 87127
		internal static int __PropertyOffset_RequiredOperatingSystemVersion;

		// Token: 0x04015458 RID: 87128
		[Nullable(2)]
		private FStreamlineVersion _RequiredOperatingSystemVersion;

		// Token: 0x04015459 RID: 87129
		internal static int __PropertyOffset_DetectedOperatingSystemVersion;

		// Token: 0x0401545A RID: 87130
		[Nullable(2)]
		private FStreamlineVersion _DetectedOperatingSystemVersion;

		// Token: 0x0401545B RID: 87131
		internal static int __PropertyOffset_RequiredDriverVersion;

		// Token: 0x0401545C RID: 87132
		[Nullable(2)]
		private FStreamlineVersion _RequiredDriverVersion;

		// Token: 0x0401545D RID: 87133
		internal static int __PropertyOffset_DetectedDriverVersion;

		// Token: 0x0401545E RID: 87134
		[Nullable(2)]
		private FStreamlineVersion _DetectedDriverVersion;
	}
}
