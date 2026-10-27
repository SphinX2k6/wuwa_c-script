using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200109C RID: 4252
	[UnrealObjectPath("/Script/Engine.RootMotionExtractionStep")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRootMotionExtractionStep : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F2FA RID: 62202 RVA: 0x0016864A File Offset: 0x0016684A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRootMotionExtractionStep._ScriptStructPtr != 0) ? FRootMotionExtractionStep._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RootMotionExtractionStep", ref FRootMotionExtractionStep._ScriptStructPtr);
		}

		// Token: 0x17003B2B RID: 15147
		// (get) Token: 0x0600F2FB RID: 62203 RVA: 0x0016866E File Offset: 0x0016686E
		// (set) Token: 0x0600F2FC RID: 62204 RVA: 0x00168682 File Offset: 0x00166882
		[Nullable(2)]
		public unsafe UAnimSequence AnimSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionExtractionStep.__PropertyOffset_AnimSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRootMotionExtractionStep.__PropertyOffset_AnimSequence, value);
			}
		}

		// Token: 0x17003B2C RID: 15148
		// (get) Token: 0x0600F2FD RID: 62205 RVA: 0x00168697 File Offset: 0x00166897
		// (set) Token: 0x0600F2FE RID: 62206 RVA: 0x001686A7 File Offset: 0x001668A7
		public unsafe float StartPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionExtractionStep.__PropertyOffset_StartPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionExtractionStep.__PropertyOffset_StartPosition) = value;
			}
		}

		// Token: 0x17003B2D RID: 15149
		// (get) Token: 0x0600F2FF RID: 62207 RVA: 0x001686B8 File Offset: 0x001668B8
		// (set) Token: 0x0600F300 RID: 62208 RVA: 0x001686C8 File Offset: 0x001668C8
		public unsafe float EndPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRootMotionExtractionStep.__PropertyOffset_EndPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRootMotionExtractionStep.__PropertyOffset_EndPosition) = value;
			}
		}

		// Token: 0x0600F301 RID: 62209 RVA: 0x001686D9 File Offset: 0x001668D9
		public FRootMotionExtractionStep()
		{
		}

		// Token: 0x0600F302 RID: 62210 RVA: 0x001686E1 File Offset: 0x001668E1
		[NullableContext(1)]
		public FRootMotionExtractionStep(UAnimSequence AnimSequence, float StartPosition, float EndPosition)
		{
			this.AnimSequence = AnimSequence;
			this.StartPosition = StartPosition;
			this.EndPosition = EndPosition;
		}

		// Token: 0x0600F303 RID: 62211 RVA: 0x001686FE File Offset: 0x001668FE
		protected override IntPtr GetUStructPtr()
		{
			return FRootMotionExtractionStep.StaticStruct();
		}

		// Token: 0x0600F304 RID: 62212 RVA: 0x0016870A File Offset: 0x0016690A
		[NullableContext(2)]
		public FRootMotionExtractionStep(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F305 RID: 62213 RVA: 0x00168714 File Offset: 0x00166914
		public FRootMotionExtractionStep(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F306 RID: 62214 RVA: 0x0016871F File Offset: 0x0016691F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRootMotionExtractionStep(Pointer, false, true);
		}

		// Token: 0x0600F307 RID: 62215 RVA: 0x00168729 File Offset: 0x00166929
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRootMotionExtractionStep(Pointer, MemoryOwner);
		}

		// Token: 0x040083CA RID: 33738
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RootMotionExtractionStep";

		// Token: 0x040083CB RID: 33739
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040083CC RID: 33740
		internal static int __PropertyOffset_AnimSequence;

		// Token: 0x040083CD RID: 33741
		internal static int __PropertyOffset_StartPosition;

		// Token: 0x040083CE RID: 33742
		internal static int __PropertyOffset_EndPosition;
	}
}
