using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002467 RID: 9319
	[UnrealObjectPath("/Script/MovieScene.TrackInstanceInputComponent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FTrackInstanceInputComponent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022E52 RID: 142930 RVA: 0x003397C2 File Offset: 0x003379C2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTrackInstanceInputComponent._ScriptStructPtr != 0) ? FTrackInstanceInputComponent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.TrackInstanceInputComponent", ref FTrackInstanceInputComponent._ScriptStructPtr);
		}

		// Token: 0x17008614 RID: 34324
		// (get) Token: 0x06022E53 RID: 142931 RVA: 0x003397E6 File Offset: 0x003379E6
		// (set) Token: 0x06022E54 RID: 142932 RVA: 0x003397FA File Offset: 0x003379FA
		[Nullable(2)]
		public unsafe UMovieSceneSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSection>(base.NativePtr / (IntPtr)sizeof(void*) + FTrackInstanceInputComponent.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FTrackInstanceInputComponent.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x17008615 RID: 34325
		// (get) Token: 0x06022E55 RID: 142933 RVA: 0x0033980F File Offset: 0x00337A0F
		// (set) Token: 0x06022E56 RID: 142934 RVA: 0x0033981F File Offset: 0x00337A1F
		public unsafe int OutputIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTrackInstanceInputComponent.__PropertyOffset_OutputIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTrackInstanceInputComponent.__PropertyOffset_OutputIndex) = value;
			}
		}

		// Token: 0x06022E57 RID: 142935 RVA: 0x00339830 File Offset: 0x00337A30
		public FTrackInstanceInputComponent()
		{
		}

		// Token: 0x06022E58 RID: 142936 RVA: 0x00339838 File Offset: 0x00337A38
		[NullableContext(1)]
		public FTrackInstanceInputComponent(UMovieSceneSection Section, int OutputIndex)
		{
			this.Section = Section;
			this.OutputIndex = OutputIndex;
		}

		// Token: 0x06022E59 RID: 142937 RVA: 0x0033984E File Offset: 0x00337A4E
		protected override IntPtr GetUStructPtr()
		{
			return FTrackInstanceInputComponent.StaticStruct();
		}

		// Token: 0x06022E5A RID: 142938 RVA: 0x0033985A File Offset: 0x00337A5A
		[NullableContext(2)]
		public FTrackInstanceInputComponent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022E5B RID: 142939 RVA: 0x00339864 File Offset: 0x00337A64
		public FTrackInstanceInputComponent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022E5C RID: 142940 RVA: 0x0033986F File Offset: 0x00337A6F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTrackInstanceInputComponent(Pointer, false, true);
		}

		// Token: 0x06022E5D RID: 142941 RVA: 0x00339879 File Offset: 0x00337A79
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTrackInstanceInputComponent(Pointer, MemoryOwner);
		}

		// Token: 0x04012A0E RID: 76302
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.TrackInstanceInputComponent";

		// Token: 0x04012A0F RID: 76303
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012A10 RID: 76304
		internal static int __PropertyOffset_Section;

		// Token: 0x04012A11 RID: 76305
		internal static int __PropertyOffset_OutputIndex;
	}
}
