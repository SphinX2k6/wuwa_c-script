using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000529 RID: 1321
	[UnrealObjectPath("/Script/ControlRig.RigMirrorSettings")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigMirrorSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004535 RID: 17717 RVA: 0x000670E3 File Offset: 0x000652E3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigMirrorSettings._ScriptStructPtr != 0) ? FRigMirrorSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigMirrorSettings", ref FRigMirrorSettings._ScriptStructPtr);
		}

		// Token: 0x170010CA RID: 4298
		// (get) Token: 0x06004536 RID: 17718 RVA: 0x00067107 File Offset: 0x00065307
		// (set) Token: 0x06004537 RID: 17719 RVA: 0x0006711B File Offset: 0x0006531B
		public unsafe TEnumAsByte<EAxis> MirrorAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigMirrorSettings.__PropertyOffset_MirrorAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigMirrorSettings.__PropertyOffset_MirrorAxis) = value;
			}
		}

		// Token: 0x170010CB RID: 4299
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x00067130 File Offset: 0x00065330
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x00067144 File Offset: 0x00065344
		public unsafe TEnumAsByte<EAxis> AxisToFlip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigMirrorSettings.__PropertyOffset_AxisToFlip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigMirrorSettings.__PropertyOffset_AxisToFlip) = value;
			}
		}

		// Token: 0x170010CC RID: 4300
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x00067159 File Offset: 0x00065359
		// (set) Token: 0x0600453B RID: 17723 RVA: 0x0006716D File Offset: 0x0006536D
		[Nullable(1)]
		public unsafe string OldName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigMirrorSettings.__PropertyOffset_OldName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigMirrorSettings.__PropertyOffset_OldName)), value);
			}
		}

		// Token: 0x170010CD RID: 4301
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x00067182 File Offset: 0x00065382
		// (set) Token: 0x0600453D RID: 17725 RVA: 0x00067196 File Offset: 0x00065396
		[Nullable(1)]
		public unsafe string NewName
		{
			[NullableContext(1)]
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FRigMirrorSettings.__PropertyOffset_NewName)));
			}
			[NullableContext(1)]
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FRigMirrorSettings.__PropertyOffset_NewName)), value);
			}
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x000671AB File Offset: 0x000653AB
		public FRigMirrorSettings()
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x000671B3 File Offset: 0x000653B3
		public FRigMirrorSettings(TEnumAsByte<EAxis> MirrorAxis, TEnumAsByte<EAxis> AxisToFlip, [Nullable(1)] string OldName, [Nullable(1)] string NewName)
		{
			this.MirrorAxis = MirrorAxis;
			this.AxisToFlip = AxisToFlip;
			this.OldName = OldName;
			this.NewName = NewName;
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x000671D8 File Offset: 0x000653D8
		protected override IntPtr GetUStructPtr()
		{
			return FRigMirrorSettings.StaticStruct();
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x000671E4 File Offset: 0x000653E4
		[NullableContext(2)]
		public FRigMirrorSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x000671EE File Offset: 0x000653EE
		public FRigMirrorSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x000671F9 File Offset: 0x000653F9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigMirrorSettings(Pointer, false, true);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00067203 File Offset: 0x00065403
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigMirrorSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040021B7 RID: 8631
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigMirrorSettings";

		// Token: 0x040021B8 RID: 8632
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021B9 RID: 8633
		internal static int __PropertyOffset_MirrorAxis;

		// Token: 0x040021BA RID: 8634
		internal static int __PropertyOffset_AxisToFlip;

		// Token: 0x040021BB RID: 8635
		internal static int __PropertyOffset_OldName;

		// Token: 0x040021BC RID: 8636
		internal static int __PropertyOffset_NewName;
	}
}
