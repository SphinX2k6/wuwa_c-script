using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200028A RID: 650
	[UnrealObjectPath("/Script/AkAudio.MovieSceneTangentDataSerializationHelper")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FMovieSceneTangentDataSerializationHelper : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600247D RID: 9341 RVA: 0x000361A1 File Offset: 0x000343A1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTangentDataSerializationHelper._ScriptStructPtr != 0) ? FMovieSceneTangentDataSerializationHelper._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.MovieSceneTangentDataSerializationHelper", ref FMovieSceneTangentDataSerializationHelper._ScriptStructPtr);
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600247E RID: 9342 RVA: 0x000361C5 File Offset: 0x000343C5
		// (set) Token: 0x0600247F RID: 9343 RVA: 0x000361D5 File Offset: 0x000343D5
		public unsafe float ArriveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_ArriveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_ArriveTangent) = value;
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002480 RID: 9344 RVA: 0x000361E6 File Offset: 0x000343E6
		// (set) Token: 0x06002481 RID: 9345 RVA: 0x000361F6 File Offset: 0x000343F6
		public unsafe float LeaveTangent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_LeaveTangent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_LeaveTangent) = value;
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06002482 RID: 9346 RVA: 0x00036207 File Offset: 0x00034407
		// (set) Token: 0x06002483 RID: 9347 RVA: 0x0003621B File Offset: 0x0003441B
		public unsafe TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_TangentWeightMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_TangentWeightMode) = value;
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x06002484 RID: 9348 RVA: 0x00036230 File Offset: 0x00034430
		// (set) Token: 0x06002485 RID: 9349 RVA: 0x00036240 File Offset: 0x00034440
		public unsafe float ArriveTangentWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_ArriveTangentWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_ArriveTangentWeight) = value;
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002486 RID: 9350 RVA: 0x00036251 File Offset: 0x00034451
		// (set) Token: 0x06002487 RID: 9351 RVA: 0x00036261 File Offset: 0x00034461
		public unsafe float LeaveTangentWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_LeaveTangentWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTangentDataSerializationHelper.__PropertyOffset_LeaveTangentWeight) = value;
			}
		}

		// Token: 0x06002488 RID: 9352 RVA: 0x00036272 File Offset: 0x00034472
		public FMovieSceneTangentDataSerializationHelper()
		{
		}

		// Token: 0x06002489 RID: 9353 RVA: 0x0003627A File Offset: 0x0003447A
		public FMovieSceneTangentDataSerializationHelper(float ArriveTangent, float LeaveTangent, TEnumAsByte<ERichCurveTangentWeightMode> TangentWeightMode, float ArriveTangentWeight, float LeaveTangentWeight)
		{
			this.ArriveTangent = ArriveTangent;
			this.LeaveTangent = LeaveTangent;
			this.TangentWeightMode = TangentWeightMode;
			this.ArriveTangentWeight = ArriveTangentWeight;
			this.LeaveTangentWeight = LeaveTangentWeight;
		}

		// Token: 0x0600248A RID: 9354 RVA: 0x000362A7 File Offset: 0x000344A7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTangentDataSerializationHelper.StaticStruct();
		}

		// Token: 0x0600248B RID: 9355 RVA: 0x000362B3 File Offset: 0x000344B3
		[NullableContext(2)]
		public FMovieSceneTangentDataSerializationHelper(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600248C RID: 9356 RVA: 0x000362BD File Offset: 0x000344BD
		public FMovieSceneTangentDataSerializationHelper(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600248D RID: 9357 RVA: 0x000362C8 File Offset: 0x000344C8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTangentDataSerializationHelper(Pointer, false, true);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x000362D2 File Offset: 0x000344D2
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTangentDataSerializationHelper(Pointer, MemoryOwner);
		}

		// Token: 0x04000DE4 RID: 3556
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.MovieSceneTangentDataSerializationHelper";

		// Token: 0x04000DE5 RID: 3557
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DE6 RID: 3558
		internal static int __PropertyOffset_ArriveTangent;

		// Token: 0x04000DE7 RID: 3559
		internal static int __PropertyOffset_LeaveTangent;

		// Token: 0x04000DE8 RID: 3560
		internal static int __PropertyOffset_TangentWeightMode;

		// Token: 0x04000DE9 RID: 3561
		internal static int __PropertyOffset_ArriveTangentWeight;

		// Token: 0x04000DEA RID: 3562
		internal static int __PropertyOffset_LeaveTangentWeight;
	}
}
