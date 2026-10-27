using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020023D5 RID: 9173
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBindingOverrideData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMovieSceneBindingOverrideData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602275D RID: 141149 RVA: 0x0032F6DA File Offset: 0x0032D8DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneBindingOverrideData._ScriptStructPtr != 0) ? FMovieSceneBindingOverrideData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneBindingOverrideData", ref FMovieSceneBindingOverrideData._ScriptStructPtr);
		}

		// Token: 0x170084BE RID: 33982
		// (get) Token: 0x0602275E RID: 141150 RVA: 0x0032F700 File Offset: 0x0032D900
		// (set) Token: 0x0602275F RID: 141151 RVA: 0x0032F743 File Offset: 0x0032D943
		public FMovieSceneObjectBindingID ObjectBindingId
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._ObjectBindingId) == null)
				{
					result = (this._ObjectBindingId = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_ObjectBindingId, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_ObjectBindingId, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170084BF RID: 33983
		// (get) Token: 0x06022760 RID: 141152 RVA: 0x0032F764 File Offset: 0x0032D964
		// (set) Token: 0x06022761 RID: 141153 RVA: 0x0032F783 File Offset: 0x0032D983
		public TSoftObjectPtr<UObject> Object
		{
			get
			{
				return new TSoftObjectPtr<UObject>(base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_Object, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_Object, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x170084C0 RID: 33984
		// (get) Token: 0x06022762 RID: 141154 RVA: 0x0032F7A8 File Offset: 0x0032D9A8
		// (set) Token: 0x06022763 RID: 141155 RVA: 0x0032F7B8 File Offset: 0x0032D9B8
		public unsafe bool bOverridesDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_bOverridesDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneBindingOverrideData.__PropertyOffset_bOverridesDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x06022764 RID: 141156 RVA: 0x0032F7C9 File Offset: 0x0032D9C9
		public FMovieSceneBindingOverrideData()
		{
		}

		// Token: 0x06022765 RID: 141157 RVA: 0x0032F7D1 File Offset: 0x0032D9D1
		public FMovieSceneBindingOverrideData(FMovieSceneObjectBindingID ObjectBindingId, TSoftObjectPtr<UObject> Object, bool bOverridesDefault)
		{
			this.ObjectBindingId = ObjectBindingId;
			this.Object = Object;
			this.bOverridesDefault = bOverridesDefault;
		}

		// Token: 0x06022766 RID: 141158 RVA: 0x0032F7EE File Offset: 0x0032D9EE
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneBindingOverrideData.StaticStruct();
		}

		// Token: 0x06022767 RID: 141159 RVA: 0x0032F7FA File Offset: 0x0032D9FA
		[NullableContext(2)]
		public FMovieSceneBindingOverrideData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022768 RID: 141160 RVA: 0x0032F804 File Offset: 0x0032DA04
		public FMovieSceneBindingOverrideData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022769 RID: 141161 RVA: 0x0032F80F File Offset: 0x0032DA0F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneBindingOverrideData(Pointer, false, true);
		}

		// Token: 0x0602276A RID: 141162 RVA: 0x0032F819 File Offset: 0x0032DA19
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneBindingOverrideData(Pointer, MemoryOwner);
		}

		// Token: 0x040126B2 RID: 75442
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneBindingOverrideData";

		// Token: 0x040126B3 RID: 75443
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040126B4 RID: 75444
		internal static int __PropertyOffset_ObjectBindingId;

		// Token: 0x040126B5 RID: 75445
		[Nullable(2)]
		private FMovieSceneObjectBindingID _ObjectBindingId;

		// Token: 0x040126B6 RID: 75446
		internal static int __PropertyOffset_Object;

		// Token: 0x040126B7 RID: 75447
		internal static int __PropertyOffset_bOverridesDefault;
	}
}
