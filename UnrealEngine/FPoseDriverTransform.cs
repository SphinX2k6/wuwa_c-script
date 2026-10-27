using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000338 RID: 824
	[UnrealObjectPath("/Script/AnimGraphRuntime.PoseDriverTransform")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPoseDriverTransform : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002DE5 RID: 11749 RVA: 0x000467AC File Offset: 0x000449AC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseDriverTransform._ScriptStructPtr != 0) ? FPoseDriverTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.PoseDriverTransform", ref FPoseDriverTransform._ScriptStructPtr);
		}

		// Token: 0x17000B5E RID: 2910
		// (get) Token: 0x06002DE6 RID: 11750 RVA: 0x000467D0 File Offset: 0x000449D0
		// (set) Token: 0x06002DE7 RID: 11751 RVA: 0x000467E4 File Offset: 0x000449E4
		public unsafe FVector TargetTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTransform.__PropertyOffset_TargetTranslation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTransform.__PropertyOffset_TargetTranslation) = value;
			}
		}

		// Token: 0x17000B5F RID: 2911
		// (get) Token: 0x06002DE8 RID: 11752 RVA: 0x000467F9 File Offset: 0x000449F9
		// (set) Token: 0x06002DE9 RID: 11753 RVA: 0x0004680D File Offset: 0x00044A0D
		public unsafe FRotator TargetRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseDriverTransform.__PropertyOffset_TargetRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseDriverTransform.__PropertyOffset_TargetRotation) = value;
			}
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00046822 File Offset: 0x00044A22
		public FPoseDriverTransform()
		{
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x0004682A File Offset: 0x00044A2A
		public FPoseDriverTransform(FVector TargetTranslation, FRotator TargetRotation)
		{
			this.TargetTranslation = TargetTranslation;
			this.TargetRotation = TargetRotation;
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x00046840 File Offset: 0x00044A40
		protected override IntPtr GetUStructPtr()
		{
			return FPoseDriverTransform.StaticStruct();
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x0004684C File Offset: 0x00044A4C
		[NullableContext(2)]
		public FPoseDriverTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00046856 File Offset: 0x00044A56
		public FPoseDriverTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x00046861 File Offset: 0x00044A61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseDriverTransform(Pointer, false, true);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x0004686B File Offset: 0x00044A6B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseDriverTransform(Pointer, MemoryOwner);
		}

		// Token: 0x040013AB RID: 5035
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AnimGraphRuntime.PoseDriverTransform";

		// Token: 0x040013AC RID: 5036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040013AD RID: 5037
		internal static int __PropertyOffset_TargetTranslation;

		// Token: 0x040013AE RID: 5038
		internal static int __PropertyOffset_TargetRotation;
	}
}
