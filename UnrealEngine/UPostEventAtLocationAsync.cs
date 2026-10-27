using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200029D RID: 669
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.PostEventAtLocationAsync")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UPostEventAtLocationAsync : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002535 RID: 9525 RVA: 0x0003798A File Offset: 0x00035B8A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UPostEventAtLocationAsync._ClassPtr;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00037998 File Offset: 0x00035B98
		public UPostEventAtLocationAsync() : this(BuiltinUtils.AllocNativeUObject(UPostEventAtLocationAsync.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000379C0 File Offset: 0x00035BC0
		public UPostEventAtLocationAsync(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UPostEventAtLocationAsync.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x000379F4 File Offset: 0x00035BF4
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00037A2D File Offset: 0x00035C2D
		public FPostEventAtLocationAsyncOutputPin Completed
		{
			get
			{
				base.FastCheckIsValid();
				FPostEventAtLocationAsyncOutputPin result;
				if ((result = this._Completed) == null)
				{
					result = (this._Completed = new FPostEventAtLocationAsyncOutputPin(base.NativePtr + (IntPtr)UPostEventAtLocationAsync.__PropertyOffset_Completed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UPostEventAtLocationAsync.__PropertyOffset_Completed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00037A4E File Offset: 0x00035C4E
		[NullableContext(2)]
		public static UPostEventAtLocationAsync PostEventAtLocationAsync(UObject WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPostEventAtLocationAsync>(UPostEventAtLocationAsync.__PostEventAtLocationAsync_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (AkEvent != null) ? AkEvent.NativePtr : IntPtr.Zero, Location, Orientation));
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00037A7C File Offset: 0x00035C7C
		public void PollPostEventFuture()
		{
			UPostEventAtLocationAsync.__PollPostEventFuture_Internal(base.NativePtr);
		}

		// Token: 0x0600253C RID: 9532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PostEventAtLocationAsync_Internal(IntPtr WorldContextObject, IntPtr AkEvent, FVector Location, FRotator Orientation);

		// Token: 0x0600253D RID: 9533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PollPostEventFuture_Internal(IntPtr @this);

		// Token: 0x0600253E RID: 9534 RVA: 0x00037A89 File Offset: 0x00035C89
		static UPostEventAtLocationAsync()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.PostEventAtLocationAsync");
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x00037A97 File Offset: 0x00035C97
		protected UPostEventAtLocationAsync(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E24 RID: 3620
		public new const string __ObjectPath = "/Script/AkAudio.PostEventAtLocationAsync";

		// Token: 0x04000E25 RID: 3621
		private static IntPtr _ClassPtr;

		// Token: 0x04000E26 RID: 3622
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E27 RID: 3623
		internal static int __PropertyOffset_Completed;

		// Token: 0x04000E28 RID: 3624
		[Nullable(2)]
		private FPostEventAtLocationAsyncOutputPin _Completed;
	}
}
