using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020004C9 RID: 1225
	[UnrealObjectPath("/Script/ControlRig.ControlRigIOSettings")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FControlRigIOSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060041F0 RID: 16880 RVA: 0x00062A62 File Offset: 0x00060C62
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FControlRigIOSettings._ScriptStructPtr != 0) ? FControlRigIOSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.ControlRigIOSettings", ref FControlRigIOSettings._ScriptStructPtr);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x00062A86 File Offset: 0x00060C86
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x00062A96 File Offset: 0x00060C96
		public unsafe bool bUpdatePose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigIOSettings.__PropertyOffset_bUpdatePose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigIOSettings.__PropertyOffset_bUpdatePose) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x060041F3 RID: 16883 RVA: 0x00062AA7 File Offset: 0x00060CA7
		// (set) Token: 0x060041F4 RID: 16884 RVA: 0x00062AB7 File Offset: 0x00060CB7
		public unsafe bool bUpdateCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FControlRigIOSettings.__PropertyOffset_bUpdateCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FControlRigIOSettings.__PropertyOffset_bUpdateCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x060041F5 RID: 16885 RVA: 0x00062AC8 File Offset: 0x00060CC8
		public FControlRigIOSettings()
		{
		}

		// Token: 0x060041F6 RID: 16886 RVA: 0x00062AD0 File Offset: 0x00060CD0
		public FControlRigIOSettings(bool bUpdatePose, bool bUpdateCurves)
		{
			this.bUpdatePose = bUpdatePose;
			this.bUpdateCurves = bUpdateCurves;
		}

		// Token: 0x060041F7 RID: 16887 RVA: 0x00062AE6 File Offset: 0x00060CE6
		protected override IntPtr GetUStructPtr()
		{
			return FControlRigIOSettings.StaticStruct();
		}

		// Token: 0x060041F8 RID: 16888 RVA: 0x00062AF2 File Offset: 0x00060CF2
		[NullableContext(2)]
		public FControlRigIOSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060041F9 RID: 16889 RVA: 0x00062AFC File Offset: 0x00060CFC
		public FControlRigIOSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060041FA RID: 16890 RVA: 0x00062B07 File Offset: 0x00060D07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FControlRigIOSettings(Pointer, false, true);
		}

		// Token: 0x060041FB RID: 16891 RVA: 0x00062B11 File Offset: 0x00060D11
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FControlRigIOSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001F56 RID: 8022
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.ControlRigIOSettings";

		// Token: 0x04001F57 RID: 8023
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001F58 RID: 8024
		internal static int __PropertyOffset_bUpdatePose;

		// Token: 0x04001F59 RID: 8025
		internal static int __PropertyOffset_bUpdateCurves;
	}
}
