using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001FBC RID: 8124
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LevelSequence.LevelSequenceMediaController")]
	[UnrealStructLayout(1080, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1080)]
	public class ALevelSequenceMediaController : AActor, IUnrealUObject, IUnrealObject, IMovieSceneCustomClockSource, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0601ED49 RID: 126281 RVA: 0x002DD1B8 File Offset: 0x002DB3B8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALevelSequenceMediaController._ClassPtr;
		}

		// Token: 0x0601ED4A RID: 126282 RVA: 0x002DD1C4 File Offset: 0x002DB3C4
		int IMovieSceneCustomClockSource.InterfaceOffset()
		{
			return ALevelSequenceMediaController.__InterfaceOffset_IMovieSceneCustomClockSource;
		}

		// Token: 0x0601ED4B RID: 126283 RVA: 0x002DD1CC File Offset: 0x002DB3CC
		public ALevelSequenceMediaController() : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceMediaController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601ED4C RID: 126284 RVA: 0x002DD1F4 File Offset: 0x002DB3F4
		[NullableContext(1)]
		public ALevelSequenceMediaController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALevelSequenceMediaController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007ABE RID: 31422
		// (get) Token: 0x0601ED4D RID: 126285 RVA: 0x002DD227 File Offset: 0x002DB427
		// (set) Token: 0x0601ED4E RID: 126286 RVA: 0x002DD23B File Offset: 0x002DB43B
		public unsafe ALevelSequenceActor Sequence
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ALevelSequenceActor>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceMediaController.__PropertyOffset_Sequence);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceMediaController.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17007ABF RID: 31423
		// (get) Token: 0x0601ED4F RID: 126287 RVA: 0x002DD250 File Offset: 0x002DB450
		// (set) Token: 0x0601ED50 RID: 126288 RVA: 0x002DD264 File Offset: 0x002DB464
		public unsafe UMediaComponent MediaComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceMediaController.__PropertyOffset_MediaComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALevelSequenceMediaController.__PropertyOffset_MediaComponent, value);
			}
		}

		// Token: 0x17007AC0 RID: 31424
		// (get) Token: 0x0601ED51 RID: 126289 RVA: 0x002DD279 File Offset: 0x002DB479
		// (set) Token: 0x0601ED52 RID: 126290 RVA: 0x002DD289 File Offset: 0x002DB489
		public unsafe float ServerStartTimeSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ALevelSequenceMediaController.__PropertyOffset_ServerStartTimeSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ALevelSequenceMediaController.__PropertyOffset_ServerStartTimeSeconds) = value;
			}
		}

		// Token: 0x0601ED53 RID: 126291 RVA: 0x002DD29A File Offset: 0x002DB49A
		public void SynchronizeToServer(float DesyncThresholdSeconds = 2f)
		{
			ALevelSequenceMediaController.__SynchronizeToServer_Internal(base.NativePtr, DesyncThresholdSeconds);
		}

		// Token: 0x0601ED54 RID: 126292 RVA: 0x002DD2A8 File Offset: 0x002DB4A8
		public void Play()
		{
			ALevelSequenceMediaController.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0601ED55 RID: 126293 RVA: 0x002DD2B5 File Offset: 0x002DB4B5
		public void OnRep_ServerStartTimeSeconds()
		{
			ALevelSequenceMediaController.__OnRep_ServerStartTimeSeconds_Internal(base.NativePtr);
		}

		// Token: 0x0601ED56 RID: 126294 RVA: 0x002DD2C2 File Offset: 0x002DB4C2
		public ALevelSequenceActor GetSequence()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ALevelSequenceActor>(ALevelSequenceMediaController.__GetSequence_Internal(base.NativePtr));
		}

		// Token: 0x0601ED57 RID: 126295 RVA: 0x002DD2D4 File Offset: 0x002DB4D4
		public UMediaComponent GetMediaComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaComponent>(ALevelSequenceMediaController.__GetMediaComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601ED58 RID: 126296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SynchronizeToServer_Internal(IntPtr @this, float DesyncThresholdSeconds);

		// Token: 0x0601ED59 RID: 126297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0601ED5A RID: 126298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ServerStartTimeSeconds_Internal(IntPtr @this);

		// Token: 0x0601ED5B RID: 126299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSequence_Internal(IntPtr @this);

		// Token: 0x0601ED5C RID: 126300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaComponent_Internal(IntPtr @this);

		// Token: 0x0601ED5D RID: 126301 RVA: 0x002DD2E6 File Offset: 0x002DB4E6
		static ALevelSequenceMediaController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LevelSequence.LevelSequenceMediaController");
		}

		// Token: 0x0601ED5E RID: 126302 RVA: 0x002DD2F4 File Offset: 0x002DB4F4
		protected ALevelSequenceMediaController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010A95 RID: 68245
		internal static int __InterfaceOffset_IMovieSceneCustomClockSource;

		// Token: 0x04010A96 RID: 68246
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LevelSequence.LevelSequenceMediaController";

		// Token: 0x04010A97 RID: 68247
		private static IntPtr _ClassPtr;

		// Token: 0x04010A98 RID: 68248
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010A99 RID: 68249
		internal static int __PropertyOffset_Sequence;

		// Token: 0x04010A9A RID: 68250
		internal static int __PropertyOffset_MediaComponent;

		// Token: 0x04010A9B RID: 68251
		internal static int __PropertyOffset_ServerStartTimeSeconds;
	}
}
