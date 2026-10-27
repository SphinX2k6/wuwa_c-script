using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F1 RID: 9969
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteAnimParams")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FMovieSceneQteAnimParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F91 RID: 151441 RVA: 0x0036B115 File Offset: 0x00369315
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteAnimParams._ScriptStructPtr != 0) ? FMovieSceneQteAnimParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteAnimParams", ref FMovieSceneQteAnimParams._ScriptStructPtr);
		}

		// Token: 0x17008EC3 RID: 36547
		// (get) Token: 0x06024F92 RID: 151442 RVA: 0x0036B13C File Offset: 0x0036933C
		// (set) Token: 0x06024F93 RID: 151443 RVA: 0x0036B17F File Offset: 0x0036937F
		public FMovieSceneObjectBindingID ConstraintBindingID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._ConstraintBindingID) == null)
				{
					result = (this._ConstraintBindingID = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_ConstraintBindingID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_ConstraintBindingID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008EC4 RID: 36548
		// (get) Token: 0x06024F94 RID: 151444 RVA: 0x0036B1A0 File Offset: 0x003693A0
		// (set) Token: 0x06024F95 RID: 151445 RVA: 0x0036B1B4 File Offset: 0x003693B4
		[Nullable(2)]
		public unsafe UAnimSequence StartStateLoop
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimParams.__PropertyOffset_StartStateLoop);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimParams.__PropertyOffset_StartStateLoop, value);
			}
		}

		// Token: 0x17008EC5 RID: 36549
		// (get) Token: 0x06024F96 RID: 151446 RVA: 0x0036B1C9 File Offset: 0x003693C9
		// (set) Token: 0x06024F97 RID: 151447 RVA: 0x0036B1DD File Offset: 0x003693DD
		[Nullable(2)]
		public unsafe UAnimSequence EndStateLoop
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimParams.__PropertyOffset_EndStateLoop);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteAnimParams.__PropertyOffset_EndStateLoop, value);
			}
		}

		// Token: 0x17008EC6 RID: 36550
		// (get) Token: 0x06024F98 RID: 151448 RVA: 0x0036B1F2 File Offset: 0x003693F2
		// (set) Token: 0x06024F99 RID: 151449 RVA: 0x0036B202 File Offset: 0x00369402
		public unsafe bool bUseExtraAnimParams
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_bUseExtraAnimParams) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_bUseExtraAnimParams) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008EC7 RID: 36551
		// (get) Token: 0x06024F9A RID: 151450 RVA: 0x0036B214 File Offset: 0x00369414
		// (set) Token: 0x06024F9B RID: 151451 RVA: 0x0036B257 File Offset: 0x00369457
		public FMovieSceneQteAnimExtraParams ExtraParams
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneQteAnimExtraParams result;
				if ((result = this._ExtraParams) == null)
				{
					result = (this._ExtraParams = new FMovieSceneQteAnimExtraParams(base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_ExtraParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneQteAnimExtraParams.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteAnimParams.__PropertyOffset_ExtraParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024F9C RID: 151452 RVA: 0x0036B278 File Offset: 0x00369478
		public FMovieSceneQteAnimParams()
		{
		}

		// Token: 0x06024F9D RID: 151453 RVA: 0x0036B280 File Offset: 0x00369480
		public FMovieSceneQteAnimParams(FMovieSceneObjectBindingID ConstraintBindingID, UAnimSequence StartStateLoop, UAnimSequence EndStateLoop, bool bUseExtraAnimParams, FMovieSceneQteAnimExtraParams ExtraParams)
		{
			this.ConstraintBindingID = ConstraintBindingID;
			this.StartStateLoop = StartStateLoop;
			this.EndStateLoop = EndStateLoop;
			this.bUseExtraAnimParams = bUseExtraAnimParams;
			this.ExtraParams = ExtraParams;
		}

		// Token: 0x06024F9E RID: 151454 RVA: 0x0036B2AD File Offset: 0x003694AD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteAnimParams.StaticStruct();
		}

		// Token: 0x06024F9F RID: 151455 RVA: 0x0036B2B9 File Offset: 0x003694B9
		[NullableContext(2)]
		public FMovieSceneQteAnimParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024FA0 RID: 151456 RVA: 0x0036B2C3 File Offset: 0x003694C3
		public FMovieSceneQteAnimParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024FA1 RID: 151457 RVA: 0x0036B2CE File Offset: 0x003694CE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteAnimParams(Pointer, false, true);
		}

		// Token: 0x06024FA2 RID: 151458 RVA: 0x0036B2D8 File Offset: 0x003694D8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteAnimParams(Pointer, MemoryOwner);
		}

		// Token: 0x04013ECA RID: 81610
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteAnimParams";

		// Token: 0x04013ECB RID: 81611
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013ECC RID: 81612
		internal static int __PropertyOffset_ConstraintBindingID;

		// Token: 0x04013ECD RID: 81613
		[Nullable(2)]
		private FMovieSceneObjectBindingID _ConstraintBindingID;

		// Token: 0x04013ECE RID: 81614
		internal static int __PropertyOffset_StartStateLoop;

		// Token: 0x04013ECF RID: 81615
		internal static int __PropertyOffset_EndStateLoop;

		// Token: 0x04013ED0 RID: 81616
		internal static int __PropertyOffset_bUseExtraAnimParams;

		// Token: 0x04013ED1 RID: 81617
		internal static int __PropertyOffset_ExtraParams;

		// Token: 0x04013ED2 RID: 81618
		[Nullable(2)]
		private FMovieSceneQteAnimExtraParams _ExtraParams;
	}
}
