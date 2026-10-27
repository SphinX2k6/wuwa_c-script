using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018FA RID: 6394
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroMp4PlayerPreviewSubsystem")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKuroMp4PlayerPreviewSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017B82 RID: 97154 RVA: 0x0022C1BB File Offset: 0x0022A3BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMp4PlayerPreviewSubsystem._ClassPtr;
		}

		// Token: 0x06017B83 RID: 97155 RVA: 0x0022C1C8 File Offset: 0x0022A3C8
		public UKuroMp4PlayerPreviewSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroMp4PlayerPreviewSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017B84 RID: 97156 RVA: 0x0022C1F0 File Offset: 0x0022A3F0
		[NullableContext(1)]
		public UKuroMp4PlayerPreviewSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMp4PlayerPreviewSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F8A RID: 24458
		// (get) Token: 0x06017B85 RID: 97157 RVA: 0x0022C223 File Offset: 0x0022A423
		// (set) Token: 0x06017B86 RID: 97158 RVA: 0x0022C233 File Offset: 0x0022A433
		public unsafe int MaxActiveMP4PlayerActors
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroMp4PlayerPreviewSubsystem.__PropertyOffset_MaxActiveMP4PlayerActors);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroMp4PlayerPreviewSubsystem.__PropertyOffset_MaxActiveMP4PlayerActors) = value;
			}
		}

		// Token: 0x06017B87 RID: 97159 RVA: 0x0022C244 File Offset: 0x0022A444
		public void UpdateDistanceAndRefresh(UObject InMP4PlayerActor, float InDistanceToCamera)
		{
			UKuroMp4PlayerPreviewSubsystem.__UpdateDistanceAndRefresh_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero, InDistanceToCamera);
		}

		// Token: 0x06017B88 RID: 97160 RVA: 0x0022C262 File Offset: 0x0022A462
		public void UnregisterMP4PlayerActor(UObject InMP4PlayerActor)
		{
			UKuroMp4PlayerPreviewSubsystem.__UnregisterMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B89 RID: 97161 RVA: 0x0022C280 File Offset: 0x0022A480
		public bool TryAcquireForMP4PlayerActor(UObject InMP4PlayerActor, ref UMediaPlayer OutPlayer, ref UMediaTexture OutTexture)
		{
			UMediaPlayer umediaPlayer = OutPlayer;
			IntPtr nativeObjectPtr = (umediaPlayer != null) ? umediaPlayer.NativePtr : IntPtr.Zero;
			UMediaTexture umediaTexture = OutTexture;
			IntPtr nativeObjectPtr2 = (umediaTexture != null) ? umediaTexture.NativePtr : IntPtr.Zero;
			bool result = UKuroMp4PlayerPreviewSubsystem.__TryAcquireForMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero, ref nativeObjectPtr, ref nativeObjectPtr2);
			OutPlayer = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlayer>(nativeObjectPtr);
			OutTexture = BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaTexture>(nativeObjectPtr2);
			return result;
		}

		// Token: 0x06017B8A RID: 97162 RVA: 0x0022C2E2 File Offset: 0x0022A4E2
		public void ReleaseForMP4PlayerActor(UObject InMP4PlayerActor)
		{
			UKuroMp4PlayerPreviewSubsystem.__ReleaseForMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B8B RID: 97163 RVA: 0x0022C300 File Offset: 0x0022A500
		[NullableContext(1)]
		public unsafe bool RegisterPoolIfNeeded(string AssetPath)
		{
			FString fstring = FString.AllocTemp(AssetPath);
			bool result = UKuroMp4PlayerPreviewSubsystem.__RegisterPoolIfNeeded_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06017B8C RID: 97164 RVA: 0x0022C32A File Offset: 0x0022A52A
		public void RegisterMP4PlayerActor(UObject InMP4PlayerActor)
		{
			UKuroMp4PlayerPreviewSubsystem.__RegisterMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B8D RID: 97165 RVA: 0x0022C347 File Offset: 0x0022A547
		public void RefreshActiveMP4PlayerActors()
		{
			UKuroMp4PlayerPreviewSubsystem.__RefreshActiveMP4PlayerActors_Internal(base.NativePtr);
		}

		// Token: 0x06017B8E RID: 97166 RVA: 0x0022C354 File Offset: 0x0022A554
		public static UKuroMp4PlayerPreviewSubsystem Get(UObject WorldContextObject)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroMp4PlayerPreviewSubsystem>(UKuroMp4PlayerPreviewSubsystem.__Get_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06017B8F RID: 97167 RVA: 0x0022C370 File Offset: 0x0022A570
		public void ForceStopMP4PlayerActor(UObject InMP4PlayerActor)
		{
			UKuroMp4PlayerPreviewSubsystem.__ForceStopMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B90 RID: 97168 RVA: 0x0022C38D File Offset: 0x0022A58D
		public void ForceStopAndReleaseAll()
		{
			UKuroMp4PlayerPreviewSubsystem.__ForceStopAndReleaseAll_Internal(base.NativePtr);
		}

		// Token: 0x06017B91 RID: 97169 RVA: 0x0022C39A File Offset: 0x0022A59A
		public bool ForcePlayMP4PlayerActor(UObject InMP4PlayerActor)
		{
			return UKuroMp4PlayerPreviewSubsystem.__ForcePlayMP4PlayerActor_Internal(base.NativePtr, (InMP4PlayerActor != null) ? InMP4PlayerActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B92 RID: 97170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateDistanceAndRefresh_Internal(IntPtr @this, IntPtr InMP4PlayerActor, float InDistanceToCamera);

		// Token: 0x06017B93 RID: 97171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor);

		// Token: 0x06017B94 RID: 97172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryAcquireForMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor, ref IntPtr OutPlayer, ref IntPtr OutTexture);

		// Token: 0x06017B95 RID: 97173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReleaseForMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor);

		// Token: 0x06017B96 RID: 97174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __RegisterPoolIfNeeded_Internal(IntPtr @this, in FString AssetPath);

		// Token: 0x06017B97 RID: 97175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor);

		// Token: 0x06017B98 RID: 97176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshActiveMP4PlayerActors_Internal(IntPtr @this);

		// Token: 0x06017B99 RID: 97177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Get_Internal(IntPtr WorldContextObject);

		// Token: 0x06017B9A RID: 97178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceStopMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor);

		// Token: 0x06017B9B RID: 97179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceStopAndReleaseAll_Internal(IntPtr @this);

		// Token: 0x06017B9C RID: 97180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ForcePlayMP4PlayerActor_Internal(IntPtr @this, IntPtr InMP4PlayerActor);

		// Token: 0x06017B9D RID: 97181 RVA: 0x0022C3B7 File Offset: 0x0022A5B7
		static UKuroMp4PlayerPreviewSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroMp4PlayerPreviewSubsystem");
		}

		// Token: 0x06017B9E RID: 97182 RVA: 0x0022C3C5 File Offset: 0x0022A5C5
		protected UKuroMp4PlayerPreviewSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CE02 RID: 52738
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroMp4PlayerPreviewSubsystem";

		// Token: 0x0400CE03 RID: 52739
		private static IntPtr _ClassPtr;

		// Token: 0x0400CE04 RID: 52740
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CE05 RID: 52741
		internal static int __PropertyOffset_MaxActiveMP4PlayerActors;
	}
}
