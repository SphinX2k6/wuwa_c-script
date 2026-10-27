using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000289 RID: 649
	[UnrealObjectPath("/Script/AkAudio.MovieSceneFloatValueSerializationHelper")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FMovieSceneFloatValueSerializationHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600246D RID: 9325 RVA: 0x00036044 File Offset: 0x00034244
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneFloatValueSerializationHelper._ScriptStructPtr != 0) ? FMovieSceneFloatValueSerializationHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.MovieSceneFloatValueSerializationHelper", ref FMovieSceneFloatValueSerializationHelper._ScriptStructPtr);
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x0600246E RID: 9326 RVA: 0x00036068 File Offset: 0x00034268
		// (set) Token: 0x0600246F RID: 9327 RVA: 0x00036078 File Offset: 0x00034278
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002470 RID: 9328 RVA: 0x00036089 File Offset: 0x00034289
		// (set) Token: 0x06002471 RID: 9329 RVA: 0x0003609D File Offset: 0x0003429D
		public unsafe TEnumAsByte<ERichCurveInterpMode> InterpMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_InterpMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_InterpMode) = value;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002472 RID: 9330 RVA: 0x000360B2 File Offset: 0x000342B2
		// (set) Token: 0x06002473 RID: 9331 RVA: 0x000360C6 File Offset: 0x000342C6
		public unsafe TEnumAsByte<ERichCurveTangentMode> TangentMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_TangentMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_TangentMode) = value;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002474 RID: 9332 RVA: 0x000360DC File Offset: 0x000342DC
		// (set) Token: 0x06002475 RID: 9333 RVA: 0x0003611F File Offset: 0x0003431F
		[Nullable(1)]
		public FMovieSceneTangentDataSerializationHelper Tangent
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTangentDataSerializationHelper result;
				if ((result = this._Tangent) == null)
				{
					result = (this._Tangent = new FMovieSceneTangentDataSerializationHelper(base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_Tangent, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTangentDataSerializationHelper.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneFloatValueSerializationHelper.__PropertyOffset_Tangent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x00036140 File Offset: 0x00034340
		public FMovieSceneFloatValueSerializationHelper()
		{
		}

		// Token: 0x06002477 RID: 9335 RVA: 0x00036148 File Offset: 0x00034348
		public FMovieSceneFloatValueSerializationHelper(float Value, TEnumAsByte<ERichCurveInterpMode> InterpMode, TEnumAsByte<ERichCurveTangentMode> TangentMode, [Nullable(1)] FMovieSceneTangentDataSerializationHelper Tangent)
		{
			this.Value = Value;
			this.InterpMode = InterpMode;
			this.TangentMode = TangentMode;
			this.Tangent = Tangent;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0003616D File Offset: 0x0003436D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneFloatValueSerializationHelper.StaticStruct();
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x00036179 File Offset: 0x00034379
		[NullableContext(2)]
		public FMovieSceneFloatValueSerializationHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600247A RID: 9338 RVA: 0x00036183 File Offset: 0x00034383
		public FMovieSceneFloatValueSerializationHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600247B RID: 9339 RVA: 0x0003618E File Offset: 0x0003438E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneFloatValueSerializationHelper(Pointer, false, true);
		}

		// Token: 0x0600247C RID: 9340 RVA: 0x00036198 File Offset: 0x00034398
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneFloatValueSerializationHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04000DDD RID: 3549
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.MovieSceneFloatValueSerializationHelper";

		// Token: 0x04000DDE RID: 3550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DDF RID: 3551
		internal static int __PropertyOffset_Value;

		// Token: 0x04000DE0 RID: 3552
		internal static int __PropertyOffset_InterpMode;

		// Token: 0x04000DE1 RID: 3553
		internal static int __PropertyOffset_TangentMode;

		// Token: 0x04000DE2 RID: 3554
		internal static int __PropertyOffset_Tangent;

		// Token: 0x04000DE3 RID: 3555
		[Nullable(2)]
		private FMovieSceneTangentDataSerializationHelper _Tangent;
	}
}
