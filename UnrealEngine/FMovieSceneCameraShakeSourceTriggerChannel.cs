using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002353 RID: 9043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerChannel")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FMovieSceneCameraShakeSourceTriggerChannel : FMovieSceneChannel, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060222CC RID: 139980 RVA: 0x00328873 File Offset: 0x00326A73
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneCameraShakeSourceTriggerChannel._ScriptStructPtr != 0) ? FMovieSceneCameraShakeSourceTriggerChannel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerChannel", ref FMovieSceneCameraShakeSourceTriggerChannel._ScriptStructPtr);
		}

		// Token: 0x170083FD RID: 33789
		// (get) Token: 0x060222CD RID: 139981 RVA: 0x00328898 File Offset: 0x00326A98
		// (set) Token: 0x060222CE RID: 139982 RVA: 0x003288DB File Offset: 0x00326ADB
		public TArray<FFrameNumber> KeyTimes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFrameNumber> result;
				if ((result = this._KeyTimes) == null)
				{
					result = (this._KeyTimes = new TArray<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTriggerChannel.__PropertyOffset_KeyTimes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyTimes.CopyAssign(value);
			}
		}

		// Token: 0x170083FE RID: 33790
		// (get) Token: 0x060222CF RID: 139983 RVA: 0x003288EC File Offset: 0x00326AEC
		// (set) Token: 0x060222D0 RID: 139984 RVA: 0x0032892F File Offset: 0x00326B2F
		public TArray<FMovieSceneCameraShakeSourceTrigger> KeyValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneCameraShakeSourceTrigger> result;
				if ((result = this._KeyValues) == null)
				{
					result = (this._KeyValues = new TArray<FMovieSceneCameraShakeSourceTrigger>(base.NativePtr + (IntPtr)FMovieSceneCameraShakeSourceTriggerChannel.__PropertyOffset_KeyValues, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.KeyValues.CopyAssign(value);
			}
		}

		// Token: 0x060222D1 RID: 139985 RVA: 0x0032893D File Offset: 0x00326B3D
		public FMovieSceneCameraShakeSourceTriggerChannel()
		{
		}

		// Token: 0x060222D2 RID: 139986 RVA: 0x00328945 File Offset: 0x00326B45
		public FMovieSceneCameraShakeSourceTriggerChannel(TArray<FFrameNumber> KeyTimes, TArray<FMovieSceneCameraShakeSourceTrigger> KeyValues)
		{
			this.KeyTimes = KeyTimes;
			this.KeyValues = KeyValues;
		}

		// Token: 0x060222D3 RID: 139987 RVA: 0x0032895B File Offset: 0x00326B5B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneCameraShakeSourceTriggerChannel.StaticStruct();
		}

		// Token: 0x060222D4 RID: 139988 RVA: 0x00328967 File Offset: 0x00326B67
		[NullableContext(2)]
		public FMovieSceneCameraShakeSourceTriggerChannel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060222D5 RID: 139989 RVA: 0x00328971 File Offset: 0x00326B71
		public FMovieSceneCameraShakeSourceTriggerChannel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060222D6 RID: 139990 RVA: 0x0032897C File Offset: 0x00326B7C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneCameraShakeSourceTriggerChannel(Pointer, false, true);
		}

		// Token: 0x060222D7 RID: 139991 RVA: 0x00328986 File Offset: 0x00326B86
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneCameraShakeSourceTriggerChannel(Pointer, MemoryOwner);
		}

		// Token: 0x040123DB RID: 74715
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCameraShakeSourceTriggerChannel";

		// Token: 0x040123DC RID: 74716
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040123DD RID: 74717
		internal static int __PropertyOffset_KeyTimes;

		// Token: 0x040123DE RID: 74718
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFrameNumber> _KeyTimes;

		// Token: 0x040123DF RID: 74719
		internal static int __PropertyOffset_KeyValues;

		// Token: 0x040123E0 RID: 74720
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneCameraShakeSourceTrigger> _KeyValues;
	}
}
