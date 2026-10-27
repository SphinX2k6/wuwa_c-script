using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000311 RID: 785
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.BlendBoneByChannelEntry")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FBlendBoneByChannelEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D3C RID: 11580 RVA: 0x0004564A File Offset: 0x0004384A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendBoneByChannelEntry._ScriptStructPtr != 0) ? FBlendBoneByChannelEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.BlendBoneByChannelEntry", ref FBlendBoneByChannelEntry._ScriptStructPtr);
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x00045670 File Offset: 0x00043870
		// (set) Token: 0x06002D3E RID: 11582 RVA: 0x000456B3 File Offset: 0x000438B3
		public FBoneReference SourceBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._SourceBone) == null)
				{
					result = (this._SourceBone = new FBoneReference(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_SourceBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_SourceBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002D3F RID: 11583 RVA: 0x000456D4 File Offset: 0x000438D4
		// (set) Token: 0x06002D40 RID: 11584 RVA: 0x00045717 File Offset: 0x00043917
		public FBoneReference TargetBone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._TargetBone) == null)
				{
					result = (this._TargetBone = new FBoneReference(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_TargetBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_TargetBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002D41 RID: 11585 RVA: 0x00045738 File Offset: 0x00043938
		// (set) Token: 0x06002D42 RID: 11586 RVA: 0x00045748 File Offset: 0x00043948
		public unsafe bool bBlendTranslation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendTranslation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendTranslation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002D43 RID: 11587 RVA: 0x00045759 File Offset: 0x00043959
		// (set) Token: 0x06002D44 RID: 11588 RVA: 0x00045769 File Offset: 0x00043969
		public unsafe bool bBlendRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x0004577A File Offset: 0x0004397A
		// (set) Token: 0x06002D46 RID: 11590 RVA: 0x0004578A File Offset: 0x0004398A
		public unsafe bool bBlendScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendBoneByChannelEntry.__PropertyOffset_bBlendScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x0004579B File Offset: 0x0004399B
		public FBlendBoneByChannelEntry()
		{
		}

		// Token: 0x06002D48 RID: 11592 RVA: 0x000457A3 File Offset: 0x000439A3
		public FBlendBoneByChannelEntry(FBoneReference SourceBone, FBoneReference TargetBone, bool bBlendTranslation, bool bBlendRotation, bool bBlendScale)
		{
			this.SourceBone = SourceBone;
			this.TargetBone = TargetBone;
			this.bBlendTranslation = bBlendTranslation;
			this.bBlendRotation = bBlendRotation;
			this.bBlendScale = bBlendScale;
		}

		// Token: 0x06002D49 RID: 11593 RVA: 0x000457D0 File Offset: 0x000439D0
		protected override IntPtr GetUStructPtr()
		{
			return FBlendBoneByChannelEntry.StaticStruct();
		}

		// Token: 0x06002D4A RID: 11594 RVA: 0x000457DC File Offset: 0x000439DC
		[NullableContext(2)]
		public FBlendBoneByChannelEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D4B RID: 11595 RVA: 0x000457E6 File Offset: 0x000439E6
		public FBlendBoneByChannelEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D4C RID: 11596 RVA: 0x000457F1 File Offset: 0x000439F1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendBoneByChannelEntry(Pointer, false, true);
		}

		// Token: 0x06002D4D RID: 11597 RVA: 0x000457FB File Offset: 0x000439FB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendBoneByChannelEntry(Pointer, MemoryOwner);
		}

		// Token: 0x040012BF RID: 4799
		public const string __ObjectPath = "/Script/AnimGraphRuntime.BlendBoneByChannelEntry";

		// Token: 0x040012C0 RID: 4800
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012C1 RID: 4801
		internal static int __PropertyOffset_SourceBone;

		// Token: 0x040012C2 RID: 4802
		[Nullable(2)]
		private FBoneReference _SourceBone;

		// Token: 0x040012C3 RID: 4803
		internal static int __PropertyOffset_TargetBone;

		// Token: 0x040012C4 RID: 4804
		[Nullable(2)]
		private FBoneReference _TargetBone;

		// Token: 0x040012C5 RID: 4805
		internal static int __PropertyOffset_bBlendTranslation;

		// Token: 0x040012C6 RID: 4806
		internal static int __PropertyOffset_bBlendRotation;

		// Token: 0x040012C7 RID: 4807
		internal static int __PropertyOffset_bBlendScale;
	}
}
