using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200241D RID: 9245
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneObjectPathChannelKeyValue")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneObjectPathChannelKeyValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022A57 RID: 141911 RVA: 0x00333C89 File Offset: 0x00331E89
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneObjectPathChannelKeyValue._ScriptStructPtr != 0) ? FMovieSceneObjectPathChannelKeyValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneObjectPathChannelKeyValue", ref FMovieSceneObjectPathChannelKeyValue._ScriptStructPtr);
		}

		// Token: 0x17008550 RID: 34128
		// (get) Token: 0x06022A58 RID: 141912 RVA: 0x00333CAD File Offset: 0x00331EAD
		// (set) Token: 0x06022A59 RID: 141913 RVA: 0x00333CCC File Offset: 0x00331ECC
		public TSoftObjectPtr<UObject> SoftPtr
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannelKeyValue.__PropertyOffset_SoftPtr, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FMovieSceneObjectPathChannelKeyValue.__PropertyOffset_SoftPtr, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17008551 RID: 34129
		// (get) Token: 0x06022A5A RID: 141914 RVA: 0x00333CF1 File Offset: 0x00331EF1
		// (set) Token: 0x06022A5B RID: 141915 RVA: 0x00333D05 File Offset: 0x00331F05
		[Nullable(2)]
		public unsafe UObject HardPtr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneObjectPathChannelKeyValue.__PropertyOffset_HardPtr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneObjectPathChannelKeyValue.__PropertyOffset_HardPtr, value);
			}
		}

		// Token: 0x06022A5C RID: 141916 RVA: 0x00333D1A File Offset: 0x00331F1A
		public FMovieSceneObjectPathChannelKeyValue()
		{
		}

		// Token: 0x06022A5D RID: 141917 RVA: 0x00333D22 File Offset: 0x00331F22
		public FMovieSceneObjectPathChannelKeyValue(TSoftObjectPtr<UObject> SoftPtr, UObject HardPtr)
		{
			this.SoftPtr = SoftPtr;
			this.HardPtr = HardPtr;
		}

		// Token: 0x06022A5E RID: 141918 RVA: 0x00333D38 File Offset: 0x00331F38
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneObjectPathChannelKeyValue.StaticStruct();
		}

		// Token: 0x06022A5F RID: 141919 RVA: 0x00333D44 File Offset: 0x00331F44
		[NullableContext(2)]
		public FMovieSceneObjectPathChannelKeyValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022A60 RID: 141920 RVA: 0x00333D4E File Offset: 0x00331F4E
		public FMovieSceneObjectPathChannelKeyValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022A61 RID: 141921 RVA: 0x00333D59 File Offset: 0x00331F59
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneObjectPathChannelKeyValue(Pointer, false, true);
		}

		// Token: 0x06022A62 RID: 141922 RVA: 0x00333D63 File Offset: 0x00331F63
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneObjectPathChannelKeyValue(Pointer, MemoryOwner);
		}

		// Token: 0x0401282E RID: 75822
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneObjectPathChannelKeyValue";

		// Token: 0x0401282F RID: 75823
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012830 RID: 75824
		internal static int __PropertyOffset_SoftPtr;

		// Token: 0x04012831 RID: 75825
		internal static int __PropertyOffset_HardPtr;
	}
}
