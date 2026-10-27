using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C0B RID: 7179
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimAnimInfo")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNdiKuroAnimAnimInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BB2C RID: 113452 RVA: 0x0028C4DA File Offset: 0x0028A6DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNdiKuroAnimAnimInfo._ScriptStructPtr != 0) ? FNdiKuroAnimAnimInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimAnimInfo", ref FNdiKuroAnimAnimInfo._ScriptStructPtr);
		}

		// Token: 0x17006FB6 RID: 28598
		// (get) Token: 0x0601BB2D RID: 113453 RVA: 0x0028C4FE File Offset: 0x0028A6FE
		// (set) Token: 0x0601BB2E RID: 113454 RVA: 0x0028C512 File Offset: 0x0028A712
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17006FB7 RID: 28599
		// (get) Token: 0x0601BB2F RID: 113455 RVA: 0x0028C527 File Offset: 0x0028A727
		// (set) Token: 0x0601BB30 RID: 113456 RVA: 0x0028C537 File Offset: 0x0028A737
		public unsafe int AnimTotalFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_AnimTotalFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_AnimTotalFrames) = value;
			}
		}

		// Token: 0x17006FB8 RID: 28600
		// (get) Token: 0x0601BB31 RID: 113457 RVA: 0x0028C548 File Offset: 0x0028A748
		// (set) Token: 0x0601BB32 RID: 113458 RVA: 0x0028C558 File Offset: 0x0028A758
		public unsafe int VatTextureIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_VatTextureIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_VatTextureIndex) = value;
			}
		}

		// Token: 0x17006FB9 RID: 28601
		// (get) Token: 0x0601BB33 RID: 113459 RVA: 0x0028C569 File Offset: 0x0028A769
		// (set) Token: 0x0601BB34 RID: 113460 RVA: 0x0028C579 File Offset: 0x0028A779
		public unsafe int RootMotionIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_RootMotionIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNdiKuroAnimAnimInfo.__PropertyOffset_RootMotionIndex) = value;
			}
		}

		// Token: 0x0601BB35 RID: 113461 RVA: 0x0028C58A File Offset: 0x0028A78A
		public FNdiKuroAnimAnimInfo()
		{
		}

		// Token: 0x0601BB36 RID: 113462 RVA: 0x0028C592 File Offset: 0x0028A792
		public FNdiKuroAnimAnimInfo(FName Name, int AnimTotalFrames, int VatTextureIndex, int RootMotionIndex)
		{
			this.Name = Name;
			this.AnimTotalFrames = AnimTotalFrames;
			this.VatTextureIndex = VatTextureIndex;
			this.RootMotionIndex = RootMotionIndex;
		}

		// Token: 0x0601BB37 RID: 113463 RVA: 0x0028C5B7 File Offset: 0x0028A7B7
		protected override IntPtr GetUStructPtr()
		{
			return FNdiKuroAnimAnimInfo.StaticStruct();
		}

		// Token: 0x0601BB38 RID: 113464 RVA: 0x0028C5C3 File Offset: 0x0028A7C3
		[NullableContext(2)]
		public FNdiKuroAnimAnimInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BB39 RID: 113465 RVA: 0x0028C5CD File Offset: 0x0028A7CD
		public FNdiKuroAnimAnimInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BB3A RID: 113466 RVA: 0x0028C5D8 File Offset: 0x0028A7D8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNdiKuroAnimAnimInfo(Pointer, false, true);
		}

		// Token: 0x0601BB3B RID: 113467 RVA: 0x0028C5E2 File Offset: 0x0028A7E2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNdiKuroAnimAnimInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400EE5B RID: 61019
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.NdiKuroAnimAnimInfo";

		// Token: 0x0400EE5C RID: 61020
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EE5D RID: 61021
		internal static int __PropertyOffset_Name;

		// Token: 0x0400EE5E RID: 61022
		internal static int __PropertyOffset_AnimTotalFrames;

		// Token: 0x0400EE5F RID: 61023
		internal static int __PropertyOffset_VatTextureIndex;

		// Token: 0x0400EE60 RID: 61024
		internal static int __PropertyOffset_RootMotionIndex;
	}
}
