using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023BF RID: 9151
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.TransformParameterNameAndCurves")]
	[UnrealStructLayout(1456, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1456)]
	public class FTransformParameterNameAndCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226E4 RID: 141028 RVA: 0x0032EADE File Offset: 0x0032CCDE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformParameterNameAndCurves._ScriptStructPtr != 0) ? FTransformParameterNameAndCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.TransformParameterNameAndCurves", ref FTransformParameterNameAndCurves._ScriptStructPtr);
		}

		// Token: 0x170084A0 RID: 33952
		// (get) Token: 0x060226E5 RID: 141029 RVA: 0x0032EB02 File Offset: 0x0032CD02
		// (set) Token: 0x060226E6 RID: 141030 RVA: 0x0032EB16 File Offset: 0x0032CD16
		public unsafe FName ParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformParameterNameAndCurves.__PropertyOffset_ParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformParameterNameAndCurves.__PropertyOffset_ParameterName) = value;
			}
		}

		// Token: 0x170084A1 RID: 33953
		// (get) Token: 0x060226E7 RID: 141031 RVA: 0x0032EB2C File Offset: 0x0032CD2C
		// (set) Token: 0x060226E8 RID: 141032 RVA: 0x0032EB70 File Offset: 0x0032CD70
		public TFixedArray<FMovieSceneFloatChannel> Translation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Translation) == null)
				{
					result = (this._Translation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FTransformParameterNameAndCurves.__PropertyOffset_Translation, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Translation.CopyAssign(value);
			}
		}

		// Token: 0x170084A2 RID: 33954
		// (get) Token: 0x060226E9 RID: 141033 RVA: 0x0032EB80 File Offset: 0x0032CD80
		// (set) Token: 0x060226EA RID: 141034 RVA: 0x0032EBC4 File Offset: 0x0032CDC4
		public TFixedArray<FMovieSceneFloatChannel> Rotation
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FTransformParameterNameAndCurves.__PropertyOffset_Rotation, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Rotation.CopyAssign(value);
			}
		}

		// Token: 0x170084A3 RID: 33955
		// (get) Token: 0x060226EB RID: 141035 RVA: 0x0032EBD4 File Offset: 0x0032CDD4
		// (set) Token: 0x060226EC RID: 141036 RVA: 0x0032EC18 File Offset: 0x0032CE18
		public TFixedArray<FMovieSceneFloatChannel> Scale
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FMovieSceneFloatChannel> result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new TFixedArray<FMovieSceneFloatChannel>(base.NativePtr + (IntPtr)FTransformParameterNameAndCurves.__PropertyOffset_Scale, 3, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Scale.CopyAssign(value);
			}
		}

		// Token: 0x060226ED RID: 141037 RVA: 0x0032EC26 File Offset: 0x0032CE26
		public FTransformParameterNameAndCurves()
		{
		}

		// Token: 0x060226EE RID: 141038 RVA: 0x0032EC2E File Offset: 0x0032CE2E
		public FTransformParameterNameAndCurves(FName ParameterName, TFixedArray<FMovieSceneFloatChannel> Translation, TFixedArray<FMovieSceneFloatChannel> Rotation, TFixedArray<FMovieSceneFloatChannel> Scale)
		{
			this.ParameterName = ParameterName;
			this.Translation = Translation;
			this.Rotation = Rotation;
			this.Scale = Scale;
		}

		// Token: 0x060226EF RID: 141039 RVA: 0x0032EC53 File Offset: 0x0032CE53
		protected override IntPtr GetUStructPtr()
		{
			return FTransformParameterNameAndCurves.StaticStruct();
		}

		// Token: 0x060226F0 RID: 141040 RVA: 0x0032EC5F File Offset: 0x0032CE5F
		[NullableContext(2)]
		public FTransformParameterNameAndCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226F1 RID: 141041 RVA: 0x0032EC69 File Offset: 0x0032CE69
		public FTransformParameterNameAndCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226F2 RID: 141042 RVA: 0x0032EC74 File Offset: 0x0032CE74
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformParameterNameAndCurves(Pointer, false, true);
		}

		// Token: 0x060226F3 RID: 141043 RVA: 0x0032EC7E File Offset: 0x0032CE7E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformParameterNameAndCurves(Pointer, MemoryOwner);
		}

		// Token: 0x0401260D RID: 75277
		public const string __ObjectPath = "/Script/MovieSceneTracks.TransformParameterNameAndCurves";

		// Token: 0x0401260E RID: 75278
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401260F RID: 75279
		internal static int __PropertyOffset_ParameterName;

		// Token: 0x04012610 RID: 75280
		internal static int __PropertyOffset_Translation;

		// Token: 0x04012611 RID: 75281
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Translation;

		// Token: 0x04012612 RID: 75282
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04012613 RID: 75283
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Rotation;

		// Token: 0x04012614 RID: 75284
		internal static int __PropertyOffset_Scale;

		// Token: 0x04012615 RID: 75285
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FMovieSceneFloatChannel> _Scale;
	}
}
