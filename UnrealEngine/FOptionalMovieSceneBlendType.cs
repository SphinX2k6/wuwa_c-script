using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200245F RID: 9311
	[UnrealObjectPath("/Script/MovieScene.OptionalMovieSceneBlendType")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FOptionalMovieSceneBlendType : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022E0E RID: 142862 RVA: 0x00339212 File Offset: 0x00337412
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOptionalMovieSceneBlendType._ScriptStructPtr != 0) ? FOptionalMovieSceneBlendType._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.OptionalMovieSceneBlendType", ref FOptionalMovieSceneBlendType._ScriptStructPtr);
		}

		// Token: 0x1700860B RID: 34315
		// (get) Token: 0x06022E0F RID: 142863 RVA: 0x00339236 File Offset: 0x00337436
		// (set) Token: 0x06022E10 RID: 142864 RVA: 0x00339246 File Offset: 0x00337446
		public unsafe EMovieSceneBlendType BlendType
		{
			get
			{
				return (EMovieSceneBlendType)(*(base.NativePtr + (IntPtr)FOptionalMovieSceneBlendType.__PropertyOffset_BlendType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOptionalMovieSceneBlendType.__PropertyOffset_BlendType) = (byte)value;
			}
		}

		// Token: 0x1700860C RID: 34316
		// (get) Token: 0x06022E11 RID: 142865 RVA: 0x00339257 File Offset: 0x00337457
		// (set) Token: 0x06022E12 RID: 142866 RVA: 0x00339267 File Offset: 0x00337467
		public unsafe bool bIsValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOptionalMovieSceneBlendType.__PropertyOffset_bIsValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOptionalMovieSceneBlendType.__PropertyOffset_bIsValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022E13 RID: 142867 RVA: 0x00339278 File Offset: 0x00337478
		public FOptionalMovieSceneBlendType()
		{
		}

		// Token: 0x06022E14 RID: 142868 RVA: 0x00339280 File Offset: 0x00337480
		public FOptionalMovieSceneBlendType(EMovieSceneBlendType BlendType, bool bIsValid)
		{
			this.BlendType = BlendType;
			this.bIsValid = bIsValid;
		}

		// Token: 0x06022E15 RID: 142869 RVA: 0x00339296 File Offset: 0x00337496
		protected override IntPtr GetUStructPtr()
		{
			return FOptionalMovieSceneBlendType.StaticStruct();
		}

		// Token: 0x06022E16 RID: 142870 RVA: 0x003392A2 File Offset: 0x003374A2
		[NullableContext(2)]
		public FOptionalMovieSceneBlendType(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E17 RID: 142871 RVA: 0x003392AC File Offset: 0x003374AC
		public FOptionalMovieSceneBlendType(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E18 RID: 142872 RVA: 0x003392B7 File Offset: 0x003374B7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOptionalMovieSceneBlendType(Pointer, false, true);
		}

		// Token: 0x06022E19 RID: 142873 RVA: 0x003392C1 File Offset: 0x003374C1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOptionalMovieSceneBlendType(Pointer, MemoryOwner);
		}

		// Token: 0x040129EC RID: 76268
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.OptionalMovieSceneBlendType";

		// Token: 0x040129ED RID: 76269
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129EE RID: 76270
		internal static int __PropertyOffset_BlendType;

		// Token: 0x040129EF RID: 76271
		internal static int __PropertyOffset_bIsValid;
	}
}
