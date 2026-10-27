using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029B RID: 667
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.PostEventAsync")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UPostEventAsync : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002520 RID: 9504 RVA: 0x000376FE File Offset: 0x000358FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPostEventAsync._ClassPtr;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x0003770C File Offset: 0x0003590C
		public UPostEventAsync() : this(BuiltinUtils.AllocNativeUObject(UPostEventAsync.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x00037734 File Offset: 0x00035934
		public UPostEventAsync(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPostEventAsync.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002523 RID: 9507 RVA: 0x00037768 File Offset: 0x00035968
		// (set) Token: 0x06002524 RID: 9508 RVA: 0x000377A1 File Offset: 0x000359A1
		public FPostEventAsyncOutputPin Completed
		{
			get
			{
				base.FastCheckIsValid();
				FPostEventAsyncOutputPin result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FPostEventAsyncOutputPin(base.NativePtr + (IntPtr)UPostEventAsync.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPostEventAsync.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000377C4 File Offset: 0x000359C4
		[NullableContext(2)]
		public static UPostEventAsync PostEventAsync(UObject WorldContextObject, UAkAudioEvent AkEvent, AActor Actor, int CallbackMask, in FOnAkPostEventCallback PostEventCallback, bool bStopWhenAttachedToDestroyed = false)
		{
			IntPtr worldContextObject = (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero;
			IntPtr akEvent = (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero;
			IntPtr actor = (Actor != null) ? Actor.NativePtr : IntPtr.Zero;
			FOnAkPostEventCallback fonAkPostEventCallback = PostEventCallback;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPostEventAsync>(UPostEventAsync.__PostEventAsync_Internal(worldContextObject, akEvent, actor, CallbackMask, (fonAkPostEventCallback != null) ? fonAkPostEventCallback.NativePtr : ((IntPtr)0), bStopWhenAttachedToDestroyed));
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x0003781E File Offset: 0x00035A1E
		public void PollPostEventFuture()
		{
			UPostEventAsync.__PollPostEventFuture_Internal(base.NativePtr);
		}

		// Token: 0x06002527 RID: 9511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PostEventAsync_Internal(IntPtr WorldContextObject, IntPtr AkEvent, IntPtr Actor, int CallbackMask, IntPtr PostEventCallback, bool bStopWhenAttachedToDestroyed);

		// Token: 0x06002528 RID: 9512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PollPostEventFuture_Internal(IntPtr @this);

		// Token: 0x06002529 RID: 9513 RVA: 0x0003782B File Offset: 0x00035A2B
		static UPostEventAsync()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.PostEventAsync");
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x00037839 File Offset: 0x00035A39
		protected UPostEventAsync(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E1C RID: 3612
		public new const string __ObjectPath = "/Script/AkAudio.PostEventAsync";

		// Token: 0x04000E1D RID: 3613
		private static IntPtr _ClassPtr;

		// Token: 0x04000E1E RID: 3614
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E1F RID: 3615
		internal static int __PropertyOffset_Completed;

		// Token: 0x04000E20 RID: 3616
		[Nullable(2)]
		private FPostEventAsyncOutputPin _Completed;
	}
}
