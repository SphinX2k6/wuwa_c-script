using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001FD1 RID: 8145
	[UnrealObjectPath("/Script/LGUI.CircleClipParameters")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FCircleClipParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601EE5A RID: 126554 RVA: 0x002DEB2B File Offset: 0x002DCD2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCircleClipParameters._ScriptStructPtr != 0) ? FCircleClipParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.CircleClipParameters", ref FCircleClipParameters._ScriptStructPtr);
		}

		// Token: 0x17007AF0 RID: 31472
		// (get) Token: 0x0601EE5B RID: 126555 RVA: 0x002DEB4F File Offset: 0x002DCD4F
		// (set) Token: 0x0601EE5C RID: 126556 RVA: 0x002DEB5F File Offset: 0x002DCD5F
		public unsafe float ClipTextureHideThreshhold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipTextureHideThreshhold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipTextureHideThreshhold) = value;
			}
		}

		// Token: 0x17007AF1 RID: 31473
		// (get) Token: 0x0601EE5D RID: 126557 RVA: 0x002DEB70 File Offset: 0x002DCD70
		// (set) Token: 0x0601EE5E RID: 126558 RVA: 0x002DEB80 File Offset: 0x002DCD80
		public unsafe float ClipTextureHideFeather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipTextureHideFeather);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipTextureHideFeather) = value;
			}
		}

		// Token: 0x17007AF2 RID: 31474
		// (get) Token: 0x0601EE5F RID: 126559 RVA: 0x002DEB91 File Offset: 0x002DCD91
		// (set) Token: 0x0601EE60 RID: 126560 RVA: 0x002DEBA1 File Offset: 0x002DCDA1
		public unsafe float ClipAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_ClipAngle) = value;
			}
		}

		// Token: 0x17007AF3 RID: 31475
		// (get) Token: 0x0601EE61 RID: 126561 RVA: 0x002DEBB2 File Offset: 0x002DCDB2
		// (set) Token: 0x0601EE62 RID: 126562 RVA: 0x002DEBC2 File Offset: 0x002DCDC2
		public unsafe bool UseTwoWayClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_UseTwoWayClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCircleClipParameters.__PropertyOffset_UseTwoWayClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601EE63 RID: 126563 RVA: 0x002DEBD3 File Offset: 0x002DCDD3
		public FCircleClipParameters()
		{
		}

		// Token: 0x0601EE64 RID: 126564 RVA: 0x002DEBDB File Offset: 0x002DCDDB
		public FCircleClipParameters(float ClipTextureHideThreshhold, float ClipTextureHideFeather, float ClipAngle, bool UseTwoWayClip)
		{
			this.ClipTextureHideThreshhold = ClipTextureHideThreshhold;
			this.ClipTextureHideFeather = ClipTextureHideFeather;
			this.ClipAngle = ClipAngle;
			this.UseTwoWayClip = UseTwoWayClip;
		}

		// Token: 0x0601EE65 RID: 126565 RVA: 0x002DEC00 File Offset: 0x002DCE00
		protected override IntPtr GetUStructPtr()
		{
			return FCircleClipParameters.StaticStruct();
		}

		// Token: 0x0601EE66 RID: 126566 RVA: 0x002DEC0C File Offset: 0x002DCE0C
		[NullableContext(2)]
		public FCircleClipParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601EE67 RID: 126567 RVA: 0x002DEC16 File Offset: 0x002DCE16
		public FCircleClipParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601EE68 RID: 126568 RVA: 0x002DEC21 File Offset: 0x002DCE21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCircleClipParameters(Pointer, false, true);
		}

		// Token: 0x0601EE69 RID: 126569 RVA: 0x002DEC2B File Offset: 0x002DCE2B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCircleClipParameters(Pointer, MemoryOwner);
		}

		// Token: 0x04010B07 RID: 68359
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.CircleClipParameters";

		// Token: 0x04010B08 RID: 68360
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04010B09 RID: 68361
		internal static int __PropertyOffset_ClipTextureHideThreshhold;

		// Token: 0x04010B0A RID: 68362
		internal static int __PropertyOffset_ClipTextureHideFeather;

		// Token: 0x04010B0B RID: 68363
		internal static int __PropertyOffset_ClipAngle;

		// Token: 0x04010B0C RID: 68364
		internal static int __PropertyOffset_UseTwoWayClip;
	}
}
