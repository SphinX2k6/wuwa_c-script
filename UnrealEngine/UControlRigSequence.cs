using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CE RID: 1230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigSequence")]
	[UnrealStructLayout(736, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 736)]
	public class UControlRigSequence : ULevelSequence, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004229 RID: 16937 RVA: 0x00062EDE File Offset: 0x000610DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigSequence._ClassPtr;
		}

		// Token: 0x0600422A RID: 16938 RVA: 0x00062EEC File Offset: 0x000610EC
		public UControlRigSequence() : this(BuiltinUtils.AllocNativeUObject(UControlRigSequence.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600422B RID: 16939 RVA: 0x00062F14 File Offset: 0x00061114
		public UControlRigSequence(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigSequence.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001018 RID: 4120
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x00062F47 File Offset: 0x00061147
		// (set) Token: 0x0600422D RID: 16941 RVA: 0x00062F5C File Offset: 0x0006115C
		public TSoftObjectPtr<UAnimSequence> LastExportedToAnimationSequence
		{
			get
			{
				return new TSoftObjectPtr<UAnimSequence>(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedToAnimationSequence, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedToAnimationSequence, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17001019 RID: 4121
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x00062F81 File Offset: 0x00061181
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x00062F96 File Offset: 0x00061196
		public TSoftObjectPtr<USkeletalMesh> LastExportedUsingSkeletalMesh
		{
			get
			{
				return new TSoftObjectPtr<USkeletalMesh>(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedUsingSkeletalMesh, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedUsingSkeletalMesh, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700101A RID: 4122
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x00062FBB File Offset: 0x000611BB
		// (set) Token: 0x06004231 RID: 16945 RVA: 0x00062FCB File Offset: 0x000611CB
		public unsafe float LastExportedFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigSequence.__PropertyOffset_LastExportedFrameRate) = value;
			}
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x00062FDC File Offset: 0x000611DC
		static UControlRigSequence()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigSequence");
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x00062FEA File Offset: 0x000611EA
		protected UControlRigSequence(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F73 RID: 8051
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigSequence";

		// Token: 0x04001F74 RID: 8052
		private static IntPtr _ClassPtr;

		// Token: 0x04001F75 RID: 8053
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F76 RID: 8054
		internal static int __PropertyOffset_LastExportedToAnimationSequence;

		// Token: 0x04001F77 RID: 8055
		internal static int __PropertyOffset_LastExportedUsingSkeletalMesh;

		// Token: 0x04001F78 RID: 8056
		internal static int __PropertyOffset_LastExportedFrameRate;
	}
}
